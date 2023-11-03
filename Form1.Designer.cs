namespace Gruppuppgift
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
            btnAdd = new Button();
            btnDelete = new Button();
            txtSearch = new TextBox();
            txtUserName = new TextBox();
            txtPassword = new TextBox();
            lblUserName = new Label();
            lblPassWord = new Label();
            btnLogIn = new Button();
            lblSearch = new Label();
            lblCategory = new Label();
            comboBox = new ComboBox();
            txtTitle = new TextBox();
            btnLogout = new Button();
            label1 = new Label();
            txtDescription1 = new TextBox();
            lblCat = new Label();
            txtCat = new TextBox();
            btnSave = new Button();
            openFileDialog1 = new OpenFileDialog();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(323, 416);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(624, 254);
            dataGridView1.TabIndex = 0;
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(442, 677);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(90, 30);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Rensa";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Visible = false;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(844, 677);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(90, 30);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Ta bort";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Visible = false;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(416, 76);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(442, 23);
            txtSearch.TabIndex = 4;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(1396, 585);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(124, 23);
            txtUserName.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(1396, 630);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(124, 23);
            txtPassword.TabIndex = 7;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(1261, 588);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(92, 15);
            lblUserName.TabIndex = 8;
            lblUserName.Text = "Användarnamn:";
            // 
            // lblPassWord
            // 
            lblPassWord.AutoSize = true;
            lblPassWord.Location = new Point(1295, 633);
            lblPassWord.Name = "lblPassWord";
            lblPassWord.Size = new Size(59, 15);
            lblPassWord.TabIndex = 9;
            lblPassWord.Text = "Lösenord:";
            // 
            // btnLogIn
            // 
            btnLogIn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogIn.Location = new Point(1282, 676);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(77, 30);
            btnLogIn.TabIndex = 10;
            btnLogIn.Text = "Logga in";
            btnLogIn.UseVisualStyleBackColor = true;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(323, 80);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(26, 15);
            lblSearch.TabIndex = 12;
            lblSearch.Text = "Sök";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(323, 112);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(54, 15);
            lblCategory.TabIndex = 13;
            lblCategory.Text = "Kategori:";
            // 
            // comboBox
            // 
            comboBox.FormattingEnabled = true;
            comboBox.Location = new Point(416, 112);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(442, 23);
            comboBox.TabIndex = 15;
            comboBox.SelectedIndexChanged += comboBox_SelectedIndexChanged;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(416, 182);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(442, 23);
            txtTitle.TabIndex = 18;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogout.Location = new Point(1438, 676);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(80, 30);
            btnLogout.TabIndex = 21;
            btnLogout.Text = "Logga Ut";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(563, 206);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 22;
            label1.Text = "Beskrivning";
            // 
            // txtDescription1
            // 
            txtDescription1.Location = new Point(323, 229);
            txtDescription1.Margin = new Padding(3, 2, 3, 2);
            txtDescription1.Multiline = true;
            txtDescription1.Name = "txtDescription1";
            txtDescription1.Size = new Size(624, 170);
            txtDescription1.TabIndex = 23;
            // 
            // lblCat
            // 
            lblCat.AutoSize = true;
            lblCat.Location = new Point(323, 150);
            lblCat.Name = "lblCat";
            lblCat.Size = new Size(72, 15);
            lblCat.TabIndex = 26;
            lblCat.Text = "Ny Kategori:";
            lblCat.Visible = false;
            // 
            // txtCat
            // 
            txtCat.Location = new Point(416, 145);
            txtCat.Name = "txtCat";
            txtCat.Size = new Size(442, 23);
            txtCat.TabIndex = 27;
            txtCat.Visible = false;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(323, 677);
            btnSave.Margin = new Padding(2, 2, 2, 2);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(83, 30);
            btnSave.TabIndex = 0;
            btnSave.Text = "Spara";
            btnSave.Visible = false;
            btnSave.Click += btnSave_Click_1;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(323, 184);
            label4.Name = "label4";
            label4.Size = new Size(29, 15);
            label4.TabIndex = 32;
            label4.Text = "Titel";
            label4.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1620, 765);
            Controls.Add(label4);
            Controls.Add(btnSave);
            Controls.Add(txtCat);
            Controls.Add(lblCat);
            Controls.Add(txtDescription1);
            Controls.Add(label1);
            Controls.Add(btnLogout);
            Controls.Add(txtTitle);
            Controls.Add(comboBox);
            Controls.Add(lblCategory);
            Controls.Add(lblSearch);
            Controls.Add(btnLogIn);
            Controls.Add(lblPassWord);
            Controls.Add(lblUserName);
            Controls.Add(txtPassword);
            Controls.Add(txtUserName);
            Controls.Add(txtSearch);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        internal DataGridView dataGridView1;
        internal Button btnAdd;
        private TextBox txtSearch;
        internal TextBox txtUserName;
        internal TextBox txtPassword;
        internal Label lblUserName;
        private Label lblPassWord;
        private Label lblSearch;
        private Label lblCategory;
        internal ComboBox comboBox;
        private TextBox txtTitle;
        internal Button btnLogout;
        private Label label1;
        private TextBox txtDescription1;
        internal Label lblCat;
        internal TextBox txtCat;
        internal Button btnSave;
        private OpenFileDialog openFileDialog1;
        internal Button btnDelete;
        internal Button btnLogIn;
        internal Label label4;
    }
}