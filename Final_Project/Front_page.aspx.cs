using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MySql.Data.MySqlClient;
using BCrypt.Net;

namespace Final_Project
{
    public partial class Front_page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;database=online_shop;user=root;password=Rohit#4321;";
            
            string username = txtUsername.Text;
            string email = txtEmail.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            string fullname = txtFullName.Text;
            string address = txtAddress.Text;
            string phoneNumber = txtPhoneNumber.Text;

            if (password != confirmPassword)
            {
                Response.Write("<script>alert('Passwords do not match');</script>");
                return;
            }

            string hashedPassword = BCrypt.Net.BCrypt.HashPassword(password);

            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();

                    string query = "INSERT INTO users (username, email, password, fullname, address, phone_number) " +
                                   "VALUES (@Username, @Email, @Password, @FullName, @Address, @PhoneNumber)";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Username", username);
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Password", hashedPassword);
                        cmd.Parameters.AddWithValue("@FullName", fullname);
                        cmd.Parameters.AddWithValue("@Address", address);
                        cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumber);

                        cmd.ExecuteNonQuery();

                        Response.Redirect("Login_page.aspx");
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
