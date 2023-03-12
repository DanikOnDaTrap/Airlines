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
    public partial class PlaneAddingForm : Form
    {
        AIRLINESdbEntities db = new AIRLINESdbEntities();
        bool saved = false;

        public PlaneAddingForm()
        {
            InitializeComponent();
            dateTimePicker1.CustomFormat = "yyyy-mm-dd hh:mm";
            comboBox1.DisplayMember = "CommanderDetail";
            comboBox1.DataSource = AIRLINESdbEntities.GetContext().Commander.ToList();
        }
        private void Add()
        {
            if (textBoxModel != null && textBoxLife != null)
            {
                bool red;
                if (checkBox1.Checked)
                    red = true;
                else
                    red = false;
                try
                {
                    Plane obj = new Plane()
                    {
                        ID = AIRLINESdbEntities.GetContext().Plane.ToList().Count,
                        Date = dateTimePicker1.Value,
                        Model = textBoxModel.Text,
                        Lifetime = Convert.ToInt32(textBoxLife.Text),
                        Commander = GetCommanderID(),
                        Ready = red                        
                    };
                    db.Plane.Add(obj);
                    db.SaveChanges();
                }
                catch
                {
                    MessageBox.Show("Ошибка при добавлении", "Внимание!");
                }
            }
        }
        private int GetCommanderID()
        {
            return Convert.ToInt32(comboBox1.Text.Substring(0, 1));
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Add();
            saved = true;
        }

        private void PlaneAddingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (saved == false)
                Add();
        }
    }
}
