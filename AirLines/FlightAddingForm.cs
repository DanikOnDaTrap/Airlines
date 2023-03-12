using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AirLines
{
    public partial class FlightAddingForm : Form
    {
        AIRLINESdbEntities db = new AIRLINESdbEntities();
        bool saved = false;

        public FlightAddingForm(SqlConnection connection)
        {
            InitializeComponent();
            dateTimePicker1.CustomFormat = "yyyy-mm-dd hh:mm";

            comboBoxRoute.DisplayMember = "RouteDetail";
            comboBoxPlane.DisplayMember = "PlaneDetail";
            comboBoxRoute.DataSource = AIRLINESdbEntities.GetContext().Route.ToList();
            comboBoxPlane.DataSource = AIRLINESdbEntities.GetContext().Plane.ToList();
        }
        private void Add()
        {
            bool can;
            if (checkBox1.Checked)
                can = true;
            else
                can = false;
            try 
            {
                Flight obj = new Flight()
                {
                    ID = AIRLINESdbEntities.GetContext().Flight.ToList().Count,
                    DateTime = dateTimePicker1.Value,
                    Route = GetRouteID(),
                    Plane = GetPlaneID(),
                    Canceled = can
                };
                db.Flight.Add(obj);
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Ошибка при добавлении", "Внимание!");
            }
        }

        private int GetRouteID()
        {
            return Convert.ToInt32(comboBoxRoute.Text.Substring(0, 1));
        }

        private int GetPlaneID()
        {
            return Convert.ToInt32(comboBoxPlane.Text.Substring(0, 1));
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Add();
            saved = true;
        }

        private void FlightAddingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (saved == false)
                Add();
        }
    }   
}
