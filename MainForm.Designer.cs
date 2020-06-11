namespace HalProject
{
    partial class MainForm
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
            this.availableOrdersGroupbox = new System.Windows.Forms.GroupBox();
            this.orderListbox = new System.Windows.Forms.ListBox();
            this.deleteOrderButton = new System.Windows.Forms.Button();
            this.addOrderButton = new System.Windows.Forms.Button();
            this.recipientLabel = new System.Windows.Forms.Label();
            this.printLabel = new System.Windows.Forms.Label();
            this.printEtaLabel = new System.Windows.Forms.Label();
            this.printerLabel = new System.Windows.Forms.Label();
            this.recipientDisplay = new System.Windows.Forms.Label();
            this.priceDisplay = new System.Windows.Forms.Label();
            this.printEtaDisplay = new System.Windows.Forms.Label();
            this.printerDisplay = new System.Windows.Forms.Label();
            this.activeOrderGroupbox = new System.Windows.Forms.GroupBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.itemUrlDisplay = new System.Windows.Forms.TextBox();
            this.itemQuantityDisplay = new System.Windows.Forms.Label();
            this.itemNameDisplay = new System.Windows.Forms.Label();
            this.itemQuantityLabel = new System.Windows.Forms.Label();
            this.itemUrlLabel = new System.Windows.Forms.Label();
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.itemListbox = new System.Windows.Forms.ListBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.availableOrdersGroupbox.SuspendLayout();
            this.activeOrderGroupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // availableOrdersGroupbox
            // 
            this.availableOrdersGroupbox.Controls.Add(this.orderListbox);
            this.availableOrdersGroupbox.Controls.Add(this.deleteOrderButton);
            this.availableOrdersGroupbox.Controls.Add(this.addOrderButton);
            this.availableOrdersGroupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.availableOrdersGroupbox.Location = new System.Drawing.Point(12, 12);
            this.availableOrdersGroupbox.Name = "availableOrdersGroupbox";
            this.availableOrdersGroupbox.Size = new System.Drawing.Size(162, 300);
            this.availableOrdersGroupbox.TabIndex = 1;
            this.availableOrdersGroupbox.TabStop = false;
            this.availableOrdersGroupbox.Text = "Available Orders";
            // 
            // orderListbox
            // 
            this.orderListbox.DisplayMember = "OrderNumber";
            this.orderListbox.FormattingEnabled = true;
            this.orderListbox.Location = new System.Drawing.Point(7, 20);
            this.orderListbox.Name = "orderListbox";
            this.orderListbox.Size = new System.Drawing.Size(149, 199);
            this.orderListbox.TabIndex = 3;
            this.orderListbox.ValueMember = "OrderNumber";
            this.orderListbox.SelectedIndexChanged += new System.EventHandler(this.orderListbox_SelectedIndexChanged);
            this.orderListbox.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.orderListbox_Format);
            // 
            // deleteOrderButton
            // 
            this.deleteOrderButton.Location = new System.Drawing.Point(79, 224);
            this.deleteOrderButton.Name = "deleteOrderButton";
            this.deleteOrderButton.Size = new System.Drawing.Size(77, 23);
            this.deleteOrderButton.TabIndex = 2;
            this.deleteOrderButton.Text = "Delete Order";
            this.deleteOrderButton.UseVisualStyleBackColor = true;
            this.deleteOrderButton.Click += new System.EventHandler(this.deleteOrderButton_Click);
            // 
            // addOrderButton
            // 
            this.addOrderButton.Location = new System.Drawing.Point(6, 224);
            this.addOrderButton.Name = "addOrderButton";
            this.addOrderButton.Size = new System.Drawing.Size(70, 23);
            this.addOrderButton.TabIndex = 1;
            this.addOrderButton.Text = "Add Order";
            this.addOrderButton.UseVisualStyleBackColor = true;
            this.addOrderButton.Click += new System.EventHandler(this.AddOrderButton_Click);
            // 
            // recipientLabel
            // 
            this.recipientLabel.AutoSize = true;
            this.recipientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipientLabel.Location = new System.Drawing.Point(4, 23);
            this.recipientLabel.Name = "recipientLabel";
            this.recipientLabel.Size = new System.Drawing.Size(86, 13);
            this.recipientLabel.TabIndex = 0;
            this.recipientLabel.Text = "Recipient Name:";
            // 
            // printLabel
            // 
            this.printLabel.AutoSize = true;
            this.printLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printLabel.Location = new System.Drawing.Point(28, 52);
            this.printLabel.Name = "printLabel";
            this.printLabel.Size = new System.Drawing.Size(61, 13);
            this.printLabel.TabIndex = 2;
            this.printLabel.Text = "Total Price:";
            // 
            // printEtaLabel
            // 
            this.printEtaLabel.AutoSize = true;
            this.printEtaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printEtaLabel.Location = new System.Drawing.Point(2, 81);
            this.printEtaLabel.Name = "printEtaLabel";
            this.printEtaLabel.Size = new System.Drawing.Size(87, 13);
            this.printEtaLabel.TabIndex = 0;
            this.printEtaLabel.Text = "Print Time (mins):";
            // 
            // printerLabel
            // 
            this.printerLabel.AutoSize = true;
            this.printerLabel.Location = new System.Drawing.Point(49, 111);
            this.printerLabel.Name = "printerLabel";
            this.printerLabel.Size = new System.Drawing.Size(40, 13);
            this.printerLabel.TabIndex = 10;
            this.printerLabel.Text = "Printer:";
            // 
            // recipientDisplay
            // 
            this.recipientDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.recipientDisplay.Location = new System.Drawing.Point(94, 20);
            this.recipientDisplay.Name = "recipientDisplay";
            this.recipientDisplay.Size = new System.Drawing.Size(100, 20);
            this.recipientDisplay.TabIndex = 11;
            // 
            // priceDisplay
            // 
            this.priceDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.priceDisplay.Location = new System.Drawing.Point(94, 49);
            this.priceDisplay.Name = "priceDisplay";
            this.priceDisplay.Size = new System.Drawing.Size(40, 20);
            this.priceDisplay.TabIndex = 12;
            // 
            // printEtaDisplay
            // 
            this.printEtaDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.printEtaDisplay.Location = new System.Drawing.Point(94, 78);
            this.printEtaDisplay.Name = "printEtaDisplay";
            this.printEtaDisplay.Size = new System.Drawing.Size(40, 20);
            this.printEtaDisplay.TabIndex = 13;
            // 
            // printerDisplay
            // 
            this.printerDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.printerDisplay.Location = new System.Drawing.Point(94, 108);
            this.printerDisplay.Name = "printerDisplay";
            this.printerDisplay.Size = new System.Drawing.Size(70, 20);
            this.printerDisplay.TabIndex = 14;
            // 
            // activeOrderGroupbox
            // 
            this.activeOrderGroupbox.Controls.Add(this.statusComboBox);
            this.activeOrderGroupbox.Controls.Add(this.itemUrlDisplay);
            this.activeOrderGroupbox.Controls.Add(this.itemQuantityDisplay);
            this.activeOrderGroupbox.Controls.Add(this.itemNameDisplay);
            this.activeOrderGroupbox.Controls.Add(this.itemQuantityLabel);
            this.activeOrderGroupbox.Controls.Add(this.itemUrlLabel);
            this.activeOrderGroupbox.Controls.Add(this.itemNameLabel);
            this.activeOrderGroupbox.Controls.Add(this.itemListbox);
            this.activeOrderGroupbox.Controls.Add(this.statusLabel);
            this.activeOrderGroupbox.Controls.Add(this.recipientDisplay);
            this.activeOrderGroupbox.Controls.Add(this.printEtaLabel);
            this.activeOrderGroupbox.Controls.Add(this.printerDisplay);
            this.activeOrderGroupbox.Controls.Add(this.printLabel);
            this.activeOrderGroupbox.Controls.Add(this.printEtaDisplay);
            this.activeOrderGroupbox.Controls.Add(this.recipientLabel);
            this.activeOrderGroupbox.Controls.Add(this.priceDisplay);
            this.activeOrderGroupbox.Controls.Add(this.printerLabel);
            this.activeOrderGroupbox.Location = new System.Drawing.Point(191, 12);
            this.activeOrderGroupbox.Name = "activeOrderGroupbox";
            this.activeOrderGroupbox.Size = new System.Drawing.Size(385, 300);
            this.activeOrderGroupbox.TabIndex = 16;
            this.activeOrderGroupbox.TabStop = false;
            this.activeOrderGroupbox.Text = "Active Order Information";
            // 
            // statusComboBox
            // 
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Items.AddRange(new object[] {
            "Disabled",
            "Pending",
            "Active",
            "Ready",
            "Complete"});
            this.statusComboBox.Location = new System.Drawing.Point(286, 18);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(91, 21);
            this.statusComboBox.TabIndex = 26;
            this.statusComboBox.SelectedIndexChanged += new System.EventHandler(this.statusComboBox_SelectedIndexChanged);
            // 
            // itemUrlDisplay
            // 
            this.itemUrlDisplay.Location = new System.Drawing.Point(237, 181);
            this.itemUrlDisplay.Name = "itemUrlDisplay";
            this.itemUrlDisplay.ReadOnly = true;
            this.itemUrlDisplay.Size = new System.Drawing.Size(140, 20);
            this.itemUrlDisplay.TabIndex = 25;
            // 
            // itemQuantityDisplay
            // 
            this.itemQuantityDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.itemQuantityDisplay.Location = new System.Drawing.Point(237, 213);
            this.itemQuantityDisplay.Name = "itemQuantityDisplay";
            this.itemQuantityDisplay.Size = new System.Drawing.Size(35, 20);
            this.itemQuantityDisplay.TabIndex = 24;
            // 
            // itemNameDisplay
            // 
            this.itemNameDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.itemNameDisplay.Location = new System.Drawing.Point(237, 153);
            this.itemNameDisplay.Name = "itemNameDisplay";
            this.itemNameDisplay.Size = new System.Drawing.Size(140, 20);
            this.itemNameDisplay.TabIndex = 22;
            // 
            // itemQuantityLabel
            // 
            this.itemQuantityLabel.AutoSize = true;
            this.itemQuantityLabel.Location = new System.Drawing.Point(182, 214);
            this.itemQuantityLabel.Name = "itemQuantityLabel";
            this.itemQuantityLabel.Size = new System.Drawing.Size(49, 13);
            this.itemQuantityLabel.TabIndex = 21;
            this.itemQuantityLabel.Text = "Quantity:";
            // 
            // itemUrlLabel
            // 
            this.itemUrlLabel.AutoSize = true;
            this.itemUrlLabel.Location = new System.Drawing.Point(176, 184);
            this.itemUrlLabel.Name = "itemUrlLabel";
            this.itemUrlLabel.Size = new System.Drawing.Size(55, 13);
            this.itemUrlLabel.TabIndex = 20;
            this.itemUrlLabel.Text = "Item URL:";
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.AutoSize = true;
            this.itemNameLabel.Location = new System.Drawing.Point(170, 154);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(61, 13);
            this.itemNameLabel.TabIndex = 19;
            this.itemNameLabel.Text = "Item Name:";
            // 
            // itemListbox
            // 
            this.itemListbox.DisplayMember = "Name";
            this.itemListbox.FormattingEnabled = true;
            this.itemListbox.Location = new System.Drawing.Point(6, 139);
            this.itemListbox.Name = "itemListbox";
            this.itemListbox.Size = new System.Drawing.Size(159, 108);
            this.itemListbox.TabIndex = 18;
            this.itemListbox.TabStop = false;
            this.itemListbox.ValueMember = "Name";
            this.itemListbox.SelectedIndexChanged += new System.EventHandler(this.itemListbox_SelectedIndexChanged);
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(211, 23);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(69, 13);
            this.statusLabel.TabIndex = 16;
            this.statusLabel.Text = "Order Status:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 361);
            this.Controls.Add(this.activeOrderGroupbox);
            this.Controls.Add(this.availableOrdersGroupbox);
            this.Name = "MainForm";
            this.Text = "Hal Project";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.availableOrdersGroupbox.ResumeLayout(false);
            this.activeOrderGroupbox.ResumeLayout(false);
            this.activeOrderGroupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox availableOrdersGroupbox;
        private System.Windows.Forms.Button addOrderButton;
        private System.Windows.Forms.Button deleteOrderButton;
        private System.Windows.Forms.ListBox orderListbox;
        private System.Windows.Forms.Label recipientLabel;
        private System.Windows.Forms.Label printLabel;
        private System.Windows.Forms.Label printEtaLabel;
        private System.Windows.Forms.Label printerLabel;
        private System.Windows.Forms.Label recipientDisplay;
        private System.Windows.Forms.Label priceDisplay;
        private System.Windows.Forms.Label printEtaDisplay;
        private System.Windows.Forms.Label printerDisplay;
        private System.Windows.Forms.GroupBox activeOrderGroupbox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.ListBox itemListbox;
        private System.Windows.Forms.Label itemQuantityDisplay;
        private System.Windows.Forms.Label itemNameDisplay;
        private System.Windows.Forms.Label itemQuantityLabel;
        private System.Windows.Forms.Label itemUrlLabel;
        private System.Windows.Forms.Label itemNameLabel;
        private System.Windows.Forms.TextBox itemUrlDisplay;
        private System.Windows.Forms.ComboBox statusComboBox;
    }
}

