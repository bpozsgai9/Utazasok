using Utazasok.Controller;
using Utazasok.Dao;
using Utazasok.Model;
using Utazasok.View;

namespace Utazasok
{
    public partial class ListTrips : Form
    {
        private TripController controller;
        public ListTrips()
        {
            InitializeComponent();
            this.controller = new TripController(new TripAdoDao());
        }

        private void addTripStrip_Click(object sender, EventArgs e)
        {
            using Form addTripForm = new AddTrip(controller);
            addTripForm.ShowDialog();
        }

        private void listTripStrip_Click(object sender, EventArgs e)
        {
            var trips = controller.GetAllTrips();

            tripDataGridView.DataSource = null;
            tripDataGridView.DataSource = trips;
            tripDataGridView.Visible = true;
        }

        private void tripDataGridView_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (!(tripDataGridView.CurrentRow.DataBoundItem is Trip trip)) { return; }

            using var addTripForm = new AddTrip(controller, trip);
            addTripForm.ShowDialog();
        }
    }
}