namespace PL
{
    partial class AddForm
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
            BackButton = new Button();
            AddButton = new Button();
            NameLabel = new Label();
            MeasureLabel = new Label();
            PriceForUnit = new Label();
            QuantityLabel = new Label();
            MeasureComboBox = new ComboBox();
            NameTextBox = new TextBox();
            PriceForUnitTextBox = new TextBox();
            QuantityTextBox = new TextBox();
            SuspendLayout();
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.IndianRed;
            BackButton.Location = new Point(12, 649);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(179, 63);
            BackButton.TabIndex = 0;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.GreenYellow;
            AddButton.Location = new Point(946, 649);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(179, 63);
            AddButton.TabIndex = 1;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            NameLabel.Location = new Point(33, 70);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(128, 51);
            NameLabel.TabIndex = 2;
            NameLabel.Text = "Name";
            // 
            // MeasureLabel
            // 
            MeasureLabel.AutoSize = true;
            MeasureLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            MeasureLabel.Location = new Point(33, 185);
            MeasureLabel.Name = "MeasureLabel";
            MeasureLabel.Size = new Size(175, 51);
            MeasureLabel.TabIndex = 3;
            MeasureLabel.Text = "Measure";
            // 
            // PriceForUnit
            // 
            PriceForUnit.AutoSize = true;
            PriceForUnit.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            PriceForUnit.Location = new Point(33, 306);
            PriceForUnit.Name = "PriceForUnit";
            PriceForUnit.Size = new Size(255, 51);
            PriceForUnit.TabIndex = 4;
            PriceForUnit.Text = "Price for unit";
            // 
            // QuantityLabel
            // 
            QuantityLabel.AutoSize = true;
            QuantityLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            QuantityLabel.Location = new Point(33, 426);
            QuantityLabel.Name = "QuantityLabel";
            QuantityLabel.Size = new Size(178, 51);
            QuantityLabel.TabIndex = 5;
            QuantityLabel.Text = "Quantity";
            // 
            // MeasureComboBox
            // 
            MeasureComboBox.FormattingEnabled = true;
            MeasureComboBox.Location = new Point(440, 196);
            MeasureComboBox.Name = "MeasureComboBox";
            MeasureComboBox.Size = new Size(456, 40);
            MeasureComboBox.TabIndex = 6;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(440, 81);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(456, 39);
            NameTextBox.TabIndex = 7;
            // 
            // PriceForUnitTextBox
            // 
            PriceForUnitTextBox.Location = new Point(440, 317);
            PriceForUnitTextBox.Name = "PriceForUnitTextBox";
            PriceForUnitTextBox.Size = new Size(456, 39);
            PriceForUnitTextBox.TabIndex = 8;
            // 
            // QuantityTextBox
            // 
            QuantityTextBox.Location = new Point(440, 437);
            QuantityTextBox.Name = "QuantityTextBox";
            QuantityTextBox.Size = new Size(456, 39);
            QuantityTextBox.TabIndex = 9;
            // 
            // AddForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1152, 757);
            Controls.Add(QuantityTextBox);
            Controls.Add(PriceForUnitTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(MeasureComboBox);
            Controls.Add(QuantityLabel);
            Controls.Add(PriceForUnit);
            Controls.Add(MeasureLabel);
            Controls.Add(NameLabel);
            Controls.Add(AddButton);
            Controls.Add(BackButton);
            Name = "AddForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AddForm";
            Load += AddForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BackButton;
        private Button AddButton;
        private Label NameLabel;
        private Label MeasureLabel;
        private Label PriceForUnit;
        private Label QuantityLabel;
        private ComboBox MeasureComboBox;
        private TextBox NameTextBox;
        private TextBox PriceForUnitTextBox;
        private TextBox QuantityTextBox;
    }
}