using System;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms;

namespace AirLines
{
    public partial class UsersAddingForm : Form
    {
        AIRLINESdbEntities db = new AIRLINESdbEntities();
        SqlConnection cn;
        DataTable table;
        public UsersAddingForm(SqlConnection connection)
        {
            InitializeComponent();
            comboBox1.DisplayMember = "Name";
            cn = connection;
            comboBox1.DataSource = AIRLINESdbEntities.GetContext().Role.ToList();
        }

        private void Add()
        {
            if (textBoxPass.Text != null && textBoxName.Text != null && textBoxLogin.Text !=null)
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
        }

        private int IndexByRole(string role)
        {
            string querySQL = $"select ID from Role Where Role.[Name] = '{role}'";

            SqlDataAdapter adapter = new SqlDataAdapter();
            table = new DataTable();
            SqlCommand cmd = new SqlCommand(querySQL, cn);

            adapter.SelectCommand = cmd;
            adapter.Fill(table);

            return table.Rows[0].Field<int>("ID");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Add();
            textBoxName.Text = "";
            textBoxLogin.Text = "";
            textBoxPass.Text = "";
        }

        private void UsersAddingForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Add();
        }
    }
}
