using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

namespace login
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void loginButton_Click(object sender, EventArgs e)
        {
            Boolean found = false;
            string connectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\jfkta\Pictures\Database\login.mdb";
            OleDbConnection thisConnection = new OleDbConnection(connectionString);
            thisConnection.Open();
            OleDbCommand thisCommand = thisConnection.CreateCommand();

            thisCommand.CommandText = "SELECT * FROM EMPLOYEEFILE";
            OleDbDataReader thisReader = thisCommand.ExecuteReader();

            while(thisReader.Read())
            {
                if(thisReader["username"].ToString().ToLower() == usernameTextbox.Text.ToLower())
                {
                    Response.Write("<script>alert('USER IS IN DATABASE')</script>");
                    Response.Redirect("register.aspx");
                }
                else
                {
                    Response.Write("<script>alert('USER IS NOT IN DATABASE')</script>");
                }
            }

            
        }
    }
}