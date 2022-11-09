namespace CS311_Project3_JWH
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblProject_Pizza = new System.Windows.Forms.Label();
            this.pictPizza = new System.Windows.Forms.PictureBox();
            this.cboSize = new System.Windows.Forms.ComboBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblCrust = new System.Windows.Forms.Label();
            this.rdoThin = new System.Windows.Forms.RadioButton();
            this.rdoThick = new System.Windows.Forms.RadioButton();
            this.rdoReg = new System.Windows.Forms.RadioButton();
            this.ckbPep = new System.Windows.Forms.CheckBox();
            this.lblToppings = new System.Windows.Forms.Label();
            this.ckbSausage = new System.Windows.Forms.CheckBox();
            this.ckbCbacon = new System.Windows.Forms.CheckBox();
            this.ckbSpicy_Saus = new System.Windows.Forms.CheckBox();
            this.ckbOnion = new System.Windows.Forms.CheckBox();
            this.ckbG_Pepper = new System.Windows.Forms.CheckBox();
            this.ckbB_Olives = new System.Windows.Forms.CheckBox();
            this.ckbG_Olives = new System.Windows.Forms.CheckBox();
            this.ckbB_Peppers = new System.Windows.Forms.CheckBox();
            this.ckbJalepeno = new System.Windows.Forms.CheckBox();
            this.ckbX_Cheese = new System.Windows.Forms.CheckBox();
            this.ckbMushroom = new System.Windows.Forms.CheckBox();
            this.rtfOrder_Sum = new System.Windows.Forms.RichTextBox();
            this.lblOrder_Sum = new System.Windows.Forms.Label();
            this.txtSub_Total = new System.Windows.Forms.TextBox();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lblSub_Total = new System.Windows.Forms.Label();
            this.lblTax = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictPizza)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProject_Pizza
            // 
            this.lblProject_Pizza.AutoSize = true;
            this.lblProject_Pizza.Font = new System.Drawing.Font("Harlow Solid Italic", 56F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.lblProject_Pizza.Location = new System.Drawing.Point(532, 46);
            this.lblProject_Pizza.Name = "lblProject_Pizza";
            this.lblProject_Pizza.Size = new System.Drawing.Size(687, 141);
            this.lblProject_Pizza.TabIndex = 0;
            this.lblProject_Pizza.Text = "Project Pizza";
            // 
            // pictPizza
            // 
            this.pictPizza.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictPizza.Image = global::CS311_Project3_JWH.Properties.Resources.ProjectPizza_image;
            this.pictPizza.Location = new System.Drawing.Point(58, 35);
            this.pictPizza.Name = "pictPizza";
            this.pictPizza.Size = new System.Drawing.Size(415, 263);
            this.pictPizza.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictPizza.TabIndex = 1;
            this.pictPizza.TabStop = false;
            // 
            // cboSize
            // 
            this.cboSize.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.cboSize.FormattingEnabled = true;
            this.cboSize.Items.AddRange(new object[] {
            "Small",
            "Medium",
            "Large",
            "X-Large",
            "Ginormous"});
            this.cboSize.Location = new System.Drawing.Point(136, 341);
            this.cboSize.Name = "cboSize";
            this.cboSize.Size = new System.Drawing.Size(199, 38);
            this.cboSize.TabIndex = 2;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSize.Location = new System.Drawing.Point(64, 342);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(66, 32);
            this.lblSize.TabIndex = 3;
            this.lblSize.Text = "Size:";
            // 
            // lblCrust
            // 
            this.lblCrust.AutoSize = true;
            this.lblCrust.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCrust.Location = new System.Drawing.Point(382, 341);
            this.lblCrust.Name = "lblCrust";
            this.lblCrust.Size = new System.Drawing.Size(142, 32);
            this.lblCrust.TabIndex = 4;
            this.lblCrust.Text = "Crust Type:";
            // 
            // rdoThin
            // 
            this.rdoThin.AutoSize = true;
            this.rdoThin.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdoThin.Location = new System.Drawing.Point(540, 341);
            this.rdoThin.Name = "rdoThin";
            this.rdoThin.Size = new System.Drawing.Size(83, 34);
            this.rdoThin.TabIndex = 5;
            this.rdoThin.TabStop = true;
            this.rdoThin.Text = "Thin";
            this.rdoThin.UseVisualStyleBackColor = true;
            // 
            // rdoThick
            // 
            this.rdoThick.AutoSize = true;
            this.rdoThick.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdoThick.Location = new System.Drawing.Point(639, 341);
            this.rdoThick.Name = "rdoThick";
            this.rdoThick.Size = new System.Drawing.Size(93, 34);
            this.rdoThick.TabIndex = 6;
            this.rdoThick.TabStop = true;
            this.rdoThick.Text = "Thick";
            this.rdoThick.UseVisualStyleBackColor = true;
            // 
            // rdoReg
            // 
            this.rdoReg.AutoSize = true;
            this.rdoReg.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rdoReg.Location = new System.Drawing.Point(747, 341);
            this.rdoReg.Name = "rdoReg";
            this.rdoReg.Size = new System.Drawing.Size(117, 34);
            this.rdoReg.TabIndex = 7;
            this.rdoReg.TabStop = true;
            this.rdoReg.Text = "Regular";
            this.rdoReg.UseVisualStyleBackColor = true;
            // 
            // ckbPep
            // 
            this.ckbPep.AutoSize = true;
            this.ckbPep.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbPep.Location = new System.Drawing.Point(217, 437);
            this.ckbPep.Name = "ckbPep";
            this.ckbPep.Size = new System.Drawing.Size(145, 34);
            this.ckbPep.TabIndex = 8;
            this.ckbPep.Text = "Pepperoni";
            this.ckbPep.UseVisualStyleBackColor = true;
            // 
            // lblToppings
            // 
            this.lblToppings.AutoSize = true;
            this.lblToppings.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblToppings.Location = new System.Drawing.Point(76, 409);
            this.lblToppings.Name = "lblToppings";
            this.lblToppings.Size = new System.Drawing.Size(126, 32);
            this.lblToppings.TabIndex = 9;
            this.lblToppings.Text = "Toppings:";
            // 
            // ckbSausage
            // 
            this.ckbSausage.AutoSize = true;
            this.ckbSausage.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbSausage.Location = new System.Drawing.Point(217, 479);
            this.ckbSausage.Name = "ckbSausage";
            this.ckbSausage.Size = new System.Drawing.Size(124, 34);
            this.ckbSausage.TabIndex = 10;
            this.ckbSausage.Text = "Sausage";
            this.ckbSausage.UseVisualStyleBackColor = true;
            // 
            // ckbCbacon
            // 
            this.ckbCbacon.AutoSize = true;
            this.ckbCbacon.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbCbacon.Location = new System.Drawing.Point(217, 521);
            this.ckbCbacon.Name = "ckbCbacon";
            this.ckbCbacon.Size = new System.Drawing.Size(204, 34);
            this.ckbCbacon.TabIndex = 11;
            this.ckbCbacon.Text = "Canadian Bacon";
            this.ckbCbacon.UseVisualStyleBackColor = true;
            // 
            // ckbSpicy_Saus
            // 
            this.ckbSpicy_Saus.AutoSize = true;
            this.ckbSpicy_Saus.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbSpicy_Saus.Location = new System.Drawing.Point(217, 561);
            this.ckbSpicy_Saus.Name = "ckbSpicy_Saus";
            this.ckbSpicy_Saus.Size = new System.Drawing.Size(256, 34);
            this.ckbSpicy_Saus.TabIndex = 12;
            this.ckbSpicy_Saus.Text = "Spicy Italian Sausage";
            this.ckbSpicy_Saus.UseVisualStyleBackColor = true;
            // 
            // ckbOnion
            // 
            this.ckbOnion.AutoSize = true;
            this.ckbOnion.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbOnion.Location = new System.Drawing.Point(522, 437);
            this.ckbOnion.Name = "ckbOnion";
            this.ckbOnion.Size = new System.Drawing.Size(101, 34);
            this.ckbOnion.TabIndex = 13;
            this.ckbOnion.Text = "Onion";
            this.ckbOnion.UseVisualStyleBackColor = true;
            // 
            // ckbG_Pepper
            // 
            this.ckbG_Pepper.AutoSize = true;
            this.ckbG_Pepper.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbG_Pepper.Location = new System.Drawing.Point(522, 479);
            this.ckbG_Pepper.Name = "ckbG_Pepper";
            this.ckbG_Pepper.Size = new System.Drawing.Size(191, 34);
            this.ckbG_Pepper.TabIndex = 14;
            this.ckbG_Pepper.Text = "Green Peppers";
            this.ckbG_Pepper.UseVisualStyleBackColor = true;
            // 
            // ckbB_Olives
            // 
            this.ckbB_Olives.AutoSize = true;
            this.ckbB_Olives.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbB_Olives.Location = new System.Drawing.Point(522, 521);
            this.ckbB_Olives.Name = "ckbB_Olives";
            this.ckbB_Olives.Size = new System.Drawing.Size(163, 34);
            this.ckbB_Olives.TabIndex = 15;
            this.ckbB_Olives.Text = "Black Olives";
            this.ckbB_Olives.UseVisualStyleBackColor = true;
            // 
            // ckbG_Olives
            // 
            this.ckbG_Olives.AutoSize = true;
            this.ckbG_Olives.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbG_Olives.Location = new System.Drawing.Point(522, 561);
            this.ckbG_Olives.Name = "ckbG_Olives";
            this.ckbG_Olives.Size = new System.Drawing.Size(170, 34);
            this.ckbG_Olives.TabIndex = 16;
            this.ckbG_Olives.Text = "Green Olives";
            this.ckbG_Olives.UseVisualStyleBackColor = true;
            // 
            // ckbB_Peppers
            // 
            this.ckbB_Peppers.AutoSize = true;
            this.ckbB_Peppers.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbB_Peppers.Location = new System.Drawing.Point(791, 437);
            this.ckbB_Peppers.Name = "ckbB_Peppers";
            this.ckbB_Peppers.Size = new System.Drawing.Size(205, 34);
            this.ckbB_Peppers.TabIndex = 17;
            this.ckbB_Peppers.Text = "Banana Peppers";
            this.ckbB_Peppers.UseVisualStyleBackColor = true;
            // 
            // ckbJalepeno
            // 
            this.ckbJalepeno.AutoSize = true;
            this.ckbJalepeno.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbJalepeno.Location = new System.Drawing.Point(791, 477);
            this.ckbJalepeno.Name = "ckbJalepeno";
            this.ckbJalepeno.Size = new System.Drawing.Size(131, 34);
            this.ckbJalepeno.TabIndex = 18;
            this.ckbJalepeno.Text = "Jalepeno";
            this.ckbJalepeno.UseVisualStyleBackColor = true;
            // 
            // ckbX_Cheese
            // 
            this.ckbX_Cheese.AutoSize = true;
            this.ckbX_Cheese.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbX_Cheese.Location = new System.Drawing.Point(791, 519);
            this.ckbX_Cheese.Name = "ckbX_Cheese";
            this.ckbX_Cheese.Size = new System.Drawing.Size(172, 34);
            this.ckbX_Cheese.TabIndex = 19;
            this.ckbX_Cheese.Text = "Extra Cheese";
            this.ckbX_Cheese.UseVisualStyleBackColor = true;
            // 
            // ckbMushroom
            // 
            this.ckbMushroom.AutoSize = true;
            this.ckbMushroom.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ckbMushroom.Location = new System.Drawing.Point(791, 561);
            this.ckbMushroom.Name = "ckbMushroom";
            this.ckbMushroom.Size = new System.Drawing.Size(151, 34);
            this.ckbMushroom.TabIndex = 20;
            this.ckbMushroom.Text = "Mushroom";
            this.ckbMushroom.UseVisualStyleBackColor = true;
            // 
            // rtfOrder_Sum
            // 
            this.rtfOrder_Sum.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rtfOrder_Sum.Location = new System.Drawing.Point(262, 612);
            this.rtfOrder_Sum.Name = "rtfOrder_Sum";
            this.rtfOrder_Sum.Size = new System.Drawing.Size(674, 251);
            this.rtfOrder_Sum.TabIndex = 21;
            this.rtfOrder_Sum.Text = "";
            // 
            // lblOrder_Sum
            // 
            this.lblOrder_Sum.AutoSize = true;
            this.lblOrder_Sum.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblOrder_Sum.Location = new System.Drawing.Point(53, 612);
            this.lblOrder_Sum.Name = "lblOrder_Sum";
            this.lblOrder_Sum.Size = new System.Drawing.Size(203, 32);
            this.lblOrder_Sum.TabIndex = 22;
            this.lblOrder_Sum.Text = "Order Summary:";
            // 
            // txtSub_Total
            // 
            this.txtSub_Total.Location = new System.Drawing.Point(1051, 615);
            this.txtSub_Total.Name = "txtSub_Total";
            this.txtSub_Total.Size = new System.Drawing.Size(186, 31);
            this.txtSub_Total.TabIndex = 23;
            // 
            // txtTax
            // 
            this.txtTax.Location = new System.Drawing.Point(1051, 665);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(186, 31);
            this.txtTax.TabIndex = 24;
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(1051, 715);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(186, 31);
            this.txtTotal.TabIndex = 25;
            // 
            // lblSub_Total
            // 
            this.lblSub_Total.AutoSize = true;
            this.lblSub_Total.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSub_Total.Location = new System.Drawing.Point(936, 614);
            this.lblSub_Total.Name = "lblSub_Total";
            this.lblSub_Total.Size = new System.Drawing.Size(109, 30);
            this.lblSub_Total.TabIndex = 26;
            this.lblSub_Total.Text = "SubTotal:";
            // 
            // lblTax
            // 
            this.lblTax.AutoSize = true;
            this.lblTax.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTax.Location = new System.Drawing.Point(991, 666);
            this.lblTax.Name = "lblTax";
            this.lblTax.Size = new System.Drawing.Size(54, 30);
            this.lblTax.TabIndex = 27;
            this.lblTax.Text = "Tax:";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTotal.Location = new System.Drawing.Point(975, 716);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(70, 30);
            this.lblTotal.TabIndex = 28;
            this.lblTotal.Text = "Total:";
            // 
            // btnCalculate
            // 
            this.btnCalculate.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCalculate.Location = new System.Drawing.Point(942, 763);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(295, 100);
            this.btnCalculate.TabIndex = 29;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 912);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.lblTax);
            this.Controls.Add(this.lblSub_Total);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.txtSub_Total);
            this.Controls.Add(this.lblOrder_Sum);
            this.Controls.Add(this.rtfOrder_Sum);
            this.Controls.Add(this.ckbMushroom);
            this.Controls.Add(this.ckbX_Cheese);
            this.Controls.Add(this.ckbJalepeno);
            this.Controls.Add(this.ckbB_Peppers);
            this.Controls.Add(this.ckbG_Olives);
            this.Controls.Add(this.ckbB_Olives);
            this.Controls.Add(this.ckbG_Pepper);
            this.Controls.Add(this.ckbOnion);
            this.Controls.Add(this.ckbSpicy_Saus);
            this.Controls.Add(this.ckbCbacon);
            this.Controls.Add(this.ckbSausage);
            this.Controls.Add(this.lblToppings);
            this.Controls.Add(this.ckbPep);
            this.Controls.Add(this.rdoReg);
            this.Controls.Add(this.rdoThick);
            this.Controls.Add(this.rdoThin);
            this.Controls.Add(this.lblCrust);
            this.Controls.Add(this.lblSize);
            this.Controls.Add(this.cboSize);
            this.Controls.Add(this.pictPizza);
            this.Controls.Add(this.lblProject_Pizza);
            this.Name = "Form1";
            this.Text = "Project Pizza";
            ((System.ComponentModel.ISupportInitialize)(this.pictPizza)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblProject_Pizza;
        private PictureBox pictPizza;
        private ComboBox cboSize;
        private Label lblSize;
        private Label lblCrust;
        private RadioButton rdoThin;
        private RadioButton rdoThick;
        private RadioButton rdoReg;
        private CheckBox ckbPep;
        private Label lblToppings;
        private CheckBox ckbSausage;
        private CheckBox ckbCbacon;
        private CheckBox ckbSpicy_Saus;
        private CheckBox ckbOnion;
        private CheckBox ckbG_Pepper;
        private CheckBox ckbB_Olives;
        private CheckBox ckbG_Olives;
        private CheckBox ckbB_Peppers;
        private CheckBox ckbJalepeno;
        private CheckBox ckbX_Cheese;
        private CheckBox ckbMushroom;
        private RichTextBox rtfOrder_Sum;
        private Label lblOrder_Sum;
        private TextBox txtSub_Total;
        private TextBox txtTax;
        private TextBox txtTotal;
        private Label lblSub_Total;
        private Label lblTax;
        private Label lblTotal;
        private Button btnCalculate;
    }
}