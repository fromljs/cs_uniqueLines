namespace cs_uniqueLines
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbxFilePath = new System.Windows.Forms.TextBox();
            this.btnFilePath = new System.Windows.Forms.Button();
            this.lbxfileInfo = new System.Windows.Forms.ListBox();
            this.btnUnique = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbxFilePath
            // 
            this.tbxFilePath.Location = new System.Drawing.Point(93, 14);
            this.tbxFilePath.Name = "tbxFilePath";
            this.tbxFilePath.Size = new System.Drawing.Size(440, 21);
            this.tbxFilePath.TabIndex = 0;
            // 
            // btnFilePath
            // 
            this.btnFilePath.Location = new System.Drawing.Point(12, 12);
            this.btnFilePath.Name = "btnFilePath";
            this.btnFilePath.Size = new System.Drawing.Size(75, 23);
            this.btnFilePath.TabIndex = 1;
            this.btnFilePath.Text = "파일경로";
            this.btnFilePath.UseVisualStyleBackColor = true;
            this.btnFilePath.Click += new System.EventHandler(this.btnFilpath_Click);
            // 
            // lbxfileInfo
            // 
            this.lbxfileInfo.FormattingEnabled = true;
            this.lbxfileInfo.ItemHeight = 12;
            this.lbxfileInfo.Location = new System.Drawing.Point(12, 51);
            this.lbxfileInfo.Name = "lbxfileInfo";
            this.lbxfileInfo.Size = new System.Drawing.Size(521, 328);
            this.lbxfileInfo.TabIndex = 2;
            // 
            // btnUnique
            // 
            this.btnUnique.Location = new System.Drawing.Point(12, 385);
            this.btnUnique.Name = "btnUnique";
            this.btnUnique.Size = new System.Drawing.Size(75, 23);
            this.btnUnique.TabIndex = 3;
            this.btnUnique.Text = "중복제거";
            this.btnUnique.UseVisualStyleBackColor = true;
            this.btnUnique.Click += new System.EventHandler(this.btnUnique_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(93, 385);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 426);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnUnique);
            this.Controls.Add(this.lbxfileInfo);
            this.Controls.Add(this.btnFilePath);
            this.Controls.Add(this.tbxFilePath);
            this.Name = "Form1";
            this.Text = "중복제거";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbxFilePath;
        private System.Windows.Forms.Button btnFilePath;
        private System.Windows.Forms.ListBox lbxfileInfo;
        private System.Windows.Forms.Button btnUnique;
        private System.Windows.Forms.Button btnSave;
    }
}

