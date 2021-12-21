namespace RestaurantApp.Home_Forms
{
    partial class HomeDelivery
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
            this.components = new System.ComponentModel.Container();
            this.lblDTHD = new System.Windows.Forms.Label();
            this.timerDTHD = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblDTHD
            // 
            this.lblDTHD.AutoSize = true;
            this.lblDTHD.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDTHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDTHD.Location = new System.Drawing.Point(0, 0);
            this.lblDTHD.Name = "lblDTHD";
            this.lblDTHD.Size = new System.Drawing.Size(298, 29);
            this.lblDTHD.TabIndex = 8;
            this.lblDTHD.Text = "DateTime HomeDelivery";
            // 
            // timerDTHD
            // 
            this.timerDTHD.Tick += new System.EventHandler(this.timerDTHD_Tick);
            // 
            // HomeDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDTHD);
            this.Name = "HomeDelivery";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HomeDelivery";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDTHD;
        private System.Windows.Forms.Timer timerDTHD;
    }
}