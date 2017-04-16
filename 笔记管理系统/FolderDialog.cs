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
            selectedNode = folderTree.SelectedNode;
            
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
            }
           
        }
        TreeNode tn = new TreeNode();
        private void 删除文件夹ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            folderTree.Nodes.Remove(tn);
        }

        private void FolderDialog_Load(object sender, EventArgs e)
        {
            folderTree.Nodes.Clear();
            foreach (TreeNode tn in tv.Nodes)
            {
                //TreeNode newNode = new TreeNode();
                //newNode.Text = tn.Text;
                TreeNode newNode = tn.Clone() as TreeNode;
                folderTree.Nodes.Add(newNode);

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
