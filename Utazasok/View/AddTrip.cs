using Utazasok.Controller;
using Utazasok.Model;

namespace Utazasok.View
{
    public partial class AddTrip : Form
    {
        private readonly TripController controller;
        private readonly int tripId;
        private readonly bool isModification = false;

        //Add
        public AddTrip(TripController controller)
        {
            InitializeComponent();
            categoryComboBox.Items.AddRange(new string[] {
                "Group",
                "Personal",
                "Virtual"
            });
            categoryComboBox.SelectedIndex = 0;

            this.controller = controller;
        }

        //Modify
        public AddTrip(TripController controller, Trip trip) : this(controller)
        {
            this.isModification = true;
            this.tripId = trip.Id;

            nameTextBox.Text = trip.Name;
            categoryComboBox.SelectedIndex = categoryComboBox.Items.IndexOf(trip.Category);
            countryTextBox.Text = trip.Country;
            descriptionTextBox.Text = trip.Description;
            priorityNumericUpDown.Value = trip.Priority;


            okButton.Text = "Modify";
            okButton.BackColor = Color.Yellow;

            //törlés gom hozzáadás
            Button deleteButton = new Button();
            deleteButton.Text = "Delete";
            deleteButton.BackColor = Color.Red;
            deleteButton.Location = new Point(114, 280);
            deleteButton.Size = new Size(154, 29);
            this.Controls.Add(deleteButton);
            deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            bool result = controller.DeleteTrip(tripId);

            if (!result)
            {
                MessageBox.Show(
                    "There's something wrong with the deletion!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                DialogResult = DialogResult.Abort;
            }
            this.Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            string name = nameTextBox.Text;
            string category = categoryComboBox.SelectedItem.ToString();
            string country = countryTextBox.Text;
            string description = descriptionTextBox.Text;
            int priority = (int)priorityNumericUpDown.Value;

            if (name == string.Empty || 
                category == string.Empty ||
                country == string.Empty ||
                description == string.Empty)
            {
                MessageBox.Show(
                    "Name, Category, Country, Description fields required!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                DialogResult = DialogResult.Abort;
                return;
            }

            Trip trip = new Trip
            {
                Name = name,
                Category = category,
                Country = country,
                Description = description,
                Priority = priority
            };

            bool result = false;
            if (isModification)
            {
                trip.Id = this.tripId;
                result = controller.ModifyTrip(trip);
            }
            else
            {
                result = controller.AddTrip(trip);
            }

            if (!result)
            {
                MessageBox.Show(
                    "There's something wrong with the transaction!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
                DialogResult = DialogResult.Abort;
            }
            this.Close();
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
