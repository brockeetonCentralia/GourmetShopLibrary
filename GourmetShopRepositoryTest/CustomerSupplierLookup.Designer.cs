namespace GourmetShopRepositoryTest
{
    partial class CustomerSupplierLookup
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
            ProductDGV = new DataGridView();
            AddtoCartbtn = new Button();
            ViewCartbtn = new Button();
            label1 = new Label();
            SupplierIDtxt = new TextBox();
            SearchSupplierID = new Button();
            ((System.ComponentModel.ISupportInitialize)ProductDGV).BeginInit();
            SuspendLayout();
            // 
            // ProductDGV
            // 
            ProductDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ProductDGV.Location = new Point(472, 43);
            ProductDGV.Name = "ProductDGV";
            ProductDGV.Size = new Size(279, 356);
            ProductDGV.TabIndex = 0;
            // 
            // AddtoCartbtn
            // 
            AddtoCartbtn.Location = new Point(227, 336);
            AddtoCartbtn.Name = "AddtoCartbtn";
            AddtoCartbtn.Size = new Size(88, 42);
            AddtoCartbtn.TabIndex = 1;
            AddtoCartbtn.Text = "Add to cart";
            AddtoCartbtn.UseVisualStyleBackColor = true;
            AddtoCartbtn.Click += AddtoCartbtn_Click;
            // 
            // ViewCartbtn
            // 
            ViewCartbtn.Location = new Point(72, 336);
            ViewCartbtn.Name = "ViewCartbtn";
            ViewCartbtn.Size = new Size(88, 42);
            ViewCartbtn.TabIndex = 2;
            ViewCartbtn.Text = "View Cart";
            ViewCartbtn.UseVisualStyleBackColor = true;
            ViewCartbtn.Click += ViewCartbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(50, 118);
            label1.Name = "label1";
            label1.Size = new Size(121, 15);
            label1.TabIndex = 3;
            label1.Text = "Search by Supplier ID:";
            // 
            // SupplierIDtxt
            // 
            SupplierIDtxt.Location = new Point(198, 110);
            SupplierIDtxt.Name = "SupplierIDtxt";
            SupplierIDtxt.Size = new Size(100, 23);
            SupplierIDtxt.TabIndex = 4;
            // 
            // SearchSupplierID
            // 
            SearchSupplierID.Location = new Point(158, 169);
            SearchSupplierID.Name = "SearchSupplierID";
            SearchSupplierID.Size = new Size(75, 23);
            SearchSupplierID.TabIndex = 5;
            SearchSupplierID.Text = "Search";
            SearchSupplierID.UseVisualStyleBackColor = true;
            SearchSupplierID.Click += SearchSupplierID_Click;
            // 
            // CustomerSupplierLookup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(SearchSupplierID);
            Controls.Add(SupplierIDtxt);
            Controls.Add(label1);
            Controls.Add(ViewCartbtn);
            Controls.Add(AddtoCartbtn);
            Controls.Add(ProductDGV);
            Name = "CustomerSupplierLookup";
            Text = "CustomerSupplierLookup";
            ((System.ComponentModel.ISupportInitialize)ProductDGV).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView ProductDGV;
        private Button AddtoCartbtn;
        private Button ViewCartbtn;
        private Label label1;
        private TextBox SupplierIDtxt;
        private Button SearchSupplierID;
    }
}