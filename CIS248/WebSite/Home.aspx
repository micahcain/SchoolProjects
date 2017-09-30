<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Home.aspx.vb" Inherits="_Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Micah Cain</title>
</head>
<body bgcolor="black">
    <form id="form1" runat="server">
    <div style="text-align: left">
        <span style="font-size: 24pt; color: red"><h1><center>Welcome to Micah's Web Site</center></h1><br /> <hr  /><br />
            <asp:Button ID="personalButton" runat="server" Height="48px" PostBackUrl="~/Personal.aspx"
                Text="BIO" Width="88px" />
            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
            &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;<center><img src="IMG000003.jpg" /></center>
            <br />
            <asp:Button ID="resumeButton" runat="server" Height="48px" PostBackUrl="~/myResume.aspx"
                Text="Resume" Width="88px" /><br />
            <br /><br />
            <br />
        </span>
    </div>
    </form>
</body>
</html>
