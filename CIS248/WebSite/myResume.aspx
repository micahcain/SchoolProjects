<%@ Page Language="VB" AutoEventWireup="false" CodeFile="myResume.aspx.vb" Inherits="myResume" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Micah Cain - Resume</title>
</head>
<body bgcolor="black">
    <form id="form1" runat="server">
    <div>
    <center><h1><font color="red">Accolades</font></h1></center>
    <hr /><br /><br />
    <center><table width="50%" border="25">
    <tr>
    <td><font color="red">High School</font></td>
    <td>
        <span style="color: red">Brewbaker Technology Magnet High School</span></td>
    <td style="width: 13px">
        <span style="color: red">Achieved: Advanced&nbsp; Academic Endorsement Diploma</span></td>
    </tr>
    <tr>
    <td style="height: 18px">
        <span style="color: red">Trade/Technical</span></td>
    <td style="height: 18px">
        <span style="color: red">Earle C. Clements Job Corps Academy</span></td>
    <td style="width: 13px; height: 18px">
        <span style="color: red">Achieved:
            A+ Certification</span></td>
    </tr>
    <tr>
    <td>
        <span style="color: red">College</span></td>
    <td>
        <span style="color: red">Henderson Community College</span></td>
    <td>
        <span style="color: red">Achievements:<br />
            A+ Recognition<br />
            Maintaining 4.0 gpa<br />
            Member:
            Phi Theta Kappa Honor Society<br />
            Member: HCC Academic Team<br />
            Member: Henderson Community Theatre<br />
            ...Many More To Come!</span></td>
    </tr>
    </table></center>
        <center>
            &nbsp;</center>
        <center>
            <asp:Button ID="homeButton" runat="server" Height="56px" PostBackUrl="~/Home.aspx"
                Text="Home" Width="96px" />&nbsp;</center>
    </div>
    </form>
</body>
</html>
