using System;
using System.Linq;
using System.Windows.Forms;


namespace AirLines
{
    public partial class CommanderAddingForm : Form
    {
        AIRLINESdbEntities db = new AIRLINESdbEntities();

        public CommanderAddingForm()
        {
            InitializeComponent();
        }
        private void Add()
        {
            if (textBoxSurname.Text != "" && textBoxName.Text != "" && textBoxAdress.Text != "" && textBoxPhone.Text != "" && textBoxFH.Text != "")
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
        }
    }
}
