using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WSLib;


namespace AirLines
{
    public partial class MainWindow : Form
    {
        int userID;
        SqlConnection cn;
        SqlDataAdapter adapter;
        DataTable table;
        SqlCommand cmd;

        public MainWindow(int usID, SqlConnection connection)
        {
            InitializeComponent();
            userID = usID;
            cn = connection;

            SetSQL();
            SetDataGrid();
            GetStats();
            comboBox1.SelectedIndex = 0;
        }
        
        private void SetSQL()
        {
            adapter = new SqlDataAdapter();
            table = new DataTable();
        }
        private void SetDataGrid()
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ReadOnly = true;
            this.dataGridView1.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);
            this.dataGridView1.Font = new Font("Microsoft Sans Serif", 12);
            dataGridView1.RowTemplate.Height = 30;
        }

        private void GetStats()
        {
            string querySQL = $"select Role.Name from Users Inner join dbo.Role ON Users.Role = Role.ID where Users.ID = {userID}";
            FillTable(querySQL);
            labelRole.Text = "Роль: " + table.Rows[0].Field<String>("Name");
            if (table.Rows[0].Field<String>("Name") == "Администратор")
                panelAdmin.Visible = true;
            querySQL = $"select Users.Name from Users where Users.ID = {userID}";
            FillTable(querySQL);
            labelUsername.Text = "Имя: " + table.Rows[0].Field<String>("Name");
        }

        private void FillTable(string querySQL)
        {
            table.Clear();
            cmd = new SqlCommand(querySQL, cn);
            adapter.SelectCommand = cmd;
            adapter.Fill(table);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    BuildCommanderTable();
                    break;
                case 1:
                    BuildFlightTable();
                    break;
                case 2:
                    BuildPassengerTable();
                    break;
                case 3:
                    BuildPlaneTable();
                    break;
                case 4:
                    BuildRoleTable();
                    break;
                case 5:
                    BuildRouteTable();
                    break;
                case 6:
                    BuildTicketTable();
                    break;
                case 7:
                    BuildUsersTable();
                    break;
                default:
                    break;
            }
            comboBoxAdd.SelectedIndex = comboBox1.SelectedIndex;
        }

        private void BuildCommanderTable()
        {
            Commander obj = new Commander();
            for (int i = 0; i < 7; i++)
            {
                DataGridViewTextBoxColumn columnTB1 = new DataGridViewTextBoxColumn();
                columnTB1.Width = 130;
                dataGridView1.Columns.Add(columnTB1);
                dataGridView1.Columns[i].DataPropertyName = obj.str[i];
                dataGridView1.Columns[i].HeaderText = obj.str[i];
            }
            dataGridView1.DataSource = AIRLINESdbEntities.GetContext().Commander.ToList();
        }
        private void BuildFlightTable()
        {
            Flight obj = new Flight();
            for (int i = 0; i < 4; i++)
            {
                DataGridViewTextBoxColumn columnTB1 = new DataGridViewTextBoxColumn();
                columnTB1.Width = 150;
                dataGridView1.Columns.Add(columnTB1);
                dataGridView1.Columns[i].DataPropertyName = obj.str[i];
                dataGridView1.Columns[i].HeaderText = obj.str[i];
            }
            dataGridView1.Columns[2].Width = 300;
            dataGridView1.DataSource = AIRLINESdbEntities.GetContext().Flight.ToList();
        }
        private void BuildPassengerTable()
        {
            Passenger obj = new Passenger();
            for (int i = 0; i < 5; i++)
            {
                DataGridViewTextBoxColumn columnTB1 = new DataGridViewTextBoxColumn();
                columnTB1.Width = 150;
                dataGridView1.Columns.Add(columnTB1);
                dataGridView1.Columns[i].DataPropertyName = obj.str[i];
                dataGridView1.Columns[i].HeaderText = obj.str[i];
            }
            dataGridView1.DataSource = AIRLINESdbEntities.GetContext().Passenger.ToList();
        }
        private void BuildPlaneTable()
        {
            Plane obj = new Plane();
            for (int i = 0; i < 6; i++)
            {
                DataGridViewTextBoxColumn columnTB1 = new DataGridViewTextBoxColumn();
                columnTB1.Width = 150;
                dataGridView1.Columns.Add(columnTB1);
                dataGridView1.Columns[i].DataPropertyName = obj.str[i];
                dataGridView1.Columns[i].HeaderText = obj.str[i];
            }
            dataGridView1.Columns[5].Width = 300;
            dataGridView1.DataSource = AIRLINESdbEntities.GetContext().Plane.ToList();
        }
        private void BuildRoleTable()
        {
            Role obj = new Role();
            for (int i = 0; i < 3; i++)
            {
                DataGridViewTextBoxColumn columnTB1 = new DataGridViewTextBoxColumn();
                columnTB1.Width = 150;
                dataGridView1.Columns.Add(columnTB1);
                dataGridView1.Columns[i].DataPropertyName = obj.str[i];
                dataGridView1.Columns[i].HeaderText = obj.str[i];
            }
            dataGridView1.DataSource = AIRLINESdbEntities.GetContext().Role.ToList();
        }
        private void BuildRouteTable()
        {
            Route obj = new Route();
            for (int i = 0; i < 5; i++)
            {
                DataGridViewTextBoxColumn columnTB1 = new DataGridViewTextBoxColumn();
                columnTB1.Width = 150;
                dataGridView1.Columns.Add(columnTB1);
                dataGridView1.Columns[i].DataPropertyName = obj.str[i];
                dataGridView1.Columns[i].HeaderText = obj.str[i];
            }
            dataGridView1.DataSource = AIRLINESdbEntities.GetContext().Route.ToList();
        }
        private void BuildTicketTable()
        {
            Ticket obj = new Ticket();
            for (int i = 0; i < 3; i++)
            {
                DataGridViewTextBoxColumn columnTB1 = new DataGridViewTextBoxColumn();
                columnTB1.Width = 150;
                dataGridView1.Columns.Add(columnTB1);
                dataGridView1.Columns[i].DataPropertyName = obj.str[i];
                dataGridView1.Columns[i].HeaderText = obj.str[i];
            }
            dataGridView1.Columns[1].Width = 300;
            dataGridView1.Columns[2].Width = 300;
            dataGridView1.DataSource = AIRLINESdbEntities.GetContext().Ticket.ToList();
        }
        private void BuildUsersTable()
        {
            Users obj = new Users();
            for (int i = 0; i < 5; i++)
            {
                DataGridViewTextBoxColumn columnTB1 = new DataGridViewTextBoxColumn();
                columnTB1.Width = 150;
                dataGridView1.Columns.Add(columnTB1);
                dataGridView1.Columns[i].DataPropertyName = obj.str[i];
                dataGridView1.Columns[i].HeaderText = obj.str[i];
            }
            dataGridView1.DataSource = AIRLINESdbEntities.GetContext().Users.ToList();
        }

        private void buttonIncome_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Продано { AirLinesCounter.IncomeCount(cn)[0]} билетов на неотмененные рейсы\nОбщая сумма выручки: {AirLinesCounter.IncomeCount(cn)[1]}", "Доходная накладная");
        }

        private void buttonLifetime_Click(object sender, EventArgs e)
        {
            Expiration obj = new Expiration(AirLinesCounter.Expiration(cn));
            obj.Show();
        }

        private void buttonArrivalTime_Click(object sender, EventArgs e)
        {
            ArrivalsForm obj = new ArrivalsForm(AirLinesCounter.Arrivals(cn));
            obj.Show();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            switch (comboBoxAdd.SelectedIndex)
            {
                case 0:
                    CommanderAddingForm objC = new CommanderAddingForm();
                    objC.ShowDialog();
                    break;
                case 1:
                    FlightAddingForm objF = new FlightAddingForm(cn);
                    objF.ShowDialog();
                    break;
                case 2:
                    PassengerAddingForm objP = new PassengerAddingForm();
                    objP.ShowDialog();
                    break;
                case 3:
                    PlaneAddingForm objPl = new PlaneAddingForm();
                    objPl.ShowDialog();
                    break;
                case 4:
                    RoleAddingForm objRl = new RoleAddingForm();
                    objRl.ShowDialog();
                    break;
                case 5:
                    RouteAddingForm objRt = new RouteAddingForm();
                    objRt.ShowDialog();
                    break;
                case 6:
                    TicketAddingForm objT = new TicketAddingForm();
                    objT.ShowDialog();
                    break;
                case 7:
                    UsersAddingForm obj = new UsersAddingForm(cn);
                    obj.ShowDialog();
                    break;
            }
        }
    }
}
