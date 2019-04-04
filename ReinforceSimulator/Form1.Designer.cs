namespace ReinforceSimulator
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
            this.label1 = new System.Windows.Forms.Label();
            this.WeaponBox = new System.Windows.Forms.PictureBox();
            this.WeaponReinForce = new System.Windows.Forms.Label();
            this.ReinforceBtn = new System.Windows.Forms.Button();
            this.percentLabel = new System.Windows.Forms.Label();
            this.percent = new System.Windows.Forms.Label();
            this.WeaponName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.WeaponBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(276, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "강화 시뮬레이터";
            // 
            // WeaponBox
            // 
            this.WeaponBox.Location = new System.Drawing.Point(272, 79);
            this.WeaponBox.Name = "WeaponBox";
            this.WeaponBox.Size = new System.Drawing.Size(226, 220);
            this.WeaponBox.TabIndex = 1;
            this.WeaponBox.TabStop = false;
            // 
            // WeaponReinForce
            // 
            this.WeaponReinForce.AutoSize = true;
            this.WeaponReinForce.Location = new System.Drawing.Point(278, 91);
            this.WeaponReinForce.Name = "WeaponReinForce";
            this.WeaponReinForce.Size = new System.Drawing.Size(184, 25);
            this.WeaponReinForce.TabIndex = 2;
            this.WeaponReinForce.Text = "WeaponReinforce";
            // 
            // ReinforceBtn
            // 
            this.ReinforceBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReinforceBtn.Location = new System.Drawing.Point(545, 138);
            this.ReinforceBtn.Name = "ReinforceBtn";
            this.ReinforceBtn.Size = new System.Drawing.Size(138, 67);
            this.ReinforceBtn.TabIndex = 3;
            this.ReinforceBtn.Text = "강화";
            this.ReinforceBtn.UseVisualStyleBackColor = true;
            // 
            // percentLabel
            // 
            this.percentLabel.AutoSize = true;
            this.percentLabel.Location = new System.Drawing.Point(92, 91);
            this.percentLabel.Name = "percentLabel";
            this.percentLabel.Size = new System.Drawing.Size(82, 25);
            this.percentLabel.TabIndex = 4;
            this.percentLabel.Text = "강화 확률";
            // 
            // percent
            // 
            this.percent.AutoSize = true;
            this.percent.Location = new System.Drawing.Point(61, 138);
            this.percent.Name = "percent";
            this.percent.Size = new System.Drawing.Size(155, 100);
            this.percent.TabIndex = 5;
            this.percent.Text = "성공 확률 : 100%\r\n유지 확률 : 0%\r\n하락 확률 : 0%\r\n파괴 확률 : 0%\r\n";
            // 
            // WeaponName
            // 
            this.WeaponName.AutoSize = true;
            this.WeaponName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeaponName.Location = new System.Drawing.Point(300, 316);
            this.WeaponName.Name = "WeaponName";
            this.WeaponName.Size = new System.Drawing.Size(267, 42);
            this.WeaponName.TabIndex = 6;
            this.WeaponName.Text = "WeaponName";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.WeaponName);
            this.Controls.Add(this.percent);
            this.Controls.Add(this.percentLabel);
            this.Controls.Add(this.ReinforceBtn);
            this.Controls.Add(this.WeaponReinForce);
            this.Controls.Add(this.WeaponBox);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.WeaponBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox WeaponBox;
        private System.Windows.Forms.Label WeaponReinForce;
        private System.Windows.Forms.Button ReinforceBtn;
        private System.Windows.Forms.Label percentLabel;
        private System.Windows.Forms.Label percent;
        private System.Windows.Forms.Label WeaponName;
    }
}

