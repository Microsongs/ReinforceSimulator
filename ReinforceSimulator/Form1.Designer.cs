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
            this.weaponReinForce = new System.Windows.Forms.Label();
            this.ReinforceBtn = new System.Windows.Forms.Button();
            this.percentLabel = new System.Windows.Forms.Label();
            this.weaponPercent = new System.Windows.Forms.Label();
            this.weaponName = new System.Windows.Forms.Label();
            this.weaponData = new System.Windows.Forms.Label();
            this.cycle = new System.Windows.Forms.Label();
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
            // weaponReinForce
            // 
            this.weaponReinForce.AutoSize = true;
            this.weaponReinForce.Location = new System.Drawing.Point(278, 91);
            this.weaponReinForce.Name = "weaponReinForce";
            this.weaponReinForce.Size = new System.Drawing.Size(179, 25);
            this.weaponReinForce.TabIndex = 2;
            this.weaponReinForce.Text = "weaponReinforce";
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
            this.ReinforceBtn.Click += new System.EventHandler(this.ReinforceBtn_Click);
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
            // weaponPercent
            // 
            this.weaponPercent.AutoSize = true;
            this.weaponPercent.Location = new System.Drawing.Point(61, 138);
            this.weaponPercent.Name = "weaponPercent";
            this.weaponPercent.Size = new System.Drawing.Size(161, 25);
            this.weaponPercent.TabIndex = 5;
            this.weaponPercent.Text = "weaponPercent";
            // 
            // weaponName
            // 
            this.weaponName.AutoSize = true;
            this.weaponName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weaponName.Location = new System.Drawing.Point(300, 316);
            this.weaponName.Name = "weaponName";
            this.weaponName.Size = new System.Drawing.Size(259, 42);
            this.weaponName.TabIndex = 6;
            this.weaponName.Text = "weaponName";
            // 
            // weaponData
            // 
            this.weaponData.AutoSize = true;
            this.weaponData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weaponData.Location = new System.Drawing.Point(49, 299);
            this.weaponData.Name = "weaponData";
            this.weaponData.Size = new System.Drawing.Size(177, 33);
            this.weaponData.TabIndex = 7;
            this.weaponData.Text = "weaponData";
            // 
            // cycle
            // 
            this.cycle.AutoSize = true;
            this.cycle.Location = new System.Drawing.Point(602, 44);
            this.cycle.Name = "cycle";
            this.cycle.Size = new System.Drawing.Size(62, 25);
            this.cycle.TabIndex = 8;
            this.cycle.Text = "cycle";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cycle);
            this.Controls.Add(this.weaponData);
            this.Controls.Add(this.weaponName);
            this.Controls.Add(this.weaponPercent);
            this.Controls.Add(this.percentLabel);
            this.Controls.Add(this.ReinforceBtn);
            this.Controls.Add(this.weaponReinForce);
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
        private System.Windows.Forms.Label weaponReinForce;
        private System.Windows.Forms.Button ReinforceBtn;
        private System.Windows.Forms.Label percentLabel;
        private System.Windows.Forms.Label weaponPercent;
        private System.Windows.Forms.Label weaponName;
        private System.Windows.Forms.Label weaponData;
        private System.Windows.Forms.Label cycle;
    }
}

