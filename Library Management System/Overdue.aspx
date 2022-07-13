<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Overdue.aspx.cs" Inherits="Library_Management_System.Overdue" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml Jump ">
<head runat="server">
    <title></title>
        <style type="text/css">

         body {
              background-image: url("Images/istockphoto-1215895214-1024x1024.jpg");
             background-size: cover;
             background-repeat: no-repeat;
             background-attachment: fixed;
             font-family: "Open Sans", sans-serif;
   color: #333333
         }
        </style> 
</head>
<body>
    <form id="form1" runat="server">
    <div>
     
 
 
    <h2>Overdue borrowed books:</h2>
    <br />
    <br />
     <div>
        <table style="width: 49%">
                  <tr>
                <td style="width: 148px"> 
                    &nbsp;</td>
                <td>
                    <br />
                    <br />
                    <br />
                    <asp:Button ID="displaybtn" runat="server" Text="Display" OnClick="registerbtn_Click" />
                    <br />
                </td>
            </tr>
        </table></div>
   <h3> <a href="Login.aspx">Login Here!</a>
       <a href="AddBook.aspx">Add Book</a>
        </h3>
 
 <asp:GridView ID="GridView1" runat="server" Width="416px" AutoGenerateColumns="False" DataKeyNames="id" DataSourceID="SqlDataSource1" Visible="False">
        <Columns>
            <asp:BoundField DataField="id" HeaderText="id" InsertVisible="False" ReadOnly="True" SortExpression="id" />
            <asp:BoundField DataField="RentedBook" HeaderText="RentedBook" SortExpression="RentedBook" />
            <asp:BoundField DataField="DueDate" HeaderText="DueDate" SortExpression="DueDate" />
        </Columns>
                    </asp:GridView>
 
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:mycon %>" SelectCommand="SELECT * FROM [Overdue]"></asp:SqlDataSource>
  
 <h4><asp:Label ID="errorlbl" runat="server" Text=""></asp:Label></h4>
    </div>
    </form>
</body>
</html>
