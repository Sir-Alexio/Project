
namespace View
{
    partial class NewExaminationView
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
            this.dateOfExaminationTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.oxygenLevelCheckBox = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.breathongCheckBox = new System.Windows.Forms.CheckBox();
            this.pulseCheckBox = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.typesOfMuscleLoading = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backButton = new System.Windows.Forms.Button();
            this.listOfPatients = new System.Windows.Forms.ListBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.temperatureCheckBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // dateOfExaminationTextBox
            // 
            this.dateOfExaminationTextBox.Location = new System.Drawing.Point(248, 289);
            this.dateOfExaminationTextBox.Name = "dateOfExaminationTextBox";
            this.dateOfExaminationTextBox.Size = new System.Drawing.Size(117, 22);
            this.dateOfExaminationTextBox.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 289);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "Add date: ";
            // 
            // oxygenLevelCheckBox
            // 
            this.oxygenLevelCheckBox.AutoSize = true;
            this.oxygenLevelCheckBox.Location = new System.Drawing.Point(670, 199);
            this.oxygenLevelCheckBox.Name = "oxygenLevelCheckBox";
            this.oxygenLevelCheckBox.Size = new System.Drawing.Size(111, 21);
            this.oxygenLevelCheckBox.TabIndex = 20;
            this.oxygenLevelCheckBox.Text = "Oxygen level";
            this.oxygenLevelCheckBox.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 199);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(245, 17);
            this.label3.TabIndex = 19;
            this.label3.Text = "Choose list of physiologic monitoring: ";
            // 
            // breathongCheckBox
            // 
            this.breathongCheckBox.AutoSize = true;
            this.breathongCheckBox.Location = new System.Drawing.Point(531, 199);
            this.breathongCheckBox.Name = "breathongCheckBox";
            this.breathongCheckBox.Size = new System.Drawing.Size(91, 21);
            this.breathongCheckBox.TabIndex = 18;
            this.breathongCheckBox.Text = "Breathing";
            this.breathongCheckBox.UseVisualStyleBackColor = true;
            // 
            // pulseCheckBox
            // 
            this.pulseCheckBox.AutoSize = true;
            this.pulseCheckBox.Location = new System.Drawing.Point(410, 199);
            this.pulseCheckBox.Name = "pulseCheckBox";
            this.pulseCheckBox.Size = new System.Drawing.Size(65, 21);
            this.pulseCheckBox.TabIndex = 17;
            this.pulseCheckBox.Text = "Pulse";
            this.pulseCheckBox.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(200, 17);
            this.label2.TabIndex = 15;
            this.label2.Text = "Select type of muscle loading: ";
            // 
            // typesOfMuscleLoading
            // 
            this.typesOfMuscleLoading.FormattingEnabled = true;
            this.typesOfMuscleLoading.Location = new System.Drawing.Point(248, 144);
            this.typesOfMuscleLoading.Name = "typesOfMuscleLoading";
            this.typesOfMuscleLoading.Size = new System.Drawing.Size(513, 24);
            this.typesOfMuscleLoading.TabIndex = 14;
            this.typesOfMuscleLoading.SelectedIndexChanged += new System.EventHandler(this.typesOfMuscleLoading_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 13;
            this.label1.Text = "Select patient: ";
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(123, 383);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(107, 40);
            this.backButton.TabIndex = 24;
            this.backButton.Text = "back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // listOfPatients
            // 
            this.listOfPatients.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.listOfPatients.FormattingEnabled = true;
            this.listOfPatients.ItemHeight = 29;
            this.listOfPatients.Location = new System.Drawing.Point(248, 12);
            this.listOfPatients.Name = "listOfPatients";
            this.listOfPatients.Size = new System.Drawing.Size(513, 120);
            this.listOfPatients.TabIndex = 25;
            this.listOfPatients.Tag = "test";
            // 
            // updateButton
            // 
            this.updateButton.Location = new System.Drawing.Point(22, 72);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(72, 28);
            this.updateButton.TabIndex = 27;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = true;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(389, 383);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(107, 40);
            this.saveButton.TabIndex = 28;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // temperatureCheckBox
            // 
            this.temperatureCheckBox.AutoSize = true;
            this.temperatureCheckBox.Location = new System.Drawing.Point(270, 198);
            this.temperatureCheckBox.Name = "temperatureCheckBox";
            this.temperatureCheckBox.Size = new System.Drawing.Size(112, 21);
            this.temperatureCheckBox.TabIndex = 29;
            this.temperatureCheckBox.Text = "Temperature";
            this.temperatureCheckBox.UseVisualStyleBackColor = true;
            // 
            // NewExaminationView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.temperatureCheckBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.listOfPatients);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.dateOfExaminationTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.oxygenLevelCheckBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.breathongCheckBox);
            this.Controls.Add(this.pulseCheckBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.typesOfMuscleLoading);
            this.Controls.Add(this.label1);
            this.Name = "NewExaminationView";
            this.Text = "NewExaminationView";
            this.Load += new System.EventHandler(this.NewExaminationView_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox dateOfExaminationTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox oxygenLevelCheckBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox breathongCheckBox;
        private System.Windows.Forms.CheckBox pulseCheckBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox typesOfMuscleLoading;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ListBox listOfPatients;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.CheckBox temperatureCheckBox;
    }
}