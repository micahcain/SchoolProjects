'Class Name:         Loan
'Class Purpose:      Define Loan objects
'Created/revised by: Micah Cain

Public Class Loan
    'instance variables
    Private _amount As Double
    Private _interest As Double
    Private _term As Double

    'constructor
    Public Property Amount() As Double
        Get
            Return _amount
        End Get
        Set(ByVal value As Double)
            _amount = value
        End Set
    End Property
    Public Property Interest() As Double
        Get
            Return _interest
        End Get
        Set(ByVal value As Double)
            _interest = value
        End Set
    End Property
    Public Property Term() As Double
        Get
            Return _term
        End Get
        Set(ByVal value As Double)
            _term = value
        End Set
    End Property
    Public Sub New(ByVal amount As Double, ByVal interest As Double, ByVal term As Double)
        _amount = Amount
        _interest = Interest
        _term = Term
    End Sub

    Public Function calculateInterest() As Double
        Return _interest * Amount
    End Function

    Public Function calculateMonthlyPayment() As Double
        Dim payment As Double

        payment = (Amount * Interest) / Term
        Return payment
    End Function
End Class
