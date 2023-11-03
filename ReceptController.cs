using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gruppuppgift

{
    public class ReceptController
    {
        private Form1 view;
        private BindingList<Recept> receptsBindingList;
        private User user;

        public ReceptController(Form1 view, BindingList<Recept> receptsBindingList)
        {
            this.view = view;
            this.receptsBindingList = receptsBindingList;

            // Koppla händelser
            view.btnLogIn.Click += BtnLogIn_Click;
            view.btnLogout.Click += BtnLogout_Click;
            view.btnDelete.Click += BtnDelete_Click;
            view.btnAdd.Click += BtnAdd_Click;
        }


        internal void BtnLogIn_Click(object sender, EventArgs e)
        {

            string inputUsername = view.txtUserName.Text;
            string inputPassword = view.txtPassword.Text;

            user = new User();

            if (user.Authenticate(inputUsername, inputPassword))
            {
                // 
                view.btnAdd.Visible = true;
                view.btnDelete.Visible = true;

                view.btnLogout.Visible = true;

                view.lblCat.Visible = true;
                view.txtCat.Visible = true;
                view.btnLogIn.Visible = false;
                view.btnSave.Visible = true;
                MessageBox.Show("Du är nu inloggad och kan ändra recept");
                view.txtUserName.Text = "";
                view.txtPassword.Text = "";
            }
            else
            {
                MessageBox.Show("Fel användarnamn eller lösenord. Försök igen.");
            }
        }

        internal void BtnLogout_Click(object sender, EventArgs e)
        {
            if (user != null)
            {
                user.Logout();
                view.btnAdd.Visible = false;
                view.btnDelete.Visible = false;
                view.btnLogIn.Visible = true;
                view.btnSave.Visible = false;
                view.btnLogout.Visible = false;
                view.lblCat.Visible = false;
                view.txtCat.Visible = false;
            }
        }

       

        internal void BtnAdd_Click(object sender, EventArgs e) //Rensa egentligen, fel namn på knappen
        {
            view.TxtTitle.Clear();
            view.TxtDescription.Clear();
            view.TxtCat.Clear();
            view.SelectedRecept = null;
        }

        internal void BtnDelete_Click(object sender, EventArgs e)
        {
            if (view.dataGridView1.SelectedRows.Count > 0)
            {
                Recept selectedRecept = (Recept)view.dataGridView1.SelectedRows[0].DataBoundItem;
                if (selectedRecept != null)
                {
                    // Ta bort från binding list
                    receptsBindingList.Remove(selectedRecept);

                    // Uppdatera UI direkt efter borttagning
                    view.UpdateUI();

                    // Ta bort kategorin om det inte finns några recept kvar i den
                    string categoryToDelete = selectedRecept.Type;
                    bool hasRecipesInCategory = receptsBindingList.Any(recept => recept.Type == categoryToDelete);

                    if (!hasRecipesInCategory)
                    {
                        view.Categories.Remove(categoryToDelete); // Använd Categories-egenskapen
                        view.UpdateCategoriesComboBox(); // Uppdatera ComboBox för kategorier
                    }

                    // Skriv nu om hela filen med den uppdaterade listan
                    SaveDataToFile();
                    MessageBox.Show("Receptet har tagits bort!");
                }
            }
            else
            {
                MessageBox.Show("Vänligen välj ett recept att ta bort.");
            }

            view.ClearTextBoxes();
        }


        private void SaveDataToFile()
        {
            string filePath = view.filePath;
            using (StreamWriter writer = new StreamWriter(filePath))
            {
                foreach (Recept recept in receptsBindingList)
                {
                    writer.WriteLine($"{recept.Title}|{recept.Description}|{recept.Type}");
                }
            }
        }
    }
}