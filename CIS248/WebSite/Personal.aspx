<%@ Page Language="VB" AutoEventWireup="false" CodeFile="Personal.aspx.vb" Inherits="Personal" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Micah Cain - Brief Biography</title>
</head>
<body bgcolor="black">
    <form id="form1" runat="server">
    <div style="text-align: center">
    <h1><font color="red">Just a little about me</font></h1>
    <hr />
    <p><font color="red">My name is Micah Cain. I am currently a student at Henderson Community College. My studies are
     focused on software development, and I hope one day to have a career in the same field. This web page serves as
    both an introduction and a small sample of the skills that I have obtained thus far. I say a small sample 
    due to the fact that I have obtained a number of other skills that are not present in this site. To 
    see the extent of my knowledge, please take a look at my <a href="myResume.aspx">resume page</a>.
        Byond my intelectual persuits, I am active at Henderson Community College in a number
        of ways. My favorite being the Henderson Community Theatre. The first picture below
        is one of me in costume for my role as Emperor Joseph in Peter Shaffer's "Amadeus"
        which ran at the theatre this March. I am also on the HCC academic team which particiates
        in Kentucky Collegiate Quick Recall League tournaments. I was also recently inducted
        into the Phi Theta Kappa National Honor Society for accademic performance. &nbsp;The second picture is one of me at home with my roomate's cat. It serves no purpose,
        but I figured, why not.</font></p>
        <p>
       </p>
       <center><img src="075.jpg" style="width: 208px; height: 352px" /> &nbsp; <img src="IMG000027.jpg" style="width: 240px; height: 216px" /></center> 
            &nbsp;<p>
            <font color="red">
                <asp:Button ID="homeButton" runat="server" Height="48px" PostBackUrl="~/Home.aspx"
                    Text="Home" Width="104px" /></font>&nbsp;</p>
    
    </div>
    </form>
</body>
</html>
