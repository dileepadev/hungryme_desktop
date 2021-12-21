namespace RestaurantApp
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
            this.btnWelcomeToHungryMe = new System.Windows.Forms.Button();
            this.btnMealToTable = new System.Windows.Forms.Button();
            this.btnTakeAway = new System.Windows.Forms.Button();
            this.btnMyAccount = new System.Windows.Forms.Button();
            this.btnMyCart = new System.Windows.Forms.Button();
            this.btnHomeDelivery = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnWelcomeToHungryMe
            // 
            this.btnWelcomeToHungryMe.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWelcomeToHungryMe.Location = new System.Drawing.Point(375, 379);
            this.btnWelcomeToHungryMe.Name = "btnWelcomeToHungryMe";
            this.btnWelcomeToHungryMe.Size = new System.Drawing.Size(352, 195);
            this.btnWelcomeToHungryMe.TabIndex = 0;
            this.btnWelcomeToHungryMe.Text = "Welcome to HungryMe";
            this.btnWelcomeToHungryMe.UseVisualStyleBackColor = true;
            // 
            // btnMealToTable
            // 
            this.btnMealToTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMealToTable.Location = new System.Drawing.Point(423, 86);
            this.btnMealToTable.Name = "btnMealToTable";
            this.btnMealToTable.Size = new System.Drawing.Size(259, 129);
            this.btnMealToTable.TabIndex = 1;
            this.btnMealToTable.Text = "Meal To Table";
            this.btnMealToTable.UseVisualStyleBackColor = true;
            // 
            // btnTakeAway
            // 
            this.btnTakeAway.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTakeAway.Location = new System.Drawing.Point(798, 230);
            this.btnTakeAway.Name = "btnTakeAway";
            this.btnTakeAway.Size = new System.Drawing.Size(259, 129);
            this.btnTakeAway.TabIndex = 2;
            this.btnTakeAway.Text = "Take Away";
            this.btnTakeAway.UseVisualStyleBackColor = true;
            // 
            // btnMyAccount
            // 
            this.btnMyAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyAccount.Location = new System.Drawing.Point(798, 586);
            this.btnMyAccount.Name = "btnMyAccount";
            this.btnMyAccount.Size = new System.Drawing.Size(259, 129);
            this.btnMyAccount.TabIndex = 3;
            this.btnMyAccount.Text = "My Account";
            this.btnMyAccount.UseVisualStyleBackColor = true;
            // 
            // btnMyCart
            // 
            this.btnMyCart.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyCart.Location = new System.Drawing.Point(40, 586);
            this.btnMyCart.Name = "btnMyCart";
            this.btnMyCart.Size = new System.Drawing.Size(259, 129);
            this.btnMyCart.TabIndex = 4;
            this.btnMyCart.Text = "My Cart";
            this.btnMyCart.UseVisualStyleBackColor = true;
            // 
            // btnHomeDelivery
            // 
            this.btnHomeDelivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHomeDelivery.Location = new System.Drawing.Point(40, 230);
            this.btnHomeDelivery.Name = "btnHomeDelivery";
            this.btnHomeDelivery.Size = new System.Drawing.Size(259, 129);
            this.btnHomeDelivery.TabIndex = 5;
            this.btnHomeDelivery.Text = "Home Delivery";
            this.btnHomeDelivery.UseVisualStyleBackColor = true;
            // 
            // HungryMe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1123, 752);
            this.Controls.Add(this.btnHomeDelivery);
            this.Controls.Add(this.btnMyCart);
            this.Controls.Add(this.btnMyAccount);
            this.Controls.Add(this.btnTakeAway);
            this.Controls.Add(this.btnMealToTable);
            this.Controls.Add(this.btnWelcomeToHungryMe);
            this.Name = "HungryMe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HungryMe";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnWelcomeToHungryMe;
        private System.Windows.Forms.Button btnMealToTable;
        private System.Windows.Forms.Button btnTakeAway;
        private System.Windows.Forms.Button btnMyAccount;
        private System.Windows.Forms.Button btnMyCart;
        private System.Windows.Forms.Button btnHomeDelivery;
    }
}

