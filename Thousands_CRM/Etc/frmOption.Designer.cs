namespace Thousands_CRM.Etc
{
    partial class frmOption
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstOptionList = new System.Windows.Forms.ListBox();
            this.panelUserCtrl = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lstOptionList
            // 
            this.lstOptionList.FormattingEnabled = true;
            this.lstOptionList.Location = new System.Drawing.Point(12, 12);
            this.lstOptionList.Name = "lstOptionList";
            this.lstOptionList.Size = new System.Drawing.Size(102, 420);
            this.lstOptionList.TabIndex = 0;
            this.lstOptionList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // panelUserCtrl
            // 
            this.panelUserCtrl.Location = new System.Drawing.Point(120, 12);
            this.panelUserCtrl.Name = "panelUserCtrl";
            this.panelUserCtrl.Size = new System.Drawing.Size(260, 420);
            this.panelUserCtrl.TabIndex = 1;
            // 
            // frmOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 445);
            this.Controls.Add(this.panelUserCtrl);
            this.Controls.Add(this.lstOptionList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmOption";
            this.Text = "Option";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmOption_FormClosing);
            this.Load += new System.EventHandler(this.frmOption_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstOptionList;
        private System.Windows.Forms.Panel panelUserCtrl;
    }
}

