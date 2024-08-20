<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="alogin.aspx.cs" Inherits="Article.alogin" %>



<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <title>xyzs</title>
    <meta name="viewport" content="" width=device-width, initial-scale="1.0">
    <link rel="stylesheet" href="alogin.css">
    <style type="text/css">
        .auto-style1 {
            left: -22px;
            top: 20px;
            width: 101%;
        }
    </style>
</head>
  <header>

       <div>
        <label class="log" style="margin-top:0px; top: -1px; font-weight:bold; font-size:50px;">Articles</label>
         <button class="admin" style="cursor:pointer;"><a href="alogin.aspx" runat="server">Admin login</a></button>
</div>
        <nav class="auto-style1">
        <ul>
            <li><a class="#" href="head.aspx"> Home</a></li>
            <li><a href="blog.aspx"> Blogs</a></li>
            <li><a  class="#" href="aboutus.aspx">About Us</a></li>
            <!-- <li><a href=""><button class="abtbtn" onclick="document.getElementById('aboutus').style.display='block'" style="width:auto;">About Us</button></a></li> -->
            <li><a class="#" href="cont.aspx"> Contact Us</a></li>
            <li><a class="#" href="login.aspx">Login</a></li>
            <!-- <li><a href=""><button class="logbtn" onclick="document.getElementById('login').style.display='block'" style="width:auto;">Login</button></a></li> -->
            <%--<input type="search" name="" placeholder="search" class="search" style="border-radius: 25px; height: 30px;text-indent: 20px;">--%>
        </ul>
    </nav>
</header>



<body style="background: linear-gradient(rgba(253, 252, 252, 0.527),rgba(37, 6, 6, 0.5)), url(pic3.jpg) no-repeat;background-size: cover"><div class="abc">  
    <!--<form action="reg.html">-->
    <div class="section"></div>
    <div id="login-form" class="login-page">
        <div class="form-box">
            <div class="button-box">
                <div id="btn" class="boxs"><b>Login Form</b> </div>
                </div>
     <form id="login" class="input-group-login" runat="server">
                    <label>Username: </label>
                    <asp:TextBox ID="TextBox1" class="input-field" placeholder="Enter username" runat="server"></asp:TextBox>
                    <label>Password: </label>
                    <asp:TextBox ID="TextBox2" class="input-field" placeholder="Enter password" runat="server" TextMode="Password"></asp:TextBox>
                   
                    <input type="checkbox" class="check-box"> <span>Remember password</span>
                    <p>By creating an account you agree to our <a href="terms.html">Terms & Privacy</a>.</p>
                    <asp:Button ID="Button1" CssClass="submit-btn" runat="server" Text="login" OnClick="Button1_Click" />

<%--                    <div class="login-register">
                        <p>Don't have an account?
                            <a href ="registration.aspx" class="register-link">Register here</a>
                        </p>
                    </div>--%>
               
               </form>
             </div>
        </div>
</div>
</body>

</html>
