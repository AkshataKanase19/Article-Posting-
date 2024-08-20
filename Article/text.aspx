<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="text.aspx.cs" Inherits="Article.text" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
    <meta name="viewport" content="" width=device-width, initial-scale="1.0">
    <link rel="stylesheet" href="login.css">
    <style type="text/css">
        .auto-style1 {
            left: -28px;
            top: 20px;
            width: 102%;
              margin-top:-11px;
        }
                        .auto-style3 {
    margin-left: 1277px;
}
    </style>
    <form id="form1" runat="server">
    <header>
        <div>
         <label class="logo" style="margin-top:0px;top:-1px;left:-450px; font-size:50px;">Articles</label>
    <asp:Button runat="server" Text="LogOut" ID="button2" BackColor="#390303" CssClass="auto-style3" ForeColor="White" OnClick="button1_Click" Width="196px" style="border-radius: 25px" Height="39px" />

 </div>
        <nav class="auto-style1">
        <ul>
            <li><a class="#" href="head.aspx"> Home</a></li>
            <li><a href="blog.aspx"> Blogs</a></li>
            <li><a  class="#" href="aboutus.aspx">About Us</a></li>
     
            <li><a class="#" href="cont.aspx"> Contact Us</a></li>
            <li><a class="#" href="login.aspx">Login</a></li>

            <%--<input type="search" name="" placeholder="search" class="search" style="border-radius: 25px; height: 30px;text-indent: 20px;">--%>
        </ul>
    </nav>
</header>

</head>
    <body style="background: linear-gradient(rgba(253, 252, 252, 0.527),rgba(37, 6, 6, 0.5)), url(coffee5.jpg) no-repeat;background-size: cover">
   
   
         <br />

 <h1 class="logo" style="margin-left:30%;"> Upload your articles in form of Text </h1>
         <div class="pqr" style="margin-left:33%;">
                <table style="border:1px solid #390303; text-align:center; border-width:3px;" >
        <tr>
            <td>
                Username:-
                    <asp:TextBox ID="TextBox1" runat="server" Height="43px" Width="233px" style="margin-left:10px;margin-top:10px;"></asp:TextBox>
               
            </td>
        </tr>
                    <br />
        <tr>
            <td>
                <br />
                <br />
                Enter your blog here:-<br />
                 <asp:TextBox ID="TextBox2" runat="server" Height="164px" Width="509px" style="margin-left:10px;margin-top:10px;" TextMode="MultiLine"></asp:TextBox>
                  </td>
        </tr>
        <br />
        <br />

 <tr>
    <td>
        <br />
        <br />
           
        &nbsp;
           
        <asp:Button ID="Button1" runat="server" Text="Submit" Height="42px" Width="141px" BackColor="#390303" ForeColor="White"  style="margin-left:2px;margin-top:10px;" OnClick="Button1_Click" />
    </td>
</tr>
        </div>
    </form>
</body>
</html>
