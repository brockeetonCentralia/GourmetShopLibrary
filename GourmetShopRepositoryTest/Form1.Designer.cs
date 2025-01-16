namespace GourmetShopRepositoryTest
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            productToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripMenuItem();
            supplierToolStripMenuItem = new ToolStripMenuItem();
            productNameTextBox = new TextBox();
            supplierTextBox = new TextBox();
            priceTextBox = new TextBox();
            stockTextBox = new TextBox();
            dataGridView1 = new DataGridView();
            editButton = new Button();
            deleteButton = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(12, 306);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, productToolStripMenuItem, supplierToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // productToolStripMenuItem
            // 
            productToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            productToolStripMenuItem.Name = "productToolStripMenuItem";
            productToolStripMenuItem.Size = new Size(61, 20);
            productToolStripMenuItem.Text = "Product";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(180, 22);
            toolStripMenuItem1.Text = "toolStripMenuItem1";
            toolStripMenuItem1.Click += toolStripMenuItem1_Click;
            // 
            // supplierToolStripMenuItem
            // 
            supplierToolStripMenuItem.Name = "supplierToolStripMenuItem";
            supplierToolStripMenuItem.Size = new Size(62, 20);
            supplierToolStripMenuItem.Text = "Supplier";
            // 
            // productNameTextBox
            // 
            productNameTextBox.Location = new Point(43, 73);
            productNameTextBox.Name = "productNameTextBox";
            productNameTextBox.Size = new Size(100, 23);
            productNameTextBox.TabIndex = 3;
            // 
            // supplierTextBox
            // 
            supplierTextBox.Location = new Point(43, 102);
            supplierTextBox.Name = "supplierTextBox";
            supplierTextBox.Size = new Size(100, 23);
            supplierTextBox.TabIndex = 4;
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(43, 133);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(100, 23);
            priceTextBox.TabIndex = 5;
            // 
            // stockTextBox
            // 
            stockTextBox.Location = new Point(43, 162);
            stockTextBox.Name = "stockTextBox";
            stockTextBox.Size = new Size(100, 23);
            stockTextBox.TabIndex = 6;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(161, 73);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(367, 222);
            dataGridView1.TabIndex = 7;
            // 
            // editButton
            // 
            editButton.Location = new Point(93, 306);
            editButton.Name = "editButton";
            editButton.Size = new Size(75, 23);
            editButton.TabIndex = 8;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(174, 306);
            deleteButton.Name = "deleteButton";
            deleteButton.RightToLeft = RightToLeft.Yes;
            deleteButton.Size = new Size(75, 23);
            deleteButton.TabIndex = 9;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(dataGridView1);
            Controls.Add(stockTextBox);
            Controls.Add(priceTextBox);
            Controls.Add(supplierTextBox);
            Controls.Add(productNameTextBox);
            Controls.Add(button1);
            Controls.Add(menuStrip1);
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem productToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem supplierToolStripMenuItem;
        private TextBox productNameTextBox;
        private TextBox supplierTextBox;
        private TextBox priceTextBox;
        private TextBox stockTextBox;
        private DataGridView dataGridView1;
        private Button editButton;
        private Button deleteButton;
    }
}
