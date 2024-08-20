<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="cont.aspx.cs" Inherits="Article.cont" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <%-- <!DOCTYPE html>
<!-- Created By CodingLab - www.codinglabweb.com -->
<html lang="en" dir="ltr">
  <head>
    <meta charset="UTF-8">
    <title> Responsive Contact Us Form  | CodingLab </title>
    <link rel="stylesheet" href="temp.css">
    <!-- Fontawesome CDN Link -->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.2/css/all.min.css"/>
     <meta name="viewport" content="width=device-width, initial-scale=1.0">
   </head>
<body style="background: linear-gradient(rgba(198, 145, 145, 0.527),rgba(54, 4, 4, 0.5)),url(laptop.jpg) no-repeat;background-size: cover">
  <div class="container">
    <div class="content">
      <div class="left-side" style="font-weight:550; font-size:20px;">
        <div class="address details">
          <i class="fas fa-map-marker-alt"></i>
          <div class="topic" style="font-weight:550; font-size:20px;">Address</div>
          <div class="text-one">Maharashtra,Satara</div>
          <div class="text-two">Powai Naka</div>
        </div>
        <div class="phone details">
          <i class="fas fa-phone-alt"></i>
          <div class="topic" style="font-weight:550; font-size:20px;">Phone</div>
          <div class="text-one">785965856</div>
          <div class="text-two">973937354</div>
        </div>
        <div class="email details">
          <i class="fas fa-envelope"></i>
          <div class="topic" style="font-weight:550; font-size:20px;">Email</div>
          <div class="text-one">abasdaf@gmail.com</div>
          <div class="text-two">fhdjfhb@gmail.com</div>
        </div>
      </div>
      <div class="right-side">
          <br /> <br />
        <div class="topic-text" style="font-size:40px;">Send us a message</div>
        <p style="font-weight:550; font-size:20px;">If you have any work from me or any types of quries related to my tutorial, you can send me message from here. It's my pleasure to help you.</p>
      <form action="#">
        <div class="input-box">
          <input type="text" placeholder="Enter your name" name="firstname">
        </div>
        <div class="input-box">
          <input type="text" placeholder="Enter your email" name="email">
        </div>
        <div class="input-box message-box">
         <input type="text" placeholder="Enter your message" name="message"> 
        </div>
        <div class="button">
        <input type="button" value="Send Now" >
         
            <br />
            <br />   <br />  <br /> <br /> <br /> <br />
        </div>
      </form>
    </div>
    </div>
  </div>
</body>
</html>--%>
    
 <!DOCTYPE html>
   
<html lang="en">
  <head>
    <meta charset="UTF-8">
    <title> Contact us </title>
    <link rel="stylesheet" href="temp.css">
    <!-- Fontawesome CDN Link -->
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.2/css/all.min.css"/>
     <meta name="viewport" content="width=device-width, initial-scale=1.0">
   </head>
   <body style="background: linear-gradient(rgba(198, 145, 145, 0.527),rgba(54, 4, 4, 0.5)),url(laptop.jpg) no-repeat;background-size: cover">

     
     
  <div class="container">
    <div class="content">
      <div class="left-side" style="font-weight:550; font-size:20px;">
        <div class="address details">
          <i class="fas fa-map-marker-alt"></i>
          <div class="topic" style="font-weight:550; font-size:20px;">Address</div>
          <div class="text-one">Maharashtra,Satara</div>
          <div class="text-two">Powai Naka</div>
        </div>
        <div class="phone details">
          <i class="fas fa-phone-alt"></i>
          <div class="topic" style="font-weight:550; font-size:20px;">Phone</div>
          <div class="text-one">785965856</div>
          <div class="text-two">973937354</div>
        </div>
        <div class="email details">
          <i class="fas fa-envelope"></i>
          <div class="topic" style="font-weight:550; font-size:20px;">Email</div>
          <div class="text-one">abasdaf@gmail.com</div>
          <div class="text-two">fhdjfhb@gmail.com</div>
        </div>
      </div>
      <div class="right-side">
          <br /> <br />
        <div class="topic-text" style="font-size:40px;">Send us a message</div>
        <p style="font-weight:550; font-size:20px;">If you have any work from me or any types of quries related to my tutorial, you can send me message from here. It's my pleasure to help you.</p>
          <%--<input type="text" placeholder="Enter your name">--%>
          <form id="form1" runat="server">
        <div class="input-box">
            <%-- <input type="text" placeholder="Enter your email">--%>
            <asp:TextBox ID="txtName" runat="server" placeholder="Name"></asp:TextBox>
        </div>
        <div class="input-box">
            <%-- <input type="text" placeholder="Enter your message"> --%>

            <asp:TextBox ID="txtEmailId" runat="server" placeholder="Email"></asp:TextBox>  

        </div>
        <div class="input-box message-box">
            <%--<input type="button" value="Send Now" >--%>
            <asp:TextBox ID="txtMessage" runat="server" placeholder="Message"></asp:TextBox>
        </div>
        <div class="button">
        <%--<input type="button" value="Send Now" >--%>
            <asp:Button ID="txtSubmit" runat="server" Text="Send" BackColor="#390303" ForeColor="White" Height="45px" Width="103px" OnClick="txtSubmit_Click" />
           <%--OnClick="txtSubmit_Click" />--%>
         
            <br />
            <br />   <br />  <br /> <br /> <br /> <br />
        </div>
      </form>
          <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
    </div>
    </div>
  </div>
</body>
</html>
</asp:Content>
