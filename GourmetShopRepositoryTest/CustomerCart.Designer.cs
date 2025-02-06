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
            dataGridView1 = new DataGridView();
            Purchasebtn = new Button();
            Backtoformbtn = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            Subtotallbl = new Label();
            Taxlbl = new Label();
            TotalAmountlbl = new Label();
            Removeitemcartbtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(458, 77);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(313, 343);
            dataGridView1.TabIndex = 0;
            // 
            // Purchasebtn
            // 
            Purchasebtn.Location = new Point(275, 358);
            Purchasebtn.Name = "Purchasebtn";
            Purchasebtn.Size = new Size(82, 47);
            Purchasebtn.TabIndex = 1;
            Purchasebtn.Text = "Purchase Cart";
            Purchasebtn.UseVisualStyleBackColor = true;
            Purchasebtn.Click += Purchasebtn_Click;
            // 
            // Backtoformbtn
            // 
            Backtoformbtn.Location = new Point(59, 358);
            Backtoformbtn.Name = "Backtoformbtn";
            Backtoformbtn.Size = new Size(82, 47);
            Backtoformbtn.TabIndex = 2;
            Backtoformbtn.Text = "Back to Products";
            Backtoformbtn.UseVisualStyleBackColor = true;
            Backtoformbtn.Click += Backtoformbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(59, 82);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 3;
            label1.Text = "Subtotal:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(554, 41);
            label2.Name = "label2";
            label2.Size = new Size(116, 15);
            label2.TabIndex = 4;
            label2.Text = "Num of items in cart";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(59, 131);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 5;
            label3.Text = "Tax:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(59, 180);
            label4.Name = "label4";
            label4.Size = new Size(307, 15);
            label4.TabIndex = 6;
            label4.Text = "------------------------------------------------------------";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(59, 232);
            label5.Name = "label5";
            label5.Size = new Size(106, 15);
            label5.TabIndex = 7;
            label5.Text = "Total Amount Due:";
            // 
            // Subtotallbl
            // 
            Subtotallbl.AutoSize = true;
            Subtotallbl.Location = new Point(227, 83);
            Subtotallbl.Name = "Subtotallbl";
            Subtotallbl.Size = new Size(57, 15);
            Subtotallbl.TabIndex = 8;
            Subtotallbl.Text = "$Amount";
            // 
            // Taxlbl
            // 
            Taxlbl.AutoSize = true;
            Taxlbl.Location = new Point(231, 129);
            Taxlbl.Name = "Taxlbl";
            Taxlbl.Size = new Size(57, 15);
            Taxlbl.TabIndex = 9;
            Taxlbl.Text = "$Amount";
            // 
            // TotalAmountlbl
            // 
            TotalAmountlbl.AutoSize = true;
            TotalAmountlbl.Location = new Point(222, 229);
            TotalAmountlbl.Name = "TotalAmountlbl";
            TotalAmountlbl.Size = new Size(57, 15);
            TotalAmountlbl.TabIndex = 10;
            TotalAmountlbl.Text = "$Amount";
            // 
            // Removeitemcartbtn
            // 
            Removeitemcartbtn.Location = new Point(164, 358);
            Removeitemcartbtn.Name = "Removeitemcartbtn";
            Removeitemcartbtn.Size = new Size(82, 47);
            Removeitemcartbtn.TabIndex = 11;
            Removeitemcartbtn.Text = "Remove item";
            Removeitemcartbtn.UseVisualStyleBackColor = true;
            Removeitemcartbtn.Click += Removeitemcartbtn_Click;
            // 
            // CustomerCart
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Removeitemcartbtn);
            Controls.Add(TotalAmountlbl);
            Controls.Add(Taxlbl);
            Controls.Add(Subtotallbl);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Backtoformbtn);
            Controls.Add(Purchasebtn);
            Controls.Add(dataGridView1);
            Name = "CustomerCart";
            Text = "CustomerCart";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button Purchasebtn;
        private Button Backtoformbtn;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label Subtotallbl;
        private Label Taxlbl;
        private Label TotalAmountlbl;
        private Button Removeitemcartbtn;
    }
}