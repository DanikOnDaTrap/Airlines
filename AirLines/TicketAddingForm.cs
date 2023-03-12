using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AirLines
{
    public partial class TicketAddingForm : Form
    {
        AIRLINESdbEntities db = new AIRLINESdbEntities();

        public TicketAddingForm()
        {
            InitializeComponent();
            comboBoxPas.DisplayMember = "PassengerDetail";
            comboBoxPas.DataSource = AIRLINESdbEntities.GetContext().Passenger.ToList();
            comboBoxFl.DisplayMember = "FlightDetail";
            comboBoxFl.DataSource = AIRLINESdbEntities.GetContext().Flight.ToList();
        }
        private void Add()
        {
            try
            {
                Ticket obj = new Ticket()
                {
                    ID = AIRLINESdbEntities.GetContext().Ticket.ToList().Count,
                    PassengerID = GetPasID(),
                    FlightID = GetFlID()
                };
                db.Ticket.Add(obj);
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Ошибка при добавлении", "Внимание!");
            }
        }
        private int GetPasID()
        {
            return Convert.ToInt32(comboBoxPas.Text.Substring(0, 1));
        }

        private int GetFlID()
        {
            return Convert.ToInt32(comboBoxFl.Text.Substring(0, 1));
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Add();
        }
    }
}
