<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="imgtxtlog.aspx.cs" Inherits="Article.imgtxtlog" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title></title>
    <meta name="viewport" content="" width=device-width, initial-scale="1.0">
    <link rel="stylesheet" href="login.css">
    <style type="text/css">
        .auto-style2 {
            left: -21px;
            top: 20px;
            width: 100%;
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
    <body style="background: linear-gradient(rgba(253, 252, 252, 0.527),rgba(37, 6, 6, 0.5));background-size: cover;overflow:scroll;">
        <div class="abc">
   
               <div >
  

            <asp:DataList ID="DataList1" runat="server" BorderColor="#390303" BorderWidth="2px">
    <ItemTemplate>
        <div class="abcd" style="border:1px solid black;padding:10px; border:1px solid black;
            padding:10px;
            width:500px;
            margin:10px;
            float:left;">
        <table>
            <tr>
                <td>
                    <img src="<%#Eval("imgpath") %>"" height="500" width="400" />
                </td>
            </tr>
                     <tr>
               <td>
            <%#Eval("title") %>
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
            <asp:Button ID="btnpost" runat="server" Text="Post" CommandArgument='<%# Eval("imgpath") %>'  OnClick="btnpost_Click"/>

            </div>
    </ItemTemplate>
</asp:DataList>
     
       </div>
    </form>
</body>
</html>