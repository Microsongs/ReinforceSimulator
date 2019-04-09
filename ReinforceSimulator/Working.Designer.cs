namespace ReinforceSimulator
{
    partial class Working
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
            this.label1 = new System.Windows.Forms.Label();
            this.ReinforceBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ReinforceBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 85);
            this.label1.TabIndex = 0;
            this.label1.Text = "강화중";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // ReinforceBox
            // 
            this.ReinforceBox.InitialImage = global::ReinforceSimulator.Properties.Resources.ReinforceImage;
            this.ReinforceBox.Location = new System.Drawing.Point(94, 12);
            this.ReinforceBox.Name = "ReinforceBox";
            this.ReinforceBox.Size = new System.Drawing.Size(256, 196);
            this.ReinforceBox.TabIndex = 1;
            this.ReinforceBox.TabStop = false;
            // 
            // Working
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 283);
            this.Controls.Add(this.ReinforceBox);
            this.Controls.Add(this.label1);
            this.Name = "Working";
            this.Text = "Working";
            ((System.ComponentModel.ISupportInitialize)(this.ReinforceBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ReinforceBox;
    }
}