
namespace View
{
    partial class GraphicView
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
            this.TemperatureGraphic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.TemperatureGraphic)).BeginInit();
            this.SuspendLayout();
            // 
            // TemperatureGraphic
            // 
            this.TemperatureGraphic.Location = new System.Drawing.Point(12, 3);
            this.TemperatureGraphic.Name = "TemperatureGraphic";
            this.TemperatureGraphic.Size = new System.Drawing.Size(746, 423);
            this.TemperatureGraphic.TabIndex = 0;
            this.TemperatureGraphic.TabStop = false;
            // 
            // GraphicView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TemperatureGraphic);
            this.Name = "GraphicView";
            this.Text = "GraphicView";
            this.Load += new System.EventHandler(this.GraphicView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TemperatureGraphic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox TemperatureGraphic;
    }
}