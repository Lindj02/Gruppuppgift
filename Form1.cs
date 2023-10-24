using Microsoft.VisualBasic.ApplicationServices;
using System.Windows.Forms;

namespace Gruppuppgift
{
    public partial class Form1 : Form
    {
        private List<Recept> recepts;
        private User user;

        List<string> categories = new List<string>
        {
            "Kött",
            "Fisk",
            "Sallader",
            "Soppor",
            "Desserter/Kakor",
            "Vegetariskt",
        };


        public Form1()
        {
            InitializeComponent();
            recepts = new List<Recept>();
            LoadDataFromFile();
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
                    recepts.Add(recept);
                }
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCategory = comboBox.SelectedItem.ToString();
            comboBox1.Items.Clear();
            foreach (Recept recept in recepts)
            {
                if (recept.Type == selectedCategory)
                {
                    comboBox1.Items.Add(recept.Title);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // När en rad väljs i comboBox1, visas informationen i listBoxRecipe.
            string selectedRecipeTitle = comboBox1.SelectedItem.ToString();
            listBoxRecipe.Items.Clear();
            foreach (Recept recept in recepts)
            {
                if (recept.Title == selectedRecipeTitle)
                {
                    listBoxRecipe.Items.Add("Titel: " + recept.Title);
                    listBoxRecipe.Items.Add("Beskrivning: " + recept.Description);
                    listBoxRecipe.Items.Add("Kategori: " + recept.Type);
                }
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
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text;
            listBoxRecipe.Items.Clear();

            foreach (Recept recept in recepts)
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