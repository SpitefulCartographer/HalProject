namespace HalProject
{
    partial class OrderForm
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
            this.recipientTextbox = new System.Windows.Forms.TextBox();
            this.priceTextbox = new System.Windows.Forms.TextBox();
            this.printEtaTextbox = new System.Windows.Forms.TextBox();
            this.itemListbox = new System.Windows.Forms.ListBox();
            this.itemGroupBox = new System.Windows.Forms.GroupBox();
            this.clearButton = new System.Windows.Forms.Button();
            this.deleteItemButton = new System.Windows.Forms.Button();
            this.addItemButton = new System.Windows.Forms.Button();
            this.itemQuantityTextbox = new System.Windows.Forms.TextBox();
            this.itemQuantityLabel = new System.Windows.Forms.Label();
            this.itemUrlTextbox = new System.Windows.Forms.TextBox();
            this.itemUrlLabel = new System.Windows.Forms.Label();
            this.itemNameLabel = new System.Windows.Forms.Label();
            this.itemNameTextbox = new System.Windows.Forms.TextBox();
            this.confirmOrderButton = new System.Windows.Forms.Button();
            this.printerTextbox = new System.Windows.Forms.TextBox();
            this.printerLabel = new System.Windows.Forms.Label();
            this.printEtaLabel = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.recipientLabel = new System.Windows.Forms.Label();
            this.itemGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // recipientTextbox
            // 
            this.recipientTextbox.Location = new System.Drawing.Point(105, 10);
            this.recipientTextbox.Name = "recipientTextbox";
            this.recipientTextbox.Size = new System.Drawing.Size(140, 20);
            this.recipientTextbox.TabIndex = 1;
            this.recipientTextbox.WordWrap = false;
            // 
            // priceTextbox
            // 
            this.priceTextbox.Location = new System.Drawing.Point(105, 40);
            this.priceTextbox.Name = "priceTextbox";
            this.priceTextbox.Size = new System.Drawing.Size(40, 20);
            this.priceTextbox.TabIndex = 2;
            this.priceTextbox.WordWrap = false;
            // 
            // printEtaTextbox
            // 
            this.printEtaTextbox.Location = new System.Drawing.Point(105, 70);
            this.printEtaTextbox.Name = "printEtaTextbox";
            this.printEtaTextbox.Size = new System.Drawing.Size(40, 20);
            this.printEtaTextbox.TabIndex = 3;
            this.printEtaTextbox.WordWrap = false;
            // 
            // itemListbox
            // 
            this.itemListbox.DisplayMember = "Name";
            this.itemListbox.FormattingEnabled = true;
            this.itemListbox.Location = new System.Drawing.Point(220, 20);
            this.itemListbox.Name = "itemListbox";
            this.itemListbox.Size = new System.Drawing.Size(162, 108);
            this.itemListbox.TabIndex = 0;
            this.itemListbox.TabStop = false;
            this.itemListbox.ValueMember = "Name";
            this.itemListbox.SelectedIndexChanged += new System.EventHandler(this.ItemListbox_SelectedIndexChanged);
            // 
            // itemGroupBox
            // 
            this.itemGroupBox.Controls.Add(this.clearButton);
            this.itemGroupBox.Controls.Add(this.deleteItemButton);
            this.itemGroupBox.Controls.Add(this.addItemButton);
            this.itemGroupBox.Controls.Add(this.itemQuantityTextbox);
            this.itemGroupBox.Controls.Add(this.itemQuantityLabel);
            this.itemGroupBox.Controls.Add(this.itemUrlTextbox);
            this.itemGroupBox.Controls.Add(this.itemUrlLabel);
            this.itemGroupBox.Controls.Add(this.itemNameLabel);
            this.itemGroupBox.Controls.Add(this.itemNameTextbox);
            this.itemGroupBox.Controls.Add(this.itemListbox);
            this.itemGroupBox.Location = new System.Drawing.Point(12, 127);
            this.itemGroupBox.Name = "itemGroupBox";
            this.itemGroupBox.Size = new System.Drawing.Size(392, 142);
            this.itemGroupBox.TabIndex = 0;
            this.itemGroupBox.TabStop = false;
            this.itemGroupBox.Text = "Order Contents";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(148, 106);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(53, 23);
            this.clearButton.TabIndex = 6;
            this.clearButton.Text = "Clear All";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.ClearButton_Click);
            // 
            // deleteItemButton
            // 
            this.deleteItemButton.Location = new System.Drawing.Point(73, 106);
            this.deleteItemButton.Name = "deleteItemButton";
            this.deleteItemButton.Size = new System.Drawing.Size(69, 23);
            this.deleteItemButton.TabIndex = 5;
            this.deleteItemButton.Text = "Delete Item";
            this.deleteItemButton.UseVisualStyleBackColor = true;
            this.deleteItemButton.Click += new System.EventHandler(this.DeleteItemButton_Click);
            // 
            // addItemButton
            // 
            this.addItemButton.Location = new System.Drawing.Point(6, 106);
            this.addItemButton.Name = "addItemButton";
            this.addItemButton.Size = new System.Drawing.Size(61, 23);
            this.addItemButton.TabIndex = 4;
            this.addItemButton.Text = "Add Item";
            this.addItemButton.UseVisualStyleBackColor = true;
            this.addItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // itemQuantityTextbox
            // 
            this.itemQuantityTextbox.Location = new System.Drawing.Point(70, 80);
            this.itemQuantityTextbox.Name = "itemQuantityTextbox";
            this.itemQuantityTextbox.Size = new System.Drawing.Size(30, 20);
            this.itemQuantityTextbox.TabIndex = 3;
            this.itemQuantityTextbox.WordWrap = false;
            // 
            // itemQuantityLabel
            // 
            this.itemQuantityLabel.AutoSize = true;
            this.itemQuantityLabel.Location = new System.Drawing.Point(18, 83);
            this.itemQuantityLabel.Name = "itemQuantityLabel";
            this.itemQuantityLabel.Size = new System.Drawing.Size(49, 13);
            this.itemQuantityLabel.TabIndex = 10;
            this.itemQuantityLabel.Text = "Quantity:";
            // 
            // itemUrlTextbox
            // 
            this.itemUrlTextbox.Location = new System.Drawing.Point(70, 50);
            this.itemUrlTextbox.Name = "itemUrlTextbox";
            this.itemUrlTextbox.Size = new System.Drawing.Size(143, 20);
            this.itemUrlTextbox.TabIndex = 2;
            this.itemUrlTextbox.WordWrap = false;
            // 
            // itemUrlLabel
            // 
            this.itemUrlLabel.AutoSize = true;
            this.itemUrlLabel.Location = new System.Drawing.Point(12, 53);
            this.itemUrlLabel.Name = "itemUrlLabel";
            this.itemUrlLabel.Size = new System.Drawing.Size(55, 13);
            this.itemUrlLabel.TabIndex = 8;
            this.itemUrlLabel.Text = "Item URL:";
            // 
            // itemNameLabel
            // 
            this.itemNameLabel.AutoSize = true;
            this.itemNameLabel.Location = new System.Drawing.Point(6, 23);
            this.itemNameLabel.Name = "itemNameLabel";
            this.itemNameLabel.Size = new System.Drawing.Size(61, 13);
            this.itemNameLabel.TabIndex = 7;
            this.itemNameLabel.Text = "Item Name:";
            // 
            // itemNameTextbox
            // 
            this.itemNameTextbox.Location = new System.Drawing.Point(70, 20);
            this.itemNameTextbox.Name = "itemNameTextbox";
            this.itemNameTextbox.Size = new System.Drawing.Size(143, 20);
            this.itemNameTextbox.TabIndex = 1;
            this.itemNameTextbox.WordWrap = false;
            // 
            // confirmOrderButton
            // 
            this.confirmOrderButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmOrderButton.Location = new System.Drawing.Point(145, 275);
            this.confirmOrderButton.Name = "confirmOrderButton";
            this.confirmOrderButton.Size = new System.Drawing.Size(100, 40);
            this.confirmOrderButton.TabIndex = 0;
            this.confirmOrderButton.Text = "Confirm Order";
            this.confirmOrderButton.UseVisualStyleBackColor = true;
            this.confirmOrderButton.Click += new System.EventHandler(this.ConfirmOrderButton_Click);
            // 
            // printerTextbox
            // 
            this.printerTextbox.Location = new System.Drawing.Point(105, 100);
            this.printerTextbox.Name = "printerTextbox";
            this.printerTextbox.Size = new System.Drawing.Size(100, 20);
            this.printerTextbox.TabIndex = 4;
            this.printerTextbox.WordWrap = false;
            // 
            // printerLabel
            // 
            this.printerLabel.AutoSize = true;
            this.printerLabel.Location = new System.Drawing.Point(62, 103);
            this.printerLabel.Name = "printerLabel";
            this.printerLabel.Size = new System.Drawing.Size(40, 13);
            this.printerLabel.TabIndex = 10;
            this.printerLabel.Text = "Printer:";
            // 
            // printEtaLabel
            // 
            this.printEtaLabel.AutoSize = true;
            this.printEtaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printEtaLabel.Location = new System.Drawing.Point(15, 73);
            this.printEtaLabel.Name = "printEtaLabel";
            this.printEtaLabel.Size = new System.Drawing.Size(87, 13);
            this.printEtaLabel.TabIndex = 0;
            this.printEtaLabel.Text = "Print Time (mins):";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.priceLabel.Location = new System.Drawing.Point(41, 44);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(61, 13);
            this.priceLabel.TabIndex = 2;
            this.priceLabel.Text = "Total Price:";
            // 
            // recipientLabel
            // 
            this.recipientLabel.AutoSize = true;
            this.recipientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipientLabel.Location = new System.Drawing.Point(16, 13);
            this.recipientLabel.Name = "recipientLabel";
            this.recipientLabel.Size = new System.Drawing.Size(86, 13);
            this.recipientLabel.TabIndex = 0;
            this.recipientLabel.Text = "Recipient Name:";
            // 
            // OrderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(416, 324);
            this.Controls.Add(this.printerTextbox);
            this.Controls.Add(this.printerLabel);
            this.Controls.Add(this.confirmOrderButton);
            this.Controls.Add(this.itemGroupBox);
            this.Controls.Add(this.printEtaTextbox);
            this.Controls.Add(this.printEtaLabel);
            this.Controls.Add(this.priceTextbox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.recipientTextbox);
            this.Controls.Add(this.recipientLabel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "OrderForm";
            this.Text = "New Order Form";
            this.itemGroupBox.ResumeLayout(false);
            this.itemGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox recipientTextbox;
        private System.Windows.Forms.TextBox priceTextbox;
        private System.Windows.Forms.TextBox printEtaTextbox;
        private System.Windows.Forms.ListBox itemListbox;
        private System.Windows.Forms.GroupBox itemGroupBox;
        private System.Windows.Forms.TextBox itemNameTextbox;
        private System.Windows.Forms.TextBox itemQuantityTextbox;
        private System.Windows.Forms.TextBox itemUrlTextbox;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.Button deleteItemButton;
        private System.Windows.Forms.Button confirmOrderButton;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.TextBox printerTextbox;
        private System.Windows.Forms.Label printerLabel;
        private System.Windows.Forms.Label printEtaLabel;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Label recipientLabel;
        private System.Windows.Forms.Label itemQuantityLabel;
        private System.Windows.Forms.Label itemUrlLabel;
        private System.Windows.Forms.Label itemNameLabel;
    }
}