namespace SceneViewer {
    partial class MainForm {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent() {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.加载文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.加载文件夹ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.加载DLLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer5 = new System.Windows.Forms.SplitContainer();
            this.HierarchiesTree = new System.Windows.Forms.TreeView();
            this.label5 = new System.Windows.Forms.Label();
            this.ComponentTree = new System.Windows.Forms.TreeView();
            this.label6 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.splitContainer4 = new System.Windows.Forms.SplitContainer();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.ExternalList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label3 = new System.Windows.Forms.Label();
            this.AssetObjList = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.FileView_Selector = new System.Windows.Forms.ComboBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.DumpText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.FileInfoText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.关闭文件ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).BeginInit();
            this.splitContainer5.Panel1.SuspendLayout();
            this.splitContainer5.Panel2.SuspendLayout();
            this.splitContainer5.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).BeginInit();
            this.splitContainer4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.Panel1.SuspendLayout();
            this.splitContainer3.Panel2.SuspendLayout();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.文件ToolStripMenuItem,
            this.加载DLLToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 文件ToolStripMenuItem
            // 
            this.文件ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.加载文件ToolStripMenuItem,
            this.加载文件夹ToolStripMenuItem,
            this.toolStripSeparator1,
            this.关闭文件ToolStripMenuItem});
            this.文件ToolStripMenuItem.Name = "文件ToolStripMenuItem";
            this.文件ToolStripMenuItem.Size = new System.Drawing.Size(44, 21);
            this.文件ToolStripMenuItem.Text = "文件";
            // 
            // 加载文件ToolStripMenuItem
            // 
            this.加载文件ToolStripMenuItem.Name = "加载文件ToolStripMenuItem";
            this.加载文件ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.加载文件ToolStripMenuItem.Text = "加载文件";
            this.加载文件ToolStripMenuItem.Click += new System.EventHandler(this.加载文件ToolStripMenuItem_Click);
            // 
            // 加载文件夹ToolStripMenuItem
            // 
            this.加载文件夹ToolStripMenuItem.Name = "加载文件夹ToolStripMenuItem";
            this.加载文件夹ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.加载文件夹ToolStripMenuItem.Text = "加载文件夹";
            this.加载文件夹ToolStripMenuItem.Click += new System.EventHandler(this.加载文件夹ToolStripMenuItem_Click);
            // 
            // 加载DLLToolStripMenuItem
            // 
            this.加载DLLToolStripMenuItem.Name = "加载DLLToolStripMenuItem";
            this.加载DLLToolStripMenuItem.Size = new System.Drawing.Size(65, 21);
            this.加载DLLToolStripMenuItem.Text = "加载DLL";
            this.加载DLLToolStripMenuItem.Click += new System.EventHandler(this.加载DLLToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tabControl1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(800, 403);
            this.splitContainer1.SplitterDistance = 569;
            this.splitContainer1.TabIndex = 1;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(569, 403);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(561, 377);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "场景视图";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer5
            // 
            this.splitContainer5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer5.Location = new System.Drawing.Point(3, 3);
            this.splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            this.splitContainer5.Panel1.Controls.Add(this.HierarchiesTree);
            this.splitContainer5.Panel1.Controls.Add(this.label5);
            // 
            // splitContainer5.Panel2
            // 
            this.splitContainer5.Panel2.Controls.Add(this.ComponentTree);
            this.splitContainer5.Panel2.Controls.Add(this.label6);
            this.splitContainer5.Size = new System.Drawing.Size(555, 371);
            this.splitContainer5.SplitterDistance = 341;
            this.splitContainer5.TabIndex = 1;
            // 
            // HierarchiesTree
            // 
            this.HierarchiesTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HierarchiesTree.Location = new System.Drawing.Point(0, 23);
            this.HierarchiesTree.Name = "HierarchiesTree";
            this.HierarchiesTree.Size = new System.Drawing.Size(337, 344);
            this.HierarchiesTree.TabIndex = 0;
            this.HierarchiesTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.HierarchiesTree_AfterSelect);
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(337, 23);
            this.label5.TabIndex = 1;
            this.label5.Text = "场景";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ComponentTree
            // 
            this.ComponentTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ComponentTree.Location = new System.Drawing.Point(0, 23);
            this.ComponentTree.Name = "ComponentTree";
            this.ComponentTree.Size = new System.Drawing.Size(206, 344);
            this.ComponentTree.TabIndex = 1;
            this.ComponentTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ComponentTree_AfterSelect);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(206, 23);
            this.label6.TabIndex = 0;
            this.label6.Text = "组件";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.splitContainer4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(561, 377);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "脚本视图";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // splitContainer4
            // 
            this.splitContainer4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer4.Location = new System.Drawing.Point(3, 3);
            this.splitContainer4.Name = "splitContainer4";
            this.splitContainer4.Size = new System.Drawing.Size(555, 371);
            this.splitContainer4.SplitterDistance = 266;
            this.splitContainer4.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.splitContainer3);
            this.tabPage3.Controls.Add(this.FileView_Selector);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(561, 377);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "文件视图";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            this.splitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.Location = new System.Drawing.Point(0, 20);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            this.splitContainer3.Panel1.Controls.Add(this.ExternalList);
            this.splitContainer3.Panel1.Controls.Add(this.label3);
            // 
            // splitContainer3.Panel2
            // 
            this.splitContainer3.Panel2.Controls.Add(this.AssetObjList);
            this.splitContainer3.Panel2.Controls.Add(this.label4);
            this.splitContainer3.Size = new System.Drawing.Size(561, 357);
            this.splitContainer3.SplitterDistance = 157;
            this.splitContainer3.TabIndex = 1;
            // 
            // ExternalList
            // 
            this.ExternalList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.ExternalList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExternalList.FullRowSelect = true;
            this.ExternalList.GridLines = true;
            this.ExternalList.Location = new System.Drawing.Point(0, 23);
            this.ExternalList.Name = "ExternalList";
            this.ExternalList.Size = new System.Drawing.Size(559, 132);
            this.ExternalList.TabIndex = 1;
            this.ExternalList.UseCompatibleStateImageBehavior = false;
            this.ExternalList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "FileID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "FileName";
            this.columnHeader2.Width = 462;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(559, 23);
            this.label3.TabIndex = 0;
            this.label3.Text = "引用文件";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AssetObjList
            // 
            this.AssetObjList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.AssetObjList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AssetObjList.FullRowSelect = true;
            this.AssetObjList.GridLines = true;
            this.AssetObjList.Location = new System.Drawing.Point(0, 23);
            this.AssetObjList.Name = "AssetObjList";
            this.AssetObjList.Size = new System.Drawing.Size(559, 171);
            this.AssetObjList.TabIndex = 1;
            this.AssetObjList.UseCompatibleStateImageBehavior = false;
            this.AssetObjList.View = System.Windows.Forms.View.Details;
            this.AssetObjList.SelectedIndexChanged += new System.EventHandler(this.AssetObjList_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "PathID";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Type";
            this.columnHeader4.Width = 465;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(559, 23);
            this.label4.TabIndex = 0;
            this.label4.Text = "Object列表";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FileView_Selector
            // 
            this.FileView_Selector.Dock = System.Windows.Forms.DockStyle.Top;
            this.FileView_Selector.FormattingEnabled = true;
            this.FileView_Selector.Location = new System.Drawing.Point(0, 0);
            this.FileView_Selector.Name = "FileView_Selector";
            this.FileView_Selector.Size = new System.Drawing.Size(561, 20);
            this.FileView_Selector.TabIndex = 0;
            this.FileView_Selector.SelectedIndexChanged += new System.EventHandler(this.FileView_Selector_SelectedIndexChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.DumpText);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.FileInfoText);
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Size = new System.Drawing.Size(227, 403);
            this.splitContainer2.SplitterDistance = 261;
            this.splitContainer2.TabIndex = 0;
            // 
            // DumpText
            // 
            this.DumpText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DumpText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DumpText.Location = new System.Drawing.Point(0, 23);
            this.DumpText.Multiline = true;
            this.DumpText.Name = "DumpText";
            this.DumpText.ReadOnly = true;
            this.DumpText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.DumpText.Size = new System.Drawing.Size(225, 236);
            this.DumpText.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "检查器";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FileInfoText
            // 
            this.FileInfoText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FileInfoText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FileInfoText.Location = new System.Drawing.Point(0, 23);
            this.FileInfoText.Multiline = true;
            this.FileInfoText.Name = "FileInfoText";
            this.FileInfoText.ReadOnly = true;
            this.FileInfoText.Size = new System.Drawing.Size(225, 113);
            this.FileInfoText.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "文件信息";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripProgressBar1,
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            this.toolStripProgressBar1.Size = new System.Drawing.Size(100, 16);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(66, 17);
            this.toolStripStatusLabel1.Text = "Log  Here";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // 关闭文件ToolStripMenuItem
            // 
            this.关闭文件ToolStripMenuItem.Name = "关闭文件ToolStripMenuItem";
            this.关闭文件ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.关闭文件ToolStripMenuItem.Text = "关闭文件";
            this.关闭文件ToolStripMenuItem.Click += new System.EventHandler(this.关闭文件ToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer5.Panel1.ResumeLayout(false);
            this.splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer5)).EndInit();
            this.splitContainer5.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer4)).EndInit();
            this.splitContainer4.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.splitContainer3.Panel1.ResumeLayout(false);
            this.splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 文件ToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox DumpText;
        private System.Windows.Forms.TextBox FileInfoText;
        private System.Windows.Forms.ToolStripMenuItem 加载文件ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 加载文件夹ToolStripMenuItem;
        private System.Windows.Forms.ComboBox FileView_Selector;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListView ExternalList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView AssetObjList;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.SplitContainer splitContainer4;
        private System.Windows.Forms.ToolStripMenuItem 加载DLLToolStripMenuItem;
        private System.Windows.Forms.TreeView HierarchiesTree;
        private System.Windows.Forms.SplitContainer splitContainer5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TreeView ComponentTree;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 关闭文件ToolStripMenuItem;
    }
}

