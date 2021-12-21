namespace RestaurantApp.Home_Forms
{
    partial class HungryMe
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
            this.lblDTHM = new System.Windows.Forms.Label();
            this.timerHM = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblDTHM
            // 
            this.lblDTHM.AutoSize = true;
            this.lblDTHM.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDTHM.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDTHM.Location = new System.Drawing.Point(0, 0);
            this.lblDTHM.Name = "lblDTHM";
            this.lblDTHM.Size = new System.Drawing.Size(252, 29);
            this.lblDTHM.TabIndex = 9;
            this.lblDTHM.Text = "DateTime HungryMe";
            // 
            // timerHM
            // 
            this.timerHM.Tick += new System.EventHandler(this.timerHM_Tick);
            // 
            // HungryMe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDTHM);
            this.Name = "HungryMe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "HungryMe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDTHM;
        private System.Windows.Forms.Timer timerHM;
    }
}