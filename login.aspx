<%@ Page Language="C#" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
     <div>
    <div>
    <center><h1><mark>Login page</mark></h1></center>
    <hr />
    </div>
    <div style=" background-color:Aqua; text-align:center;">
    
    User Name   
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>    
        <br />
        <br />
        
        Password   
        <asp:TextBox ID="TextBox2" runat="server" TextMode="Password"></asp:TextBox>
        <br />
        <br />
        
        <asp:Button ID="Button1" runat="server" Text="login" onclick="Button1_Click" 
            Height="27px" Width="66px" />    
        </div>
    
    </div>
    </form>
</body>
</html>
