using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using BCrypt.Net;  // Ensure BCrypt is referenced for password verification

namespace Final_Project
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;database=online_shop;user=root;password=Rohit#4321;";


            string username = txtUsername.Text;
            string password = txtPassword.Text;

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT password FROM users WHERE username = @Username";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);

                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            string storedHashedPassword = result.ToString();

                            if (BCrypt.Net.BCrypt.Verify(password, storedHashedPassword))
                            {
                                Response.Redirect("Home_page.aspx");
                            }
                            else
                            {
                                Response.Write("<script>alert('Invalid username or password');</script>");
                            }
                        }
                        else
                        {
                            Response.Write("<script>alert('Invalid username or password');</script>");
                        }
                    }
                }
                catch (Exception ex)
                {
                    Response.Write($"<script>alert('Error: {ex.Message}');</script>");
                }
            }
        }
    }
}
