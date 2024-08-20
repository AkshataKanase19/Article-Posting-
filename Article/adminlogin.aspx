<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminlogin.aspx.cs" Inherits="Article.adminlogin" %>


<!DOCTYPE html>
<html><head>
   <meta charset="utf-8">
    <title>xyzs</title>
    <meta name="viewport" content="" width=device-width, initial-scale="1.0">
    <link rel="stylesheet" href="post.css">
    <style type="text/css">
        .auto-style1 {
            margin-left: 1277px;
        }
        .auto-style2 {
            display: flex;
            width: 70%;
            justify-content: space-around;
            height: 917px;
        }
        .auto-style3 {
            left: -21px;
            top: 0px;
            width: 100%;
        }
    </style>
    <%--<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.2/css/all.min.css" />--%>

</head>
    <form id="form1" runat="server">

    <header>
<!--<input type="checkbox" id="check">

<label for="check" class="checkbtn">

<i class="fas fa-bars"></i>
-->
<div>
 <label class="log" style="margin-top:0px; top: -1px; font-weight:bold; font-size:50px;">Articles</label>
   <%-- <button class="admin" style="cursor:pointer;background-color: #390303; color:white;"><a runat="server">LogOut</a></button>--%>
    <asp:Button runat="server" Text="LogOut" ID="button1" BackColor="#390303" CssClass="auto-style1" ForeColor="White" OnClick="button1_Click" Width="196px" style="border-radius: 25px" Height="39px" />
</div>
<nav style="margin-top:10px;" class="auto-style3">
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
<body style="background: linear-gradient(rgba(253, 252, 252, 0.527),rgba(37, 6, 6, 0.5));background-size: cover; overflow:scroll;">

<div class="abc">
<div class="auto-style2" style="margin-top:50px;">
<div class="card" style="height:350px;">

<img src="blog2.jpg"  />
<div class ="info">
<%--<h1> Mountain</h1>--%>
<p>Read only Images of article...</p>
<button class="btn"><a href="imglog.aspx">Read More</a></button>
</div>
</div>
<div  class="card"style="height:350px;">
<img src="blog3.jpg" />
<div class ="info" >
<%--<h1> Road</h1>--%>
<p >Read Images with discription of article.</p>
<button class="btn"><a href="imgtxtlog.aspx">Read More</a></button>

</div>
</div>


<div class="card" style="height:350px;">
<img src="blog4.jpg" />
<div class ="info" >
<%--<h1> Road</h1>--%>
<p >Read text messages of article..</p>
<button class="btn"><a href="textlog.aspx">Read More</a></button>

               </div>
 </div>
 </div>

</div>
    <div id="imagePlaceholder" runat="server" style="display: flex; flex-wrap: wrap; gap: 90px; border: 1px solid #000; padding: 10px; border-width:7px;">
    <!-- Your dynamic content will be displayed here -->
</div>

</div>

        </form>
 </body>
</html>