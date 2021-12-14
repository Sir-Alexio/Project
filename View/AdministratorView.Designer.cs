
namespace View
{
    partial class AdministratorView
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
            this.newExaminationButton = new System.Windows.Forms.Button();
            this.newPatientButton = new System.Windows.Forms.Button();
            this.showTheResult = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administratorBackButton = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listOfPatients = new System.Windows.Forms.ListBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // newExaminationButton
            // 
            this.newExaminationButton.Location = new System.Drawing.Point(69, 518);
            this.newExaminationButton.Name = "newExaminationButton";
            this.newExaminationButton.Size = new System.Drawing.Size(140, 70);
            this.newExaminationButton.TabIndex = 12;
            this.newExaminationButton.Text = "Schedule new medical examination";
            this.newExaminationButton.UseVisualStyleBackColor = true;
            this.newExaminationButton.Click += new System.EventHandler(this.newExaminationButton_Click);
            // 
            // newPatientButton
            // 
            this.newPatientButton.Location = new System.Drawing.Point(397, 518);
            this.newPatientButton.Name = "newPatientButton";
            this.newPatientButton.Size = new System.Drawing.Size(140, 70);
            this.newPatientButton.TabIndex = 13;
            this.newPatientButton.Text = "Register new patient";
            this.newPatientButton.UseVisualStyleBackColor = true;
            this.newPatientButton.Click += new System.EventHandler(this.newPatientButton_Click);
            // 
            // showTheResult
            // 
            this.showTheResult.Location = new System.Drawing.Point(712, 518);
            this.showTheResult.Name = "showTheResult";
            this.showTheResult.Size = new System.Drawing.Size(140, 70);
            this.showTheResult.TabIndex = 14;
            this.showTheResult.Text = "Show the result of medical examination";
            this.showTheResult.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administratorBackButton,
            this.viewToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(935, 28);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // administratorBackButton
            // 
            this.administratorBackButton.Name = "administratorBackButton";
            this.administratorBackButton.Size = new System.Drawing.Size(54, 24);
            this.administratorBackButton.Text = "back";
            this.administratorBackButton.Click += new System.EventHandler(this.administratorBackButton_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(72, 24);
            this.viewToolStripMenuItem.Text = "Update";
            // 
            // listOfPatients
            // 
            this.listOfPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listOfPatients.FormattingEnabled = true;
            this.listOfPatients.ItemHeight = 29;
            this.listOfPatients.Location = new System.Drawing.Point(0, 31);
            this.listOfPatients.Name = "listOfPatients";
            this.listOfPatients.Size = new System.Drawing.Size(935, 468);
            this.listOfPatients.TabIndex = 11;
            this.listOfPatients.SelectedIndexChanged += new System.EventHandler(this.listOfPatients_SelectedIndexChanged);
            // 
            // AdministratorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 625);
            this.Controls.Add(this.showTheResult);
            this.Controls.Add(this.newPatientButton);
            this.Controls.Add(this.newExaminationButton);
            this.Controls.Add(this.listOfPatients);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdministratorView";
            this.Text = "Administrator";
            this.Load += new System.EventHandler(this.Administrator_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button newExaminationButton;
        private System.Windows.Forms.Button newPatientButton;
        private System.Windows.Forms.Button showTheResult;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administratorBackButton;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ListBox listOfPatients;
    }
}