Public Class Form1

  Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
    Dim checkAmt As Decimal
    Dim percentTip As Decimal
    Dim percent As Decimal
    Dim tipAmt As Decimal

    checkAmt = InputBox("Enter Check Amount", "Tip Calculator", "Enter A Dollar Amount")
    percentTip = InputBox("Enter The Tip Percentage", "Tip Calculator", "15.00")
    percent = percentTip / 100
    tipAmt = checkAmt * percent
    Label1.Text = "A " & percentTip & "% tip on a $" & checkAmt & " bill is " & tipAmt.ToString("C")
  End Sub

  Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

  End Sub

  Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
    Dim readerVar As IO.StreamReader
    Const POPULATION_TOTAL As Decimal = 301139

    readerVar = IO.File.OpenText("population.txt")
    Dim strVar As String = readerVar.ReadLine
    Dim strVar2 As Decimal = readerVar.ReadLine
    Dim strVar3 As Decimal = readerVar.ReadLine
    Dim varTotal As Decimal = strVar2 + strVar3
    ListBox1.Items.Add("Age Group     Males     Females     %Males              %Females                %Total")
    ListBox1.Items.Add(strVar & "     " & strVar2 & "         " & strVar3 & "         " & (strVar2 / varTotal).ToString("P2") _
    & "             " & (strVar3 / varTotal).ToString("P2") & "             " & (varTotal / POPULATION_TOTAL).ToString("P2"))

    strVar = readerVar.ReadLine
    strVar2 = readerVar.ReadLine
    strVar3 = readerVar.ReadLine
    varTotal = strVar2 + strVar3
    ListBox1.Items.Add(strVar & "         " & strVar2 & "         " & strVar3 & "         " & (strVar2 / varTotal).ToString("P2") _
    & "             " & (strVar3 / varTotal).ToString("P2") & "             " & (varTotal / POPULATION_TOTAL).ToString("P2"))

    strVar = readerVar.ReadLine
    strVar2 = readerVar.ReadLine
    strVar3 = readerVar.ReadLine
    varTotal = strVar2 + strVar3
    ListBox1.Items.Add(strVar & "         " & strVar2 & "           " & strVar3 & "           " & (strVar2 / varTotal).ToString("P2") _
    & "              " & (strVar3 / varTotal).ToString("P2") & "              " & (varTotal / POPULATION_TOTAL).ToString("P2"))

  End Sub
End Class
