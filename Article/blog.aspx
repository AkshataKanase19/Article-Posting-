<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="blog.aspx.cs" Inherits="Article.blog" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

	<%--  
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8" />
    <title>Blog</title>
    <!-- Add your stylesheets and meta tags here -->
</head>
     <body style="background: linear-gradient(rgba(253, 252, 252, 0.527),rgba(37, 6, 6, 0.5));background-size: cover;overflow:scroll;">
     <div class="abc">
   
    <form id="form1" runat="server">
        <div>
                                          <asp:DataList ID="DataList1" runat="server" BorderColor="Black" BorderWidth="2px" Width="500px">
             
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

        <%--    <tr>
               
                <td><%#Eval("img_date") %>
                   
                </td>
            </tr>
 
        </table>--%>
          <%--  </table>
       
            </div>
    </ItemTemplate>
</asp:DataList>
            <asp:DataList ID="DataList2" runat="server"  BorderColor="Black" BorderWidth="2px" Width="500px">


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
   <%#Eval("title") %>
         </td>
</tr>
         <tr>
             <td>
                 <p>This image is posted by:
                     <%#Eval("username") %></p>
             </td>
         </tr>

     <%--    <tr>
             
             <td><%#Eval("img_date") %>
                 
             </td>
         </tr>
 
     </table>--
         </table>
   
         </div>
 </ItemTemplate>

            </asp:DataList>

            <asp:DataList ID="DataList3" runat="server" BorderColor="Black" BorderWidth="2px" Width="500px">

                <ItemTemplate>
                           <div class="abcd" style="border:1px solid black;padding:10px;">
    <table>
        <tr>
            <td>
                <%#Eval("blog") %>
            </td>
        </tr>
        <tr>
            <td>
                <p>This is posted by:
                    <%#Eval("username") %></p>
            </td>
        </tr>
        <tr>
           
            <td><%#Eval("img_date") %>
               
            </td>
        </tr>
 
    </table>

 </div>
</ItemTemplate>





            </asp:DataList>


        </div>
    </form>
        </div>
</body>
</html>--%>
<%--new code--%>



    <!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="utf-8" />
    <title>Blog</title>
    <style>
 
    .center-container {
        text-align: center;
    }
</style>
    
</head>
     <body style="background: linear-gradient(rgba(253, 252, 252, 0.527),rgba(37, 6, 6, 0.5));background-size: cover;overflow:scroll;">
         
     <div class="ab" style="display: flex; justify-content: center; margin-left: 48%;">
     
    <center>
    <form id="form1" runat="server">
        <div class="center-container">
            <br />
            <h1>Only Images</h1>
                                          <asp:DataList ID="DataList1" runat="server" BorderColor="Black" BorderWidth="2px" Width="500px">
             
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
                <td>

               Username:-<asp:TextBox ID="TextBox2" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
                    <br />
                    <br />
                   Add Comment:<asp:TextBox ID="TextBox1" runat="server" TextMode="MultiLine"></asp:TextBox>
                    <br />
                    <br />
   &nbsp&nbsp&nbsp&nbsp&nbsp <asp:Button ID="btnSubmitReply" runat="server" Text="Submit Reply" OnClick="btnSubmitReply_Click" CommandArgument='<%# Eval("Id") %>' />

                </td>
            </tr>

        <%--    <tr>
               
                <td><%#Eval("img_date") %>
                   
                </td>
            </tr>
 
        </table>--%>

             <asp:DataList ID="DataListReplies" runat="server" BorderColor="Black" BorderWidth="2px" Width="500px">
                        <ItemTemplate>
                            <table>
                                       
                                                   
                                                    <tr>
                                                        <td>
                                                            Reply by: <%# Eval("Username") %>
                                                        </td>
                                                    </tr>
                                                    <tr>
                                                        <td>
                                                            <%# Eval("ReplyText") %>
                                                        </td>
                                             
                                                        </tr>
                                         

                                                            </table>
                        </ItemTemplate>
                    </asp:DataList>

                                    </td>
                                </tr>

            </table>
       
            </div>
    </ItemTemplate>
</asp:DataList>
                <br />
    <h1>Images with Description</h1>
            <asp:DataList ID="DataList2" runat="server"  BorderColor="Black" BorderWidth="2px" Width="500px">


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
             <td>

            Username:-<asp:TextBox ID="TextBox4" runat="server" OnTextChanged="TextBox4_TextChanged"></asp:TextBox>
                 <br />
                 <br />
                Add Comment:<asp:TextBox ID="TextBox3" runat="server" TextMode="MultiLine"></asp:TextBox>
                 <br />
                 <br />
&nbsp&nbsp&nbsp&nbsp&nbsp <asp:Button ID="btnSubmitReply1" runat="server" Text="Submit Reply" OnClick="btnSubmitReply1_Click" CommandArgument='<%# Eval("Id") %>' />

             </td>
         </tr>
           <asp:DataList ID="DataListReplies1" runat="server" BorderColor="Black" BorderWidth="2px" Width="500px">
             <ItemTemplate>
                 <table>
                           
                                        
                                         <tr>
                                             <td>
                                                 Reply by: <%# Eval("Username") %>
                                             </td>
                                         </tr>
                                         <tr>
                                             <td>
                                                 <%# Eval("ReplyText") %>
                                             </td>
                                 
                                             </tr>
                             

                                                 </table>
             </ItemTemplate>
         </asp:DataList>
   
                 
             </td>
         </tr>
 
 
         </table>
   
         </div>
 </ItemTemplate>

            </asp:DataList>
                          <br />
  <h1>only Description</h1>

            <asp:DataList ID="DataList3" runat="server" BorderColor="Black" BorderWidth="2px" Width="500px">

                <ItemTemplate>
                           <div class="abcd" style="border:1px solid black;padding:10px;">
    <table>
        <tr>
            <td>
                <%#Eval("blog") %>
            </td>
        </tr>
        <tr>
            <td>
                <p>This is posted by:
                    <%#Eval("username") %></p>
            </td>
        </tr>
        <tr>
           
            <td><%#Eval("img_date") %>
               
            </td>
        </tr>
                          <tr>
             <td>

            Username:-<asp:TextBox ID="TextBox6" runat="server" OnTextChanged="TextBox6_TextChanged"></asp:TextBox>
                 <br />
                 <br />
                Add Comment:<asp:TextBox ID="TextBox5" runat="server" TextMode="MultiLine"></asp:TextBox>
                 <br />
                 <br />
&nbsp&nbsp&nbsp&nbsp&nbsp <asp:Button ID="btnSubmitReply2" runat="server" Text="Submit Reply" OnClick="btnSubmitReply2_Click" CommandArgument='<%# Eval("Id") %>' />

             </td>
         </tr>
           <asp:DataList ID="DataListReplies2" runat="server" BorderColor="Black" BorderWidth="2px" Width="500px">
             <ItemTemplate>
                 <table>
                           
                                         
                                         <tr>
                                             <td>
                                                 Reply by: <%# Eval("Username") %>
                                             </td>
                                         </tr>
                                         <tr>
                                             <td>
                                                 <%# Eval("ReplyText") %>
                                             </td>
                                 
                                             </tr>
                             

                                                 </table>
             </ItemTemplate>
         </asp:DataList>
   
                 
             </td>
         </tr>
 
    </table>

 </div>
</ItemTemplate>

     </asp:DataList>

        </div>
    </form>
        </center>
        </div>
</body>
</html>


	
</asp:Content>
