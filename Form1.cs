using Microsoft.VisualBasic.ApplicationServices;
using System.ComponentModel;
using System.Windows.Forms;

namespace Gruppuppgift
{
    public partial class Form1 : Form
    {
        private BindingList<Recept> receptsBindingList;
        private User user;

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

            string filePath = @"C:\Temp\Recept.txt";
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
                btnUpdate.Visible = true;
                btnLogout.Visible = true;
                lblpicturePath.Visible = true;
                txtpicturePath.Visible = true;
                lblCat.Visible = true;
                txtCat.Visible = true;
                btnLogIn.Visible = false;
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
                btnUpdate.Visible = false;
                btnLogIn.Visible = true;
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


        /* private void scrollbarK_Scroll(object sender, ScrollEventArgs e)
         {

         }*/
    }
}
