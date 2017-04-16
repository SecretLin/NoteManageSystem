using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 笔记管理系统
{
    //在Main窗体中按了“保存”之后就显示这个窗体。
    public partial class NewNote : Form
    {
        public NewNote()
        {
            InitializeComponent();
        }
       
        public TreeNode selectedNode;
        public TreeView tv;
        private void button1_Click(object sender, EventArgs e)
        {
            //点击“浏览”，选择笔记要存放在哪个文件夹。
            FolderDialog folderDialog = new FolderDialog();
            folderDialog.tv = this.tv;
            folderDialog.ShowDialog();              
            if(folderDialog.DialogResult == DialogResult.OK)
            {
                //把选择文件夹窗体的foldertree给传回来，以及选中的文件夹的那个节点。
                this.selectedNode = folderDialog.selectedNode;
                tbFolderName.Text = folderDialog.selectedNode.Text;
                this.tv = folderDialog.tv;
                //MessageBox.Show(Convert.ToString(this.tv.Nodes.Count));
            }
        }
        //保存笔记到文件夹中
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbFolderName.Text.Equals(""))
            {
                MessageBox.Show("文件名不能为空！");
                return;
            }
            
            this.Close();
            this.DialogResult = DialogResult.OK;
        }
    }
}



