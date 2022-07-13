<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Library_Management_System.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>  
      <style type="text/css">  
          .auto-style1 {  
              position:absolute;
              top:40px;

            width: 86%;
              height: 223px;
          }
          body {
              background-image: url("Images/istockphoto-1215895214-1024x1024.jpg");
              background-size: cover;
              background-repeat: no-repeat;
              background-attachment: fixed;
              font-family: "Open Sans", sans-serif;
              color: #333333;
          }
        Label1{
            position:absolute;
            font-family:Vivaldi;
            color:blue;

        }
          Label2{
            position:absolute;
            top:500px;
            left:200px;
            font-family:Vivaldi;
                        color:blue;
        }
            Label3{
            position:absolute;
            top:500px;
            left:200px;
            font-family:Vivaldi;
            color:blue;
        }
        div{
            background-color:aquamarine;
            opacity:1;
            color:cadetblue;
        }
    </style>  
</head>  
<body>  
    <form id="form1" runat="server">  
    <div>  
      
        <table class="auto-style1">  
            <tr>  
                <td colspan="6" style="text-align: center; vertical-align: bottom">  
                    <asp:Label ID="Label1" CssClass="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" Font-Underline="True" Text="Log In " ForeColor="Blue"></asp:Label>  
                </td>  
            </tr>  
            <tr>   
                <td> </td>  
                <td style="text-align: center">  
                    <asp:Label ID="Label2" CssClass="Label2" runat="server" Font-Size="X-Large" Text="User Id :" ForeColor="Blue"></asp:Label>  
                </td>  
                <td style="text-align: center">  
                    <asp:TextBox ID="TextBox1" runat="server" Font-Size="X-Large" Width="182px"></asp:TextBox>  
                    <asp:RequiredFieldValidator ID="vTextBox1" 
   runat="server" ControlToValidate ="TextBox1"
   ErrorMessage="Please enter your User ID" ForeColor="Black"></asp:RequiredFieldValidator>
                </td>  
                <td> </td>  
                <td> </td>  
                <td> </td>  
            </tr>  
            <tr>  
                <td> </td>  
                <td style="text-align: center">  
                    <asp:Label ID="Label3" CssClass="Label3" runat="server" Font-Size="X-Large" Text="Password :" ForeColor="Blue"></asp:Label>  
                </td>  
                <td style="text-align: center">  
                    <asp:TextBox ID="TextBox2" runat="server" Font-Size="X-Large" TextMode="Password" Width="174px"></asp:TextBox>  
                <asp:RequiredFieldValidator ID="vTextBox2" 
   runat="server" ControlToValidate ="TextBox2"
   ErrorMessage="Please enter your Password"  ForeColor="Black"></asp:RequiredFieldValidator>
                </td>  
            </tr>  
            <tr>  
                <td> </td>  
                <td> </td>  
                <td> </td>  
                <td> </td>  
                <td> </td>  
                <td> </td>  
            </tr>  
            <tr>  
                <td> </td>  
                <td> </td>  
                <td style="text-align: justify-all">  
                    <asp:Button ID="Button1" runat="server" BorderStyle="None" Font-Size="X-Large" OnClick="Button1_Click" Text="Log In" BackColor="#99CCFF" BorderColor="#3333CC" />  
                </td>  
            </tr>  
            <tr>  
                <td> </td>  
                <td> </td>  
                <td>  
                    <asp:Label ID="Label4" CssClass="Label4" runat="server" Font-Size="X-Large"></asp:Label>  
                &nbsp;&nbsp;&nbsp;
                    <div>
                        <h3><a href="RegisterAdmin.aspx">Want be an Admin?</a>
                            <a href="RegisterStu.aspx">Register as a student??</a>
                        </h3>
                    </div>
                </td>  
                <td> </td>  
                <td> </td>  
                <td> </td>  
            </tr>  
        </table>  
      
        <asp:DropDownList ID="DropDownList1" runat="server" >
        </asp:DropDownList>
      
    </div>  
   
        
    </form>  
    
       
</body>  
