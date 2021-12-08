
namespace View
{
    partial class Authorization
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
            this.Administrator = new System.Windows.Forms.Button();
            this.Doctor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Administrator
            // 
            this.Administrator.Location = new System.Drawing.Point(147, 165);
            this.Administrator.Name = "Administrator";
            this.Administrator.Size = new System.Drawing.Size(139, 117);
            this.Administrator.TabIndex = 0;
            this.Administrator.Text = "Administrator";
            this.Administrator.UseVisualStyleBackColor = true;
            this.Administrator.Click += new System.EventHandler(this.Administrator_Click);
            // 
            // Doctor
            // 
            this.Doctor.Location = new System.Drawing.Point(475, 165);
            this.Doctor.Name = "Doctor";
            this.Doctor.Size = new System.Drawing.Size(139, 117);
            this.Doctor.TabIndex = 1;
            this.Doctor.Text = "Doctor";
            this.Doctor.UseVisualStyleBackColor = true;
            this.Doctor.Click += new System.EventHandler(this.Doctor_Click);
            // 
            // Authorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Doctor);
            this.Controls.Add(this.Administrator);
            this.Name = "Authorization";
            this.Text = "Authorization";
            this.Load += new System.EventHandler(this.Authorization_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Administrator;
        private System.Windows.Forms.Button Doctor;
    }
}

