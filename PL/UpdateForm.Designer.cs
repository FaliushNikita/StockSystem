namespace PL
{
    partial class UpdateForm
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
            QuantityTextBox = new TextBox();
            PriceForUnitTextBox = new TextBox();
            NameTextBox = new TextBox();
            MeasureComboBox = new ComboBox();
            QuantityLabel = new Label();
            PriceForUnit = new Label();
            MeasureLabel = new Label();
            NameLabel = new Label();
            UpdateButton = new Button();
            BackButton = new Button();
            SuspendLayout();
            // 
            // QuantityTextBox
            // 
            QuantityTextBox.Location = new Point(460, 451);
            QuantityTextBox.Name = "QuantityTextBox";
            QuantityTextBox.Size = new Size(456, 39);
            QuantityTextBox.TabIndex = 19;
            // 
            // PriceForUnitTextBox
            // 
            PriceForUnitTextBox.Location = new Point(460, 331);
            PriceForUnitTextBox.Name = "PriceForUnitTextBox";
            PriceForUnitTextBox.Size = new Size(456, 39);
            PriceForUnitTextBox.TabIndex = 18;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(460, 95);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(456, 39);
            NameTextBox.TabIndex = 17;
            // 
            // MeasureComboBox
            // 
            MeasureComboBox.FormattingEnabled = true;
            MeasureComboBox.Location = new Point(460, 210);
            MeasureComboBox.Name = "MeasureComboBox";
            MeasureComboBox.Size = new Size(456, 40);
            MeasureComboBox.TabIndex = 16;
            // 
            // QuantityLabel
            // 
            QuantityLabel.AutoSize = true;
            QuantityLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            QuantityLabel.Location = new Point(53, 440);
            QuantityLabel.Name = "QuantityLabel";
            QuantityLabel.Size = new Size(178, 51);
            QuantityLabel.TabIndex = 15;
            QuantityLabel.Text = "Quantity";
            // 
            // PriceForUnit
            // 
            PriceForUnit.AutoSize = true;
            PriceForUnit.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            PriceForUnit.Location = new Point(53, 320);
            PriceForUnit.Name = "PriceForUnit";
            PriceForUnit.Size = new Size(255, 51);
            PriceForUnit.TabIndex = 14;
            PriceForUnit.Text = "Price for unit";
            // 
            // MeasureLabel
            // 
            MeasureLabel.AutoSize = true;
            MeasureLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            MeasureLabel.Location = new Point(53, 199);
            MeasureLabel.Name = "MeasureLabel";
            MeasureLabel.Size = new Size(175, 51);
            MeasureLabel.TabIndex = 13;
            MeasureLabel.Text = "Measure";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point);
            NameLabel.Location = new Point(53, 84);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(128, 51);
            NameLabel.TabIndex = 12;
            NameLabel.Text = "Name";
            // 
            // UpdateButton
            // 
            UpdateButton.BackColor = Color.GreenYellow;
            UpdateButton.Location = new Point(966, 663);
            UpdateButton.Name = "UpdateButton";
            UpdateButton.Size = new Size(179, 63);
            UpdateButton.TabIndex = 11;
            UpdateButton.Text = "Update";
            UpdateButton.UseVisualStyleBackColor = false;
            UpdateButton.Click += UpdateButton_Click;
            // 
            // BackButton
            // 
            BackButton.BackColor = Color.IndianRed;
            BackButton.Location = new Point(32, 663);
            BackButton.Name = "BackButton";
            BackButton.Size = new Size(179, 63);
            BackButton.TabIndex = 10;
            BackButton.Text = "Back";
            BackButton.UseVisualStyleBackColor = false;
            BackButton.Click += BackButton_Click;
            // 
            // UpdateForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1176, 779);
            Controls.Add(QuantityTextBox);
            Controls.Add(PriceForUnitTextBox);
            Controls.Add(NameTextBox);
            Controls.Add(MeasureComboBox);
            Controls.Add(QuantityLabel);
            Controls.Add(PriceForUnit);
            Controls.Add(MeasureLabel);
            Controls.Add(NameLabel);
            Controls.Add(UpdateButton);
            Controls.Add(BackButton);
            Name = "UpdateForm";
            Text = "UpdateForm";
            Load += UpdateForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox QuantityTextBox;
        private TextBox PriceForUnitTextBox;
        private TextBox NameTextBox;
        private ComboBox MeasureComboBox;
        private Label QuantityLabel;
        private Label PriceForUnit;
        private Label MeasureLabel;
        private Label NameLabel;
        private Button UpdateButton;
        private Button BackButton;
    }
}