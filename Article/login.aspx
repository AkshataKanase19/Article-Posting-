<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Article.login" %>
<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <title>xyzs</title>
    <meta name="viewport" content="" width=device-width, initial-scale="1.0">
    <link rel="stylesheet" href="login.css">
    <style type="text/css">
        .auto-style1 {
            left: -20px;
            top: 18px;
            width: 101%;
        }
    </style>
</head>
  <header>

    <div>
     <label class="logo" style="margin-top:0px;top:-1px;left:-450px; font-size:50px;">Articles</label>

 </div>
      <br />
      <br />
        <nav class="auto-style1">
        <ul>
            <li><a class="#" href="head.aspx"> Home</a></li>
            <li><a href="#"> Blogs</a></li>
            <li><a  class="#" href="aboutus.aspx">About Us</a></li>
     
            <li><a class="#" href="cont.aspx"> Contact Us</a></li>
            <li><a class="#" href="login.aspx">Login</a></li>

            <%--<input type="search" name="" placeholder="search" class="search" style="border-radius: 25px; height: 30px;text-indent: 20px;">--%>
        </ul>
    </nav>
</header>



<body style="background: linear-gradient(rgba(253, 252, 252, 0.527),rgba(37, 6, 6, 0.5)), url(pic3.jpg) no-repeat;background-size: cover"><div class="abc">  
   
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
                    <asp:Button ID="Button1" CssClass="submit-btn" OnClick="Button1_click" runat="server" Text="login" />

                    <div class="login-register">
                        <p>Don't have an account?
                            <a href ="registration.aspx" class="register-link">Register here</a>
                        </p>
                    </div>
               
               </form>
             </div>
        </div>
</div>
</body>

</html>


