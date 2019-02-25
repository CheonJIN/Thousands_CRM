namespace Thousands_CRM.Etc
{
    partial class uCtrlViewData
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

        #region 구성 요소 디자이너에서 생성한 코드

        /// <summary> 
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBasicSetting = new System.Windows.Forms.Label();
            this.lstCheckList = new System.Windows.Forms.ListBox();
            this.lstDeleteList = new System.Windows.Forms.ListBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnDel = new System.Windows.Forms.Button();
            this.lblDelete = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblSeeing = new System.Windows.Forms.Label();
            this.btnUp = new System.Windows.Forms.Button();
            this.btnDown = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // lblBasicSetting
            // 
            this.lblBasicSetting.AutoSize = true;
            this.lblBasicSetting.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBasicSetting.Location = new System.Drawing.Point(3, 0);
            this.lblBasicSetting.Name = "lblBasicSetting";
            this.lblBasicSetting.Size = new System.Drawing.Size(71, 13);
            this.lblBasicSetting.TabIndex = 11;
            this.lblBasicSetting.Text = "- View data";
            // 
            // lstCheckList
            // 
            this.lstCheckList.FormattingEnabled = true;
            this.lstCheckList.Location = new System.Drawing.Point(14, 38);
            this.lstCheckList.Name = "lstCheckList";
            this.lstCheckList.Size = new System.Drawing.Size(98, 251);
            this.lstCheckList.TabIndex = 21;
            // 
            // lstDeleteList
            // 
            this.lstDeleteList.FormattingEnabled = true;
            this.lstDeleteList.Location = new System.Drawing.Point(149, 38);
            this.lstDeleteList.Name = "lstDeleteList";
            this.lstDeleteList.Size = new System.Drawing.Size(98, 251);
            this.lstDeleteList.TabIndex = 22;
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(172, 296);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 29;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(118, 171);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(25, 25);
            this.btnDel.TabIndex = 23;
            this.btnDel.Text = "▷";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // lblDelete
            // 
            this.lblDelete.AutoSize = true;
            this.lblDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelete.Location = new System.Drawing.Point(146, 22);
            this.lblDelete.Name = "lblDelete";
            this.lblDelete.Size = new System.Drawing.Size(54, 13);
            this.lblDelete.TabIndex = 28;
            this.lblDelete.Text = "제거 목록";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(118, 140);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(25, 25);
            this.btnAdd.TabIndex = 24;
            this.btnAdd.Text = "◀";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblSeeing
            // 
            this.lblSeeing.AutoSize = true;
            this.lblSeeing.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeeing.Location = new System.Drawing.Point(11, 22);
            this.lblSeeing.Name = "lblSeeing";
            this.lblSeeing.Size = new System.Drawing.Size(54, 13);
            this.lblSeeing.TabIndex = 27;
            this.lblSeeing.Text = "확인 목록";
            // 
            // btnUp
            // 
            this.btnUp.Location = new System.Drawing.Point(56, 296);
            this.btnUp.Name = "btnUp";
            this.btnUp.Size = new System.Drawing.Size(25, 25);
            this.btnUp.TabIndex = 25;
            this.btnUp.Text = "▲";
            this.btnUp.UseVisualStyleBackColor = true;
            this.btnUp.Click += new System.EventHandler(this.btnUp_Click);
            // 
            // btnDown
            // 
            this.btnDown.Location = new System.Drawing.Point(87, 296);
            this.btnDown.Name = "btnDown";
            this.btnDown.Size = new System.Drawing.Size(25, 25);
            this.btnDown.TabIndex = 26;
            this.btnDown.Text = "▼";
            this.btnDown.UseVisualStyleBackColor = true;
            this.btnDown.Click += new System.EventHandler(this.btnDown_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(14, 325);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(233, 10);
            this.groupBox1.TabIndex = 30;
            this.groupBox1.TabStop = false;
            // 
            // uCtrlViewData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstCheckList);
            this.Controls.Add(this.lstDeleteList);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDel);
            this.Controls.Add(this.lblDelete);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblSeeing);
            this.Controls.Add(this.btnUp);
            this.Controls.Add(this.btnDown);
            this.Controls.Add(this.lblBasicSetting);
            this.Name = "uCtrlViewData";
            this.Size = new System.Drawing.Size(260, 420);
            this.Load += new System.EventHandler(this.uCtrlViewData_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBasicSetting;
        private System.Windows.Forms.ListBox lstCheckList;
        private System.Windows.Forms.ListBox lstDeleteList;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Label lblDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblSeeing;
        private System.Windows.Forms.Button btnUp;
        private System.Windows.Forms.Button btnDown;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}
