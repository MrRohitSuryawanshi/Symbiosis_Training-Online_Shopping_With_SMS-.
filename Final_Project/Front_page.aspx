<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Front_page.aspx.cs" Inherits="Final_Project.Front_page" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Registration Form</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-image: url('your-image-url.jpg');
            background-size: cover;
            background-position: center;
            background-repeat: no-repeat;
            margin: 0;
            padding: 0;
        }
        .container {
            max-width: 400px;
            margin: 50px auto;
            padding: 20px;
            border: 1px solid #ccc;
            border-radius: 5px;
            background-color: rgba(255, 255, 255, 0.9);
        }
        .form-group {
            margin-bottom: 15px;
        }
        .form-group label {
            display: block;
            font-weight: bold;
        }
        .form-group input {
            width: 100%;
            padding: 8px;
            box-sizing: border-box;
        }
        .form-group button {
            width: 100%;
            padding: 10px;
            background-color: #28a745;
            border: none;
            color: white;
            font-size: 16px;
            cursor: pointer;
            border-radius: 5px;
        }
        .form-group button:hover {
            background-color: #218838;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>Register</h2>
            <div class="form-group">
                <label for="txtUsername">Username:</label>
                <asp:TextBox ID="txtUsername" runat="server" placeholder="Enter your username"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtEmail">Email:</label>
                <asp:TextBox ID="txtEmail" runat="server" placeholder="Enter your email" TextMode="Email"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtPassword">Password:</label>
                <asp:TextBox ID="txtPassword" runat="server" placeholder="Enter your password" TextMode="Password"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtConfirmPassword">Confirm Password:</label>
                <asp:TextBox ID="txtConfirmPassword" runat="server" placeholder="Confirm your password" TextMode="Password"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtFullName">Full Name:</label>
                <asp:TextBox ID="txtFullName" runat="server" placeholder="Enter your full name"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtAddress">Address:</label>
                <asp:TextBox ID="txtAddress" runat="server" placeholder="Enter your address"></asp:TextBox>
            </div>
            <div class="form-group">
                <label for="txtPhoneNumber">Phone Number:</label>
                <asp:TextBox ID="txtPhoneNumber" runat="server" placeholder="Enter your phone number"></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Button ID="btnRegister" runat="server" Text="Register" OnClick="btnRegister_Click" />
            </div>
        </div>
    </form>
</body>
</html>
