using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AirLines
{
    public partial class PassengerAddingForm : Form
    {
        AIRLINESdbEntities db = new AIRLINESdbEntities();
        public PassengerAddingForm()
        {
            InitializeComponent();
        }
        private void Add()
        {
            if (textBoxSurname.Text != null && textBoxName.Text != null && textBoxAdress.Text != null && textBoxPhone.Text != null)
            {
                try
                {
                    Passenger obj = new Passenger()
                    {
                        ID = AIRLINESdbEntities.GetContext().Passenger.ToList().Count,
                        Name = textBoxName.Text,
                        Surname = textBoxSurname.Text,
                        Patronymic = textBoxPatr.Text,
                        Adress = textBoxAdress.Text,
                        PhoneNumber = textBoxPhone.Text,
                    };
                    db.Passenger.Add(obj);
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

        private void PassengerAddingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Add();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxAdress_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxPatr_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxSurname_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
