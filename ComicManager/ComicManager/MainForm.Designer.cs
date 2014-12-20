namespace ComicManager
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.baseInfoGB = new System.Windows.Forms.GroupBox();
            this.resetBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.addBookBtn = new System.Windows.Forms.Button();
            this.endDateDTP = new System.Windows.Forms.DateTimePicker();
            this.startDateDTP = new System.Windows.Forms.DateTimePicker();
            this.bookNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.bookNameLabel = new System.Windows.Forms.Label();
            this.searchGB = new System.Windows.Forms.GroupBox();
            this.searchBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.copyBookNameBtn = new System.Windows.Forms.Button();
            this.openFileBtn = new System.Windows.Forms.Button();
            this.bookListView = new System.Windows.Forms.ListView();
            this.bookNameLVColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.startDateLVColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.endDateLVColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.leftPanel = new System.Windows.Forms.Panel();
            this.centerPanel = new System.Windows.Forms.Panel();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.topPanel = new System.Windows.Forms.Panel();
            this.baseInfoGB.SuspendLayout();
            this.searchGB.SuspendLayout();
            this.leftPanel.SuspendLayout();
            this.centerPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // baseInfoGB
            // 
            this.baseInfoGB.Controls.Add(this.resetBtn);
            this.baseInfoGB.Controls.Add(this.updateBtn);
            this.baseInfoGB.Controls.Add(this.addBookBtn);
            this.baseInfoGB.Controls.Add(this.endDateDTP);
            this.baseInfoGB.Controls.Add(this.startDateDTP);
            this.baseInfoGB.Controls.Add(this.bookNameTextBox);
            this.baseInfoGB.Controls.Add(this.label3);
            this.baseInfoGB.Controls.Add(this.startDateLabel);
            this.baseInfoGB.Controls.Add(this.bookNameLabel);
            this.baseInfoGB.Location = new System.Drawing.Point(12, 12);
            this.baseInfoGB.Name = "baseInfoGB";
            this.baseInfoGB.Size = new System.Drawing.Size(336, 182);
            this.baseInfoGB.TabIndex = 0;
            this.baseInfoGB.TabStop = false;
            this.baseInfoGB.Text = "基本信息";
            // 
            // resetBtn
            // 
            this.resetBtn.Location = new System.Drawing.Point(232, 144);
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.Size = new System.Drawing.Size(75, 23);
            this.resetBtn.TabIndex = 8;
            this.resetBtn.Text = "重写";
            this.resetBtn.UseVisualStyleBackColor = true;
            // 
            // updateBtn
            // 
            this.updateBtn.Enabled = false;
            this.updateBtn.Location = new System.Drawing.Point(126, 144);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 7;
            this.updateBtn.Text = "修改";
            this.updateBtn.UseVisualStyleBackColor = true;
            // 
            // addBookBtn
            // 
            this.addBookBtn.Location = new System.Drawing.Point(20, 144);
            this.addBookBtn.Name = "addBookBtn";
            this.addBookBtn.Size = new System.Drawing.Size(75, 23);
            this.addBookBtn.TabIndex = 6;
            this.addBookBtn.Text = "添加(&A)";
            this.addBookBtn.UseVisualStyleBackColor = true;
            // 
            // endDateDTP
            // 
            this.endDateDTP.Location = new System.Drawing.Point(89, 111);
            this.endDateDTP.Name = "endDateDTP";
            this.endDateDTP.Size = new System.Drawing.Size(219, 21);
            this.endDateDTP.TabIndex = 5;
            // 
            // startDateDTP
            // 
            this.startDateDTP.Location = new System.Drawing.Point(89, 69);
            this.startDateDTP.Name = "startDateDTP";
            this.startDateDTP.Size = new System.Drawing.Size(219, 21);
            this.startDateDTP.TabIndex = 4;
            // 
            // bookNameTextBox
            // 
            this.bookNameTextBox.Location = new System.Drawing.Point(89, 30);
            this.bookNameTextBox.Name = "bookNameTextBox";
            this.bookNameTextBox.Size = new System.Drawing.Size(219, 21);
            this.bookNameTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "结束时间：";
            // 
            // startDateLabel
            // 
            this.startDateLabel.AutoSize = true;
            this.startDateLabel.Location = new System.Drawing.Point(18, 75);
            this.startDateLabel.Name = "startDateLabel";
            this.startDateLabel.Size = new System.Drawing.Size(65, 12);
            this.startDateLabel.TabIndex = 1;
            this.startDateLabel.Text = "开始时间：";
            // 
            // bookNameLabel
            // 
            this.bookNameLabel.AutoSize = true;
            this.bookNameLabel.Location = new System.Drawing.Point(18, 33);
            this.bookNameLabel.Name = "bookNameLabel";
            this.bookNameLabel.Size = new System.Drawing.Size(65, 12);
            this.bookNameLabel.TabIndex = 0;
            this.bookNameLabel.Text = "作 品 名：";
            // 
            // searchGB
            // 
            this.searchGB.Controls.Add(this.searchBtn);
            this.searchGB.Controls.Add(this.textBox1);
            this.searchGB.Location = new System.Drawing.Point(12, 200);
            this.searchGB.Name = "searchGB";
            this.searchGB.Size = new System.Drawing.Size(336, 58);
            this.searchGB.TabIndex = 1;
            this.searchGB.TabStop = false;
            this.searchGB.Text = "搜索";
            // 
            // searchBtn
            // 
            this.searchBtn.Location = new System.Drawing.Point(232, 20);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(75, 23);
            this.searchBtn.TabIndex = 2;
            this.searchBtn.Text = "搜索";
            this.searchBtn.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(20, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(181, 21);
            this.textBox1.TabIndex = 2;
            // 
            // copyBookNameBtn
            // 
            this.copyBookNameBtn.Location = new System.Drawing.Point(32, 279);
            this.copyBookNameBtn.Name = "copyBookNameBtn";
            this.copyBookNameBtn.Size = new System.Drawing.Size(101, 23);
            this.copyBookNameBtn.TabIndex = 2;
            this.copyBookNameBtn.Text = "复制作品名";
            this.copyBookNameBtn.UseVisualStyleBackColor = true;
            this.copyBookNameBtn.Click += new System.EventHandler(this.copyBookNameBtn_Click);
            // 
            // openFileBtn
            // 
            this.openFileBtn.Location = new System.Drawing.Point(218, 279);
            this.openFileBtn.Name = "openFileBtn";
            this.openFileBtn.Size = new System.Drawing.Size(101, 23);
            this.openFileBtn.TabIndex = 3;
            this.openFileBtn.Text = "打开文件";
            this.openFileBtn.UseVisualStyleBackColor = true;
            this.openFileBtn.Click += new System.EventHandler(this.openFileBtn_Click);
            // 
            // bookListView
            // 
            this.bookListView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bookListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.bookNameLVColumn,
            this.startDateLVColumn,
            this.endDateLVColumn});
            this.bookListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookListView.GridLines = true;
            this.bookListView.Location = new System.Drawing.Point(5, 5);
            this.bookListView.Name = "bookListView";
            this.bookListView.Size = new System.Drawing.Size(360, 305);
            this.bookListView.TabIndex = 4;
            this.bookListView.UseCompatibleStateImageBehavior = false;
            this.bookListView.View = System.Windows.Forms.View.Details;
            // 
            // bookNameLVColumn
            // 
            this.bookNameLVColumn.Text = "作品名称";
            this.bookNameLVColumn.Width = 126;
            // 
            // startDateLVColumn
            // 
            this.startDateLVColumn.Text = "开始时间";
            this.startDateLVColumn.Width = 104;
            // 
            // endDateLVColumn
            // 
            this.endDateLVColumn.Text = "结束时间";
            this.endDateLVColumn.Width = 105;
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.baseInfoGB);
            this.leftPanel.Controls.Add(this.searchGB);
            this.leftPanel.Controls.Add(this.openFileBtn);
            this.leftPanel.Controls.Add(this.copyBookNameBtn);
            this.leftPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftPanel.Location = new System.Drawing.Point(0, 0);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(372, 315);
            this.leftPanel.TabIndex = 5;
            // 
            // centerPanel
            // 
            this.centerPanel.Controls.Add(this.bookListView);
            this.centerPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerPanel.Location = new System.Drawing.Point(372, 0);
            this.centerPanel.Name = "centerPanel";
            this.centerPanel.Padding = new System.Windows.Forms.Padding(5);
            this.centerPanel.Size = new System.Drawing.Size(370, 315);
            this.centerPanel.TabIndex = 6;
            // 
            // bottomPanel
            // 
            this.bottomPanel.Controls.Add(this.statusStrip1);
            this.bottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomPanel.Location = new System.Drawing.Point(0, 315);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(742, 28);
            this.bottomPanel.TabIndex = 7;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 6);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(742, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.centerPanel);
            this.topPanel.Controls.Add(this.leftPanel);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(742, 315);
            this.topPanel.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 343);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.bottomPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(758, 381);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "动漫管理";
            this.baseInfoGB.ResumeLayout(false);
            this.baseInfoGB.PerformLayout();
            this.searchGB.ResumeLayout(false);
            this.searchGB.PerformLayout();
            this.leftPanel.ResumeLayout(false);
            this.centerPanel.ResumeLayout(false);
            this.bottomPanel.ResumeLayout(false);
            this.bottomPanel.PerformLayout();
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox baseInfoGB;
        private System.Windows.Forms.DateTimePicker startDateDTP;
        private System.Windows.Forms.TextBox bookNameTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label startDateLabel;
        private System.Windows.Forms.Label bookNameLabel;
        private System.Windows.Forms.DateTimePicker endDateDTP;
        private System.Windows.Forms.Button resetBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button addBookBtn;
        private System.Windows.Forms.GroupBox searchGB;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button copyBookNameBtn;
        private System.Windows.Forms.Button openFileBtn;
        private System.Windows.Forms.ListView bookListView;
        private System.Windows.Forms.ColumnHeader bookNameLVColumn;
        private System.Windows.Forms.ColumnHeader startDateLVColumn;
        private System.Windows.Forms.ColumnHeader endDateLVColumn;
        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel centerPanel;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel topPanel;
    }
}

