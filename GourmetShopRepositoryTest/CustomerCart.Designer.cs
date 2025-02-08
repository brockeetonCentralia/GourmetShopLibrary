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
            Purchasebtn = new Button();
            Backtoformbtn = new Button();
            TotalItemslbl = new Label();
            label4 = new Label();
            label5 = new Label();
            TotalAmountlbl = new Label();
            Removeitemcartbtn = new Button();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)CartGridView).BeginInit();
            SuspendLayout();
            // 
            // CartGridView
            // 
            CartGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CartGridView.Location = new Point(523, 103);
            CartGridView.Margin = new Padding(3, 4, 3, 4);
            CartGridView.Name = "CartGridView";
            CartGridView.RowHeadersWidth = 51;
            CartGridView.Size = new Size(358, 457);
            CartGridView.TabIndex = 0;
            // 
            // Purchasebtn
            // 
            Purchasebtn.Location = new Point(314, 477);
            Purchasebtn.Margin = new Padding(3, 4, 3, 4);
            Purchasebtn.Name = "Purchasebtn";
            Purchasebtn.Size = new Size(94, 63);
            Purchasebtn.TabIndex = 1;
            Purchasebtn.Text = "Purchase Cart";
            Purchasebtn.UseVisualStyleBackColor = true;
            Purchasebtn.Click += Purchasebtn_Click;
            // 
            // Backtoformbtn
            // 
            Backtoformbtn.Location = new Point(67, 477);
            Backtoformbtn.Margin = new Padding(3, 4, 3, 4);
            Backtoformbtn.Name = "Backtoformbtn";
            Backtoformbtn.Size = new Size(94, 63);
            Backtoformbtn.TabIndex = 2;
            Backtoformbtn.Text = "Back to Products";
            Backtoformbtn.UseVisualStyleBackColor = true;
            Backtoformbtn.Click += Backtoformbtn_Click;
            // 
            // TotalItemslbl
            // 
            TotalItemslbl.AutoSize = true;
            TotalItemslbl.Location = new Point(712, 66);
            TotalItemslbl.Name = "TotalItemslbl";
            TotalItemslbl.Size = new Size(70, 20);
            TotalItemslbl.TabIndex = 4;
            TotalItemslbl.Text = "$Amount";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(67, 240);
            label4.Name = "label4";
            label4.Size = new Size(369, 20);
            label4.TabIndex = 6;
            label4.Text = "------------------------------------------------------------";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(67, 309);
            label5.Name = "label5";
            label5.Size = new Size(133, 20);
            label5.TabIndex = 7;
            label5.Text = "Total Amount Due:";
            // 
            // TotalAmountlbl
            // 
            TotalAmountlbl.AutoSize = true;
            TotalAmountlbl.Location = new Point(257, 309);
            TotalAmountlbl.Name = "TotalAmountlbl";
            TotalAmountlbl.Size = new Size(70, 20);
            TotalAmountlbl.TabIndex = 10;
            TotalAmountlbl.Text = "$Amount";
            // 
            // Removeitemcartbtn
            // 
            Removeitemcartbtn.Location = new Point(187, 477);
            Removeitemcartbtn.Margin = new Padding(3, 4, 3, 4);
            Removeitemcartbtn.Name = "Removeitemcartbtn";
            Removeitemcartbtn.Size = new Size(94, 63);
            Removeitemcartbtn.TabIndex = 11;
            Removeitemcartbtn.Text = "Remove item";
            Removeitemcartbtn.UseVisualStyleBackColor = true;
            Removeitemcartbtn.Click += Removeitemcartbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(523, 66);
            label1.Name = "label1";
            label1.Size = new Size(147, 20);
            label1.TabIndex = 12;
            label1.Text = "Num of items in cart:";
            // 
            // CustomerCart
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label1);
            Controls.Add(Removeitemcartbtn);
            Controls.Add(TotalAmountlbl);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(TotalItemslbl);
            Controls.Add(Backtoformbtn);
            Controls.Add(Purchasebtn);
            Controls.Add(CartGridView);
            Margin = new Padding(3, 4, 3, 4);
            Name = "CustomerCart";
            Text = "CustomerCart";
            ((System.ComponentModel.ISupportInitialize)CartGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView CartGridView;
        private Button Purchasebtn;
        private Button Backtoformbtn;
        private Label TotalItemslbl;
        private Label label4;
        private Label label5;
        private Label TotalAmountlbl;
        private Button Removeitemcartbtn;
        private Label label1;
    }
}