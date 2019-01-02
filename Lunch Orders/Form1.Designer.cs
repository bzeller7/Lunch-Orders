namespace Lunch_Orders
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioSalad = new System.Windows.Forms.RadioButton();
            this.radioPizza = new System.Windows.Forms.RadioButton();
            this.radioHamburger = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CheckFrenchFries = new System.Windows.Forms.CheckBox();
            this.CheckKetchupMusterdMayo = new System.Windows.Forms.CheckBox();
            this.CheckLettuceTomatoOnion = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtOrderTotal = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtSubtotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioSalad);
            this.groupBox1.Controls.Add(this.radioPizza);
            this.groupBox1.Controls.Add(this.radioHamburger);
            this.groupBox1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.groupBox1.Location = new System.Drawing.Point(24, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Main Course";
            // 
            // radioSalad
            // 
            this.radioSalad.AutoSize = true;
            this.radioSalad.Location = new System.Drawing.Point(22, 68);
            this.radioSalad.Name = "radioSalad";
            this.radioSalad.Size = new System.Drawing.Size(88, 17);
            this.radioSalad.TabIndex = 2;
            this.radioSalad.TabStop = true;
            this.radioSalad.Text = "Salad - $4.95";
            this.radioSalad.UseVisualStyleBackColor = true;
            // 
            // radioPizza
            // 
            this.radioPizza.AutoSize = true;
            this.radioPizza.Location = new System.Drawing.Point(22, 44);
            this.radioPizza.Name = "radioPizza";
            this.radioPizza.Size = new System.Drawing.Size(86, 17);
            this.radioPizza.TabIndex = 1;
            this.radioPizza.TabStop = true;
            this.radioPizza.Text = "Pizza - $5.95";
            this.radioPizza.UseVisualStyleBackColor = true;
            // 
            // radioHamburger
            // 
            this.radioHamburger.AutoSize = true;
            this.radioHamburger.Location = new System.Drawing.Point(22, 21);
            this.radioHamburger.Name = "radioHamburger";
            this.radioHamburger.Size = new System.Drawing.Size(113, 17);
            this.radioHamburger.TabIndex = 0;
            this.radioHamburger.TabStop = true;
            this.radioHamburger.Text = "Hamburger - $6.95";
            this.radioHamburger.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.CheckFrenchFries);
            this.groupBox2.Controls.Add(this.CheckKetchupMusterdMayo);
            this.groupBox2.Controls.Add(this.CheckLettuceTomatoOnion);
            this.groupBox2.Location = new System.Drawing.Point(277, 32);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 100);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add-on Items ($.75/each)";
            // 
            // CheckFrenchFires
            // 
            this.CheckFrenchFries.AutoSize = true;
            this.CheckFrenchFries.Location = new System.Drawing.Point(20, 68);
            this.CheckFrenchFries.Name = "CheckFrenchFires";
            this.CheckFrenchFries.Size = new System.Drawing.Size(84, 17);
            this.CheckFrenchFries.TabIndex = 2;
            this.CheckFrenchFries.Text = "French Fries";
            this.CheckFrenchFries.UseVisualStyleBackColor = true;
            this.CheckFrenchFries.CheckedChanged += new System.EventHandler(this.CheckFrenchFires_CheckedChanged);
            // 
            // CheckKetchupMusterdMayo
            // 
            this.CheckKetchupMusterdMayo.AutoSize = true;
            this.CheckKetchupMusterdMayo.Location = new System.Drawing.Point(20, 44);
            this.CheckKetchupMusterdMayo.Name = "CheckKetchupMusterdMayo";
            this.CheckKetchupMusterdMayo.Size = new System.Drawing.Size(163, 17);
            this.CheckKetchupMusterdMayo.TabIndex = 1;
            this.CheckKetchupMusterdMayo.Text = "Ketchup, Mustard, and Mayo";
            this.CheckKetchupMusterdMayo.UseVisualStyleBackColor = true;
            this.CheckKetchupMusterdMayo.CheckedChanged += new System.EventHandler(this.CheckKetchupMusterdMayo_CheckedChanged);
            // 
            // CheckLettuceTomatoOnion
            // 
            this.CheckLettuceTomatoOnion.AutoSize = true;
            this.CheckLettuceTomatoOnion.Location = new System.Drawing.Point(20, 21);
            this.CheckLettuceTomatoOnion.Name = "CheckLettuceTomatoOnion";
            this.CheckLettuceTomatoOnion.Size = new System.Drawing.Size(159, 17);
            this.CheckLettuceTomatoOnion.TabIndex = 0;
            this.CheckLettuceTomatoOnion.Text = "Lettuce, Tomato, and Onion";
            this.CheckLettuceTomatoOnion.UseVisualStyleBackColor = true;
            this.CheckLettuceTomatoOnion.CheckedChanged += new System.EventHandler(this.CheckLettuceTomatoOnionCheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtOrderTotal);
            this.groupBox3.Controls.Add(this.txtTax);
            this.groupBox3.Controls.Add(this.txtSubtotal);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(24, 176);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(304, 155);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Order Total";
            // 
            // txtOrderTotal
            // 
            this.txtOrderTotal.Enabled = false;
            this.txtOrderTotal.Location = new System.Drawing.Point(123, 105);
            this.txtOrderTotal.Name = "txtOrderTotal";
            this.txtOrderTotal.Size = new System.Drawing.Size(100, 20);
            this.txtOrderTotal.TabIndex = 5;
            // 
            // txtTax
            // 
            this.txtTax.Enabled = false;
            this.txtTax.Location = new System.Drawing.Point(123, 68);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(100, 20);
            this.txtTax.TabIndex = 4;
            // 
            // txtSubtotal
            // 
            this.txtSubtotal.Enabled = false;
            this.txtSubtotal.Location = new System.Drawing.Point(123, 30);
            this.txtSubtotal.Name = "txtSubtotal";
            this.txtSubtotal.Size = new System.Drawing.Size(100, 20);
            this.txtSubtotal.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Order Total:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tax (7.75%):";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subtotal:";
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.Location = new System.Drawing.Point(380, 176);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(97, 50);
            this.btnPlaceOrder.TabIndex = 3;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = true;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(380, 281);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(97, 50);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 422);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Lunch Order";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox CheckFrenchFries;
        private System.Windows.Forms.CheckBox CheckKetchupMusterdMayo;
        private System.Windows.Forms.CheckBox CheckLettuceTomatoOnion;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.RadioButton radioSalad;
        private System.Windows.Forms.RadioButton radioPizza;
        private System.Windows.Forms.RadioButton radioHamburger;
        private System.Windows.Forms.TextBox txtOrderTotal;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.TextBox txtSubtotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

