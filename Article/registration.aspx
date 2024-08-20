<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="registration.aspx.cs" Inherits="Article.registration" %>
<!DOCTYPE html>
 <html>
<head>

<meta charset="utf-8">

<title> nav bar</title>

<meta name="viewport" content=" "width=device-width, initial-scale="1.0">

<link rel="stylesheet" href="registration.css">


    <style type="text/css">
        .auto-style1 {
            left: -11px;
            top: 0px;
            width: 101%;
        }
    </style>


</head>

<header>
<div>
    <label class="logo" style="margin-top:0px;top:0px; left:1px; font-size:50px;">Articles</label>
    <br />
    <br />
    <br />
    <br />

</div>
 <nav class="auto-style1">
<ul>
<li><a class="#" href="head.aspx">Home</a></li>
<li><a href="#"> Blogs</a></li>

<li><a class="#" href="aboutus.aspx">About us</a></li>
<li><a class="#" href="cont.aspx"> Contact Us</a></li>

<li><a class="#" href="login.aspx">Login</a></li>
<%--<input type="search" name="" placeholder="search" class="search" style="border-radius: 25px; height: 30px;text-indent: 20px;">--%>
</ul>
</nav>
</header>
<body style="background: linear-gradient(rgba(198, 145, 145, 0.527),rgba(54, 4, 4, 0.5)),url(pic4.jpg) no-repeat;background-size: cover">
    <div class="abc">    
        <div class="container"></div>
    <form id="form1" runat="server">
      <h1 >Register</h1>
        <p>Please fill in this form for new user</p>
         <label><b>Username</b></label>
        <br />
        <asp:TextBox ID="TextBox1" runat="server" placeholder="enter username" style="border-radius: 25px;"></asp:TextBox>
    <br/>
      <label><b>email</b></label>
        <br />
        <asp:TextBox ID="TextBox2" runat="server" placeholder="enter email" style="border-radius: 25px;"></asp:TextBox>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="Email is not valid" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="Please enter email id" ForeColor="Red"></asp:RequiredFieldValidator>
  &nbsp;<br/>
      <label><b>Qualification</b></label>
        <br />
        <asp:TextBox ID="TextBox3" runat="server" placeholder="enter qualification" style="border-radius: 25px;"></asp:TextBox>
        <br />
         <label><b>Password</b></label>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox4" ControlToValidate="TextBox5" ErrorMessage="CompareValidator" style="border-radius: 25px;"></asp:CompareValidator>
        <br />
        <asp:TextBox ID="TextBox4" runat="server" placeholder="enter password" TextMode="Password" style="border-radius: 25px;"></asp:TextBox>
   <br />
              <label><b> confirm Password</b></label>
        <br />
<asp:TextBox ID="TextBox5" runat="server" placeholder="repeat password" style="border-radius: 25px;" TextMode="Password" ></asp:TextBox>
        <asp:Label ID="Label1" runat="server"></asp:Label>
        <asp:Button ID="Button1" class="registerbtn" OnClick="Button1_Click" runat="server" Text="register" style="border-radius: 25px;"/>
    </form>  

    </div>
      </body>
     </html>