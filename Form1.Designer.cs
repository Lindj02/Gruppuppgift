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
            pictureBoxRecipe = new PictureBox();
            txtTitle = new TextBox();
            comboBox1 = new ComboBox();
            btnLogout = new Button();
            label1 = new Label();
            txtDescription1 = new TextBox();
            lblpicturePath = new Label();
            lblCat = new Label();
            txtCat = new TextBox();
            btnSave = new Button();
            openFileDialog1 = new OpenFileDialog();
            txtPictures = new TextBox();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRecipe).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(369, 555);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(713, 339);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.RowHeaderMouseClick += dataGridView1_RowHeaderMouseClick;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnAdd.Location = new Point(505, 903);
            btnAdd.Margin = new Padding(3, 4, 3, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(103, 40);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Rensa";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Visible = false;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnDelete.Location = new Point(965, 903);
            btnDelete.Margin = new Padding(3, 4, 3, 4);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(103, 40);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Ta bort";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Visible = false;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(475, 101);
            txtSearch.Margin = new Padding(3, 4, 3, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(505, 27);
            txtSearch.TabIndex = 4;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // txtUserName
            // 
            txtUserName.Location = new Point(1595, 780);
            txtUserName.Margin = new Padding(3, 4, 3, 4);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(141, 27);
            txtUserName.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(1595, 840);
            txtPassword.Margin = new Padding(3, 4, 3, 4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(141, 27);
            txtPassword.TabIndex = 7;
            // 
            // lblUserName
            // 
            lblUserName.AutoSize = true;
            lblUserName.Location = new Point(1441, 784);
            lblUserName.Name = "lblUserName";
            lblUserName.Size = new Size(112, 20);
            lblUserName.TabIndex = 8;
            lblUserName.Text = "Användarnamn:";
            // 
            // lblPassWord
            // 
            lblPassWord.AutoSize = true;
            lblPassWord.Location = new Point(1480, 844);
            lblPassWord.Name = "lblPassWord";
            lblPassWord.Size = new Size(73, 20);
            lblPassWord.TabIndex = 9;
            lblPassWord.Text = "Lösenord:";
            // 
            // btnLogIn
            // 
            btnLogIn.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogIn.Location = new Point(1465, 901);
            btnLogIn.Margin = new Padding(3, 4, 3, 4);
            btnLogIn.Name = "btnLogIn";
            btnLogIn.Size = new Size(88, 40);
            btnLogIn.TabIndex = 10;
            btnLogIn.Text = "Logga in";
            btnLogIn.UseVisualStyleBackColor = true;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(369, 107);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(33, 20);
            lblSearch.TabIndex = 12;
            lblSearch.Text = "Sök";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(369, 150);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(69, 20);
            lblCategory.TabIndex = 13;
            lblCategory.Text = "Kategori:";
            // 
            // comboBox
            // 
            comboBox.FormattingEnabled = true;
            comboBox.Location = new Point(475, 150);
            comboBox.Margin = new Padding(3, 4, 3, 4);
            comboBox.Name = "comboBox";
            comboBox.Size = new Size(505, 28);
            comboBox.TabIndex = 15;
            comboBox.SelectedIndexChanged += comboBox_SelectedIndexChanged;
            // 
            // pictureBoxRecipe
            // 
            pictureBoxRecipe.Location = new Point(15, 231);
            pictureBoxRecipe.Margin = new Padding(3, 4, 3, 4);
            pictureBoxRecipe.Name = "pictureBoxRecipe";
            pictureBoxRecipe.Size = new Size(329, 400);
            pictureBoxRecipe.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxRecipe.TabIndex = 17;
            pictureBoxRecipe.TabStop = false;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(475, 243);
            txtTitle.Margin = new Padding(3, 4, 3, 4);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(505, 27);
            txtTitle.TabIndex = 18;
            txtTitle.TextChanged += txtTitle_TextChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(1119, 163);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(505, 28);
            comboBox1.TabIndex = 20;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            btnLogout.Location = new Point(1643, 901);
            btnLogout.Margin = new Padding(3, 4, 3, 4);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(91, 40);
            btnLogout.TabIndex = 21;
            btnLogout.Text = "Logga Ut";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(643, 274);
            label1.Name = "label1";
            label1.Size = new Size(84, 20);
            label1.TabIndex = 22;
            label1.Text = "Beskrivning";
            label1.Click += label1_Click;
            // 
            // txtDescription1
            // 
            txtDescription1.Location = new Point(369, 305);
            txtDescription1.Multiline = true;
            txtDescription1.Name = "txtDescription1";
            txtDescription1.Size = new Size(713, 226);
            txtDescription1.TabIndex = 23;
            // 
            // lblpicturePath
            // 
            lblpicturePath.AutoSize = true;
            lblpicturePath.Location = new Point(1119, 60);
            lblpicturePath.Name = "lblpicturePath";
            lblpicturePath.Size = new Size(35, 20);
            lblpicturePath.TabIndex = 24;
            lblpicturePath.Text = "Bild";
            lblpicturePath.Visible = false;
            // 
            // lblCat
            // 
            lblCat.AutoSize = true;
            lblCat.Location = new Point(369, 200);
            lblCat.Name = "lblCat";
            lblCat.Size = new Size(91, 20);
            lblCat.TabIndex = 26;
            lblCat.Text = "Ny Kategori:";
            lblCat.Visible = false;
            // 
            // txtCat
            // 
            txtCat.Location = new Point(475, 193);
            txtCat.Margin = new Padding(3, 4, 3, 4);
            txtCat.Name = "txtCat";
            txtCat.Size = new Size(505, 27);
            txtCat.TabIndex = 27;
            txtCat.Visible = false;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(369, 903);
            btnSave.Margin = new Padding(2, 3, 2, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(95, 40);
            btnSave.TabIndex = 0;
            btnSave.Text = "Spara";
            btnSave.Visible = false;
            btnSave.Click += btnSave_Click_1;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtPictures
            // 
            txtPictures.Location = new Point(1119, 116);
            txtPictures.Margin = new Padding(3, 4, 3, 4);
            txtPictures.Name = "txtPictures";
            txtPictures.Size = new Size(505, 27);
            txtPictures.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(369, 246);
            label4.Name = "label4";
            label4.Size = new Size(38, 20);
            label4.TabIndex = 32;
            label4.Text = "Titel";
            label4.Visible = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1851, 1020);
            Controls.Add(label4);
            Controls.Add(txtPictures);
            Controls.Add(btnSave);
            Controls.Add(txtCat);
            Controls.Add(lblCat);
            Controls.Add(lblpicturePath);
            Controls.Add(txtDescription1);
            Controls.Add(label1);
            Controls.Add(btnLogout);
            Controls.Add(comboBox1);
            Controls.Add(txtTitle);
            Controls.Add(pictureBoxRecipe);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxRecipe).EndInit();
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
        private PictureBox pictureBoxRecipe;
        private TextBox txtTitle;
        internal ComboBox comboBox1;
        internal Button btnLogout;
        private Label label1;
        private TextBox txtDescription1;
        internal Label lblpicturePath;
        internal Label lblCat;
        internal TextBox txtCat;
        internal Button btnSave;
        private OpenFileDialog openFileDialog1;
        internal Button btnDelete;
        internal Button btnLogIn;
        internal TextBox txtPictures;
        internal Label label4;
    }
}