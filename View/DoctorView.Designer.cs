
namespace View
{
    partial class DoctorView
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
            this.startMedicalExaminationButton = new System.Windows.Forms.Button();
            this.listOfExaminations = new System.Windows.Forms.ListBox();
            this.backButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startMedicalExaminationButton
            // 
            this.startMedicalExaminationButton.Location = new System.Drawing.Point(330, 482);
            this.startMedicalExaminationButton.Name = "startMedicalExaminationButton";
            this.startMedicalExaminationButton.Size = new System.Drawing.Size(134, 64);
            this.startMedicalExaminationButton.TabIndex = 12;
            this.startMedicalExaminationButton.Text = "Start medical examination";
            this.startMedicalExaminationButton.UseVisualStyleBackColor = true;
            this.startMedicalExaminationButton.Click += new System.EventHandler(this.startMadicalExaminationButton_Click);
            // 
            // listOfExaminations
            // 
            this.listOfExaminations.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listOfExaminations.FormattingEnabled = true;
            this.listOfExaminations.ItemHeight = 29;
            this.listOfExaminations.Location = new System.Drawing.Point(1, -2);
            this.listOfExaminations.Name = "listOfExaminations";
            this.listOfExaminations.Size = new System.Drawing.Size(927, 468);
            this.listOfExaminations.TabIndex = 17;
            this.listOfExaminations.Tag = "test";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(39, 494);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(103, 41);
            this.backButton.TabIndex = 18;
            this.backButton.Text = "back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(669, 494);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(103, 41);
            this.updateButton.TabIndex = 19;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // DoctorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 573);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.listOfExaminations);
            this.Controls.Add(this.startMedicalExaminationButton);
            this.Name = "DoctorView";
            this.Text = "Doctor";
            this.Load += new System.EventHandler(this.Doctor_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button startMedicalExaminationButton;
        private System.Windows.Forms.ListBox listOfExaminations;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button updateButton;
    }
}