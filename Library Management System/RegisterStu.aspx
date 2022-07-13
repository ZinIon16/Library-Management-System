<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterStu.aspx.cs" Inherits="Library_Management_System.RegisterStu" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml Jump ">
<head runat="server">
    <title></title>
        <style type="text/css">
            body{
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
     
 
 
    <h2>REGISTER YOUR ACCOUNT</h2>
    <br />
    <br />
     <div>
        <table style="width:148px" >
                  <tr>
                <td style="width: 148px">Username :</td>
                <td>
                    <asp:TextBox ID="email"  runat="server"  
                         
                        Height="24px" Width="175px"></asp:TextBox>
                     <br />
                    <br />
                </td>
            </tr>
            <tr>
                <td style="width: 148px">Password :</td>
                <td>
                    <asp:TextBox ID="password" runat="server" ></asp:TextBox>
                    <br />
                    <br />
                </td>
            </tr>
            <tr>
                <td style="width: 148px"> </td>
                <td>
                    <br />
                    <asp:Button ID="registerbtn" runat="server" Text="Register" OnClick="registerbtn_Click" />
                    <br />
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