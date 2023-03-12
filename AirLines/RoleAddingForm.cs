using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace AirLines
{
    public partial class RoleAddingForm : Form
    {
        AIRLINESdbEntities db = new AIRLINESdbEntities();

        public RoleAddingForm()
        {
            InitializeComponent();
        }
        private void Add()
        {
            if (textBoxName.Text != "" && textBoxDescription.Text != "")
            {
                try
                {
                    Role obj = new Role()
                    {
                        ID = AIRLINESdbEntities.GetContext().Role.ToList().Count,
                        Name = textBoxName.Text,
                        Description = textBoxDescription.Text
                    };
                    db.Role.Add(obj);
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
