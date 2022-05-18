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
using System.Configuration;

namespace DisconnectedArchitecture
{
    public partial class View : Form
    {
        private string strConfig = ConfigurationManager.ConnectionStrings["disconnectedArchitecture"].ToString();

        public View()
        {
            InitializeComponent();
        }

        private void View_Load(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection(strConfig);

                string sqlCmd = "SELECT * FROM stud_mst";

                DataSet ds = new DataSet();

                SqlDataAdapter adp = new SqlDataAdapter(sqlCmd, con);

                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adp);

                adp.Fill(ds, "stud_mst");

                dataGridView1.DataSource = ds.Tables["stud_mst"];

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
