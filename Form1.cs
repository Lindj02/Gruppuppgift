using System.Windows.Forms;

namespace Gruppuppgift
{
    public partial class Form1 : Form
    {
        private List<Recept> recepts;

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
            // När en rad väljs i comboBox1, visa informationen i listBoxRecipe.
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

        /* private void scrollbarK_Scroll(object sender, ScrollEventArgs e)
         {

         }*/
    }
}