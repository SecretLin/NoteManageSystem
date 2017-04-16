namespace 笔记管理系统
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.新建文件夹ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.删除文件夹ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新建文件夹ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.新建文档ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.退出登录ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tbContent = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.剪切ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.粘贴ToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.保存ctrlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.复制ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粘贴ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.粘贴ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChangbg = new System.Windows.Forms.Button();
            this.btnRedo = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.cbFontName = new System.Windows.Forms.ComboBox();
            this.btnStrike = new System.Windows.Forms.Button();
            this.saveDoc = new System.Windows.Forms.Button();
            this.btnPicture = new System.Windows.Forms.Button();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnUnderline = new System.Windows.Forms.Button();
            this.btnItalic = new System.Windows.Forms.Button();
            this.btnBold = new System.Windows.Forms.Button();
            this.cbFontSize = new System.Windows.Forms.ComboBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.contextMenuStrip1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView1.ContextMenuStrip = this.contextMenuStrip1;
            this.treeView1.Location = new System.Drawing.Point(1, 33);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(199, 458);
            this.treeView1.TabIndex = 1;
            this.treeView1.Visible = false;
            this.treeView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseClick);
            this.treeView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseDoubleClick);
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
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.退出登录ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1113, 25);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新建文件夹ToolStripMenuItem1,
            this.新建文档ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 新建文件夹ToolStripMenuItem1
            // 
            this.新建文件夹ToolStripMenuItem1.Name = "新建文件夹ToolStripMenuItem1";
            this.新建文件夹ToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.新建文件夹ToolStripMenuItem1.Text = "新建文件夹";
            this.新建文件夹ToolStripMenuItem1.Click += new System.EventHandler(this.新建文件夹ToolStripMenuItem1_Click);
            // 
            // 新建文档ToolStripMenuItem
            // 
            this.新建文档ToolStripMenuItem.Name = "新建文档ToolStripMenuItem";
            this.新建文档ToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
            this.新建文档ToolStripMenuItem.Text = "新建文档";
            this.新建文档ToolStripMenuItem.Click += new System.EventHandler(this.新建文档ToolStripMenuItem_Click);
            // 
            // 退出登录ToolStripMenuItem
            // 
            this.退出登录ToolStripMenuItem.Name = "退出登录ToolStripMenuItem";
            this.退出登录ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.退出登录ToolStripMenuItem.Text = "退出登录";
            this.退出登录ToolStripMenuItem.Click += new System.EventHandler(this.退出登录ToolStripMenuItem_Click);
            // 
            // tbContent
            // 
            this.tbContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbContent.ContextMenuStrip = this.contextMenuStrip3;
            this.tbContent.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tbContent.Location = new System.Drawing.Point(271, 89);
            this.tbContent.Name = "tbContent";
            this.tbContent.Size = new System.Drawing.Size(836, 402);
            this.tbContent.TabIndex = 14;
            this.tbContent.TabStop = false;
            this.tbContent.Text = "";
            this.tbContent.MouseClick += new System.Windows.Forms.MouseEventHandler(this.tbContent_MouseClick);
            this.tbContent.Enter += new System.EventHandler(this.tbContent_Enter);
            this.tbContent.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbContent_KeyDown);
            this.tbContent.Leave += new System.EventHandler(this.tbContent_Leave);
            // 
            // contextMenuStrip3
            // 
            this.contextMenuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.剪切ToolStripMenuItem,
            this.复制ToolStripMenuItem1,
            this.粘贴ToolStripMenuItem2,
            this.保存ctrlsToolStripMenuItem});
            this.contextMenuStrip3.Name = "contextMenuStrip3";
            this.contextMenuStrip3.Size = new System.Drawing.Size(154, 92);
            // 
            // 剪切ToolStripMenuItem
            // 
            this.剪切ToolStripMenuItem.Name = "剪切ToolStripMenuItem";
            this.剪切ToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.剪切ToolStripMenuItem.Text = "剪切 (ctrl + x)";
            this.剪切ToolStripMenuItem.Click += new System.EventHandler(this.剪切ToolStripMenuItem_Click);
            // 
            // 复制ToolStripMenuItem1
            // 
            this.复制ToolStripMenuItem1.Name = "复制ToolStripMenuItem1";
            this.复制ToolStripMenuItem1.Size = new System.Drawing.Size(153, 22);
            this.复制ToolStripMenuItem1.Text = "复制 (ctrl + c)";
            this.复制ToolStripMenuItem1.Click += new System.EventHandler(this.复制ToolStripMenuItem1_Click);
            // 
            // 粘贴ToolStripMenuItem2
            // 
            this.粘贴ToolStripMenuItem2.Name = "粘贴ToolStripMenuItem2";
            this.粘贴ToolStripMenuItem2.Size = new System.Drawing.Size(153, 22);
            this.粘贴ToolStripMenuItem2.Text = "粘贴 (ctrl + v)";
            this.粘贴ToolStripMenuItem2.Click += new System.EventHandler(this.粘贴ToolStripMenuItem2_Click);
            // 
            // 保存ctrlsToolStripMenuItem
            // 
            this.保存ctrlsToolStripMenuItem.Name = "保存ctrlsToolStripMenuItem";
            this.保存ctrlsToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.保存ctrlsToolStripMenuItem.Text = "保存 (ctrl + s)";
            this.保存ctrlsToolStripMenuItem.Click += new System.EventHandler(this.保存ctrlsToolStripMenuItem_Click);
            // 
            // 复制ToolStripMenuItem
            // 
            this.复制ToolStripMenuItem.Name = "复制ToolStripMenuItem";
            this.复制ToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // 粘贴ToolStripMenuItem
            // 
            this.粘贴ToolStripMenuItem.Name = "粘贴ToolStripMenuItem";
            this.粘贴ToolStripMenuItem.Size = new System.Drawing.Size(32, 19);
            // 
            // 粘贴ToolStripMenuItem1
            // 
            this.粘贴ToolStripMenuItem1.Name = "粘贴ToolStripMenuItem1";
            this.粘贴ToolStripMenuItem1.Size = new System.Drawing.Size(32, 19);
            // 
            // tbTitle
            // 
            this.tbTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbTitle.Font = new System.Drawing.Font("宋体", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tbTitle.ImeMode = System.Windows.Forms.ImeMode.On;
            this.tbTitle.Location = new System.Drawing.Point(271, 0);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(836, 41);
            this.tbTitle.TabIndex = 2;
            this.tbTitle.TabStop = false;
            this.tbTitle.Enter += new System.EventHandler(this.tbTitle_Enter);
            this.tbTitle.Leave += new System.EventHandler(this.tbTitle_Leave);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnChangbg);
            this.panel1.Controls.Add(this.btnRedo);
            this.panel1.Controls.Add(this.btnUndo);
            this.panel1.Controls.Add(this.cbFontName);
            this.panel1.Controls.Add(this.btnStrike);
            this.panel1.Controls.Add(this.saveDoc);
            this.panel1.Controls.Add(this.btnPicture);
            this.panel1.Controls.Add(this.btnColor);
            this.panel1.Controls.Add(this.btnUnderline);
            this.panel1.Controls.Add(this.btnItalic);
            this.panel1.Controls.Add(this.btnBold);
            this.panel1.Controls.Add(this.cbFontSize);
            this.panel1.Location = new System.Drawing.Point(271, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 36);
            this.panel1.TabIndex = 7;
            // 
            // btnChangbg
            // 
            this.btnChangbg.BackgroundImage = global::笔记管理系统.Properties.Resources.paintbg;
            this.btnChangbg.FlatAppearance.BorderSize = 0;
            this.btnChangbg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChangbg.Location = new System.Drawing.Point(614, 10);
            this.btnChangbg.Name = "btnChangbg";
            this.btnChangbg.Size = new System.Drawing.Size(18, 18);
            this.btnChangbg.TabIndex = 13;
            this.btnChangbg.TabStop = false;
            this.toolTip1.SetToolTip(this.btnChangbg, "背景色");
            this.btnChangbg.UseVisualStyleBackColor = true;
            this.btnChangbg.Click += new System.EventHandler(this.btnChangbg_Click);
            // 
            // btnRedo
            // 
            this.btnRedo.BackgroundImage = global::笔记管理系统.Properties.Resources.redo11;
            this.btnRedo.FlatAppearance.BorderSize = 0;
            this.btnRedo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRedo.Location = new System.Drawing.Point(573, 10);
            this.btnRedo.Name = "btnRedo";
            this.btnRedo.Size = new System.Drawing.Size(18, 20);
            this.btnRedo.TabIndex = 12;
            this.btnRedo.TabStop = false;
            this.toolTip1.SetToolTip(this.btnRedo, "重做");
            this.btnRedo.UseVisualStyleBackColor = true;
            this.btnRedo.Click += new System.EventHandler(this.btnRedo_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.BackgroundImage = global::笔记管理系统.Properties.Resources.undo12;
            this.btnUndo.FlatAppearance.BorderSize = 0;
            this.btnUndo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUndo.Location = new System.Drawing.Point(537, 10);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(18, 20);
            this.btnUndo.TabIndex = 11;
            this.btnUndo.TabStop = false;
            this.toolTip1.SetToolTip(this.btnUndo, "撤销");
            this.btnUndo.UseVisualStyleBackColor = true;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // cbFontName
            // 
            this.cbFontName.FormattingEnabled = true;
            this.cbFontName.Items.AddRange(new object[] {
            "宋体",
            "微软雅黑",
            "新宋体",
            "仿宋",
            "楷体",
            "黑体",
            "Arial",
            "Arial Black",
            "Times New Roman",
            "Courier New",
            "Tahoma",
            "Verdana"});
            this.cbFontName.Location = new System.Drawing.Point(4, 7);
            this.cbFontName.Name = "cbFontName";
            this.cbFontName.Size = new System.Drawing.Size(127, 20);
            this.cbFontName.TabIndex = 3;
            this.cbFontName.TabStop = false;
            this.cbFontName.Text = "宋体";
            this.cbFontName.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbFontName_DrawItem);
            this.cbFontName.SelectedIndexChanged += new System.EventHandler(this.cbFontName_SelectedIndexChanged);
            // 
            // btnStrike
            // 
            this.btnStrike.BackgroundImage = global::笔记管理系统.Properties.Resources.strike;
            this.btnStrike.FlatAppearance.BorderSize = 0;
            this.btnStrike.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStrike.Location = new System.Drawing.Point(401, 8);
            this.btnStrike.Name = "btnStrike";
            this.btnStrike.Size = new System.Drawing.Size(19, 20);
            this.btnStrike.TabIndex = 8;
            this.btnStrike.TabStop = false;
            this.toolTip1.SetToolTip(this.btnStrike, "删除线");
            this.btnStrike.UseVisualStyleBackColor = true;
            this.btnStrike.Click += new System.EventHandler(this.btnStrike_Click);
            // 
            // saveDoc
            // 
            this.saveDoc.BackgroundImage = global::笔记管理系统.Properties.Resources.save;
            this.saveDoc.FlatAppearance.BorderSize = 0;
            this.saveDoc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveDoc.Location = new System.Drawing.Point(655, 9);
            this.saveDoc.Name = "saveDoc";
            this.saveDoc.Size = new System.Drawing.Size(18, 18);
            this.saveDoc.TabIndex = 15;
            this.saveDoc.TabStop = false;
            this.toolTip1.SetToolTip(this.saveDoc, "保存笔记");
            this.saveDoc.UseVisualStyleBackColor = true;
            this.saveDoc.Click += new System.EventHandler(this.saveDoc_Click);
            // 
            // btnPicture
            // 
            this.btnPicture.BackgroundImage = global::笔记管理系统.Properties.Resources.picture;
            this.btnPicture.FlatAppearance.BorderSize = 0;
            this.btnPicture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPicture.Location = new System.Drawing.Point(492, 9);
            this.btnPicture.Name = "btnPicture";
            this.btnPicture.Size = new System.Drawing.Size(19, 20);
            this.btnPicture.TabIndex = 10;
            this.btnPicture.TabStop = false;
            this.toolTip1.SetToolTip(this.btnPicture, "插入图片");
            this.btnPicture.UseVisualStyleBackColor = true;
            this.btnPicture.Click += new System.EventHandler(this.btnPicture_Click);
            // 
            // btnColor
            // 
            this.btnColor.BackgroundImage = global::笔记管理系统.Properties.Resources.color;
            this.btnColor.FlatAppearance.BorderSize = 0;
            this.btnColor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor.Location = new System.Drawing.Point(445, 9);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(18, 18);
            this.btnColor.TabIndex = 9;
            this.btnColor.TabStop = false;
            this.toolTip1.SetToolTip(this.btnColor, "选择字体颜色");
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnUnderline
            // 
            this.btnUnderline.BackgroundImage = global::笔记管理系统.Properties.Resources.underline;
            this.btnUnderline.FlatAppearance.BorderSize = 0;
            this.btnUnderline.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnderline.Location = new System.Drawing.Point(361, 8);
            this.btnUnderline.Name = "btnUnderline";
            this.btnUnderline.Size = new System.Drawing.Size(20, 20);
            this.btnUnderline.TabIndex = 7;
            this.btnUnderline.TabStop = false;
            this.toolTip1.SetToolTip(this.btnUnderline, "下划线");
            this.btnUnderline.UseVisualStyleBackColor = true;
            this.btnUnderline.Click += new System.EventHandler(this.btnUnderline_Click);
            // 
            // btnItalic
            // 
            this.btnItalic.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnItalic.BackgroundImage")));
            this.btnItalic.FlatAppearance.BorderSize = 0;
            this.btnItalic.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnItalic.Location = new System.Drawing.Point(319, 8);
            this.btnItalic.Name = "btnItalic";
            this.btnItalic.Size = new System.Drawing.Size(20, 20);
            this.btnItalic.TabIndex = 6;
            this.btnItalic.TabStop = false;
            this.toolTip1.SetToolTip(this.btnItalic, "斜体");
            this.btnItalic.UseVisualStyleBackColor = true;
            this.btnItalic.Click += new System.EventHandler(this.btnItalic_Click);
            // 
            // btnBold
            // 
            this.btnBold.BackgroundImage = global::笔记管理系统.Properties.Resources.bold;
            this.btnBold.FlatAppearance.BorderSize = 0;
            this.btnBold.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBold.Location = new System.Drawing.Point(280, 8);
            this.btnBold.Name = "btnBold";
            this.btnBold.Size = new System.Drawing.Size(20, 20);
            this.btnBold.TabIndex = 5;
            this.btnBold.TabStop = false;
            this.toolTip1.SetToolTip(this.btnBold, "粗体");
            this.btnBold.UseVisualStyleBackColor = true;
            this.btnBold.Click += new System.EventHandler(this.btnBold_Click);
            // 
            // cbFontSize
            // 
            this.cbFontSize.FormattingEnabled = true;
            this.cbFontSize.Items.AddRange(new object[] {
            "9",
            "12",
            "14",
            "16",
            "18",
            "22",
            "26",
            "30",
            "36",
            "42"});
            this.cbFontSize.Location = new System.Drawing.Point(149, 7);
            this.cbFontSize.Name = "cbFontSize";
            this.cbFontSize.Size = new System.Drawing.Size(111, 20);
            this.cbFontSize.TabIndex = 4;
            this.cbFontSize.TabStop = false;
            this.cbFontSize.Text = "9";
            this.cbFontSize.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbFontSize_DrawItem);
            this.cbFontSize.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.cbFontSize_MeasureItem);
            this.cbFontSize.SelectedIndexChanged += new System.EventHandler(this.cbFontSize_SelectedIndexChanged);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 490);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.tbContent);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 新建文件夹ToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建文件夹ToolStripMenuItem1;
        private System.Windows.Forms.RichTextBox tbContent;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbFontSize;
        private System.Windows.Forms.Button btnBold;
        private System.Windows.Forms.Button btnItalic;
        private System.Windows.Forms.Button btnUnderline;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnPicture;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button saveDoc;
        private System.Windows.Forms.Button btnStrike;
        private System.Windows.Forms.ToolStripMenuItem 复制ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 粘贴ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 粘贴ToolStripMenuItem1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip3;
        private System.Windows.Forms.ToolStripMenuItem 剪切ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 复制ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 粘贴ToolStripMenuItem2;
        private System.Windows.Forms.ComboBox cbFontName;
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnRedo;
        private System.Windows.Forms.Button btnChangbg;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem 删除文件夹ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 退出登录ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 保存ctrlsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新建文档ToolStripMenuItem;
    }
}