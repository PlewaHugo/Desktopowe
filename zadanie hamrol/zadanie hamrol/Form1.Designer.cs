﻿namespace zadanie_hamrol
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
            richTextBox1 = new RichTextBox();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            textBox4 = new TextBox();
            button1 = new Button();
            textBox5 = new TextBox();
            label6 = new Label();
            label7 = new Label();
            richTextBox2 = new RichTextBox();
            label3 = new Label();
            textBox2 = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(2, 37);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(530, 86);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(553, 95);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(182, 23);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(27, 6);
            label1.Name = "label1";
            label1.Size = new Size(216, 28);
            label1.TabIndex = 2;
            label1.Text = "Tekst wejściowy: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(553, 77);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 3;
            label2.Text = "Długość tekstu: ";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(553, 129);
            label5.Name = "label5";
            label5.Size = new Size(144, 15);
            label5.TabIndex = 6;
            label5.Text = "Występują znaki specjalne";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(553, 147);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(182, 23);
            textBox4.TabIndex = 9;
            // 
            // button1
            // 
            button1.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(553, 367);
            button1.Name = "button1";
            button1.Size = new Size(200, 71);
            button1.TabIndex = 10;
            button1.Text = "Przeprowadź analizę";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(553, 325);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(182, 23);
            textBox5.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(553, 307);
            label6.Name = "label6";
            label6.Size = new Size(110, 15);
            label6.TabIndex = 12;
            label6.Text = "Czas działania kodu";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial Rounded MT Bold", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(27, 129);
            label7.Name = "label7";
            label7.Size = new Size(153, 28);
            label7.TabIndex = 13;
            label7.Text = "Statystyka : ";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(2, 158);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(530, 280);
            richTextBox2.TabIndex = 14;
            richTextBox2.Text = "";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(553, 182);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 15;
            label3.Text = "Entropia:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(553, 203);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(182, 23);
            textBox2.TabIndex = 16;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(label3);
            Controls.Add(richTextBox2);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox5);
            Controls.Add(button1);
            Controls.Add(textBox4);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(richTextBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label5;
        private TextBox textBox4;
        private Button button1;
        private TextBox textBox5;
        private Label label6;
        private Label label7;
        private RichTextBox richTextBox2;
        private Label label3;
        private TextBox textBox2;
        private OpenFileDialog openFileDialog1;
    }
}