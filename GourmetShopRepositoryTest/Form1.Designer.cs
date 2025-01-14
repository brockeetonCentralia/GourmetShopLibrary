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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            nameTextBox = new TextBox();
            priceTextBox = new TextBox();
            stockTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(62, 65);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(240, 199);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(554, 331);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 1;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(529, 202);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(100, 23);
            nameTextBox.TabIndex = 2;
            // 
            // priceTextBox
            // 
            priceTextBox.Location = new Point(529, 241);
            priceTextBox.Name = "priceTextBox";
            priceTextBox.Size = new Size(100, 23);
            priceTextBox.TabIndex = 3;
            // 
            // stockTextBox
            // 
            stockTextBox.Location = new Point(529, 282);
            stockTextBox.Name = "stockTextBox";
            stockTextBox.Size = new Size(100, 23);
            stockTextBox.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(stockTextBox);
            Controls.Add(priceTextBox);
            Controls.Add(nameTextBox);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private TextBox nameTextBox;
        private TextBox priceTextBox;
        private TextBox stockTextBox;
    }
}
