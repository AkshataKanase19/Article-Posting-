<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="imglog.aspx.cs" Inherits="Article.imglog"  %>

<!DOCTYPE html>
<html><head>
   <meta charset="utf-8">
    <title>xyzs</title>
    <meta name="viewport" content="" width=device-width, initial-scale="1.0">
    <link rel="stylesheet" href="login.css">
    <style type="text/css">
        .auto-style1 {
            left: -15px;
            top: 20px;
            width: 100%;
                margin-top:-11px;
        }
         .auto-style3 {
    margin-left: 1277px;
}
    </style>
</head>
    <form id="form1" runat="server">
    <header>
<!--<input type="checkbox" id="check">

<label for="check" class="checkbtn">


<i class="fas fa-bars"></i>
-->
<div>
   <label class="logo" style="margin-top:0px;top:-1px;left:-450px; font-size:50px;">Articles</label>
    <asp:Button runat="server" Text="LogOut" ID="button2" BackColor="#390303" CssClass="auto-style3" ForeColor="White" OnClick="button1_Click" Width="196px" style="border-radius: 25px" Height="39px" />

</div>
<nav class="auto-style1">
<ul>
<li><a class="#" href="head.aspx">Home</a></li>
<li><a href="blog.aspx"> Blogs</a></li>
<!--
<a href="aboutus.html"><button class="abtbtn" onclick="document.getElementById('aboutus").style.display="block" style="width:auto;"> aboutus</button></a></li>
-->
<li><a class="#" href="aboutus.aspx">About us</a></li>
<li><a class="#" href="cont.aspx"> Contact Us</a></li>
<!---
<li><a href="login.html"><button class="logbtn" onclick="document.getElementById("login").style.display= "block" style="width:auto;">login</button></a></li>
-->
<li><a class="#" href="login.aspx">Login</a></li>
<%--<input type="search" name="" placeholder="search" class="search" style="border-radius: 25px; height: 30px;text-indent: 20px;">--%>

</ul>
</nav>
</header>
<body style="background: linear-gradient(rgba(253, 252, 252, 0.527),rgba(37, 6, 6, 0.5));background-size: cover;overflow:scroll;">
    <div class="abc">
   
   

           <div >
            <asp:DataList ID="DataList1" runat="server" BorderColor="#390303" BorderWidth="2px">
    <ItemTemplate>
        <div class="abcd" style="border:1px solid black;padding:10px;">
        <table>
            <tr>
                <td>
                    <img src="<%#Eval("imgpath") %>"" height="500" width="400" />
                </td>
            </tr>
            <tr>
                <td>
                    <p>This image is posted by:
                        <%#Eval("username") %></p>
                </td>
            </tr>
            <tr>
               
                <td><%#Eval("img_date") %>
                   
                </td>
            </tr>
 
        </table>
         <asp:Button ID="btnDelete" runat="server" Text="Delete" CommandArgument='<%# Eval("imgpath") %>' OnClick="btnDelete_Click" />
      <%--   <asp:Button ID="btnpost" runat="server" Text="Post" OnClick="btnpost_Click" />--%>
            <asp:Button ID="btnpost" runat="server" Text="Post" OnClick="btnpost_Click" CommandArgument='<%# Eval("imgpath") %>' />

            </div>
    </ItemTemplate>
</asp:DataList>
       </div>
         
       
     
    </form>
  <div>
</body>
</html>
