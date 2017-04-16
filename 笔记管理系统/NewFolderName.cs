using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace 笔记管理系统
{
    public partial class NewFolderName : Form
    {
        public NewFolderName()
        {
            InitializeComponent();
        }
        public String folderName;
        
        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (tvFolderName.Text.Equals(""))
            {
                this.Close();
                this.DialogResult = DialogResult.Cancel;
                return;
            }
            folderName = tvFolderName.Text; 
            tvFolderName.Text = "";
            this.Close();
            this.DialogResult = DialogResult.OK;
        }
        //按下回车键
        private void tvFolderName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)13)
            {
                if (tvFolderName.Text.Equals(""))
                {
                    this.Close();
                    this.DialogResult = DialogResult.Cancel;
                    return;
                }
                folderName = tvFolderName.Text;
                tvFolderName.Text = "";
                this.Close();
                this.DialogResult = DialogResult.OK;
            }
           
        }
    }
}
