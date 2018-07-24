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
            this.wpfFundsView1 = new Altkom.Santander.Arka.WinFormsClient.Views.WPFFundsView();
            this.hostedComponent1 = new Altkom.Santander.Arka.WPFViews.FundsView();
            this.fundsView1 = new Altkom.Santander.Arka.WinFormsClient.Views.FundsView();
            this.wpfFundGroupsView1 = new Altkom.Santander.Arka.WinFormsClient.Views.WPFFundGroupsView();
            this.hostedComponent2 = new Altkom.Santander.Arka.WPFViews.FundGroupsView();
            this.SuspendLayout();
            // 
            // wpfFundsView1
            // 
            this.wpfFundsView1.Location = new System.Drawing.Point(45, 189);
            this.wpfFundsView1.Name = "wpfFundsView1";
            this.wpfFundsView1.Size = new System.Drawing.Size(761, 202);
            this.wpfFundsView1.TabIndex = 1;
            this.wpfFundsView1.Text = "wpfFundsView1";
            this.wpfFundsView1.Child = this.hostedComponent1;
            // 
            // fundsView1
            // 
            this.fundsView1.Location = new System.Drawing.Point(45, 28);
            this.fundsView1.Name = "fundsView1";
            this.fundsView1.Size = new System.Drawing.Size(715, 141);
            this.fundsView1.TabIndex = 0;
            // 
            // wpfFundGroupsView1
            // 
            this.wpfFundGroupsView1.Location = new System.Drawing.Point(45, 437);
            this.wpfFundGroupsView1.Name = "wpfFundGroupsView1";
            this.wpfFundGroupsView1.Size = new System.Drawing.Size(321, 207);
            this.wpfFundGroupsView1.TabIndex = 2;
            this.wpfFundGroupsView1.Text = "wpfFundGroupsView1";
            this.wpfFundGroupsView1.Child = this.hostedComponent2;
            // 
            // FrmShell
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 684);
            this.Controls.Add(this.wpfFundGroupsView1);
            this.Controls.Add(this.wpfFundsView1);
            this.Controls.Add(this.fundsView1);
            this.Name = "FrmShell";
            this.Text = "FrmShell";
            this.ResumeLayout(false);

        }

        #endregion

        private Views.FundsView fundsView1;
        private Views.WPFFundsView wpfFundsView1;
        private WPFViews.FundsView hostedComponent1;
        private Views.WPFFundGroupsView wpfFundGroupsView1;
        private WPFViews.FundGroupsView hostedComponent2;
    }
}