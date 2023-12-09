namespace PL
{
    partial class MainStockForm
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
            AddNewItemButton = new Button();
            MianLabel = new Label();
            dataGridView1 = new DataGridView();
            CloseButton = new Button();
            UpdateItemButton = new Button();
            DeleteItemButton = new Button();
            SearchButton = new Button();
            richTextBox1 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // AddNewItemButton
            // 
            AddNewItemButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            AddNewItemButton.Location = new Point(1273, 374);
            AddNewItemButton.Name = "AddNewItemButton";
            AddNewItemButton.Size = new Size(439, 112);
            AddNewItemButton.TabIndex = 5;
            AddNewItemButton.Text = "Add New Item";
            AddNewItemButton.UseVisualStyleBackColor = true;
            AddNewItemButton.Click += AddNewItemButton_Click;
            // 
            // MianLabel
            // 
            MianLabel.AutoSize = true;
            MianLabel.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            MianLabel.Location = new Point(729, 69);
            MianLabel.Name = "MianLabel";
            MianLabel.Size = new Size(416, 59);
            MianLabel.TabIndex = 4;
            MianLabel.Text = "Items in warehouse";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(28, 329);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 82;
            dataGridView1.RowTemplate.Height = 41;
            dataGridView1.Size = new Size(1117, 581);
            dataGridView1.TabIndex = 3;
            // 
            // CloseButton
            // 
            CloseButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            CloseButton.Location = new Point(28, 961);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(270, 78);
            CloseButton.TabIndex = 6;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // UpdateItemButton
            // 
            UpdateItemButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateItemButton.Location = new Point(1273, 567);
            UpdateItemButton.Name = "UpdateItemButton";
            UpdateItemButton.Size = new Size(439, 112);
            UpdateItemButton.TabIndex = 7;
            UpdateItemButton.Text = "Update Item";
            UpdateItemButton.UseVisualStyleBackColor = true;
            UpdateItemButton.Click += UpdateItemButton_Click;
            // 
            // DeleteItemButton
            // 
            DeleteItemButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            DeleteItemButton.Location = new Point(1273, 764);
            DeleteItemButton.Name = "DeleteItemButton";
            DeleteItemButton.Size = new Size(439, 112);
            DeleteItemButton.TabIndex = 8;
            DeleteItemButton.Text = "Delete Item";
            DeleteItemButton.UseVisualStyleBackColor = true;
            DeleteItemButton.Click += DeleteItemButton_Click;
            // 
            // SearchButton
            // 
            SearchButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            SearchButton.Location = new Point(28, 206);
            SearchButton.Name = "SearchButton";
            SearchButton.Size = new Size(270, 78);
            SearchButton.TabIndex = 9;
            SearchButton.Text = "Search";
            SearchButton.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            richTextBox1.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBox1.Location = new Point(361, 206);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(1093, 78);
            richTextBox1.TabIndex = 11;
            richTextBox1.Text = "\n";
            // 
            // MainStockForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1820, 1063);
            Controls.Add(richTextBox1);
            Controls.Add(SearchButton);
            Controls.Add(DeleteItemButton);
            Controls.Add(UpdateItemButton);
            Controls.Add(CloseButton);
            Controls.Add(AddNewItemButton);
            Controls.Add(MianLabel);
            Controls.Add(dataGridView1);
            Name = "MainStockForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainStockForm";
            Load += MainStockForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button AddNewItemButton;
        private Label MianLabel;
        private DataGridView dataGridView1;
        private Button CloseButton;
        private Button UpdateItemButton;
        private Button DeleteItemButton;
        private Button SearchButton;
        private RichTextBox richTextBox1;
    }
}