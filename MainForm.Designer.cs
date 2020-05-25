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
            this.itemsGridView = new System.Windows.Forms.DataGridView();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeOrderGroupbox = new System.Windows.Forms.GroupBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.statusDisplay = new System.Windows.Forms.Label();
            this.availableOrdersGroupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.itemsGridView)).BeginInit();
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
            // itemsGridView
            // 
            this.itemsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemName,
            this.ItemUrl,
            this.ItemQuantity});
            this.itemsGridView.Location = new System.Drawing.Point(7, 147);
            this.itemsGridView.Name = "itemsGridView";
            this.itemsGridView.Size = new System.Drawing.Size(345, 100);
            this.itemsGridView.TabIndex = 15;
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "Item Name";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            // 
            // ItemUrl
            // 
            this.ItemUrl.HeaderText = "Item URL";
            this.ItemUrl.Name = "ItemUrl";
            this.ItemUrl.ReadOnly = true;
            // 
            // ItemQuantity
            // 
            this.ItemQuantity.HeaderText = "Item Qty.";
            this.ItemQuantity.Name = "ItemQuantity";
            this.ItemQuantity.ReadOnly = true;
            // 
            // activeOrderGroupbox
            // 
            this.activeOrderGroupbox.Controls.Add(this.statusDisplay);
            this.activeOrderGroupbox.Controls.Add(this.statusLabel);
            this.activeOrderGroupbox.Controls.Add(this.recipientDisplay);
            this.activeOrderGroupbox.Controls.Add(this.itemsGridView);
            this.activeOrderGroupbox.Controls.Add(this.printEtaLabel);
            this.activeOrderGroupbox.Controls.Add(this.printerDisplay);
            this.activeOrderGroupbox.Controls.Add(this.printLabel);
            this.activeOrderGroupbox.Controls.Add(this.printEtaDisplay);
            this.activeOrderGroupbox.Controls.Add(this.recipientLabel);
            this.activeOrderGroupbox.Controls.Add(this.priceDisplay);
            this.activeOrderGroupbox.Controls.Add(this.printerLabel);
            this.activeOrderGroupbox.Location = new System.Drawing.Point(191, 12);
            this.activeOrderGroupbox.Name = "activeOrderGroupbox";
            this.activeOrderGroupbox.Size = new System.Drawing.Size(366, 300);
            this.activeOrderGroupbox.TabIndex = 16;
            this.activeOrderGroupbox.TabStop = false;
            this.activeOrderGroupbox.Text = "Active Order Information";
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
            // statusDisplay
            // 
            this.statusDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.statusDisplay.Location = new System.Drawing.Point(286, 20);
            this.statusDisplay.Name = "statusDisplay";
            this.statusDisplay.Size = new System.Drawing.Size(67, 20);
            this.statusDisplay.TabIndex = 17;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 361);
            this.Controls.Add(this.activeOrderGroupbox);
            this.Controls.Add(this.availableOrdersGroupbox);
            this.Name = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.availableOrdersGroupbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.itemsGridView)).EndInit();
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
        private System.Windows.Forms.DataGridView itemsGridView;
        private System.Windows.Forms.GroupBox activeOrderGroupbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemUrl;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemQuantity;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label statusDisplay;
    }
}

