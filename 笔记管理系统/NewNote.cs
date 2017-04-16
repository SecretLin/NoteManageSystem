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
            
            FolderDialog folderDialog = new FolderDialog();
            folderDialog.tv = this.tv;
            folderDialog.ShowDialog();              
            if(folderDialog.DialogResult == DialogResult.OK)
            {
                
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



