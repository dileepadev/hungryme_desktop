namespace RestaurantApp.Home_Forms
{
    partial class MealToTable
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
            this.lblDTMTT = new System.Windows.Forms.Label();
            this.timerDTMTT = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblDTMTT
            // 
            this.lblDTMTT.AutoSize = true;
            this.lblDTMTT.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDTMTT.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDTMTT.Location = new System.Drawing.Point(0, 0);
            this.lblDTMTT.Name = "lblDTMTT";
            this.lblDTMTT.Size = new System.Drawing.Size(291, 29);
            this.lblDTMTT.TabIndex = 7;
            this.lblDTMTT.Text = "DateTime MealToTable";
            // 
            // timerDTMTT
            // 
            this.timerDTMTT.Tick += new System.EventHandler(this.timerDTMTT_Tick);
            // 
            // MealToTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDTMTT);
            this.Name = "MealToTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MealToTable";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDTMTT;
        private System.Windows.Forms.Timer timerDTMTT;
    }
}