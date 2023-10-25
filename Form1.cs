using Microsoft.VisualBasic.ApplicationServices;
using System.ComponentModel;
using System.Windows.Forms;

namespace Gruppuppgift
{
    public partial class Form1 : Form
    {
        private BindingList<Recept> receptsBindingList;
        private User user;
        string filePath = @"C:\Temp\Recept.txt";
        HashSet<string> categories = new HashSet<string>();


        public Form1()
        {
            InitializeComponent();
            receptsBindingList = new BindingList<Recept>();
            LoadDataFromFile();
            categories.Add("Alla kategorier");
            comboBox.Items.AddRange(categories.ToArray());
            User user = new User(txtUserName.Text, txtPassword.Text);

        }



        private void LoadDataFromFile()
        {


            using (StreamReader reader = new StreamReader(filePath))
            {
                string rad;
                while ((rad = reader.ReadLine()) != null)
                {
                    string[] columnNames = rad.Split('|');
                    string title = columnNames[0];
                    string description = columnNames[1];
                    string type = columnNames[2];

                    Recept recept = new Recept { Title = title, Description = description, Type = type };
                    receptsBindingList.Add(recept);
                    categories.Add(type);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        public void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = comboBox.SelectedItem.ToString();
            comboBox1.Items.Clear();

            if (selectedCategory == "Alla kategorier")
            {
                // om man vill se alla recept så loopar den igenom textfilen
                foreach (Recept recept in receptsBindingList)
                {
                    comboBox1.Items.Add(recept.Title);
                }
            }
            else
            {
                // Visa receptet i valda kategorin
                foreach (Recept recept in receptsBindingList)
                {
                    if (recept.Type == selectedCategory)
                    {
                        comboBox1.Items.Add(recept.Title);
                    }
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedRecipeTitle = comboBox1.SelectedItem.ToString();
            dataGridView1.DataSource = null;

            var selectedRecept = receptsBindingList.FirstOrDefault(recept => recept.Title == selectedRecipeTitle);

            if (selectedRecept != null)
            {
                dataGridView1.DataSource = new BindingList<Recept> { selectedRecept };
            }
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            string inputUsername = txtUserName.Text;
            string inputPassword = txtPassword.Text;

            user = new User(inputUsername, inputPassword);

            if (user.Authenticate(inputUsername, inputPassword))
            {
                // 
                btnAdd.Visible = true;
                btnDelete.Visible = true;
                //btnUpdate.Visible = true;
                btnLogout.Visible = true;
                lblpicturePath.Visible = true;
                txtpicturePath.Visible = true;
                lblCat.Visible = true;
                txtCat.Visible = true;
                btnLogIn.Visible = false;
                btnSave.Visible = true;
                MessageBox.Show("Du är nu inloggad och kan ändra recept");
                txtUserName.Text = "";
                txtPassword.Text = "";
            }
            else
            {
                MessageBox.Show("Fel användarnamn eller lösenord. Försök igen.");
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (user != null)
            {
                user.Logout();

                // Göm admin-knapparna
                btnAdd.Visible = false;
                btnDelete.Visible = false;
                //btnUpdate.Visible = false;
                btnLogIn.Visible = true;
                btnSave.Visible = false;
                btnLogout.Visible = false;
                lblpicturePath.Visible = false;
                txtpicturePath.Visible = false;
                lblCat.Visible = false;
                txtCat.Visible = false;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text;
            listBoxRecipe.Items.Clear();

            foreach (Recept recept in receptsBindingList)
            {
                if (recept.Title.Contains(searchTerm) || recept.Description.Contains(searchTerm) || recept.Type.Contains(searchTerm))
                {
                    listBoxRecipe.Items.Add("Titel: " + recept.Title);
                    listBoxRecipe.Items.Add("Beskrivning: " + recept.Description);
                    listBoxRecipe.Items.Add("Kategori: " + recept.Type);
                    listBoxRecipe.Items.Add(""); // Lägg till en tom rad mellan varje recept
                }
            }
        }

        // Öppnar form2.cs
        private void btnAdd_Click(object sender, EventArgs e)
        {
            new Form2().ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        public void SaveRecept(string Titel, string Description, string Type)
        {

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine($"{Titel}|{Description}|{Type}");
            }
            MessageBox.Show("Du har sparat i textfilen!");
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            SaveRecept(txtTitle.Text, txtDescription1.Text, txtCat.Text);
        }

        //private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    if (e.RowIndex >= 0) // För att säkerställa att det inte är header-cell som klickas på
        //    {
        //        Recept selectedRecept = (Recept)dataGridView1.Rows[e.RowIndex].DataBoundItem;
        //        txtDescription1.Text = selectedRecept.Description;
        //    }
        //}

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0) // För att säkerställa att det inte är header-cell som klickas på
            {
                Recept selectedRecept = (Recept)dataGridView1.Rows[e.RowIndex].DataBoundItem;
                if (selectedRecept != null)
                {
                    txtDescription1.Text = selectedRecept.Description;
                }
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string searchText = txtSearch.Text.ToLower();


            var filteredList = new BindingList<Recept>(receptsBindingList
                .Where(x => x.Title.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0 || x.Type.IndexOf(searchText, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList());

            dataGridView1.DataSource = filteredList;
        }

        //private void btnUpdate_Click(object sender, EventArgs e)
        //{
        //    UpdateRecept(int rowIndex, string Titel, string Description, string Type)
        //}
        //public void UpdateRecept(int rowIndex, string Titel, string Description, string Type)
        //{
        //string[] lines = File.ReadAllLines(filePath);
        //lines[rowIndex] = $"{Titel},{Description},{Type}";
        //File.WriteAllLines(filePath, lines);

        //    LoadDataFromFile(); //Hämtar den senaste uppgifter från filen
        //}
    }
}
