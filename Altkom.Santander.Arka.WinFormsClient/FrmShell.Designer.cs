namespace Altkom.Santander.Arka.WinFormsClient
{
    partial class FrmShell
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
            this.fundsView1 = new Altkom.Santander.Arka.WinFormsClient.Views.FundsView();
            this.SuspendLayout();
            // 
            // fundsView1
            // 
            this.fundsView1.Location = new System.Drawing.Point(24, 62);
            this.fundsView1.Name = "fundsView1";
            this.fundsView1.Size = new System.Drawing.Size(715, 362);
            this.fundsView1.TabIndex = 0;
            // 
            // FrmShell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.fundsView1);
            this.Name = "FrmShell";
            this.Text = "FrmShell";
            this.ResumeLayout(false);

        }

        #endregion

        private Views.FundsView fundsView1;
    }
}