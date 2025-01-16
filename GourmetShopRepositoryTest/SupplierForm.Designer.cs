namespace GourmetShopRepositoryTest
{
    partial class SupplierForm
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
            button2 = new Button();
            button3 = new Button();
            companyNameTextBox = new TextBox();
            contactNameTextBox = new TextBox();
            contactTitleTextBox = new TextBox();
            cityTextBox = new TextBox();
            countryTextBox = new TextBox();
            phoneTextBox = new TextBox();
            faxTextBox = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(313, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(459, 365);
            dataGridView1.TabIndex = 0;
            // 
            // addButton
            // 
            addButton.Location = new Point(49, 272);
            addButton.Name = "addButton";
            addButton.Size = new Size(75, 23);
            addButton.TabIndex = 1;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // button2
            // 
            button2.Location = new Point(130, 272);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 2;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(211, 272);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 3;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // companyNameTextBox
            // 
            companyNameTextBox.Location = new Point(170, 54);
            companyNameTextBox.Name = "companyNameTextBox";
            companyNameTextBox.Size = new Size(100, 23);
            companyNameTextBox.TabIndex = 4;
            // 
            // contactNameTextBox
            // 
            contactNameTextBox.Location = new Point(170, 83);
            contactNameTextBox.Name = "contactNameTextBox";
            contactNameTextBox.Size = new Size(100, 23);
            contactNameTextBox.TabIndex = 5;
            // 
            // contactTitleTextBox
            // 
            contactTitleTextBox.Location = new Point(170, 112);
            contactTitleTextBox.Name = "contactTitleTextBox";
            contactTitleTextBox.Size = new Size(100, 23);
            contactTitleTextBox.TabIndex = 6;
            // 
            // cityTextBox
            // 
            cityTextBox.Location = new Point(170, 141);
            cityTextBox.Name = "cityTextBox";
            cityTextBox.Size = new Size(100, 23);
            cityTextBox.TabIndex = 7;
            // 
            // countryTextBox
            // 
            countryTextBox.Location = new Point(170, 170);
            countryTextBox.Name = "countryTextBox";
            countryTextBox.Size = new Size(100, 23);
            countryTextBox.TabIndex = 8;
            // 
            // phoneTextBox
            // 
            phoneTextBox.Location = new Point(170, 199);
            phoneTextBox.Name = "phoneTextBox";
            phoneTextBox.Size = new Size(100, 23);
            phoneTextBox.TabIndex = 9;
            // 
            // faxTextBox
            // 
            faxTextBox.Location = new Point(170, 228);
            faxTextBox.Name = "faxTextBox";
            faxTextBox.Size = new Size(100, 23);
            faxTextBox.TabIndex = 10;
            // 
            // SupplierForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(faxTextBox);
            Controls.Add(phoneTextBox);
            Controls.Add(countryTextBox);
            Controls.Add(cityTextBox);
            Controls.Add(contactTitleTextBox);
            Controls.Add(contactNameTextBox);
            Controls.Add(companyNameTextBox);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(addButton);
            Controls.Add(dataGridView1);
            Name = "SupplierForm";
            Text = "SupplierForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button addButton;
        private Button button2;
        private Button button3;
        private TextBox companyNameTextBox;
        private TextBox contactNameTextBox;
        private TextBox contactTitleTextBox;
        private TextBox cityTextBox;
        private TextBox countryTextBox;
        private TextBox phoneTextBox;
        private TextBox faxTextBox;
    }
}