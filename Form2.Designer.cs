namespace Gruppuppgift
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtTitel = new TextBox();
            comboBox1 = new ComboBox();
            textBox1 = new TextBox();
            txtDescription = new TextBox();
            btnSave = new Button();
            btnAbort = new Button();
            label4 = new Label();
            label5 = new Label();
            picAdress = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(94, 44);
            label1.Name = "label1";
            label1.Size = new Size(29, 15);
            label1.TabIndex = 0;
            label1.Text = "Titel";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(94, 80);
            label2.Name = "label2";
            label2.Size = new Size(25, 15);
            label2.TabIndex = 1;
            label2.Text = "Typ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(94, 104);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 2;
            label3.Text = "Ny Typ";
            // 
            // txtTitel
            // 
            txtTitel.Location = new Point(180, 39);
            txtTitel.Margin = new Padding(3, 2, 3, 2);
            txtTitel.Name = "txtTitel";
            txtTitel.Size = new Size(264, 23);
            txtTitel.TabIndex = 5;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(180, 74);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(264, 23);
            comboBox1.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(180, 99);
            textBox1.Margin = new Padding(3, 2, 3, 2);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(264, 23);
            textBox1.TabIndex = 8;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(94, 177);
            txtDescription.Margin = new Padding(3, 2, 3, 2);
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(397, 26);
            txtDescription.TabIndex = 10;
            txtDescription.TextChanged += txtDescription_TextChanged;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(94, 260);
            btnSave.Margin = new Padding(3, 2, 3, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(82, 22);
            btnSave.TabIndex = 11;
            btnSave.Text = "Spara";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnAbort
            // 
            btnAbort.Location = new Point(361, 260);
            btnAbort.Margin = new Padding(3, 2, 3, 2);
            btnAbort.Name = "btnAbort";
            btnAbort.Size = new Size(82, 22);
            btnAbort.TabIndex = 12;
            btnAbort.Text = "Avbryt";
            btnAbort.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(259, 152);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 13;
            label4.Text = "Beskrivning";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(94, 130);
            label5.Name = "label5";
            label5.Size = new Size(51, 15);
            label5.TabIndex = 14;
            label5.Text = "Bildkälla";
            // 
            // picAdress
            // 
            picAdress.Location = new Point(180, 128);
            picAdress.Margin = new Padding(3, 2, 3, 2);
            picAdress.Name = "picAdress";
            picAdress.Size = new Size(264, 23);
            picAdress.TabIndex = 15;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1570, 636);
            Controls.Add(picAdress);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(btnAbort);
            Controls.Add(btnSave);
            Controls.Add(txtDescription);
            Controls.Add(textBox1);
            Controls.Add(comboBox1);
            Controls.Add(txtTitel);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtTitel;
        private ComboBox comboBox1;
        private TextBox textBox1;
        private TextBox txtDescription;
        private Button btnSave;
        private Button btnAbort;
        private Label label4;
        private Label label5;
        private TextBox picAdress;
    }
}