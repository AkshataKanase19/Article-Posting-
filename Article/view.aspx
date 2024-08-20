<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="view.aspx.cs" Inherits="Article.view" %>

<!doctype html>
<html>
    <head runat="server">
        <title></title>
    </head>
    <body>
        <form id="form1" runat="server">
            <div style="float:left">
                <table border="1">
                <tr><td>
                    <h1>&nbsp;upload image</h1></td>
                </tr>
                <tr>
                   <td> <asp:Label ID="Label1" runat="server" Text="upload image"></asp:Label></td>
                    <td>
                        <asp:FileUpload ID="FileUpload1" runat="server" /></td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        <asp:Button ID="Button1" runat="server" Text="submit" Height="67px" OnClick="Button1_Click" Width="174px" /></td>
                </tr>
                    </table>
            </div>
            <div style="float:right">
                <asp:DataList ID="DataList1" runat="server" BackColor="Maroon">
                    <ItemTemplate>
                        <asp:Label ID="Label2" runat="server" Text="number"></asp:Label>
                        <asp:Label ID="Label3" runat="server" Text='<%#Eval("Id") %>'></asp:Label>
                        <image src="image/<%#Eval("image") %>" height="150" width="180"/>
                    </ItemTemplate>
                </asp:DataList>
            </div>
        </form>
    </body>
</html>