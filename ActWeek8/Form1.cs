using System.Data;
using System.Data.OleDb;
using System.Xml.Linq;

namespace ActWeek8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\User\\Documents\\SchoolDatabase.accdb");
        OleDbCommand cmd = new OleDbCommand();
        DataSet? ds;
        OleDbDataAdapter da = new OleDbDataAdapter();
        int indexRow;

        private void btnCon_Click(object sender, EventArgs e)
        {
            ds = new DataSet();
            con.Open();
            System.Windows.Forms.MessageBox.Show("Connected successfully!");
            con.Close();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            da = new OleDbDataAdapter("SELECT *FROM Student", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Student");
            dgvStudInfo.DataSource = ds.Tables["Student"];
            con.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string query = "Insert into Student (LastName, FirstName) values(@LName, @FName)";
            cmd = new OleDbCommand(query, con);
            cmd.Parameters.AddWithValue("@LName", tbLast.Text);
            cmd.Parameters.AddWithValue("@FName", tbFirst.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            da.Fill(ds, "Student");
            dgvStudInfo.Refresh();
            dgvStudInfo.FirstDisplayedScrollingRowIndex = dgvStudInfo.Rows.Count - 1;
            if (dgvStudInfo.Rows.Count > 0)
            {
                dgvStudInfo.Rows[dgvStudInfo.Rows.Count - 1].Selected = true;
            }
            con.Close();
        }

        private void dgvStudInfo_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dgvStudInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dgvStudInfo.Rows[indexRow];
            tbID.Text = row.Cells[0].Value.ToString();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            string query = "Delete From Student Where StudentID = @id";
            cmd = new OleDbCommand(query, con);
            cmd.Parameters.AddWithValue("@id",
            dgvStudInfo.CurrentRow.Cells[0].Value);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            ds.Tables["Student"].Rows.RemoveAt(indexRow);
            dgvStudInfo.Refresh();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = "Update Student Set LastName = @Lname Where StudentID = @id";
            cmd = new OleDbCommand(query, con);
            cmd.Parameters.AddWithValue("@ln", tbLast.Text);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(tbID.Text));
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            DataGridViewRow row = dgvStudInfo.Rows[indexRow];
            row.Cells[1].Value = tbLast.Text;
            dgvStudInfo.Refresh();
        }
    }
}
