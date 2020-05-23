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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.recipientDisplay = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.itemsGridView = new System.Windows.Forms.DataGridView();
            this.activeOrderGroupbox = new System.Windows.Forms.GroupBox();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemUrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemQuantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.orderListbox.Format += new System.Windows.Forms.ListControlConvertEventHandler(this.OrderListbox_Format);
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recipient Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Total Price:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Print Time (mins):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Printer:";
            // 
            // recipientDisplay
            // 
            this.recipientDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.recipientDisplay.Location = new System.Drawing.Point(94, 20);
            this.recipientDisplay.Name = "recipientDisplay";
            this.recipientDisplay.Size = new System.Drawing.Size(100, 20);
            this.recipientDisplay.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label5.Location = new System.Drawing.Point(94, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 20);
            this.label5.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label6.Location = new System.Drawing.Point(94, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 13;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label7.Location = new System.Drawing.Point(94, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 20);
            this.label7.TabIndex = 14;
            // 
            // itemsGridView
            // 
            this.itemsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.itemsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemName,
            this.ItemUrl,
            this.ItemQuantity});
            this.itemsGridView.Location = new System.Drawing.Point(8, 137);
            this.itemsGridView.Name = "itemsGridView";
            this.itemsGridView.Size = new System.Drawing.Size(352, 100);
            this.itemsGridView.TabIndex = 15;
            // 
            // activeOrderGroupbox
            // 
            this.activeOrderGroupbox.Controls.Add(this.recipientDisplay);
            this.activeOrderGroupbox.Controls.Add(this.itemsGridView);
            this.activeOrderGroupbox.Controls.Add(this.label3);
            this.activeOrderGroupbox.Controls.Add(this.label7);
            this.activeOrderGroupbox.Controls.Add(this.label2);
            this.activeOrderGroupbox.Controls.Add(this.label6);
            this.activeOrderGroupbox.Controls.Add(this.label1);
            this.activeOrderGroupbox.Controls.Add(this.label5);
            this.activeOrderGroupbox.Controls.Add(this.label4);
            this.activeOrderGroupbox.Location = new System.Drawing.Point(191, 12);
            this.activeOrderGroupbox.Name = "activeOrderGroupbox";
            this.activeOrderGroupbox.Size = new System.Drawing.Size(366, 300);
            this.activeOrderGroupbox.TabIndex = 16;
            this.activeOrderGroupbox.TabStop = false;
            this.activeOrderGroupbox.Text = "Active Order Information";
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label recipientDisplay;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView itemsGridView;
        private System.Windows.Forms.GroupBox activeOrderGroupbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemUrl;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemQuantity;
    }
}

