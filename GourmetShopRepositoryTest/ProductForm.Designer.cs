namespace GourmetShopRepositoryTest
{
    partial class ProductForm
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
            addButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            productNameTextBox = new TextBox();
            supplierTextBox = new TextBox();
            priceTextBox = new TextBox();
            stockTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            menuStrip1 = new MenuStrip();
            fIleToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            productToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            supplierToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(365, 65);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(536, 473);
            dataGridView1.TabIndex = 0;
            // 
            // addButton
            // 
            addButton.Location = new Point(49, 411);
            addButton.Margin = new Padding(3, 4, 3, 4);
            addButton.Name = "addButton";
            addButton.Size = new Size(86, 31);
            addButton.TabIndex = 1;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(142, 411);
            editButton.Margin = new Padding(3, 4, 3, 4);
            editButton.Name = "editButton";
            editButton.Size = new Size(86, 31);
            editButton.TabIndex = 2;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(234, 411);
            deleteButton.Margin = new Padding(3, 4, 3, 4);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(86, 31);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            // 
            // productNameTextBox
            // 
            productNameTextBox.Location = new Point(190, 209);
            productNameTextBox.Margin = new Padding(3, 4, 3, 4);
            productNameTextBox.Name = "productNameTextBox";
            productNameTextBox.Size = new Size(114, 27);
            productNameTextBox.TabIndex = 4;
            // 
            // supplierTextBox
            // 
            supplierTextBox.Location = new Point(190, 248);
            supplierTextBox.Margin = new Padding(3, 4, 3, 4);
            supplierTextBox.Name = "supplierTextBox";
            supplierTextBox.Size = new Size(114, 27);
            supplierTextBox.TabIndex = 5;
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(190, 287);
            priceTextBox.Margin = new Padding(3, 4, 3, 4);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(114, 27);
            priceTextBox.TabIndex = 6;
            // 
            // stockTextBox
            // 
            stockTextBox.Location = new Point(190, 325);
            stockTextBox.Margin = new Padding(3, 4, 3, 4);
            stockTextBox.Name = "stockTextBox";
            stockTextBox.Size = new Size(114, 27);
            stockTextBox.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(80, 216);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 8;
            label1.Text = "Product Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(101, 255);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 9;
            label2.Text = "Supplier ID";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(112, 294);
            label3.Name = "label3";
            label3.Size = new Size(72, 20);
            label3.TabIndex = 10;
            label3.Text = "Unit Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(121, 332);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.Yes;
            label4.Size = new Size(63, 20);
            label4.TabIndex = 11;
            label4.Text = "Package";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fIleToolStripMenuItem, productToolStripMenuItem, supplierToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(914, 28);
            menuStrip1.TabIndex = 12;
            menuStrip1.Text = "menuStrip1";
            // 
            // fIleToolStripMenuItem
            // 
            fIleToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            fIleToolStripMenuItem.Name = "fIleToolStripMenuItem";
            fIleToolStripMenuItem.Size = new Size(46, 24);
            fIleToolStripMenuItem.Text = "FIle";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(116, 26);
            toolStripMenuItem1.Text = "Exit";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // productToolStripMenuItem
            // 
            productToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem2 });
            productToolStripMenuItem.Name = "productToolStripMenuItem";
            productToolStripMenuItem.Size = new Size(74, 24);
            productToolStripMenuItem.Text = "Product";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.ForeColor = SystemColors.AppWorkspace;
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(118, 26);
            toolStripMenuItem2.Text = "Edit";
            // 
            // supplierToolStripMenuItem
            // 
            supplierToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem3 });
            supplierToolStripMenuItem.Name = "supplierToolStripMenuItem";
            supplierToolStripMenuItem.Size = new Size(78, 24);
            supplierToolStripMenuItem.Text = "Supplier";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(118, 26);
            toolStripMenuItem3.Text = "Edit";
            toolStripMenuItem3.Click += toolStripMenuItem3_Click;
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(stockTextBox);
            Controls.Add(priceTextBox);
            Controls.Add(supplierTextBox);
            Controls.Add(productNameTextBox);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(addButton);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3, 4, 3, 4);
            Name = "ProductForm";
            Text = "ProductForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button addButton;
        private Button editButton;
        private Button deleteButton;
        private TextBox productNameTextBox;
        private TextBox supplierTextBox;
        private TextBox priceTextBox;
        private TextBox stockTextBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fIleToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem productToolStripMenuItem;
        private ToolStripMenuItem supplierToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripMenuItem toolStripMenuItem2;
    }
}