namespace WinFormsCalculator
{
    partial class CalculatorBase
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
            this.NumberInput = new System.Windows.Forms.TextBox();
            this.ButtonLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.PlusButton = new System.Windows.Forms.Button();
            this.ThreeButton = new System.Windows.Forms.Button();
            this.TwoButton = new System.Windows.Forms.Button();
            this.OneButton = new System.Windows.Forms.Button();
            this.MinusButton = new System.Windows.Forms.Button();
            this.SixButton = new System.Windows.Forms.Button();
            this.FiveButton = new System.Windows.Forms.Button();
            this.FourButton = new System.Windows.Forms.Button();
            this.MultiplyButton = new System.Windows.Forms.Button();
            this.NineButton = new System.Windows.Forms.Button();
            this.EightButton = new System.Windows.Forms.Button();
            this.SevenButton = new System.Windows.Forms.Button();
            this.CEButton = new System.Windows.Forms.Button();
            this.BackspaceButton = new System.Windows.Forms.Button();
            this.DivideButton = new System.Windows.Forms.Button();
            this.DecimalButton = new System.Windows.Forms.Button();
            this.EqualsButton = new System.Windows.Forms.Button();
            this.ZeroButton = new System.Windows.Forms.Button();
            this.ButtonLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NumberInput
            // 
            this.NumberInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NumberInput.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NumberInput.Location = new System.Drawing.Point(12, 12);
            this.NumberInput.Name = "NumberInput";
            this.NumberInput.PlaceholderText = "0";
            this.NumberInput.Size = new System.Drawing.Size(362, 50);
            this.NumberInput.TabIndex = 0;
            this.NumberInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NumberInput.TextChanged += new System.EventHandler(this.NumberInput_TextChanged);
            // 
            // ButtonLayoutPanel
            // 
            this.ButtonLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonLayoutPanel.ColumnCount = 4;
            this.ButtonLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.ButtonLayoutPanel.Controls.Add(this.PlusButton, 3, 3);
            this.ButtonLayoutPanel.Controls.Add(this.ThreeButton, 2, 3);
            this.ButtonLayoutPanel.Controls.Add(this.TwoButton, 1, 3);
            this.ButtonLayoutPanel.Controls.Add(this.OneButton, 0, 3);
            this.ButtonLayoutPanel.Controls.Add(this.MinusButton, 3, 2);
            this.ButtonLayoutPanel.Controls.Add(this.SixButton, 2, 2);
            this.ButtonLayoutPanel.Controls.Add(this.FiveButton, 1, 2);
            this.ButtonLayoutPanel.Controls.Add(this.FourButton, 0, 2);
            this.ButtonLayoutPanel.Controls.Add(this.MultiplyButton, 3, 1);
            this.ButtonLayoutPanel.Controls.Add(this.NineButton, 2, 1);
            this.ButtonLayoutPanel.Controls.Add(this.EightButton, 1, 1);
            this.ButtonLayoutPanel.Controls.Add(this.SevenButton, 0, 1);
            this.ButtonLayoutPanel.Controls.Add(this.CEButton, 0, 0);
            this.ButtonLayoutPanel.Controls.Add(this.BackspaceButton, 2, 0);
            this.ButtonLayoutPanel.Controls.Add(this.DivideButton, 3, 0);
            this.ButtonLayoutPanel.Controls.Add(this.DecimalButton, 2, 4);
            this.ButtonLayoutPanel.Controls.Add(this.EqualsButton, 3, 4);
            this.ButtonLayoutPanel.Controls.Add(this.ZeroButton, 0, 4);
            this.ButtonLayoutPanel.Location = new System.Drawing.Point(12, 68);
            this.ButtonLayoutPanel.Name = "ButtonLayoutPanel";
            this.ButtonLayoutPanel.RowCount = 5;
            this.ButtonLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.ButtonLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.ButtonLayoutPanel.Size = new System.Drawing.Size(362, 381);
            this.ButtonLayoutPanel.TabIndex = 1;
            this.ButtonLayoutPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.ButtonLayoutPanel_Paint);
            // 
            // PlusButton
            // 
            this.PlusButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PlusButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PlusButton.Location = new System.Drawing.Point(270, 228);
            this.PlusButton.Margin = new System.Windows.Forms.Padding(0);
            this.PlusButton.Name = "PlusButton";
            this.PlusButton.Size = new System.Drawing.Size(92, 76);
            this.PlusButton.TabIndex = 19;
            this.PlusButton.Text = "+";
            this.PlusButton.UseVisualStyleBackColor = true;
            this.PlusButton.Click += new System.EventHandler(this.PlusButton_Click);
            // 
            // ThreeButton
            // 
            this.ThreeButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ThreeButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ThreeButton.Location = new System.Drawing.Point(180, 228);
            this.ThreeButton.Margin = new System.Windows.Forms.Padding(0);
            this.ThreeButton.Name = "ThreeButton";
            this.ThreeButton.Size = new System.Drawing.Size(90, 76);
            this.ThreeButton.TabIndex = 18;
            this.ThreeButton.Text = "3";
            this.ThreeButton.UseVisualStyleBackColor = true;
            this.ThreeButton.Click += new System.EventHandler(this.ThreeButton_Click);
            // 
            // TwoButton
            // 
            this.TwoButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TwoButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TwoButton.Location = new System.Drawing.Point(90, 228);
            this.TwoButton.Margin = new System.Windows.Forms.Padding(0);
            this.TwoButton.Name = "TwoButton";
            this.TwoButton.Size = new System.Drawing.Size(90, 76);
            this.TwoButton.TabIndex = 17;
            this.TwoButton.Text = "2";
            this.TwoButton.UseVisualStyleBackColor = true;
            this.TwoButton.Click += new System.EventHandler(this.TwoButton_Click);
            // 
            // OneButton
            // 
            this.OneButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OneButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OneButton.Location = new System.Drawing.Point(0, 228);
            this.OneButton.Margin = new System.Windows.Forms.Padding(0);
            this.OneButton.Name = "OneButton";
            this.OneButton.Size = new System.Drawing.Size(90, 76);
            this.OneButton.TabIndex = 16;
            this.OneButton.Text = "1";
            this.OneButton.UseVisualStyleBackColor = true;
            this.OneButton.Click += new System.EventHandler(this.OneButton_Click);
            // 
            // MinusButton
            // 
            this.MinusButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MinusButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinusButton.Location = new System.Drawing.Point(270, 152);
            this.MinusButton.Margin = new System.Windows.Forms.Padding(0);
            this.MinusButton.Name = "MinusButton";
            this.MinusButton.Size = new System.Drawing.Size(92, 76);
            this.MinusButton.TabIndex = 15;
            this.MinusButton.Text = "-";
            this.MinusButton.UseVisualStyleBackColor = true;
            this.MinusButton.Click += new System.EventHandler(this.MinusButton_Click);
            // 
            // SixButton
            // 
            this.SixButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SixButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SixButton.Location = new System.Drawing.Point(180, 152);
            this.SixButton.Margin = new System.Windows.Forms.Padding(0);
            this.SixButton.Name = "SixButton";
            this.SixButton.Size = new System.Drawing.Size(90, 76);
            this.SixButton.TabIndex = 14;
            this.SixButton.Text = "6";
            this.SixButton.UseVisualStyleBackColor = true;
            this.SixButton.Click += new System.EventHandler(this.SixButton_Click);
            // 
            // FiveButton
            // 
            this.FiveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FiveButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FiveButton.Location = new System.Drawing.Point(90, 152);
            this.FiveButton.Margin = new System.Windows.Forms.Padding(0);
            this.FiveButton.Name = "FiveButton";
            this.FiveButton.Size = new System.Drawing.Size(90, 76);
            this.FiveButton.TabIndex = 13;
            this.FiveButton.Text = "5";
            this.FiveButton.UseVisualStyleBackColor = true;
            this.FiveButton.Click += new System.EventHandler(this.FiveButton_Click);
            // 
            // FourButton
            // 
            this.FourButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FourButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FourButton.Location = new System.Drawing.Point(0, 152);
            this.FourButton.Margin = new System.Windows.Forms.Padding(0);
            this.FourButton.Name = "FourButton";
            this.FourButton.Size = new System.Drawing.Size(90, 76);
            this.FourButton.TabIndex = 12;
            this.FourButton.Text = "4";
            this.FourButton.UseVisualStyleBackColor = true;
            this.FourButton.Click += new System.EventHandler(this.FourButton_Click);
            // 
            // MultiplyButton
            // 
            this.MultiplyButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MultiplyButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MultiplyButton.Location = new System.Drawing.Point(270, 76);
            this.MultiplyButton.Margin = new System.Windows.Forms.Padding(0);
            this.MultiplyButton.Name = "MultiplyButton";
            this.MultiplyButton.Size = new System.Drawing.Size(92, 76);
            this.MultiplyButton.TabIndex = 11;
            this.MultiplyButton.Text = "*";
            this.MultiplyButton.UseVisualStyleBackColor = true;
            this.MultiplyButton.Click += new System.EventHandler(this.MultiplyButton_Click);
            // 
            // NineButton
            // 
            this.NineButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NineButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NineButton.Location = new System.Drawing.Point(180, 76);
            this.NineButton.Margin = new System.Windows.Forms.Padding(0);
            this.NineButton.Name = "NineButton";
            this.NineButton.Size = new System.Drawing.Size(90, 76);
            this.NineButton.TabIndex = 10;
            this.NineButton.Text = "9";
            this.NineButton.UseVisualStyleBackColor = true;
            this.NineButton.Click += new System.EventHandler(this.NineButton_Click);
            // 
            // EightButton
            // 
            this.EightButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EightButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EightButton.Location = new System.Drawing.Point(90, 76);
            this.EightButton.Margin = new System.Windows.Forms.Padding(0);
            this.EightButton.Name = "EightButton";
            this.EightButton.Size = new System.Drawing.Size(90, 76);
            this.EightButton.TabIndex = 9;
            this.EightButton.Text = "8";
            this.EightButton.UseVisualStyleBackColor = true;
            this.EightButton.Click += new System.EventHandler(this.EightButton_Click);
            // 
            // SevenButton
            // 
            this.SevenButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SevenButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SevenButton.Location = new System.Drawing.Point(0, 76);
            this.SevenButton.Margin = new System.Windows.Forms.Padding(0);
            this.SevenButton.Name = "SevenButton";
            this.SevenButton.Size = new System.Drawing.Size(90, 76);
            this.SevenButton.TabIndex = 8;
            this.SevenButton.Text = "7";
            this.SevenButton.UseVisualStyleBackColor = true;
            this.SevenButton.Click += new System.EventHandler(this.SevenButton_Click);
            // 
            // CEButton
            // 
            this.ButtonLayoutPanel.SetColumnSpan(this.CEButton, 2);
            this.CEButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CEButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CEButton.Location = new System.Drawing.Point(0, 0);
            this.CEButton.Margin = new System.Windows.Forms.Padding(0);
            this.CEButton.Name = "CEButton";
            this.CEButton.Size = new System.Drawing.Size(180, 76);
            this.CEButton.TabIndex = 0;
            this.CEButton.Text = "CE";
            this.CEButton.UseVisualStyleBackColor = true;
            this.CEButton.Click += new System.EventHandler(this.CEButton_Click);
            // 
            // BackspaceButton
            // 
            this.BackspaceButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BackspaceButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BackspaceButton.Location = new System.Drawing.Point(180, 0);
            this.BackspaceButton.Margin = new System.Windows.Forms.Padding(0);
            this.BackspaceButton.Name = "BackspaceButton";
            this.BackspaceButton.Size = new System.Drawing.Size(90, 76);
            this.BackspaceButton.TabIndex = 2;
            this.BackspaceButton.Text = "Del";
            this.BackspaceButton.UseVisualStyleBackColor = true;
            this.BackspaceButton.Click += new System.EventHandler(this.BackspaceButton_Click);
            // 
            // DivideButton
            // 
            this.DivideButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DivideButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DivideButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.DivideButton.Location = new System.Drawing.Point(270, 0);
            this.DivideButton.Margin = new System.Windows.Forms.Padding(0);
            this.DivideButton.Name = "DivideButton";
            this.DivideButton.Size = new System.Drawing.Size(92, 76);
            this.DivideButton.TabIndex = 7;
            this.DivideButton.Text = "/";
            this.DivideButton.UseVisualStyleBackColor = true;
            this.DivideButton.Click += new System.EventHandler(this.DivideButton_Click);
            // 
            // DecimalButton
            // 
            this.DecimalButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DecimalButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DecimalButton.Location = new System.Drawing.Point(180, 304);
            this.DecimalButton.Margin = new System.Windows.Forms.Padding(0);
            this.DecimalButton.Name = "DecimalButton";
            this.DecimalButton.Size = new System.Drawing.Size(90, 77);
            this.DecimalButton.TabIndex = 4;
            this.DecimalButton.Text = ".";
            this.DecimalButton.UseVisualStyleBackColor = true;
            this.DecimalButton.Click += new System.EventHandler(this.DecimalButton);
            // 
            // EqualsButton
            // 
            this.EqualsButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EqualsButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EqualsButton.Location = new System.Drawing.Point(270, 304);
            this.EqualsButton.Margin = new System.Windows.Forms.Padding(0);
            this.EqualsButton.Name = "EqualsButton";
            this.EqualsButton.Size = new System.Drawing.Size(92, 77);
            this.EqualsButton.TabIndex = 3;
            this.EqualsButton.Text = "=";
            this.EqualsButton.UseVisualStyleBackColor = true;
            this.EqualsButton.Click += new System.EventHandler(this.EqualsButton_Click);
            // 
            // ZeroButton
            // 
            this.ButtonLayoutPanel.SetColumnSpan(this.ZeroButton, 2);
            this.ZeroButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ZeroButton.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ZeroButton.Location = new System.Drawing.Point(0, 304);
            this.ZeroButton.Margin = new System.Windows.Forms.Padding(0);
            this.ZeroButton.Name = "ZeroButton";
            this.ZeroButton.Size = new System.Drawing.Size(180, 77);
            this.ZeroButton.TabIndex = 5;
            this.ZeroButton.Text = "0";
            this.ZeroButton.UseVisualStyleBackColor = true;
            this.ZeroButton.Click += new System.EventHandler(this.ZeroButton_Click);
            // 
            // CalculatorBase
            // 
            this.AcceptButton = this.EqualsButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.CEButton;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.ButtonLayoutPanel);
            this.Controls.Add(this.NumberInput);
            this.MinimumSize = new System.Drawing.Size(250, 330);
            this.Name = "CalculatorBase";
            this.Text = "WinForms Calculator";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ButtonLayoutPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox NumberInput;
        private TableLayoutPanel ButtonLayoutPanel;
        private Button CEButton;
        private Button EqualsButton;
        private Button BackspaceButton;
        private Button PlusButton;
        private Button ThreeButton;
        private Button TwoButton;
        private Button OneButton;
        private Button MinusButton;
        private Button SixButton;
        private Button FiveButton;
        private Button FourButton;
        private Button MultiplyButton;
        private Button NineButton;
        private Button EightButton;
        private Button SevenButton;
        private Button ZeroButton;
        private Button DecimalButton;
        private Button DivideButton;
    }
}