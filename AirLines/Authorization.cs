using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace AirLines
{
    public partial class Form1 : Form
    {
        SqlConnection cn;
        DataTable table;
        private string textCaptcha = String.Empty;
        bool captchaRequired = false;

        public Form1()
        {
            InitializeComponent();
            textBoxPassword.UseSystemPasswordChar = true;
            ////////
            UsersAddingForm obj = new UsersAddingForm();
            obj.ShowDialog();
            //////////
        }
        
        private void ConnectionBuild()
        {
            SqlConnectionStringBuilder connect = new SqlConnectionStringBuilder();
            connect.InitialCatalog = "AIRLINES";
            connect.DataSource = @"SHEVELEVPC\SQLEXPRESS";
            connect.ConnectTimeout = 5;
            connect.IntegratedSecurity = true;
            cn = new SqlConnection();
            cn.ConnectionString = connect.ConnectionString;
            cn.Open();
        }

        private void checkBoxPass_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = !textBoxPassword.UseSystemPasswordChar;
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            ConnectionBuild();
            
            string enterLogin = textBoxLogin.Text;
            string enterPass = textBoxPassword.Text;
            string querySQL = $"select * from Users where Login = '{enterLogin}' AND Password = '{enterPass}'";

            SqlDataAdapter adapter = new SqlDataAdapter();
            table = new DataTable();
            SqlCommand cmd = new SqlCommand(querySQL, cn);

            adapter.SelectCommand = cmd;
            adapter.Fill(table);

            if (captchaRequired == false)
            {
                if (table.Rows.Count == 0)
                {
                    MessageBox.Show("Данные введены неверно", "Ошибка!");
                    textBoxLogin.Text = "";
                    textBoxPassword.Text = "";
                    CaptchaFieldUPD();
                    pictureBox2.Image = this.CreateImage(pictureBox2.Width, pictureBox2.Height);
                }
                else
                {
                    MWOpen();
                }
            }
            else
            {
                if (table.Rows.Count != 0 && textBoxCaptcha.Text == textCaptcha)
                {
                    CaptchaFieldUPD();
                    MWOpen();
                }
                else
                {
                    pictureBox2.Image = this.CreateImage(pictureBox2.Width, pictureBox2.Height);
                    MessageBox.Show("Введены некорректные данные, возможность авторизации заблокирована на 10 секунд", "Ошибка!");
                    Thread.Sleep(10000);
                }                    
            }
        }

        private void CaptchaFieldUPD()
        {
            captchaRequired = !captchaRequired;
            panelCaptcha.Visible = !panelCaptcha.Visible;
        }

        private void MWOpen()
        {
            MainWindow obj = new MainWindow(table.Rows[0].Field<int>("ID"),cn);
            obj.ShowDialog();
        }

        private Bitmap CreateImage(int Width, int Height)
        {
            Random rnd = new Random();
            Bitmap result = new Bitmap(Width, Height);

            int Xpos = rnd.Next(5, Width - 120);
            int Ypos = rnd.Next(20, Height - 30);

            Brush[] colors = { Brushes.Black,
                     Brushes.Red,
                     Brushes.RoyalBlue,
                     Brushes.Green };

            Graphics g = Graphics.FromImage((Image)result);

            g.Clear(Color.Gray);

            textCaptcha = String.Empty;
            string ALF = "1234567890QWERTYUIOPASDFGHJKLZXCVBNM";
            for (int i = 0; i < 5; ++i)
                textCaptcha += ALF[rnd.Next(ALF.Length)];

            g.DrawString(textCaptcha,
                         new Font("Arial", 20),
                         colors[rnd.Next(colors.Length)],
                         new PointF(Xpos, Ypos));
            g.DrawLine(Pens.Black,
                       new Point(0, 0),
                       new Point(Width - 1, Height - 1));
            g.DrawLine(Pens.Black,
                       new Point(0, Height - 1),
                       new Point(Width - 1, 0));
            for (int i = 0; i < Width; ++i)
                for (int j = 0; j < Height; ++j)
                    if (rnd.Next() % 20 == 0)
                        result.SetPixel(i, j, Color.White);

            return result;
        }
    }
}
