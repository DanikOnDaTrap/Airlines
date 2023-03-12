using System;
using System.Linq;
using System.Windows.Forms;


namespace AirLines
{
    public partial class CommanderAddingForm : Form
    {
        AIRLINESdbEntities db = new AIRLINESdbEntities();
        bool saved = false;

        public CommanderAddingForm()
        {
            InitializeComponent();
        }
        private void Add()
        {
            if (textBoxSurname.Text != null && textBoxName.Text != null && textBoxAdress.Text != null && textBoxPhone.Text != null && textBoxFH.Text != null)
            {
                try
                {
                    Commander obj = new Commander()
                    {
                        ID = AIRLINESdbEntities.GetContext().Commander.ToList().Count,
                        Name = textBoxName.Text,
                        Surname = textBoxSurname.Text,
                        Patronymic = textBoxPatr.Text,
                        Adress = textBoxAdress.Text,
                        PhoneNumber = textBoxPhone.Text,
                        FlyingHours = Convert.ToInt32(textBoxFH.Text)
                    };
                    db.Commander.Add(obj);
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
            saved = true;
        }

        private void CommanderAddingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (saved == false)
                Add();
        }
    }
}
