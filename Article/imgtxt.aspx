<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="imgtxt.aspx.cs" Inherits="Article.imgtxt" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
    <meta name="viewport" content="" width=device-width, initial-scale="1.0">
    <link rel="stylesheet" href="login.css">
    <style type="text/css">
        .auto-style1 {
            height: 97px;
        }
        .auto-style2 {
            left: -23px;
            top: 20px;
            width: 101%;
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
        <nav class="auto-style2">
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
    <%--<body style="background: linear-gradient(rgba(253, 252, 252, 0.527),rgba(37, 6, 6, 0.5));background-size: cover;overflow:scroll;">--%>
        <%--<div class="abc">--%>
 <body style="background: linear-gradient(rgba(253, 252, 252, 0.527),rgba(37, 6, 6, 0.5)), url(coffee1.jpg) no-repeat;background-size: cover">
   
   
        <br />
         <h1 class="loggo" style="margin-left:270px;">Upload your articles in form of Images with description </h1>
                     <div>
               
    <table style="border:1px solid #390303;  text-align:center; margin-left:39%;border-width:3px;">
        <tr>
            <td>
                <p>
                    <asp:TextBox ID="TextBox2" runat="server" placeholder="Enter Username" Height="43px" Width="233px" style="margin-left:10px;margin-top:10px;"></asp:TextBox>
                </p>
            </td>
        </tr>
        <tr>
            <td>
                <p>
                    <asp:FileUpload ID="FileUpload1" runat="server" style="margin-left:10px;margin-top:10px;" />
                </p>
            </td>
        </tr>
        <br />
        <br />

 <tr>
    <td>
        <p>
            <asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine" placeholder="Enter Your description" Height="48px" style="margin-left:10px;margin-top:10px;"></asp:TextBox>
        </p>
    </td>
</tr>
<tr>
    <td class="auto-style1">
        <p>
            <asp:Button ID="Button1" runat="server" Text="Submit" Height="42px" Width="141px" BackColor="#390303" ForeColor="White"  style="margin-left:10px;margin-top:10px;" OnClick="Button1_Click" />
        </p>
    </td>
</tr>
    </table>

       </div>
    </form>
</body>
</html>