namespace WalshChristianAssgn4CoffeeCuppaOrders
{
    partial class CoffeeCuppaOrdersForm
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
            this.addToOrderButton = new System.Windows.Forms.Button();
            this.contactNumberMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.mgmtTotalButton = new System.Windows.Forms.Button();
            this.orderTotalButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.newOrderButton = new System.Windows.Forms.Button();
            this.discountCheckBox = new System.Windows.Forms.CheckBox();
            this.item5CheckBox = new System.Windows.Forms.CheckBox();
            this.item4CheckBox = new System.Windows.Forms.CheckBox();
            this.item3CheckBox = new System.Windows.Forms.CheckBox();
            this.reportLabel = new System.Windows.Forms.Label();
            this.item1CheckBox = new System.Windows.Forms.CheckBox();
            this.additionalItemGroupBox = new System.Windows.Forms.GroupBox();
            this.item2CheckBox = new System.Windows.Forms.CheckBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip5 = new System.Windows.Forms.ToolTip(this.components);
            this.quantityLabel = new System.Windows.Forms.Label();
            this.materialTypeGroupBox = new System.Windows.Forms.GroupBox();
            this.pressMaterialLabel = new System.Windows.Forms.Label();
            this.material4RadioButton = new System.Windows.Forms.RadioButton();
            this.material3RadioButton = new System.Windows.Forms.RadioButton();
            this.material2RadioButton = new System.Windows.Forms.RadioButton();
            this.material1RadioButton = new System.Windows.Forms.RadioButton();
            this.infoLabel = new System.Windows.Forms.Label();
            this.contactNameTextBox = new System.Windows.Forms.TextBox();
            this.restaurantAddressTextBox = new System.Windows.Forms.TextBox();
            this.restaurantNameTextBox = new System.Windows.Forms.TextBox();
            this.customerInfoLabel = new System.Windows.Forms.Label();
            this.headerLabel = new System.Windows.Forms.Label();
            this.sizeGroupBox = new System.Windows.Forms.GroupBox();
            this.testButton = new System.Windows.Forms.Button();
            this.size3RadioButton = new System.Windows.Forms.RadioButton();
            this.size2RadioButton = new System.Windows.Forms.RadioButton();
            this.size1RadioButton = new System.Windows.Forms.RadioButton();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.toolTip4 = new System.Windows.Forms.ToolTip(this.components);
            this.additionalItemGroupBox.SuspendLayout();
            this.materialTypeGroupBox.SuspendLayout();
            this.sizeGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // addToOrderButton
            // 
            this.addToOrderButton.ForeColor = System.Drawing.Color.Black;
            this.addToOrderButton.Location = new System.Drawing.Point(203, 67);
            this.addToOrderButton.Name = "addToOrderButton";
            this.addToOrderButton.Size = new System.Drawing.Size(75, 23);
            this.addToOrderButton.TabIndex = 4;
            this.addToOrderButton.Text = "&Add to Order";
            this.toolTip1.SetToolTip(this.addToOrderButton, "Adds Input to Orders");
            this.addToOrderButton.UseVisualStyleBackColor = true;
            this.addToOrderButton.Click += new System.EventHandler(this.addToOrderButton_Click);
            // 
            // contactNumberMaskedTextBox
            // 
            this.contactNumberMaskedTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.contactNumberMaskedTextBox.Location = new System.Drawing.Point(171, 188);
            this.contactNumberMaskedTextBox.Mask = "(999) 000-0000";
            this.contactNumberMaskedTextBox.Name = "contactNumberMaskedTextBox";
            this.contactNumberMaskedTextBox.Size = new System.Drawing.Size(100, 20);
            this.contactNumberMaskedTextBox.TabIndex = 23;
            // 
            // mgmtTotalButton
            // 
            this.mgmtTotalButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.mgmtTotalButton.Location = new System.Drawing.Point(277, 136);
            this.mgmtTotalButton.Name = "mgmtTotalButton";
            this.mgmtTotalButton.Size = new System.Drawing.Size(75, 23);
            this.mgmtTotalButton.TabIndex = 19;
            this.mgmtTotalButton.Text = "&Mgmt. Total";
            this.toolTip1.SetToolTip(this.mgmtTotalButton, "Shows Management Totals");
            this.mgmtTotalButton.UseVisualStyleBackColor = true;
            this.mgmtTotalButton.Click += new System.EventHandler(this.mgmtTotalButton_Click);
            // 
            // orderTotalButton
            // 
            this.orderTotalButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.orderTotalButton.Location = new System.Drawing.Point(277, 110);
            this.orderTotalButton.Name = "orderTotalButton";
            this.orderTotalButton.Size = new System.Drawing.Size(75, 23);
            this.orderTotalButton.TabIndex = 16;
            this.orderTotalButton.Text = "&End of Order";
            this.toolTip1.SetToolTip(this.orderTotalButton, "Sums All Current Orders");
            this.orderTotalButton.UseVisualStyleBackColor = true;
            this.orderTotalButton.Click += new System.EventHandler(this.orderTotalButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exitButton.Location = new System.Drawing.Point(277, 186);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 25;
            this.exitButton.Text = "E&xit";
            this.toolTip1.SetToolTip(this.exitButton, "Closes Program");
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // newOrderButton
            // 
            this.newOrderButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.newOrderButton.Location = new System.Drawing.Point(277, 161);
            this.newOrderButton.Name = "newOrderButton";
            this.newOrderButton.Size = new System.Drawing.Size(75, 23);
            this.newOrderButton.TabIndex = 21;
            this.newOrderButton.Text = "&New Order";
            this.toolTip1.SetToolTip(this.newOrderButton, "Resets Order for New Customer");
            this.newOrderButton.UseVisualStyleBackColor = true;
            this.newOrderButton.Click += new System.EventHandler(this.newOrderButton_Click);
            // 
            // discountCheckBox
            // 
            this.discountCheckBox.AutoSize = true;
            this.discountCheckBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.discountCheckBox.Location = new System.Drawing.Point(195, 84);
            this.discountCheckBox.Name = "discountCheckBox";
            this.discountCheckBox.Size = new System.Drawing.Size(163, 17);
            this.discountCheckBox.TabIndex = 29;
            this.discountCheckBox.Text = "Frequent Customer Discount ";
            this.discountCheckBox.UseVisualStyleBackColor = true;
            // 
            // item5CheckBox
            // 
            this.item5CheckBox.AutoSize = true;
            this.item5CheckBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.item5CheckBox.Location = new System.Drawing.Point(6, 113);
            this.item5CheckBox.Name = "item5CheckBox";
            this.item5CheckBox.Size = new System.Drawing.Size(160, 17);
            this.item5CheckBox.TabIndex = 4;
            this.item5CheckBox.Text = "Cup Sleeves - $20.00/1,000";
            this.item5CheckBox.UseVisualStyleBackColor = true;
            // 
            // item4CheckBox
            // 
            this.item4CheckBox.AutoSize = true;
            this.item4CheckBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.item4CheckBox.Location = new System.Drawing.Point(6, 90);
            this.item4CheckBox.Name = "item4CheckBox";
            this.item4CheckBox.Size = new System.Drawing.Size(170, 17);
            this.item4CheckBox.TabIndex = 3;
            this.item4CheckBox.Text = "Sugar Packets - $25.00/1,000";
            this.item4CheckBox.UseVisualStyleBackColor = true;
            // 
            // item3CheckBox
            // 
            this.item3CheckBox.AutoSize = true;
            this.item3CheckBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.item3CheckBox.Location = new System.Drawing.Point(6, 67);
            this.item3CheckBox.Name = "item3CheckBox";
            this.item3CheckBox.Size = new System.Drawing.Size(147, 17);
            this.item3CheckBox.TabIndex = 2;
            this.item3CheckBox.Text = "Stir Sticks - $12.00/1,000";
            this.item3CheckBox.UseVisualStyleBackColor = true;
            // 
            // reportLabel
            // 
            this.reportLabel.AutoSize = true;
            this.reportLabel.BackColor = System.Drawing.Color.White;
            this.reportLabel.Font = new System.Drawing.Font("Lucida Console", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.reportLabel.Location = new System.Drawing.Point(364, 84);
            this.reportLabel.Name = "reportLabel";
            this.reportLabel.Size = new System.Drawing.Size(82, 11);
            this.reportLabel.TabIndex = 28;
            this.reportLabel.Text = "reportLabel";
            // 
            // item1CheckBox
            // 
            this.item1CheckBox.AutoSize = true;
            this.item1CheckBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.item1CheckBox.Location = new System.Drawing.Point(6, 21);
            this.item1CheckBox.Name = "item1CheckBox";
            this.item1CheckBox.Size = new System.Drawing.Size(135, 17);
            this.item1CheckBox.TabIndex = 0;
            this.item1CheckBox.Text = "Coasters - $8.25/2,000";
            this.item1CheckBox.UseVisualStyleBackColor = true;
            // 
            // additionalItemGroupBox
            // 
            this.additionalItemGroupBox.Controls.Add(this.item5CheckBox);
            this.additionalItemGroupBox.Controls.Add(this.item4CheckBox);
            this.additionalItemGroupBox.Controls.Add(this.item3CheckBox);
            this.additionalItemGroupBox.Controls.Add(this.item2CheckBox);
            this.additionalItemGroupBox.Controls.Add(this.item1CheckBox);
            this.additionalItemGroupBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.additionalItemGroupBox.Location = new System.Drawing.Point(175, 221);
            this.additionalItemGroupBox.Name = "additionalItemGroupBox";
            this.additionalItemGroupBox.Size = new System.Drawing.Size(177, 135);
            this.additionalItemGroupBox.TabIndex = 27;
            this.additionalItemGroupBox.TabStop = false;
            this.additionalItemGroupBox.Text = "Additional Items";
            // 
            // item2CheckBox
            // 
            this.item2CheckBox.AutoSize = true;
            this.item2CheckBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.item2CheckBox.Location = new System.Drawing.Point(6, 44);
            this.item2CheckBox.Name = "item2CheckBox";
            this.item2CheckBox.Size = new System.Drawing.Size(139, 17);
            this.item2CheckBox.TabIndex = 1;
            this.item2CheckBox.Text = "Napkins - $10.00/1,000";
            this.item2CheckBox.UseVisualStyleBackColor = true;
            // 
            // quantityLabel
            // 
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Location = new System.Drawing.Point(200, 21);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(89, 13);
            this.quantityLabel.TabIndex = 15;
            this.quantityLabel.Text = "Enter # of Boxes:\r\n";
            // 
            // materialTypeGroupBox
            // 
            this.materialTypeGroupBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.materialTypeGroupBox.Controls.Add(this.pressMaterialLabel);
            this.materialTypeGroupBox.Controls.Add(this.material4RadioButton);
            this.materialTypeGroupBox.Controls.Add(this.material3RadioButton);
            this.materialTypeGroupBox.Controls.Add(this.material2RadioButton);
            this.materialTypeGroupBox.Controls.Add(this.material1RadioButton);
            this.materialTypeGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialTypeGroupBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.materialTypeGroupBox.Location = new System.Drawing.Point(20, 221);
            this.materialTypeGroupBox.Name = "materialTypeGroupBox";
            this.materialTypeGroupBox.Size = new System.Drawing.Size(151, 135);
            this.materialTypeGroupBox.TabIndex = 24;
            this.materialTypeGroupBox.TabStop = false;
            this.materialTypeGroupBox.Text = "Press Material ";
            // 
            // pressMaterialLabel
            // 
            this.pressMaterialLabel.AutoSize = true;
            this.pressMaterialLabel.Location = new System.Drawing.Point(23, 21);
            this.pressMaterialLabel.Name = "pressMaterialLabel";
            this.pressMaterialLabel.Size = new System.Drawing.Size(113, 13);
            this.pressMaterialLabel.TabIndex = 4;
            this.pressMaterialLabel.Text = "Type and Upcharge %";
            // 
            // material4RadioButton
            // 
            this.material4RadioButton.AutoSize = true;
            this.material4RadioButton.Location = new System.Drawing.Point(6, 112);
            this.material4RadioButton.Name = "material4RadioButton";
            this.material4RadioButton.Size = new System.Drawing.Size(69, 17);
            this.material4RadioButton.TabIndex = 3;
            this.material4RadioButton.TabStop = true;
            this.material4RadioButton.Text = "Porcelain";
            this.material4RadioButton.UseVisualStyleBackColor = true;
            this.material4RadioButton.CheckedChanged += new System.EventHandler(this.materialTypesRadioButton_CheckedChanged);
            // 
            // material3RadioButton
            // 
            this.material3RadioButton.AutoSize = true;
            this.material3RadioButton.Location = new System.Drawing.Point(6, 88);
            this.material3RadioButton.Name = "material3RadioButton";
            this.material3RadioButton.Size = new System.Drawing.Size(63, 17);
            this.material3RadioButton.TabIndex = 2;
            this.material3RadioButton.TabStop = true;
            this.material3RadioButton.Text = "Ceramic";
            this.material3RadioButton.UseVisualStyleBackColor = true;
            this.material3RadioButton.CheckedChanged += new System.EventHandler(this.materialTypesRadioButton_CheckedChanged);
            // 
            // material2RadioButton
            // 
            this.material2RadioButton.AutoSize = true;
            this.material2RadioButton.Location = new System.Drawing.Point(6, 65);
            this.material2RadioButton.Name = "material2RadioButton";
            this.material2RadioButton.Size = new System.Drawing.Size(51, 17);
            this.material2RadioButton.TabIndex = 1;
            this.material2RadioButton.TabStop = true;
            this.material2RadioButton.Text = "Glass";
            this.material2RadioButton.UseVisualStyleBackColor = true;
            this.material2RadioButton.CheckedChanged += new System.EventHandler(this.materialTypesRadioButton_CheckedChanged);
            // 
            // material1RadioButton
            // 
            this.material1RadioButton.AutoSize = true;
            this.material1RadioButton.Location = new System.Drawing.Point(6, 40);
            this.material1RadioButton.Name = "material1RadioButton";
            this.material1RadioButton.Size = new System.Drawing.Size(51, 17);
            this.material1RadioButton.TabIndex = 0;
            this.material1RadioButton.TabStop = true;
            this.material1RadioButton.Text = "Metal";
            this.material1RadioButton.UseVisualStyleBackColor = true;
            this.material1RadioButton.CheckedChanged += new System.EventHandler(this.materialTypesRadioButton_CheckedChanged);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.infoLabel.Location = new System.Drawing.Point(33, 115);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(122, 91);
            this.infoLabel.TabIndex = 22;
            this.infoLabel.Text = "Restaurant Name:\r\n\r\nRestaurant Address:\r\n\r\nContact Name:\r\n\r\nContact Number:";
            // 
            // contactNameTextBox
            // 
            this.contactNameTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.contactNameTextBox.Location = new System.Drawing.Point(171, 161);
            this.contactNameTextBox.Name = "contactNameTextBox";
            this.contactNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.contactNameTextBox.TabIndex = 20;
            // 
            // restaurantAddressTextBox
            // 
            this.restaurantAddressTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.restaurantAddressTextBox.Location = new System.Drawing.Point(171, 135);
            this.restaurantAddressTextBox.Name = "restaurantAddressTextBox";
            this.restaurantAddressTextBox.Size = new System.Drawing.Size(100, 20);
            this.restaurantAddressTextBox.TabIndex = 18;
            // 
            // restaurantNameTextBox
            // 
            this.restaurantNameTextBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.restaurantNameTextBox.Location = new System.Drawing.Point(171, 109);
            this.restaurantNameTextBox.Name = "restaurantNameTextBox";
            this.restaurantNameTextBox.Size = new System.Drawing.Size(100, 20);
            this.restaurantNameTextBox.TabIndex = 15;
            // 
            // customerInfoLabel
            // 
            this.customerInfoLabel.AutoSize = true;
            this.customerInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerInfoLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.customerInfoLabel.Location = new System.Drawing.Point(43, 85);
            this.customerInfoLabel.Name = "customerInfoLabel";
            this.customerInfoLabel.Size = new System.Drawing.Size(146, 13);
            this.customerInfoLabel.TabIndex = 17;
            this.customerInfoLabel.Text = "Enter Information Below:";
            // 
            // headerLabel
            // 
            this.headerLabel.AutoSize = true;
            this.headerLabel.Font = new System.Drawing.Font("Engravers MT", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.headerLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.headerLabel.Location = new System.Drawing.Point(164, 11);
            this.headerLabel.Name = "headerLabel";
            this.headerLabel.Size = new System.Drawing.Size(688, 37);
            this.headerLabel.TabIndex = 14;
            this.headerLabel.Text = "Coffee Cuppa Press Orders";
            // 
            // sizeGroupBox
            // 
            this.sizeGroupBox.Controls.Add(this.testButton);
            this.sizeGroupBox.Controls.Add(this.addToOrderButton);
            this.sizeGroupBox.Controls.Add(this.quantityLabel);
            this.sizeGroupBox.Controls.Add(this.size3RadioButton);
            this.sizeGroupBox.Controls.Add(this.size2RadioButton);
            this.sizeGroupBox.Controls.Add(this.size1RadioButton);
            this.sizeGroupBox.Controls.Add(this.quantityTextBox);
            this.sizeGroupBox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.sizeGroupBox.Location = new System.Drawing.Point(20, 362);
            this.sizeGroupBox.Name = "sizeGroupBox";
            this.sizeGroupBox.Size = new System.Drawing.Size(331, 105);
            this.sizeGroupBox.TabIndex = 26;
            this.sizeGroupBox.TabStop = false;
            this.sizeGroupBox.Text = "Press Size (4/Box)";
            // 
            // testButton
            // 
            this.testButton.Location = new System.Drawing.Point(106, 67);
            this.testButton.Name = "testButton";
            this.testButton.Size = new System.Drawing.Size(75, 23);
            this.testButton.TabIndex = 16;
            this.testButton.Text = "Test";
            this.testButton.UseVisualStyleBackColor = true;
            this.testButton.Click += new System.EventHandler(this.testButton_Click);
            // 
            // size3RadioButton
            // 
            this.size3RadioButton.AutoSize = true;
            this.size3RadioButton.Location = new System.Drawing.Point(6, 67);
            this.size3RadioButton.Name = "size3RadioButton";
            this.size3RadioButton.Size = new System.Drawing.Size(85, 17);
            this.size3RadioButton.TabIndex = 2;
            this.size3RadioButton.TabStop = true;
            this.size3RadioButton.Text = "8 Cup Press ";
            this.size3RadioButton.UseVisualStyleBackColor = true;
            this.size3RadioButton.CheckedChanged += new System.EventHandler(this.pressSizesRadioButton_CheckedChanged);
            // 
            // size2RadioButton
            // 
            this.size2RadioButton.AutoSize = true;
            this.size2RadioButton.Location = new System.Drawing.Point(6, 44);
            this.size2RadioButton.Name = "size2RadioButton";
            this.size2RadioButton.Size = new System.Drawing.Size(85, 17);
            this.size2RadioButton.TabIndex = 1;
            this.size2RadioButton.TabStop = true;
            this.size2RadioButton.Text = "4 Cup Press ";
            this.size2RadioButton.UseVisualStyleBackColor = true;
            this.size2RadioButton.CheckedChanged += new System.EventHandler(this.pressSizesRadioButton_CheckedChanged);
            // 
            // size1RadioButton
            // 
            this.size1RadioButton.AutoSize = true;
            this.size1RadioButton.Location = new System.Drawing.Point(6, 21);
            this.size1RadioButton.Name = "size1RadioButton";
            this.size1RadioButton.Size = new System.Drawing.Size(85, 17);
            this.size1RadioButton.TabIndex = 0;
            this.size1RadioButton.TabStop = true;
            this.size1RadioButton.Text = "2 Cup Press ";
            this.size1RadioButton.UseVisualStyleBackColor = true;
            this.size1RadioButton.CheckedChanged += new System.EventHandler(this.pressSizesRadioButton_CheckedChanged);
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(197, 41);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(90, 20);
            this.quantityTextBox.TabIndex = 3;
            // 
            // CoffeeCuppaOrdersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 479);
            this.Controls.Add(this.contactNumberMaskedTextBox);
            this.Controls.Add(this.mgmtTotalButton);
            this.Controls.Add(this.orderTotalButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.newOrderButton);
            this.Controls.Add(this.discountCheckBox);
            this.Controls.Add(this.reportLabel);
            this.Controls.Add(this.additionalItemGroupBox);
            this.Controls.Add(this.materialTypeGroupBox);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.contactNameTextBox);
            this.Controls.Add(this.restaurantAddressTextBox);
            this.Controls.Add(this.restaurantNameTextBox);
            this.Controls.Add(this.customerInfoLabel);
            this.Controls.Add(this.headerLabel);
            this.Controls.Add(this.sizeGroupBox);
            this.Name = "CoffeeCuppaOrdersForm";
            this.Text = "Coffee Cuppa Orders";
            this.Load += new System.EventHandler(this.CoffeeCuppaOrdersForm_Load);
            this.additionalItemGroupBox.ResumeLayout(false);
            this.additionalItemGroupBox.PerformLayout();
            this.materialTypeGroupBox.ResumeLayout(false);
            this.materialTypeGroupBox.PerformLayout();
            this.sizeGroupBox.ResumeLayout(false);
            this.sizeGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button addToOrderButton;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.MaskedTextBox contactNumberMaskedTextBox;
        private System.Windows.Forms.Button mgmtTotalButton;
        private System.Windows.Forms.Button orderTotalButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button newOrderButton;
        private System.Windows.Forms.CheckBox discountCheckBox;
        private System.Windows.Forms.CheckBox item5CheckBox;
        private System.Windows.Forms.CheckBox item4CheckBox;
        private System.Windows.Forms.CheckBox item3CheckBox;
        private System.Windows.Forms.Label reportLabel;
        private System.Windows.Forms.GroupBox additionalItemGroupBox;
        private System.Windows.Forms.CheckBox item2CheckBox;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.ToolTip toolTip5;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.RadioButton material4RadioButton;
        private System.Windows.Forms.RadioButton material3RadioButton;
        private System.Windows.Forms.RadioButton material2RadioButton;
        private System.Windows.Forms.RadioButton material1RadioButton;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.TextBox contactNameTextBox;
        private System.Windows.Forms.TextBox restaurantAddressTextBox;
        private System.Windows.Forms.TextBox restaurantNameTextBox;
        private System.Windows.Forms.Label customerInfoLabel;
        private System.Windows.Forms.Label headerLabel;
        private System.Windows.Forms.RadioButton size3RadioButton;
        private System.Windows.Forms.RadioButton size2RadioButton;
        private System.Windows.Forms.RadioButton size1RadioButton;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.ToolTip toolTip4;
        private System.Windows.Forms.Label pressMaterialLabel;
        private System.Windows.Forms.Button testButton;
        public System.Windows.Forms.GroupBox materialTypeGroupBox;
        public System.Windows.Forms.GroupBox sizeGroupBox;
        public System.Windows.Forms.CheckBox item1CheckBox;
    }
}

