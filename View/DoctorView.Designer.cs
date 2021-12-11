
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
            this.lv_Initiative = new System.Windows.Forms.ListView();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_Initiative
            // 
            this.lv_Initiative.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_Initiative.FullRowSelect = true;
            this.lv_Initiative.GridLines = true;
            this.lv_Initiative.HideSelection = false;
            this.lv_Initiative.Location = new System.Drawing.Point(1, 1);
            this.lv_Initiative.Name = "lv_Initiative";
            this.lv_Initiative.Size = new System.Drawing.Size(927, 458);
            this.lv_Initiative.TabIndex = 11;
            this.lv_Initiative.UseCompatibleStateImageBehavior = false;
            this.lv_Initiative.View = System.Windows.Forms.View.Details;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(379, 482);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(134, 64);
            this.button1.TabIndex = 12;
            this.button1.Text = "Start medical examination";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // DoctorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 573);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lv_Initiative);
            this.Name = "DoctorView";
            this.Text = "Doctor";
            this.Load += new System.EventHandler(this.Doctor_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lv_Initiative;
        private System.Windows.Forms.Button button1;
    }
}