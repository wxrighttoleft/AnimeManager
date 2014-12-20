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
            this.endDateDTP = new System.Windows.Forms.DateTimePicker();
            this.startDateDTP = new System.Windows.Forms.DateTimePicker();
            this.bookNameTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.startDateLabel = new System.Windows.Forms.Label();
            this.bookNameLabel = new System.Windows.Forms.Label();
            this.addBookBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.resetBtn = new System.Windows.Forms.Button();
            this.baseInfoGB.SuspendLayout();
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
            // addBookBtn
            // 
            this.addBookBtn.Location = new System.Drawing.Point(20, 144);
            this.addBookBtn.Name = "addBookBtn";
            this.addBookBtn.Size = new System.Drawing.Size(75, 23);
            this.addBookBtn.TabIndex = 6;
            this.addBookBtn.Text = "添加(&A)";
            this.addBookBtn.UseVisualStyleBackColor = true;
            // 
            // updateBtn
            // 
            this.updateBtn.Location = new System.Drawing.Point(126, 144);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(75, 23);
            this.updateBtn.TabIndex = 7;
            this.updateBtn.Text = "修改";
            this.updateBtn.UseVisualStyleBackColor = true;
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 444);
            this.Controls.Add(this.baseInfoGB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "动漫管理";
            this.baseInfoGB.ResumeLayout(false);
            this.baseInfoGB.PerformLayout();
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
    }
}

