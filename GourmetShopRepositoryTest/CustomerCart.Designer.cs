namespace GourmetShopRepositoryTest
{
    partial class CustomerCart
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
            CartGridView = new DataGridView();
            btnPurchase = new Button();
            btnBackToProducts = new Button();
            lblDataViewAmount = new Label();
            label4 = new Label();
            lblTotalAmountDue = new Label();
            lblAmount = new Label();
            btnRemoveItem = new Button();
            lblNumItemsInCart = new Label();
            ((System.ComponentModel.ISupportInitialize)CartGridView).BeginInit();
            SuspendLayout();
            // 
            // CartGridView
            // 
            CartGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CartGridView.Location = new Point(654, 129);
            CartGridView.Margin = new Padding(4, 5, 4, 5);
            CartGridView.Name = "CartGridView";
            CartGridView.RowHeadersWidth = 51;
            CartGridView.Size = new Size(448, 571);
            CartGridView.TabIndex = 0;
            // 
            // btnPurchase
            // 
            btnPurchase.Location = new Point(392, 596);
            btnPurchase.Margin = new Padding(4, 5, 4, 5);
            btnPurchase.Name = "btnPurchase";
            btnPurchase.Size = new Size(118, 79);
            btnPurchase.TabIndex = 1;
            btnPurchase.Text = "Purchase Cart";
            btnPurchase.UseVisualStyleBackColor = true;
            btnPurchase.Click += Purchasebtn_Click;
            // 
            // btnBackToProducts
            // 
            btnBackToProducts.Location = new Point(84, 596);
            btnBackToProducts.Margin = new Padding(4, 5, 4, 5);
            btnBackToProducts.Name = "btnBackToProducts";
            btnBackToProducts.Size = new Size(118, 79);
            btnBackToProducts.TabIndex = 2;
            btnBackToProducts.Text = "Back to Products";
            btnBackToProducts.UseVisualStyleBackColor = true;
            btnBackToProducts.Click += Backtoformbtn_Click;
            // 
            // lblDataViewAmount
            // 
            lblDataViewAmount.AutoSize = true;
            lblDataViewAmount.Location = new Point(890, 82);
            lblDataViewAmount.Margin = new Padding(4, 0, 4, 0);
            lblDataViewAmount.Name = "lblDataViewAmount";
            lblDataViewAmount.Size = new Size(87, 25);
            lblDataViewAmount.TabIndex = 4;
            lblDataViewAmount.Text = "$Amount";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(84, 300);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(432, 25);
            label4.TabIndex = 6;
            label4.Text = "------------------------------------------------------------";
            // 
            // lblTotalAmountDue
            // 
            lblTotalAmountDue.AutoSize = true;
            lblTotalAmountDue.Location = new Point(84, 386);
            lblTotalAmountDue.Margin = new Padding(4, 0, 4, 0);
            lblTotalAmountDue.Name = "lblTotalAmountDue";
            lblTotalAmountDue.Size = new Size(160, 25);
            lblTotalAmountDue.TabIndex = 7;
            lblTotalAmountDue.Text = "Total Amount Due:";
            // 
            // lblAmount
            // 
            lblAmount.AutoSize = true;
            lblAmount.Location = new Point(321, 386);
            lblAmount.Margin = new Padding(4, 0, 4, 0);
            lblAmount.Name = "lblAmount";
            lblAmount.Size = new Size(87, 25);
            lblAmount.TabIndex = 10;
            lblAmount.Text = "$Amount";
            // 
            // btnRemoveItem
            // 
            btnRemoveItem.Location = new Point(234, 596);
            btnRemoveItem.Margin = new Padding(4, 5, 4, 5);
            btnRemoveItem.Name = "btnRemoveItem";
            btnRemoveItem.Size = new Size(118, 79);
            btnRemoveItem.TabIndex = 11;
            btnRemoveItem.Text = "Remove item";
            btnRemoveItem.UseVisualStyleBackColor = true;
            btnRemoveItem.Click += Removeitemcartbtn_Click;
            // 
            // lblNumItemsInCart
            // 
            lblNumItemsInCart.AutoSize = true;
            lblNumItemsInCart.Location = new Point(654, 82);
            lblNumItemsInCart.Margin = new Padding(4, 0, 4, 0);
            lblNumItemsInCart.Name = "lblNumItemsInCart";
            lblNumItemsInCart.Size = new Size(178, 25);
            lblNumItemsInCart.TabIndex = 12;
            lblNumItemsInCart.Text = "Num of items in cart:";
            // 
            // CustomerCart
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1142, 750);
            Controls.Add(lblNumItemsInCart);
            Controls.Add(btnRemoveItem);
            Controls.Add(lblAmount);
            Controls.Add(lblTotalAmountDue);
            Controls.Add(label4);
            Controls.Add(lblDataViewAmount);
            Controls.Add(btnBackToProducts);
            Controls.Add(btnPurchase);
            Controls.Add(CartGridView);
            Margin = new Padding(4, 5, 4, 5);
            Name = "CustomerCart";
            Text = "CustomerCart";
            ((System.ComponentModel.ISupportInitialize)CartGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView CartGridView;
        private Button btnPurchase;
        private Button btnBackToProducts;
        private Label lblDataViewAmount;
        private Label label4;
        private Label lblTotalAmountDue;
        private Label lblAmount;
        private Button btnRemoveItem;
        private Label lblNumItemsInCart;
    }
}