namespace RestaurantApp.TableToMeal_Forms
{
    partial class Appetizers
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.appatizersSoup1 = new RestaurantApp.TableToMeal_Forms.AppatizersSoup();
            this.appatizersSalads1 = new RestaurantApp.TableToMeal_Forms.AppatizersSalads();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(527, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Appatizers";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(363, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(256, 59);
            this.button1.TabIndex = 2;
            this.button1.Text = "Soups";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(643, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(256, 59);
            this.button2.TabIndex = 3;
            this.button2.Text = "Salads";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.appatizersSoup1);
            this.panel1.Controls.Add(this.appatizersSalads1);
            this.panel1.Location = new System.Drawing.Point(23, 176);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1227, 541);
            this.panel1.TabIndex = 4;
            // 
            // appatizersSoup1
            // 
            this.appatizersSoup1.Location = new System.Drawing.Point(301, 8);
            this.appatizersSoup1.Name = "appatizersSoup1";
            this.appatizersSoup1.Size = new System.Drawing.Size(505, 530);
            this.appatizersSoup1.TabIndex = 1;
            // 
            // appatizersSalads1
            // 
            this.appatizersSalads1.Location = new System.Drawing.Point(301, 8);
            this.appatizersSalads1.Name = "appatizersSalads1";
            this.appatizersSalads1.Size = new System.Drawing.Size(505, 530);
            this.appatizersSalads1.TabIndex = 0;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(1046, 43);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(180, 99);
            this.button3.TabIndex = 5;
            this.button3.Text = "My Cart";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Appetizers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1296, 747);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "Appetizers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Appetizers";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private AppatizersSoup appatizersSoup1;
        private AppatizersSalads appatizersSalads1;
        private System.Windows.Forms.Button button3;
    }
}