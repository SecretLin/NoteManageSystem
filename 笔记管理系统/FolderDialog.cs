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
    //这里是显示所有文件夹。
    
    /*
     * 此窗体中有两个treeview
     * 一个是专门用来显示只有文件夹的
     * 一个是main窗体中的treeview内容，包括了笔记的标题名。
     */ 
    public partial class FolderDialog : Form
    {

        public TreeView tv;
        public FolderDialog()
        {
            InitializeComponent();
            
        }
       
        //选择中文件夹     
        public TreeNode selectedNode;
        private void btnConform_Click(object sender, EventArgs e)
        {          
            selectedNode = treeView1.SelectedNode;
            
            this.Close();
            this.DialogResult = DialogResult.OK;
            this.tv = folderTree;

        }
        NewFolderName form = new NewFolderName();//新建文件夹的名称
        private void 新建文件夹ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form.ShowDialog();
            if (form.DialogResult == DialogResult.OK)
            {
                folderTree.Visible = true;
                TreeNode node = new TreeNode();
                node.Text = form.folderName;
                folderTree.Nodes.Add(node);
                //这里用treeview1来显示文件夹的名字，并不把笔记的标题也显示出来。
                TreeNode node1 = new TreeNode();
                node1.Text = node.Text;
                treeView1.Nodes.Add(node1);
            }
           
        }
        TreeNode tn = new TreeNode();
        private void 删除文件夹ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            TreeNode tn1 = new TreeNode();
            tn1.Text = tn.Text;
            treeView1.Nodes.Remove(tn1);
            //这里的删除才会改变到main窗体的treeview。
            folderTree.Nodes.Remove(tn);
          
        }

        private void FolderDialog_Load(object sender, EventArgs e)
        {
            folderTree.Visible = false;
            folderTree.Nodes.Clear();
            foreach (TreeNode tn in tv.Nodes)
            {
                //这里是把main窗体的整个treeview都搬过来
                TreeNode newNode = tn.Clone() as TreeNode;
                folderTree.Nodes.Add(newNode);

            }

            foreach (TreeNode tn in tv.Nodes)
            {
                //只有文件夹的名称。
                TreeNode newNode = new TreeNode();
                newNode.Text = tn.Text;
                treeView1.Nodes.Add(newNode);

            }
        }

        private void folderTree_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                Point p = new Point(e.X, e.Y); //计算此时鼠标点击的是哪一个节点
                TreeNode node = folderTree.GetNodeAt(p);
                tn = node;

            }
        }
    }
}
