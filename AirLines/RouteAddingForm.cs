using System;
using System.Linq;
using System.Windows.Forms;

namespace AirLines
{
    public partial class RouteAddingForm : Form
    {
        AIRLINESdbEntities db = new AIRLINESdbEntities();

        public RouteAddingForm()
        {
            InitializeComponent();
        }
        private void Add()
        {
            if (textBoxDep.Text != "" && textBoxDes.Text != "" && textBoxDur.Text != "" && textBoxPrice.Text != "")
            {
                try
                {
                    Route obj = new Route()
                    {
                        ID = AIRLINESdbEntities.GetContext().Route.ToList().Count,
                        DepartureAirport = textBoxDep.Text,
                        DestinationAirport = textBoxDes.Text,
                        TicketPrice = Decimal.Parse(textBoxPrice.Text),
                        Duration = Convert.ToInt32(textBoxDur.Text)
                    };
                    db.Route.Add(obj);
                    db.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("Ошибка при добавлении", "Внимание!");
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Add();
        }
    }
}
