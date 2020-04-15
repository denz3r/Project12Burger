namespace burgers
{
    partial class BurgerMenu
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
            this.Condiment = new System.Windows.Forms.GroupBox();
            this.onionRingBox = new System.Windows.Forms.CheckBox();
            this.mustardBox = new System.Windows.Forms.CheckBox();
            this.ketchupBox = new System.Windows.Forms.CheckBox();
            this.pickleBox = new System.Windows.Forms.CheckBox();
            this.baconBox = new System.Windows.Forms.CheckBox();
            this.cheeseBox = new System.Windows.Forms.CheckBox();
            this.BurgerSize = new System.Windows.Forms.GroupBox();
            this.largeBurger = new System.Windows.Forms.RadioButton();
            this.mediumBurger = new System.Windows.Forms.RadioButton();
            this.smallBurger = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.PriceLabel = new System.Windows.Forms.Label();
            this.Condiment.SuspendLayout();
            this.BurgerSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // Condiment
            // 
            this.Condiment.Controls.Add(this.onionRingBox);
            this.Condiment.Controls.Add(this.mustardBox);
            this.Condiment.Controls.Add(this.ketchupBox);
            this.Condiment.Controls.Add(this.pickleBox);
            this.Condiment.Controls.Add(this.baconBox);
            this.Condiment.Controls.Add(this.cheeseBox);
            this.Condiment.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Condiment.Location = new System.Drawing.Point(769, 100);
            this.Condiment.Name = "Condiment";
            this.Condiment.Size = new System.Drawing.Size(934, 546);
            this.Condiment.TabIndex = 0;
            this.Condiment.TabStop = false;
            this.Condiment.Text = "Condiments";
            this.Condiment.Enter += new System.EventHandler(this.Condiment_Enter);
            // 
            // onionRingBox
            // 
            this.onionRingBox.AutoSize = true;
            this.onionRingBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.onionRingBox.Location = new System.Drawing.Point(523, 353);
            this.onionRingBox.Name = "onionRingBox";
            this.onionRingBox.Size = new System.Drawing.Size(246, 33);
            this.onionRingBox.TabIndex = 5;
            this.onionRingBox.Text = "Onion Ring ($ 1.99)";
            this.onionRingBox.UseVisualStyleBackColor = true;
            this.onionRingBox.CheckedChanged += new System.EventHandler(this.onionRingBox_CheckedChanged);
            // 
            // mustardBox
            // 
            this.mustardBox.AutoSize = true;
            this.mustardBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.mustardBox.Location = new System.Drawing.Point(523, 218);
            this.mustardBox.Name = "mustardBox";
            this.mustardBox.Size = new System.Drawing.Size(205, 33);
            this.mustardBox.TabIndex = 4;
            this.mustardBox.Text = "Mustard ($0.50)";
            this.mustardBox.UseVisualStyleBackColor = true;
            this.mustardBox.CheckedChanged += new System.EventHandler(this.mustardBox_CheckedChanged);
            // 
            // ketchupBox
            // 
            this.ketchupBox.AutoSize = true;
            this.ketchupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ketchupBox.Location = new System.Drawing.Point(523, 79);
            this.ketchupBox.Name = "ketchupBox";
            this.ketchupBox.Size = new System.Drawing.Size(207, 33);
            this.ketchupBox.TabIndex = 3;
            this.ketchupBox.Text = "Ketchup ($0.50)";
            this.ketchupBox.UseVisualStyleBackColor = true;
            this.ketchupBox.CheckedChanged += new System.EventHandler(this.ketchupBox_CheckedChanged);
            // 
            // pickleBox
            // 
            this.pickleBox.AutoSize = true;
            this.pickleBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.pickleBox.Location = new System.Drawing.Point(129, 353);
            this.pickleBox.Name = "pickleBox";
            this.pickleBox.Size = new System.Drawing.Size(197, 33);
            this.pickleBox.TabIndex = 2;
            this.pickleBox.Text = "Pickles ($0.50)";
            this.pickleBox.UseVisualStyleBackColor = true;
            this.pickleBox.CheckedChanged += new System.EventHandler(this.pickleBox_CheckedChanged);
            // 
            // baconBox
            // 
            this.baconBox.AutoSize = true;
            this.baconBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.baconBox.Location = new System.Drawing.Point(129, 217);
            this.baconBox.Name = "baconBox";
            this.baconBox.Size = new System.Drawing.Size(187, 33);
            this.baconBox.TabIndex = 1;
            this.baconBox.Text = "Bacon ($2.33)";
            this.baconBox.UseVisualStyleBackColor = true;
            this.baconBox.CheckedChanged += new System.EventHandler(this.baconBox_CheckedChanged);
            // 
            // cheeseBox
            // 
            this.cheeseBox.AutoSize = true;
            this.cheeseBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.cheeseBox.Location = new System.Drawing.Point(129, 79);
            this.cheeseBox.Name = "cheeseBox";
            this.cheeseBox.Size = new System.Drawing.Size(203, 33);
            this.cheeseBox.TabIndex = 0;
            this.cheeseBox.Text = "Cheese ($1.50)";
            this.cheeseBox.UseVisualStyleBackColor = true;
            this.cheeseBox.CheckedChanged += new System.EventHandler(this.cheeseBox_CheckedChanged);
            // 
            // BurgerSize
            // 
            this.BurgerSize.Controls.Add(this.largeBurger);
            this.BurgerSize.Controls.Add(this.mediumBurger);
            this.BurgerSize.Controls.Add(this.smallBurger);
            this.BurgerSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BurgerSize.Location = new System.Drawing.Point(72, 100);
            this.BurgerSize.Name = "BurgerSize";
            this.BurgerSize.Size = new System.Drawing.Size(663, 546);
            this.BurgerSize.TabIndex = 1;
            this.BurgerSize.TabStop = false;
            this.BurgerSize.Text = "Burger Sizes";
            this.BurgerSize.Enter += new System.EventHandler(this.BurgerSize_Enter);
            // 
            // largeBurger
            // 
            this.largeBurger.AutoSize = true;
            this.largeBurger.Location = new System.Drawing.Point(72, 325);
            this.largeBurger.Name = "largeBurger";
            this.largeBurger.Size = new System.Drawing.Size(272, 33);
            this.largeBurger.TabIndex = 2;
            this.largeBurger.TabStop = true;
            this.largeBurger.Text = "Large Burger ($13.99)";
            this.largeBurger.UseVisualStyleBackColor = true;
            this.largeBurger.CheckedChanged += new System.EventHandler(this.LargeBurger_CheckedChanged);
            // 
            // mediumBurger
            // 
            this.mediumBurger.AutoSize = true;
            this.mediumBurger.Location = new System.Drawing.Point(72, 217);
            this.mediumBurger.Name = "mediumBurger";
            this.mediumBurger.Size = new System.Drawing.Size(297, 33);
            this.mediumBurger.TabIndex = 1;
            this.mediumBurger.TabStop = true;
            this.mediumBurger.Text = "Medium Burger ($11.99)";
            this.mediumBurger.UseVisualStyleBackColor = true;
            this.mediumBurger.CheckedChanged += new System.EventHandler(this.MediumBurger_CheckedChanged);
            // 
            // smallBurger
            // 
            this.smallBurger.AutoSize = true;
            this.smallBurger.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.smallBurger.Location = new System.Drawing.Point(72, 106);
            this.smallBurger.Name = "smallBurger";
            this.smallBurger.Size = new System.Drawing.Size(245, 33);
            this.smallBurger.TabIndex = 0;
            this.smallBurger.TabStop = true;
            this.smallBurger.Text = "Small Burger (9.99)";
            this.smallBurger.UseVisualStyleBackColor = true;
            this.smallBurger.CheckedChanged += new System.EventHandler(this.SmallBurger_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(762, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Burger Menu";
            // 
            // PriceLabel
            // 
            this.PriceLabel.AutoSize = true;
            this.PriceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.PriceLabel.Location = new System.Drawing.Point(1393, 696);
            this.PriceLabel.Name = "PriceLabel";
            this.PriceLabel.Size = new System.Drawing.Size(145, 29);
            this.PriceLabel.TabIndex = 3;
            this.PriceLabel.Text = "Price: $ 0.00";
            this.PriceLabel.Click += new System.EventHandler(this.PriceLabel_Click);
            // 
            // BurgerMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1765, 777);
            this.Controls.Add(this.PriceLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BurgerSize);
            this.Controls.Add(this.Condiment);
            this.Name = "BurgerMenu";
            this.Text = "Ed\'s  Burgers";
            this.Load += new System.EventHandler(this.BurgerMenu_Load);
            this.Condiment.ResumeLayout(false);
            this.Condiment.PerformLayout();
            this.BurgerSize.ResumeLayout(false);
            this.BurgerSize.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Condiment;
        private System.Windows.Forms.CheckBox onionRingBox;
        private System.Windows.Forms.CheckBox mustardBox;
        private System.Windows.Forms.CheckBox ketchupBox;
        private System.Windows.Forms.CheckBox pickleBox;
        private System.Windows.Forms.CheckBox baconBox;
        private System.Windows.Forms.CheckBox cheeseBox;
        private System.Windows.Forms.GroupBox BurgerSize;
        private System.Windows.Forms.RadioButton largeBurger;
        private System.Windows.Forms.RadioButton mediumBurger;
        private System.Windows.Forms.RadioButton smallBurger;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label PriceLabel;
    }
}

