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
    public partial class Update : Form
    {
        private string strConfig = ConfigurationManager.ConnectionStrings["disconnectedArchitecture"].ToString();

        public Update()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {

                SqlConnection con = new SqlConnection(strConfig);

                int srno = Int32.Parse(mtxtRollNo.Text);
                string sname = txtSName.Text;
                string semail = txtEmail.Text;
                DateTime dob = DateTime.Parse(dpDOB.Text);

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

                // DataRow updateRow = ds.Tables["stud_mst"].Rows.Find(Convert.ToInt32(dr.Cells[0].Value));
                DataRow updateRow = ds.Tables["stud_mst"].Rows.Find(Convert.ToInt32(mtxtRollNo.Text));

                updateRow["stud_name"] = sname;

                updateRow["stud_email"] = semail;

                updateRow["stud_dob"] = dob;

                adp.Update(ds.Tables["stud_mst"]);

                MessageBox.Show("Record Updated Successfully.");

                mtxtRollNo.Clear();
                txtEmail.Clear();
                txtSName.Clear();
                dpDOB.Text = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
