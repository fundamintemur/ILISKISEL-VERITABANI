using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace PROJE6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=LENOVO\SQLEXPRESS;Initial Catalog=Proje5;Integrated Security=True");
        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'proje5DataSet1.PROJE6' table. You can move, or remove it, as needed.
            this.pROJE6TableAdapter1.Fill(this.proje5DataSet1.PROJE6);
            // TODO: This line of code loads data into the 'proje5DataSet.PROJE6' table. You can move, or remove it, as needed.
            this.pROJE6TableAdapter.Fill(this.proje5DataSet.PROJE6);
           
            
            //SqlDataAdapter da = new SqlDataAdapter("Execute PROJE6", baglanti);
            //DataTable dt = new DataTable();
            //da.Fill(dt);
            //dataGridView1.DataSource = dt;

        }
    }
}
