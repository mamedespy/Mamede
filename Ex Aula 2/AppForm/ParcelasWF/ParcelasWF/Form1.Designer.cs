namespace ParcelasWF
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
            ValorLabel = new Label();
            dataGridView1 = new DataGridView();
            Parcelas = new DataGridViewTextBoxColumn();
            Varlor = new DataGridViewTextBoxColumn();
            ValorTextBox = new TextBox();
            ParcelasLabel = new Label();
            ParcelasTextBox = new TextBox();
            CalcBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // ValorLabel
            // 
            ValorLabel.AutoSize = true;
            ValorLabel.Location = new Point(12, 9);
            ValorLabel.Name = "ValorLabel";
            ValorLabel.Size = new Size(33, 15);
            ValorLabel.TabIndex = 0;
            ValorLabel.Text = "Valor";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Parcelas, Varlor });
            dataGridView1.Location = new Point(12, 93);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(240, 345);
            dataGridView1.TabIndex = 1;
            // 
            // Parcelas
            // 
            Parcelas.HeaderText = "Parcelas";
            Parcelas.Name = "Parcelas";
            Parcelas.ReadOnly = true;
            // 
            // Varlor
            // 
            Varlor.HeaderText = "Valor";
            Varlor.Name = "Varlor";
            Varlor.ReadOnly = true;
            // 
            // ValorTextBox
            // 
            ValorTextBox.Location = new Point(68, 6);
            ValorTextBox.Name = "ValorTextBox";
            ValorTextBox.Size = new Size(184, 23);
            ValorTextBox.TabIndex = 2;
            // 
            // ParcelasLabel
            // 
            ParcelasLabel.AutoSize = true;
            ParcelasLabel.Location = new Point(12, 38);
            ParcelasLabel.Name = "ParcelasLabel";
            ParcelasLabel.Size = new Size(50, 15);
            ParcelasLabel.TabIndex = 0;
            ParcelasLabel.Text = "Parcelas";
            // 
            // ParcelasTextBox
            // 
            ParcelasTextBox.Location = new Point(68, 35);
            ParcelasTextBox.Name = "ParcelasTextBox";
            ParcelasTextBox.Size = new Size(184, 23);
            ParcelasTextBox.TabIndex = 2;
            // 
            // CalcBtn
            // 
            CalcBtn.Location = new Point(176, 64);
            CalcBtn.Name = "CalcBtn";
            CalcBtn.Size = new Size(75, 23);
            CalcBtn.TabIndex = 3;
            CalcBtn.Text = "Calcular";
            CalcBtn.UseVisualStyleBackColor = true;
            CalcBtn.Click += CalcBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(263, 450);
            Controls.Add(CalcBtn);
            Controls.Add(ParcelasTextBox);
            Controls.Add(ValorTextBox);
            Controls.Add(ParcelasLabel);
            Controls.Add(dataGridView1);
            Controls.Add(ValorLabel);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ValorLabel;
        private DataGridView dataGridView1;
        private TextBox ValorTextBox;
        private Label ParcelasLabel;
        private TextBox ParcelasTextBox;
        private DataGridViewTextBoxColumn Parcelas;
        private DataGridViewTextBoxColumn Varlor;
        private Button CalcBtn;
    }
}