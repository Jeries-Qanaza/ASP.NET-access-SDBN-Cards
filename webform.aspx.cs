using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;


namespace sdbn
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {
            
            
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {
            String fname = null, lname = null, fullName = null,grade=null;
            OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\User1\\Desktop\\Jeriesx\\sdbn-cards\\Database1.accdb");
           
            int inpId = Int32.Parse(TextBox3.Text);

            OleDbCommand cmd = new OleDbCommand("select * from Sheet1 where SDBN_ID="+ inpId,con);
            con.Open();
            OleDbDataReader odr = cmd.ExecuteReader();

            while (odr.Read())
            {
                 fname= odr["firstName"].ToString();
                 lname = odr["lastName"].ToString();
                 fullName = fname + " " + lname;
                grade= odr["grade"].ToString();
            }
            TextBox1.Text = fullName;
            TextBox2.Text = grade;
            con.Close();
        }
    }
}
