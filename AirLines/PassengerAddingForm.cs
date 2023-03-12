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
            if (textBoxSurname.Text != "" && textBoxName.Text != "" && textBoxAdress.Text != "" && textBoxPhone.Text != "")
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
    }
}
