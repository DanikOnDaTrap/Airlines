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

namespace AirLines
{
    public partial class UsersAddingForm : Form
    {
        AIRLINESdbEntities db = new AIRLINESdbEntities();

        public UsersAddingForm()
        {
            InitializeComponent();
            comboBox1.DisplayMember = "Name";
            comboBox1.DataSource = AIRLINESdbEntities.GetContext().Role.ToList();
        }

        private void UserAdd()
        {
            try
            {
                Users obj = new Users()
                {
                    ID = AIRLINESdbEntities.GetContext().Users.ToList().Count,
                    Name = textBoxName.Text,
                    Login = textBoxLogin.Text,
                    Password = textBoxPass.Text,
                    Role = IndexByRole(comboBox1.Text)
                };
                db.Users.Add(obj);
                db.SaveChanges();
            }
            catch
            {
                MessageBox.Show("Ошибка при добавлении", "Внимание!");
            }
            
        }

        private int IndexByRole(string role)
        {
            int index = 0;
            switch (role)
            {
                case "Администратор":
                    index = 0;
                        break;
                case "Пользователь":
                    index = 1;
                        break;
            }
            return index;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserAdd();
        }

        private void UsersAddingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            UserAdd();
        }
    }
}
