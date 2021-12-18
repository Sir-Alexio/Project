
namespace View
{
    partial class MedicalExaminationView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicalExaminationView));
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveResultButton = new System.Windows.Forms.Button();
            this.showResultButton = new System.Windows.Forms.Button();
            this.sturtButton = new System.Windows.Forms.Button();
            this.diagnoseButton = new System.Windows.Forms.Button();
            this.pulsometerCheckBox = new System.Windows.Forms.CheckBox();
            this.OximeterCheckBox = new System.Windows.Forms.CheckBox();
            this.termometerCheckBox = new System.Windows.Forms.CheckBox();
            this.spirometerCheckBox = new System.Windows.Forms.CheckBox();
            this.infoTextBox = new System.Windows.Forms.TextBox();
            this.humanPic = new System.Windows.Forms.PictureBox();
            this.Update = new System.Windows.Forms.Button();
            this.hangSensorsButton = new System.Windows.Forms.Button();
            this.pulsometerPic = new System.Windows.Forms.PictureBox();
            this.oxymeterPic = new System.Windows.Forms.PictureBox();
            this.spirometerPic = new System.Windows.Forms.PictureBox();
            this.termometerPic = new System.Windows.Forms.PictureBox();
            this.backButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.humanPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pulsometerPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oxymeterPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spirometerPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.termometerPic)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(804, 433);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(122, 22);
            this.textBox3.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(717, 436);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 28;
            this.label2.Text = "Time: ";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(580, 436);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(122, 22);
            this.textBox2.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(414, 436);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Date of examination: ";
            // 
            // saveResultButton
            // 
            this.saveResultButton.Location = new System.Drawing.Point(741, 578);
            this.saveResultButton.Name = "saveResultButton";
            this.saveResultButton.Size = new System.Drawing.Size(131, 72);
            this.saveResultButton.TabIndex = 25;
            this.saveResultButton.Text = "Save result\r\n";
            this.saveResultButton.UseVisualStyleBackColor = true;
            // 
            // showResultButton
            // 
            this.showResultButton.Location = new System.Drawing.Point(543, 578);
            this.showResultButton.Name = "showResultButton";
            this.showResultButton.Size = new System.Drawing.Size(131, 72);
            this.showResultButton.TabIndex = 24;
            this.showResultButton.Text = "Show result in realtime processing\r\n";
            this.showResultButton.UseVisualStyleBackColor = true;
            // 
            // sturtButton
            // 
            this.sturtButton.Location = new System.Drawing.Point(634, 492);
            this.sturtButton.Name = "sturtButton";
            this.sturtButton.Size = new System.Drawing.Size(117, 54);
            this.sturtButton.TabIndex = 23;
            this.sturtButton.Text = "Start";
            this.sturtButton.UseVisualStyleBackColor = true;
            this.sturtButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // diagnoseButton
            // 
            this.diagnoseButton.Location = new System.Drawing.Point(809, 492);
            this.diagnoseButton.Name = "diagnoseButton";
            this.diagnoseButton.Size = new System.Drawing.Size(117, 54);
            this.diagnoseButton.TabIndex = 22;
            this.diagnoseButton.Text = "Diagnose sensors";
            this.diagnoseButton.UseVisualStyleBackColor = true;
            this.diagnoseButton.Click += new System.EventHandler(this.diagnoseButton_Click);
            // 
            // pulsometerCheckBox
            // 
            this.pulsometerCheckBox.AutoSize = true;
            this.pulsometerCheckBox.Location = new System.Drawing.Point(823, 358);
            this.pulsometerCheckBox.Name = "pulsometerCheckBox";
            this.pulsometerCheckBox.Size = new System.Drawing.Size(101, 21);
            this.pulsometerCheckBox.TabIndex = 20;
            this.pulsometerCheckBox.Text = "Pulsometer";
            this.pulsometerCheckBox.UseVisualStyleBackColor = true;
            // 
            // OximeterCheckBox
            // 
            this.OximeterCheckBox.AutoSize = true;
            this.OximeterCheckBox.Location = new System.Drawing.Point(677, 358);
            this.OximeterCheckBox.Name = "OximeterCheckBox";
            this.OximeterCheckBox.Size = new System.Drawing.Size(86, 21);
            this.OximeterCheckBox.TabIndex = 19;
            this.OximeterCheckBox.Text = "Oximeter";
            this.OximeterCheckBox.UseVisualStyleBackColor = true;
            // 
            // termometerCheckBox
            // 
            this.termometerCheckBox.AutoSize = true;
            this.termometerCheckBox.Location = new System.Drawing.Point(397, 358);
            this.termometerCheckBox.Name = "termometerCheckBox";
            this.termometerCheckBox.Size = new System.Drawing.Size(115, 21);
            this.termometerCheckBox.TabIndex = 18;
            this.termometerCheckBox.Text = "Thermometer";
            this.termometerCheckBox.UseVisualStyleBackColor = true;
            // 
            // spirometerCheckBox
            // 
            this.spirometerCheckBox.AutoSize = true;
            this.spirometerCheckBox.Location = new System.Drawing.Point(543, 358);
            this.spirometerCheckBox.Name = "spirometerCheckBox";
            this.spirometerCheckBox.Size = new System.Drawing.Size(99, 21);
            this.spirometerCheckBox.TabIndex = 17;
            this.spirometerCheckBox.Text = "Spirometer";
            this.spirometerCheckBox.UseVisualStyleBackColor = true;
            // 
            // infoTextBox
            // 
            this.infoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.infoTextBox.Location = new System.Drawing.Point(397, 2);
            this.infoTextBox.Multiline = true;
            this.infoTextBox.Name = "infoTextBox";
            this.infoTextBox.ReadOnly = true;
            this.infoTextBox.Size = new System.Drawing.Size(559, 313);
            this.infoTextBox.TabIndex = 16;
            // 
            // humanPic
            // 
            this.humanPic.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.humanPic.Image = ((System.Drawing.Image)(resources.GetObject("humanPic.Image")));
            this.humanPic.InitialImage = ((System.Drawing.Image)(resources.GetObject("humanPic.InitialImage")));
            this.humanPic.Location = new System.Drawing.Point(85, 55);
            this.humanPic.Name = "humanPic";
            this.humanPic.Size = new System.Drawing.Size(224, 545);
            this.humanPic.TabIndex = 15;
            this.humanPic.TabStop = false;
            // 
            // Update
            // 
            this.Update.Location = new System.Drawing.Point(349, 602);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(102, 48);
            this.Update.TabIndex = 30;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = true;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // hangSensorsButton
            // 
            this.hangSensorsButton.Location = new System.Drawing.Point(417, 492);
            this.hangSensorsButton.Name = "hangSensorsButton";
            this.hangSensorsButton.Size = new System.Drawing.Size(117, 54);
            this.hangSensorsButton.TabIndex = 31;
            this.hangSensorsButton.Text = "Hang sensors on the body";
            this.hangSensorsButton.UseVisualStyleBackColor = true;
            this.hangSensorsButton.Click += new System.EventHandler(this.hangSensorsButton_Click);
            // 
            // pulsometerPic
            // 
            this.pulsometerPic.BackColor = System.Drawing.SystemColors.GrayText;
            this.pulsometerPic.Location = new System.Drawing.Point(210, 176);
            this.pulsometerPic.Name = "pulsometerPic";
            this.pulsometerPic.Size = new System.Drawing.Size(32, 14);
            this.pulsometerPic.TabIndex = 32;
            this.pulsometerPic.TabStop = false;
            this.pulsometerPic.Visible = false;
            // 
            // oxymeterPic
            // 
            this.oxymeterPic.BackColor = System.Drawing.SystemColors.GrayText;
            this.oxymeterPic.Location = new System.Drawing.Point(267, 311);
            this.oxymeterPic.Name = "oxymeterPic";
            this.oxymeterPic.Size = new System.Drawing.Size(31, 14);
            this.oxymeterPic.TabIndex = 33;
            this.oxymeterPic.TabStop = false;
            this.oxymeterPic.Visible = false;
            // 
            // spirometerPic
            // 
            this.spirometerPic.BackColor = System.Drawing.SystemColors.GrayText;
            this.spirometerPic.Location = new System.Drawing.Point(161, 120);
            this.spirometerPic.Name = "spirometerPic";
            this.spirometerPic.Size = new System.Drawing.Size(33, 16);
            this.spirometerPic.TabIndex = 34;
            this.spirometerPic.TabStop = false;
            this.spirometerPic.Visible = false;
            // 
            // termometerPic
            // 
            this.termometerPic.BackColor = System.Drawing.SystemColors.GrayText;
            this.termometerPic.Location = new System.Drawing.Point(252, 199);
            this.termometerPic.Name = "termometerPic";
            this.termometerPic.Size = new System.Drawing.Size(31, 14);
            this.termometerPic.TabIndex = 35;
            this.termometerPic.TabStop = false;
            this.termometerPic.Visible = false;
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(49, 649);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(81, 39);
            this.backButton.TabIndex = 36;
            this.backButton.Text = "back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // MedicalExaminationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 721);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.termometerPic);
            this.Controls.Add(this.spirometerPic);
            this.Controls.Add(this.oxymeterPic);
            this.Controls.Add(this.pulsometerPic);
            this.Controls.Add(this.hangSensorsButton);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.saveResultButton);
            this.Controls.Add(this.showResultButton);
            this.Controls.Add(this.sturtButton);
            this.Controls.Add(this.diagnoseButton);
            this.Controls.Add(this.pulsometerCheckBox);
            this.Controls.Add(this.OximeterCheckBox);
            this.Controls.Add(this.termometerCheckBox);
            this.Controls.Add(this.spirometerCheckBox);
            this.Controls.Add(this.infoTextBox);
            this.Controls.Add(this.humanPic);
            this.Name = "MedicalExaminationView";
            this.Text = "MedicalExaminationView";
            this.Load += new System.EventHandler(this.MedicalExaminationView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.humanPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pulsometerPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oxymeterPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spirometerPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.termometerPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button saveResultButton;
        private System.Windows.Forms.Button showResultButton;
        private System.Windows.Forms.Button sturtButton;
        private System.Windows.Forms.Button diagnoseButton;
        private System.Windows.Forms.CheckBox pulsometerCheckBox;
        private System.Windows.Forms.CheckBox OximeterCheckBox;
        private System.Windows.Forms.CheckBox termometerCheckBox;
        private System.Windows.Forms.CheckBox spirometerCheckBox;
        private System.Windows.Forms.TextBox infoTextBox;
        private System.Windows.Forms.PictureBox humanPic;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button hangSensorsButton;
        private System.Windows.Forms.PictureBox pulsometerPic;
        private System.Windows.Forms.PictureBox oxymeterPic;
        private System.Windows.Forms.PictureBox spirometerPic;
        private System.Windows.Forms.PictureBox termometerPic;
        private System.Windows.Forms.Button backButton;
    }
}