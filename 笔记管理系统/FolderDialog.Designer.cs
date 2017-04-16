namespace 笔记管理系统
{
    partial class FolderDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FolderDialog));
            this.folderTree = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.新建文件夹ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除文件夹ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnConform = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // folderTree
            // 
            this.folderTree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.folderTree.ContextMenuStrip = this.contextMenuStrip1;
            this.folderTree.Location = new System.Drawing.Point(2, 12);
            this.folderTree.Name = "folderTree";
            this.folderTree.Size = new System.Drawing.Size(356, 209);
            this.folderTree.TabIndex = 0;
            this.folderTree.MouseClick += new System.Windows.Forms.MouseEventHandler(this.folderTree_MouseClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建文件夹ToolStripMenuItem,
            this.删除文件夹ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(137, 48);
            // 
            // 新建文件夹ToolStripMenuItem
            // 
            this.新建文件夹ToolStripMenuItem.Name = "新建文件夹ToolStripMenuItem";
            this.新建文件夹ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.新建文件夹ToolStripMenuItem.Text = "新建文件夹";
            this.新建文件夹ToolStripMenuItem.Click += new System.EventHandler(this.新建文件夹ToolStripMenuItem_Click);
            // 
            // 删除文件夹ToolStripMenuItem
            // 
            this.删除文件夹ToolStripMenuItem.Name = "删除文件夹ToolStripMenuItem";
            this.删除文件夹ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.删除文件夹ToolStripMenuItem.Text = "删除文件夹";
            this.删除文件夹ToolStripMenuItem.Click += new System.EventHandler(this.删除文件夹ToolStripMenuItem_Click);
            // 
            // btnConform
            // 
            this.btnConform.Location = new System.Drawing.Point(136, 240);
            this.btnConform.Name = "btnConform";
            this.btnConform.Size = new System.Drawing.Size(75, 23);
            this.btnConform.TabIndex = 2;
            this.btnConform.Text = "确定";
            this.btnConform.UseVisualStyleBackColor = true;
            this.btnConform.Click += new System.EventHandler(this.btnConform_Click);
            // 
            // FolderDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 285);
            this.Controls.Add(this.btnConform);
            this.Controls.Add(this.folderTree);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FolderDialog";
            this.Text = "FolderDialog";
            this.Load += new System.EventHandler(this.FolderDialog_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView folderTree;
        private System.Windows.Forms.Button btnConform;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 新建文件夹ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 删除文件夹ToolStripMenuItem;
    }
}