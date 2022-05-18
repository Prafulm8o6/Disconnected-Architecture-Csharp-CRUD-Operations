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
    public partial class Delete : Form
    {
        private string strConfig = ConfigurationManager.ConnectionStrings["disconnectedArchitecture"].ToString();

        public Delete()
        {
            InitializeComponent();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection(strConfig);

                int srno = Int32.Parse(mtxtRollNo.Text);

                string sqlCmd = "SELECT * FROM stud_mst";

                DataSet ds = new DataSet();

                SqlDataAdapter adp = new SqlDataAdapter(sqlCmd, con);

                SqlCommandBuilder cmdBuilder = new SqlCommandBuilder(adp);

                adp.Fill(ds, "stud_mst");

                DataGridView dataGV1 = new DataGridView();

                dataGV1.DataSource = ds.Tables["stud_mst"];

                DataGridViewRow dr = dataGV1.CurrentRow;

                DataColumn[] dtCol = new DataColumn[1];

                dtCol[0] = ds.Tables["stud_mst"].Columns["stud_rno"];

                ds.Tables["stud_mst"].PrimaryKey = dtCol;

                // DataRow deleteRow = ds.Tables["stud_mst"].Rows.Find(Convert.ToInt32(dr.Cells[0].Value));

                DataRow deleteRow = ds.Tables["stud_mst"].Rows.Find(Convert.ToInt32(mtxtRollNo.Text));

                deleteRow.Delete();

                adp.Update(ds.Tables["stud_mst"]);

                MessageBox.Show("Record Deleted Successfully.");

                mtxtRollNo.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
