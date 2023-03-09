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
    public partial class Expiration : Form
    {
        public Expiration(DataTable tbl)
        {
            InitializeComponent();
            dataGridView1.DataSource = tbl;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ReadOnly = true;
            this.dataGridView1.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 12);
            this.dataGridView1.Font = new Font("Microsoft Sans Serif", 12);
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.Columns[2].Width = 200;
        }
    }
}
