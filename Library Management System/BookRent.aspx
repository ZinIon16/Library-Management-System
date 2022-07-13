<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BookRent.aspx.cs" Inherits="Library_Management_System.BookRent" %>

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
     
 
 
    <h2>Rent a book</h2>
    <br />
    <br />
     <div>
        <table style="width: 100%">
                  <tr>
                <td style="width: 148px">Student Name :</td>
                <td>
                    <asp:TextBox ID="nametxt"  runat="server"  
                         
                        Height="24px" Width="175px"></asp:TextBox>
                     <br />
                    <br />
                </td>
            </tr>
            <tr>
                <td style="width: 148px"> 
                    <asp:DropDownList ID="Bookddl" runat="server">
                    </asp:DropDownList>
                </td>
                <td>
                    <br />
                    <asp:Button ID="rentbtn" runat="server" Text="Rent" OnClick="registerbtn_Click" />
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Select Time Period:<asp:Calendar ID="Calendar1" runat="server" style="margin-left: 265px"></asp:Calendar>
&nbsp;<br />
                    <br />
                    <asp:Label ID="outputlabel" runat="server"></asp:Label>
                    <br />
                </td>
            </tr>
        </table></div>
   <h3> <a href="Login.aspx">Login Here!</a></h3>
 
 
 
    </div>
    </form>
</body>
</html>
