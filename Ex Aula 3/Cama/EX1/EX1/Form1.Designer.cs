namespace EX1
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
            label1 = new Label();
            label2 = new Label();
            radioButton1 = new RadioButton();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            label3 = new Label();
            button1 = new Button();
            label4 = new Label();
            radioButton5 = new RadioButton();
            radioButton6 = new RadioButton();
            menuStrip1 = new MenuStrip();
            sairToolStripMenuItem = new ToolStripMenuItem();
            ajudaToolStripMenuItem = new ToolStripMenuItem();
            somaToolStripMenuItem = new ToolStripMenuItem();
            subtraçãoToolStripMenuItem = new ToolStripMenuItem();
            multiplicaçãoToolStripMenuItem = new ToolStripMenuItem();
            divisãoToolStripMenuItem = new ToolStripMenuItem();
            médiaToolStripMenuItem = new ToolStripMenuItem();
            quadradoToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 65);
            label1.Name = "label1";
            label1.Size = new Size(45, 15);
            label1.TabIndex = 0;
            label1.Text = "Valor 1:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(47, 115);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 1;
            label2.Text = "Valor 2:";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(102, 196);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(59, 19);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "Somar";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(102, 62);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            textBox1.Text = "0";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(102, 112);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            textBox2.Text = "0";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(102, 221);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(66, 19);
            radioButton2.TabIndex = 6;
            radioButton2.TabStop = true;
            radioButton2.Text = "Subtrair";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(102, 246);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(82, 19);
            radioButton3.TabIndex = 7;
            radioButton3.TabStop = true;
            radioButton3.Text = "Multiplicar";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(102, 271);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(59, 19);
            radioButton4.TabIndex = 8;
            radioButton4.TabStop = true;
            radioButton4.Text = "Dividir";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 164);
            label3.Name = "label3";
            label3.Size = new Size(170, 15);
            label3.TabIndex = 9;
            label3.Text = "Selecione a operação desejada:";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(180, 364);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "Calcular";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(147, 404);
            label4.Name = "label4";
            label4.Size = new Size(145, 37);
            label4.TabIndex = 11;
            label4.Text = "Resultado";
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(102, 296);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(58, 19);
            radioButton5.TabIndex = 12;
            radioButton5.TabStop = true;
            radioButton5.Text = "Média";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(102, 321);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(78, 19);
            radioButton6.TabIndex = 13;
            radioButton6.TabStop = true;
            radioButton6.Text = "Quadrado";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { sairToolStripMenuItem, ajudaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(445, 24);
            menuStrip1.TabIndex = 16;
            menuStrip1.Text = "menuStrip1";
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(38, 20);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // ajudaToolStripMenuItem
            // 
            ajudaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { somaToolStripMenuItem, subtraçãoToolStripMenuItem, multiplicaçãoToolStripMenuItem, divisãoToolStripMenuItem, médiaToolStripMenuItem, quadradoToolStripMenuItem });
            ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            ajudaToolStripMenuItem.Size = new Size(50, 20);
            ajudaToolStripMenuItem.Text = "Ajuda";
            // 
            // somaToolStripMenuItem
            // 
            somaToolStripMenuItem.Name = "somaToolStripMenuItem";
            somaToolStripMenuItem.Size = new Size(146, 22);
            somaToolStripMenuItem.Text = "Soma";
            somaToolStripMenuItem.Click += somaToolStripMenuItem_Click;
            // 
            // subtraçãoToolStripMenuItem
            // 
            subtraçãoToolStripMenuItem.Name = "subtraçãoToolStripMenuItem";
            subtraçãoToolStripMenuItem.Size = new Size(146, 22);
            subtraçãoToolStripMenuItem.Text = "Subtração";
            subtraçãoToolStripMenuItem.Click += subtraçãoToolStripMenuItem_Click;
            // 
            // multiplicaçãoToolStripMenuItem
            // 
            multiplicaçãoToolStripMenuItem.Name = "multiplicaçãoToolStripMenuItem";
            multiplicaçãoToolStripMenuItem.Size = new Size(146, 22);
            multiplicaçãoToolStripMenuItem.Text = "Multiplicação";
            multiplicaçãoToolStripMenuItem.Click += multiplicaçãoToolStripMenuItem_Click;
            // 
            // divisãoToolStripMenuItem
            // 
            divisãoToolStripMenuItem.Name = "divisãoToolStripMenuItem";
            divisãoToolStripMenuItem.Size = new Size(146, 22);
            divisãoToolStripMenuItem.Text = "Divisão";
            divisãoToolStripMenuItem.Click += divisãoToolStripMenuItem_Click;
            // 
            // médiaToolStripMenuItem
            // 
            médiaToolStripMenuItem.Name = "médiaToolStripMenuItem";
            médiaToolStripMenuItem.Size = new Size(146, 22);
            médiaToolStripMenuItem.Text = "Média";
            médiaToolStripMenuItem.Click += médiaToolStripMenuItem_Click;
            // 
            // quadradoToolStripMenuItem
            // 
            quadradoToolStripMenuItem.Name = "quadradoToolStripMenuItem";
            quadradoToolStripMenuItem.Size = new Size(146, 22);
            quadradoToolStripMenuItem.Text = "Quadrado";
            quadradoToolStripMenuItem.Click += quadradoToolStripMenuItem_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(445, 450);
            Controls.Add(radioButton6);
            Controls.Add(radioButton5);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(radioButton1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private RadioButton radioButton1;
        private TextBox textBox1;
        private TextBox textBox2;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Label label3;
        private Button button1;
        private Label label4;
        private RadioButton radioButton5;
        private RadioButton radioButton6;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem ajudaToolStripMenuItem;
        private ToolStripMenuItem somaToolStripMenuItem;
        private ToolStripMenuItem subtraçãoToolStripMenuItem;
        private ToolStripMenuItem multiplicaçãoToolStripMenuItem;
        private ToolStripMenuItem divisãoToolStripMenuItem;
        private ToolStripMenuItem médiaToolStripMenuItem;
        private ToolStripMenuItem quadradoToolStripMenuItem;
    }
}