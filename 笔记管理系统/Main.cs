using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Common;
using System.IO;
using System.Threading;
namespace 笔记管理系统
{  
    public partial class Main : Form
    {
        
        public Main()
        {
            InitializeComponent();
                      
        }
        private string username;//当前用户名
        private void Main_Load(object sender, EventArgs e)
        {

            username = File.ReadAllText(@"D:\1.txt");//从这个文件夹中取到当前用户名
            
            //将字体样式选择框和字体大小选择框设置成自定义的
            cbFontSize.DrawMode = DrawMode.OwnerDrawVariable;
            cbFontName.DrawMode = DrawMode.OwnerDrawVariable;

            //初始化标题框和内容框
            tbContent.Text = "添加新内容";
            tbTitle.Text = "无标题";

            //连接数据库，把当前用户所存的笔记显示在左边的treeview那里。
            String strConnection = @"Server=DESKTOP-V900MGO;";
            strConnection += "initial catalog=NoteDB;";
            strConnection += "user id=sa;";
            strConnection += "password=lj123456;";
            SqlConnection con = new SqlConnection(strConnection);
            String query = "select *from note where username = '" + username + "'";
            SqlCommand command = new SqlCommand(query, con);
           
            try//异常处理
            {
                bool isFirst = true;//用于判断是不是获取的第一个文件夹
                con.Open();
                //int n = comm();
                //MessageBox.Show(n + "");
               // command.ExecuteNonQuery();
                
                SqlDataReader reader1 = command.ExecuteReader();
                if (reader1.Read())//判断有没有笔记，如果有，才显示treeview
                {
                    treeView1.Nodes.Clear();
                    treeView1.Visible = true;
                }
                reader1.Close();
                
                SqlDataReader reader = command.ExecuteReader();
                
                while (reader.Read())
                {

                    string s = Convert.ToString(reader["folderName"]);//笔记存放的文件夹名称。
                    string s1 = Convert.ToString(reader["title"]);//笔记的标题
                    
                    TreeNode fNode = new TreeNode();
                    TreeNode cNode = new TreeNode();

                    if (isFirst)//如果是第一个文件夹，则直接显示在treeview上
                    {
                        fNode.Text = s.Trim();
                        treeView1.Nodes.Add(fNode);
                        if (s1.Trim() != "")
                        {
                            cNode.Text = s1.Trim();
                            fNode.Nodes.Add(cNode);
                        }

                    }
                    else//如果不是，则要判断这个文件夹是否已经在treeview上有了
                        //如果有了就不用再建一个节点
                    {
                        bool isExist = false;
                        foreach (TreeNode tn in treeView1.Nodes)
                        {

                            if (s.Trim().Equals(tn.Text))
                            {

                                if (s1.Trim() != "")
                                {
                                    cNode.Text = s1.Trim();
                                    tn.Nodes.Add(cNode);
                                    isExist = true;
                                }
                            }

                        }
                        if (!isExist)
                        {
                            fNode.Text = s.Trim();
                            treeView1.Nodes.Add(fNode);
                            if (s1.Trim() != "")
                            {
                                cNode.Text = s1.Trim();
                                fNode.Nodes.Add(cNode);
                            }
                        }
                       

                    }
                    isFirst = false;
                }
                reader.Close();
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("{0} Exception caught." + ex.Message);
            }
        }
        //为标题框初始化标题
        private void tbTitle_Enter(object sender, EventArgs e)
        {
            tbTitle.Text = "";
        }
        private void tbTitle_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbTitle.Text))
            {
                tbTitle.Text = "无标题";
            }
        }
        //为内容框初始化内容
        private void tbContent_Enter(object sender, EventArgs e)
        {
            if (tbContent.Text == "添加新内容")
            {
                tbContent.Text = "";
            }

        }

        private void tbContent_Leave(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbContent.Text))
            {
                tbContent.Text = "添加新内容";
            }
        }

        NewFolderName form = new NewFolderName();//建文件夹的窗口
        public String folderName;//新建文件夹的名称
        //Treeview的右键点击事件
        private void 新建文件夹ToolStripMenuItem_Click(object sender, EventArgs e)
        {
                //显示一个对话框，专门填文件的名字。
                form.ShowDialog();
                //点击“确定”
                if (form.DialogResult == DialogResult.OK)
                {   //有了第一个文件夹，所以treeview显示出来。
                    treeView1.Visible = true;
                    TreeNode node = new TreeNode();
                    node.Text = form.folderName;
                    treeView1.Nodes.Add(node);
                }
        }
        

        //菜单栏的“新建文件夹”按钮事件       
        private void 新建文件夹ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //打开创建文件夹。
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                treeView1.Visible = true;
                TreeNode node = new TreeNode();
                node.Text = form.folderName;
                treeView1.Nodes.Add(node);
            }
        }
        //TreeView根节点的右键点击事件
        TreeNode tn = new TreeNode();
        private void treeView1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Right)
            {  
                Point p = new Point(e.X, e.Y); //计算此时鼠标点击的是哪一个节点
                TreeNode node = treeView1.GetNodeAt(p);
                tn = node;
                               
            }
        }
        //右键，可删除该文件夹
        private void 删除文件夹ToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            DialogResult dr = MessageBox.Show("确认删除吗？", "提示", MessageBoxButtons.OKCancel);           
            if (dr == DialogResult.OK)
            {

                String delete = null;
                if ((tn.Parent == null) && (tn.Nodes.Count == 0))
                {
                    //用户选择确认的操作
                    treeView1.Nodes.Remove(tn);
                    return;
                }
                //删除文件夹和笔记。
                if (tn.Nodes.Count > 0)
                {
                    delete = "delete from note where foldername = '" + tn.Text.Trim() + "'";
                }
                //删除笔记
                else if (tn.Nodes.Count == 0)
                {
                    delete = "delete from note where title = '" + tn.Text.Trim() + "'";
                }

                String strConnection = @"Server=DESKTOP-V900MGO;";
                strConnection += "initial catalog=NoteDB;";
                strConnection += "user id=sa;";
                strConnection += "password=lj123456;";
                SqlConnection con = new SqlConnection(strConnection);
                SqlCommand command = new SqlCommand(delete, con);
                try//异常处理
                {

                    con.Open();
                    command.ExecuteNonQuery();
                    //用户选择确认的操作
                    treeView1.Nodes.Remove(tn);//将选中的节点移除
                    MessageBox.Show("删除成功。");
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("{0} Exception caught." + ex.Message);
                }
            }
        }

        //重新写选择字体样式的combobox的item的字体
        private void cbFontName_DrawItem(object sender, DrawItemEventArgs e)
        {
            Pen fColor = new Pen(this.ForeColor);
            Pen bColor = new Pen(this.BackColor);
            Font f = new Font(this.Font.Name, this.Font.Size, this.Font.Style);
            switch (e.Index)
            {
                case 0:
                    f = new Font("微软雅黑", 9, this.Font.Style);
                    break;
                case 1:
                    f = new Font("宋体", 9, this.Font.Style);
                    break;
                case 2:
                    f = new Font("新宋体", 9, this.Font.Style);
                    break;
                case 3:
                    f = new Font("仿宋", 9, this.Font.Style);
                    break;
                case 4:
                    f = new Font("楷体", 9, this.Font.Style);
                    break;
                case 5:
                    f = new Font("黑体", 9, this.Font.Style);
                    break;
                case 6:
                    f = new Font("Arial", 9, this.Font.Style);
                    break;
                case 7:
                    f = new Font("Arial Black", 9, this.Font.Style);
                    break;
                case 8:
                    f = new Font("Times New Roman", 9, this.Font.Style);
                    break;
                case 9:
                    f = new Font("Courier New", 9, this.Font.Style);
                    break;
                case 10:
                    f = new Font("Tahoma", 9, this.Font.Style);
                    break;
                case 11:
                    f = new Font("Verdana", 9, this.Font.Style);
                    break;
            }


            //改变鼠标移动到该项时的颜色。
            if ((e.State & DrawItemState.Selected) != 0)
            {
                SolidBrush brush = new SolidBrush(Color.FromArgb(255, 236, 181));
                //设置鼠标悬浮ComboBox的item的背景色
                e.Graphics.FillRectangle(brush, e.Bounds);
            }
            else
            {
                SolidBrush brush1 = new SolidBrush(Color.FromArgb(217, 223, 230));
                e.Graphics.FillRectangle(brush1, e.Bounds);
            }

            e.DrawFocusRectangle();
            e.Graphics.DrawString((string)cbFontName.Items[e.Index], f, fColor.Brush, e.Bounds);
        }
        //选择字体样式后字体的改变
        public void changeFontFamilies(String fontName)
        {
            RichTextBox tempRichTextBox = new RichTextBox();  //用于保存被选中文本的副本   

            //curRichTextBox是当前文本，即原型   
            int curRtbStart = tbContent.SelectionStart;
            int len = tbContent.SelectionLength;
            int tempRtbStart = 0;

            if (len > 0)
            {
                tempRichTextBox.Rtf = tbContent.SelectedRtf;
                for (int i = 0; i < len; i++)  //逐个设置字体种类   
                {
                    tempRichTextBox.Select(tempRtbStart + i, 1);

                    tempRichTextBox.SelectionFont =
                                        new Font(fontName, tempRichTextBox.SelectionFont.Size,
                                                 tempRichTextBox.SelectionFont.Style);

                }

                //将副本内容插入到到原型中   
                tempRichTextBox.Select(tempRtbStart, len);

                tbContent.SelectedRtf = tempRichTextBox.SelectedRtf;

                tbContent.Focus();
            }
            else
            {
                tbContent.SelectionFont = new Font(fontName, tbContent.SelectionFont.Size,
                                             tbContent.SelectionFont.Style);
            }
        }
        //改变字体
        private void cbFontName_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbContent.Focus();
            switch (cbFontName.SelectedIndex)
            {
                case 0:
                    changeFontFamilies("微软雅黑");

                    break;
                case 1:
                    changeFontFamilies("宋体");

                    break;
                case 2:
                    changeFontFamilies("新宋体");
                    break;
                case 3:
                    changeFontFamilies("仿宋");
                    break;
                case 4:
                    changeFontFamilies("楷体");
                    break;
                case 5:
                    changeFontFamilies("黑体");
                    break;
                case 6:
                    changeFontFamilies("Arial");
                    break;
                case 7:
                    changeFontFamilies("Arial Black");
                    break;
                case 8:
                    changeFontFamilies("Times New Roman");
                    break;
                case 9:
                    changeFontFamilies("Courier New");
                    break;
                case 10:
                    changeFontFamilies("Tahoma");
                    break;
                case 11:
                    changeFontFamilies("Verdana");
                    break;
            }

        }

        Boolean isSelected = true;//判断是否选择了“粗体”，“斜体”等
        private void btnBold_Click(object sender, EventArgs e)
        {
            tbContent.Focus();

            if (isSelected)
            {
                btnBold.BackColor = Color.Gray;
                isSelected = false;
            }
            else
            {
                btnBold.BackColor = Color.White;
                isSelected = true;
            }

            //用于保存被选中文本的副本   
            RichTextBox tempRichTextBox = new RichTextBox();                         
            int len = tbContent.SelectionLength;//选中的文字的长度
            int tempRtbStart = 0;
            if (len > 0)
            {
                tempRichTextBox.Rtf = tbContent.SelectedRtf;
                for (int i = 0; i < len; i++)  //逐个设置字体种类   
                {
                    tempRichTextBox.Select(tempRtbStart + i, 1);

                    tempRichTextBox.SelectionFont =
                                        new Font(tempRichTextBox.SelectionFont.Name, tempRichTextBox.SelectionFont.Size,
                                                 tempRichTextBox.SelectionFont.Style ^ FontStyle.Bold);

                }

                //将副本内容插入到到原型中   
                tempRichTextBox.Select(tempRtbStart, len);
                tbContent.SelectedRtf = tempRichTextBox.SelectedRtf;
                tbContent.Focus();
            }
            else//没有选择文字，直接选择了“粗体”，此后所有的字体都变成粗体。
            {
                tbContent.SelectionFont = new Font(tbContent.SelectionFont.Name, tbContent.SelectionFont.Size,
                                             tbContent.SelectionFont.Style ^ FontStyle.Bold);
            }
        }
        //选择字体是否为斜体
        private void btnItalic_Click(object sender, EventArgs e)
        {
            tbContent.Focus();

            if (isSelected)
            {
                btnItalic.BackColor = Color.Gray;
                isSelected = false;
            }
            else
            {
                btnItalic.BackColor = Color.White;
                isSelected = true;
            }

            RichTextBox tempRichTextBox = new RichTextBox();  //用于保存被选中文本的副本   
            int len = tbContent.SelectionLength;
            int tempRtbStart = 0;

            if (len > 0)
            {
                tempRichTextBox.Rtf = tbContent.SelectedRtf;
                for (int i = 0; i < len; i++)  //逐个设置字体种类   
                {
                    tempRichTextBox.Select(tempRtbStart + i, 1);

                    tempRichTextBox.SelectionFont =
                                        new Font(tempRichTextBox.SelectionFont.Name, tempRichTextBox.SelectionFont.Size,
                                                 tempRichTextBox.SelectionFont.Style ^ FontStyle.Italic);

                }

                //将副本内容插入到到原型中   
                tempRichTextBox.Select(tempRtbStart, len);

                tbContent.SelectedRtf = tempRichTextBox.SelectedRtf;

                tbContent.Focus();
            }
            else
            {
                tbContent.SelectionFont = new Font(tbContent.SelectionFont.Name, tbContent.SelectionFont.Size,
                                             tbContent.SelectionFont.Style ^ FontStyle.Italic);
            }
        }
        //选择是否要下划线
        private void btnUnderline_Click(object sender, EventArgs e)
        {
            tbContent.Focus();
            if (isSelected)
            {
                btnUnderline.BackColor = Color.Gray;
                isSelected = false;
            }
            else
            {
                btnUnderline.BackColor = Color.White;
                isSelected = true;
            }

            RichTextBox tempRichTextBox = new RichTextBox();  //用于保存被选中文本的副本   
            int len = tbContent.SelectionLength;
            int tempRtbStart = 0;

            if (len > 0)
            {
                tempRichTextBox.Rtf = tbContent.SelectedRtf;
                for (int i = 0; i < len; i++)  //逐个设置字体种类   
                {
                    tempRichTextBox.Select(tempRtbStart + i, 1);

                    tempRichTextBox.SelectionFont =
                                        new Font(tempRichTextBox.SelectionFont.Name, tempRichTextBox.SelectionFont.Size,
                                                 tempRichTextBox.SelectionFont.Style ^ FontStyle.Underline);

                }

                //将副本内容插入到到原型中   
                tempRichTextBox.Select(tempRtbStart, len);

                tbContent.SelectedRtf = tempRichTextBox.SelectedRtf;

                tbContent.Focus();
            }
            else
            {
                tbContent.SelectionFont = new Font(tbContent.SelectionFont.Name, tbContent.SelectionFont.Size,
                                             tbContent.SelectionFont.Style ^ FontStyle.Underline);
            }
        }
        //选择是否要删除线
        private void btnStrike_Click(object sender, EventArgs e)
        {
            tbContent.Focus();

            if (isSelected)
            {
                btnStrike.BackColor = Color.Gray;
                isSelected = false;
            }
            else
            {
                btnStrike.BackColor = Color.White;
                isSelected = true;
            }

            RichTextBox tempRichTextBox = new RichTextBox();  //用于保存被选中文本的副本   
            int len = tbContent.SelectionLength;
            int tempRtbStart = 0;

            if (len > 0)
            {
                tempRichTextBox.Rtf = tbContent.SelectedRtf;
                for (int i = 0; i < len; i++)  //逐个设置字体种类   
                {
                    tempRichTextBox.Select(tempRtbStart + i, 1);

                    tempRichTextBox.SelectionFont =
                                        new Font(tempRichTextBox.SelectionFont.Name, tempRichTextBox.SelectionFont.Size,
                                                 tempRichTextBox.SelectionFont.Style ^ FontStyle.Strikeout);

                }

                //将副本内容插入到到原型中   
                tempRichTextBox.Select(tempRtbStart, len);

                tbContent.SelectedRtf = tempRichTextBox.SelectedRtf;

                tbContent.Focus();
            }
            else
            {
                tbContent.SelectionFont = new Font(tbContent.SelectionFont.Name, tbContent.SelectionFont.Size,
                                             tbContent.SelectionFont.Style ^ FontStyle.Strikeout);
            }
        }
        //选择字体颜色
        private void btnColor_Click(object sender, EventArgs e)
        {

            if (colorDialog1.ShowDialog().Equals(DialogResult.OK))
            {
                tbContent.Focus();
                Color getColor = colorDialog1.Color;
                RichTextBox tempRichTextBox = new RichTextBox();  //用于保存被选中文本的副本   
                int len = tbContent.SelectionLength;
                int tempRtbStart = 0;

                if (len > 0)
                {
                    tempRichTextBox.Rtf = tbContent.SelectedRtf;
                    for (int i = 0; i < len; i++)  //逐个设置字体种类   
                    {
                        tempRichTextBox.Select(tempRtbStart + i, 1);

                        tempRichTextBox.SelectionColor = getColor;

                    }

                    //将副本内容插入到到原型中   
                    tempRichTextBox.Select(tempRtbStart, len);

                    tbContent.SelectedRtf = tempRichTextBox.SelectedRtf;

                    tbContent.Focus();
                }
                else
                {
                    tbContent.SelectionColor = getColor;
                }
            }
            
            
            
        }
              

        //点击可显示上列按钮是否已经被点击
        private void tbContent_MouseClick(object sender, MouseEventArgs e)
        {
            try {//由于有时选择的文字的样式不同会报错退出，所以采取异常捕获的方式。

                //以下是判断所选文字是不是粗体、斜体等，如果是，上面的按钮的背景就变色。
                if (tbContent.SelectionFont.Bold)
                {
                    btnBold.BackColor = Color.Gray;
                }
                else
                {
                    btnBold.BackColor = Color.White;

                }

                if (tbContent.SelectionFont.Italic)
                {
                    btnItalic.BackColor = Color.Gray;
                }
                else
                {
                    btnItalic.BackColor = Color.White;
                }

                if (tbContent.SelectionFont.Underline)
                {
                    btnUnderline.BackColor = Color.Gray;
                }
                else
                {
                    btnUnderline.BackColor = Color.White;
                }
                if (tbContent.SelectionFont.Strikeout)
                {
                    btnStrike.BackColor = Color.Gray;
                }
                else
                {
                    btnStrike.BackColor = Color.White;
                }

                //将选择字体大小的选择框的文字变成当前选择的文字的大小。
                cbFontSize.Text = Convert.ToString(tbContent.SelectionFont.Size);
                //将选择字体样式名字的选择框的文字变成当前选择的文字的字体样式名。
                cbFontName.Text = Convert.ToString(tbContent.SelectionFont.Name);

            } catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
                       
        }
        //重写字体大小选择框里面item的大小。
        private void cbFontSize_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            switch (e.Index)
            {
                case 0:
                    e.ItemHeight = 11;
                    break;
                case 1:
                    e.ItemHeight = 18;
                    break;
                case 2:
                    e.ItemHeight = 20;
                    break;
                case 3:
                    e.ItemHeight = 23;
                    break;
                case 4:
                    e.ItemHeight = 28;
                    break;
                case 5:
                    e.ItemHeight = 31;
                    break;
                case 6:
                    e.ItemHeight = 38;
                    break;
                case 7:
                    e.ItemHeight = 44;
                    break;
                case 8:
                    e.ItemHeight = 50;
                    break;
                case 9:
                    e.ItemHeight = 55;
                    break;
            }
        }
        //重写选择字体的combox里面item的字体大小
        private void cbFontSize_DrawItem(object sender, DrawItemEventArgs e)
        {
            Pen fColor = new Pen(this.ForeColor);
            Pen bColor = new Pen(this.BackColor);
            Font f = new Font(this.Font.Name, this.Font.Size, this.Font.Style);
            switch (e.Index)
            {

                case 0:
                    f = new Font(this.Font.Name, 9, this.Font.Style);
                    break;
                case 1:
                    f = new Font(this.Font.Name, 12, this.Font.Style);
                    break;
                case 2:
                    f = new Font(this.Font.Name, 14, this.Font.Style);
                    break;
                case 3:
                    f = new Font(this.Font.Name, 16, this.Font.Style);
                    break;
                case 4:
                    f = new Font(this.Font.Name, 18, this.Font.Style);
                    break;
                case 5:
                    f = new Font(this.Font.Name, 22, this.Font.Style);
                    break;
                case 6:
                    f = new Font(this.Font.Name, 26, this.Font.Style);
                    break;
                case 7:
                    f = new Font(this.Font.Name, 30, this.Font.Style);
                    break;
                case 8:
                    f = new Font(this.Font.Name, 36, this.Font.Style);
                    break;
                case 9:
                    f = new Font(this.Font.Name, 42, this.Font.Style);
                    break;
            }

            //改变鼠标移动到该项时的颜色。
            if ((e.State & DrawItemState.Selected) != 0)
            {
                SolidBrush brush = new SolidBrush(Color.FromArgb(255, 236, 181));
                //设置鼠标悬浮ComboBox的item的背景色
                e.Graphics.FillRectangle(brush, e.Bounds);
            }
            else
            {
                SolidBrush brush1 = new SolidBrush(Color.FromArgb(217, 223, 230));
                e.Graphics.FillRectangle(brush1, e.Bounds);
            }

            e.Graphics.DrawString((string)cbFontSize.Items[e.Index], f, fColor.Brush, e.Bounds);
        }
        //点击选择字体大小的combobox时触发事件
        private void cbFontSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbContent.Focus();
            switch (cbFontSize.SelectedIndex)
            {
                case 0:
                    changeFontSize(9);
                    break;
                case 1:
                    changeFontSize(12);
                    break;
                case 2:
                    changeFontSize(14);
                    break;
                case 3:
                    changeFontSize(16);
                    break;
                case 4:
                    changeFontSize(18);
                    break;
                case 5:
                    changeFontSize(22);
                    break;
                case 6:
                    changeFontSize(26);
                    break;
                case 7:
                    changeFontSize(30);
                    break;
                case 8:
                    changeFontSize(36);
                    break;
                case 9:
                    changeFontSize(42);
                    break;
            }
        }
        //改变字体的大小
        private void changeFontSize(int size)
        {
            RichTextBox tempRichTextBox = new RichTextBox();  //用于保存被选中文本的副本   
            int len = tbContent.SelectionLength;
            int tempRtbStart = 0;

            if (len > 0)
            {
                tempRichTextBox.Rtf = tbContent.SelectedRtf;
                for (int i = 0; i < len; i++)  //逐个设置字体种类   
                {
                    tempRichTextBox.Select(tempRtbStart + i, 1);

                    tempRichTextBox.SelectionFont =
                                        new Font(tempRichTextBox.SelectionFont.Name,size,
                                                 tempRichTextBox.SelectionFont.Style);

                }

                //将副本内容插入到到原型中   
                tempRichTextBox.Select(tempRtbStart, len);

                tbContent.SelectedRtf = tempRichTextBox.SelectedRtf;

                tbContent.Focus();
            }
            else
            {
                tbContent.SelectionFont = new Font(tbContent.SelectionFont.Name, size,
                                             tbContent.SelectionFont.Style);
            }
        }

        private void 剪切ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbContent.Cut();
        }

        private void 复制ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tbContent.Copy();
        }

        private void 粘贴ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            tbContent.Paste();
        }
        //选择图片插入到笔记中。
        private void btnPicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Filter = "所有文件(*.*)|*.*" + "|JPEG(*.jpg;*.jpeg;*.jpe)|*.jpg;*.jpeg;*.jpe"+
                "|位图文件(*.bmp)|*.bmp" + "|GIF(*.gif)|*.gif" + "|PNG(*.png)|*.png" + "|ICO(*.ico)|*.ico";
            
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = fileDialog.FileName;
                //只能先把取到的图片放到系统的剪贴版中，然后再通过粘贴显示出来。
                Clipboard.SetDataObject(Image.FromFile(path), false);
                tbContent.Paste();
            }
        }
       
        //改变内容编辑框的背景色
        private void btnChangbg_Click(object sender, EventArgs e)
        {

            Color getColor = colorDialog1.Color;

            if (colorDialog1.ShowDialog().Equals(DialogResult.OK))
            {
                getColor = colorDialog1.Color;
                tbContent.BackColor = getColor;
            }

        }
        //点击“撤退”
        private void btnUndo_Click(object sender, EventArgs e)
        {
            tbContent.Undo();
        }
        //点击“重做”
        private void btnRedo_Click(object sender, EventArgs e)
        {
            tbContent.Redo();
        }
        //关闭程序时的提醒设置。
        bool isSaved = false;
        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            //先查询当前的笔记是否已经保存了。
            String strConnection = @"Server=DESKTOP-V900MGO;";
            strConnection += "initial catalog=NoteDB;";
            strConnection += "user id=sa;";
            strConnection += "password=lj123456;";
            SqlConnection con = new SqlConnection(strConnection);
            if (treeView1.SelectedNode != null)
            {
                if (treeView1.SelectedNode.Parent != null)
                {
                    string foldername = treeView1.SelectedNode.Parent.Text;
                    string title = tbTitle.Text;
                    string content = Convert.ToString(tbContent.Rtf);
                    string content1 = content.Replace("'", "''");
                    String query = "select *from note where title = '" + title + "' and foldername = '" + foldername + "'";
                    SqlCommand command = new SqlCommand(query, con);
                    try//异常处理
                    {
                        con.Open();

                        SqlDataReader reader = command.ExecuteReader();
                        while (reader.Read())
                        {
                            string content2 = Convert.ToString(reader[1]);
                            if (content.Equals(content2))
                            {
                                isSaved = true;
                            }
                            else
                            {
                                isSaved = false;
                            }
                        }
                        reader.Close();

                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("{0} Exception caught." + ex.Message);
                    }
                }
                else
                {
                    if (tbContent.Text == "添加新内容")
                    {
                        isSaved = true;
                    }
                    else
                    {
                        isSaved = false;
                    }
                }
            }
           
            
          
            if (!isSaved)//还没保存
            {

                if (MessageBox.Show
               ("还未保存该笔记，是否还要继续关闭", "确认", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
               == System.Windows.Forms.DialogResult.No)
                    e.Cancel = true;

            }
            
           
        }
        //在treeview中找到选定的节点可进行保存文件和笔记。
        public void searchNode(TreeNodeCollection node,TreeNode selectedNode)
        {
            string tbtile = tbTitle.Text.Trim();
            //选择的节点（文件夹）在左边的treeview那里遍历
            foreach (TreeNode p in treeView1.Nodes)
            {
                if (p.Text.Trim() == selectedNode.Text.Trim())//找到匹配的节点
                {
                    //再遍历该节点的子节点
                    foreach (TreeNode c in p.Nodes)
                    {
                        //如果要保存的笔记的标题跟该节点的子节点相同（即某个笔记的标题）
                        if (tbtile == c.Text)
                        {
                            if (!isUpdate)//如果不是原来的笔记进行更新的话
                            {
                                MessageBox.Show("同一个文件夹下的文档名不能一样");
                                return;
                            }                           
                        }
                        
                    }
                    p.Nodes.Add(tbtile); //把标题添加进去。               
                    string foldername = selectedNode.Text;
                    String strConnection = @"Server=DESKTOP-V900MGO;";
                    strConnection += "initial catalog=NoteDB;";
                    strConnection += "user id=sa;";
                    strConnection += "password=lj123456;";
                    SqlConnection con = new SqlConnection(strConnection);
                    //由于背景颜色是由A RGB组成的，且获取的值是属于byte类型的。
                    //以下的A、B、G、R都是储存颜色的变量。
                    byte A = tbContent.BackColor.A;
                    byte B = tbContent.BackColor.B;
                    byte G = tbContent.BackColor.G;
                    byte R = tbContent.BackColor.R;
                    //标题名称
                    string title = tbTitle.Text;
                    //获取文本框中的内容
                    //Rtf是因为能获取到文字的样式等格式。
                    string content = Convert.ToString(tbContent.Rtf);
                    //由于Rtf是一串含有‘’的字符串，不能直接存到数据库中，需要把''变成""。
                    string content1 = content.Replace("'", "''");

                    String insert = "insert into note (title,noteContent,foldername,username,A,B,G,R) values('" + title + "','" + @content1 + "','" + foldername + "','" + username + "','"+A+"','"+B+"','"+G+"','"+R+"')";
                    SqlCommand command = new SqlCommand(insert, con);
                    try//异常处理
                    {
                        con.Open();
                        command.ExecuteNonQuery();
                        MessageBox.Show("保存成功！");
                        isSaved = true;//保存状态，使得在关闭程序时不会提示“没保存”。
                        con.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("{0} Exception caught." + ex.Message);
                    }
                    p.Expand();

                }
            }

           
        }
        //保存笔记
        public void saveNote()
        {
            if (!isUpdate)
            {
                //另起一个窗口，选择笔记要保存在哪个文件夹中。
                
                NewNote noteForm = new NewNote();
                noteForm.tv = treeView1;
                noteForm.ShowDialog();
                if (noteForm.DialogResult == DialogResult.OK)
                {
                    this.tv = noteForm.tv;
                    treeView1.Visible = true;
                    treeView1.Nodes.Clear();
                    foreach (TreeNode tn in tv.Nodes)
                    {

                        TreeNode newNode = tn.Clone() as TreeNode;
                        treeView1.Nodes.Add(newNode);
                    }

                    //保存到文件夹中，并把该文件夹和文档路径存到数据库中。
                    searchNode(treeView1.Nodes, noteForm.selectedNode);

                }
            }
            else
            {
                TreeNode c = treeView1.SelectedNode;
                TreeNode p = c.Parent;
                updateNote(c, p);
            }
        }

        //点击右方的“保存”键来保存笔记内容
        public TreeView tv;
        private void saveDoc_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(Convert.ToString(tbContent.BackColor.B));
            //tbTitle.Text = Convert.ToString(tbContent.BackColor);
            saveNote();

        }
        //更新笔记的内容
        public void updateNote(TreeNode c,TreeNode p)
        {
            string cNode = c.Text;
            string pNode = p.Text;
            string content = @tbContent.Rtf;
            string content1 = content.Replace("'", "''");
            String strConnection = @"Server=DESKTOP-V900MGO;";
            strConnection += "initial catalog=NoteDB;";
            strConnection += "user id=sa;";
            strConnection += "password=lj123456;";
            SqlConnection con = new SqlConnection(strConnection);
            String query = "update note set noteContent = '" + content1 + "' where title = '" + cNode + "' and foldername = '" + pNode + "'";
            SqlCommand command = new SqlCommand(query, con);

            try//异常处理
            {
                con.Open();
                command.ExecuteNonQuery();
                SqlDataReader reader = command.ExecuteReader();     //执行SQL，返回一个“流”
                while (reader.Read())
                {
                    String s1 = Convert.ToString(reader["noteContent"]);
                    tbContent.Rtf = @s1;
                    String title = Convert.ToString(reader["title"]);
                    tbTitle.Text = title;
                }
                
                reader.Close();
                con.Close();
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show("{0} Exception caught." + ex.Message);
            }
        }

        //双击文档，可打开编辑
        bool isUpdate = false;
        TreeNode doubleSelectdNode;
        private void treeView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            isUpdate = true;
            doubleSelectdNode = treeView1.SelectedNode;
            if (treeView1.SelectedNode.Nodes.Count == 0)
            {
                String nodeText = treeView1.SelectedNode.Text;
                String strConnection = @"Server=DESKTOP-V900MGO;";
                strConnection += "initial catalog=NoteDB;";
                strConnection += "user id=sa;";
                strConnection += "password=lj123456;";
                SqlConnection con = new SqlConnection(strConnection);
                String query = "select *from note where title = '"+nodeText+"'";
                SqlCommand command = new SqlCommand(query, con);

                try//异常处理
                {
                    con.Open();
                    command.ExecuteNonQuery();
                    SqlDataReader reader = command.ExecuteReader();    
                    while (reader.Read())
                    {
                        String s = Convert.ToString(reader["noteContent"]);
                        tbContent.Rtf = @s;
                        String title = Convert.ToString(reader["title"]);
                        tbTitle.Text = title;
                        if (reader["A"] != null)
                        {
                            byte A = Convert.ToByte(reader["A"]);
                            byte B = Convert.ToByte(reader["B"]);
                            byte G = Convert.ToByte(reader["G"]);
                            byte R = Convert.ToByte(reader["R"]);
                            tbContent.BackColor = Color.FromArgb(A, R, G, B);
                        }
                        
                        
                    }
                    reader.Close();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("{0} Exception caught." + ex.Message);
                }
                
             
            }
        }

        //退出当前账户，回到登录界面
        public void startMain()
        {
            Application.Run(new Home());
        }
        private void 退出登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("确认退出吗？", "提示", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                //用户选择确认的操作
                File.Delete(@"D:\1.txt");
                Thread t = new Thread(startMain);
                t.Start();
                this.Close();
            }
        }
        //点击右键，按“保存”
        private void 保存ctrlsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveNote();
        }
        //快捷键ctrl+S，保存笔记。
        private void tbContent_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyValue == 'S')
            {
                saveNote();
            }
        }

        private void 新建文档ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbTitle.Text = "无标题";
            tbContent.Text = "添加新内容";
            tbContent.BackColor = Color.White;
            isUpdate = false;
        }
    }
    

    
}
