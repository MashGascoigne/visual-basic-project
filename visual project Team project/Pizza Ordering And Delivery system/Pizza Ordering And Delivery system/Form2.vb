Public Class Form2
    Public Property firstorder_total As Integer

    Dim First_Name As String
    Dim Last_Name As String
    Dim City As String
    Dim Sub_Location As String
    Dim Address1 As String
    Dim Address2 As String
    Dim Pin_code As String
    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        First_Name = txtfirstname.Text
        Last_Name = txtlastname.Text
        City = cbxcity.Text
        Sub_Location = txtsublocation.Text
        Address1 = txtaddress1.Text
        Address2 = txtaddress2.Text
        Pin_code = txtpincode.Text
        Lstvorderdetails.Items.Add(First_Name)
        Lstvorderdetails.Items.Add(Last_Name)
        Lstvorderdetails.Items.Add(City)
        Lstvorderdetails.Items.Add(Sub_Location)
        Lstvorderdetails.Items.Add(Address1)
        Lstvorderdetails.Items.Add(Address2)
        Lstvorderdetails.Items.Add(Pin_code)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        MsgBox("Pay the total amount  by sending to this number 0710705457 ")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Lstvorderdetails.Items.Clear()
        txtfirstname.Clear()
        txtlastname.Clear()
        cbxcity.Text = String.Empty
        txtsublocation.Clear()
        txtaddress1.Clear()
        txtaddress2.Clear()
        txtpincode.Clear()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("Tap the payment button.
Enter the recipient's information: Name(Gascoigne Macharia), @username(Gacimash), email(Gacimash@gmail.com), or mobile(0710705457).
Enter the amount, choose the currency, add an (optional) note, and tap Next.
Select your payment method, review your information, and tap Send.")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MsgBox("ENTER CARD DETAILS, Enter your card number, Enter your card expiration MONTH and YEAR, Enter theCard Verification Value number(cvv),ENTER THE OTP CODE and click submit
     ")
        InputBox("cardnumber")
        InputBox("Enter your card expiration MONTH and YEAR")
        InputBox(" Enter theCard Verification Value number(cvv)")
        MsgBox("OTP means One Time Pass-code. This is an additional layer of security most banks and card providers give to customers to protect your card and identity.

The OTP is sent to your mobile or email address which was used when issued the card.

This code is very important and time sensitive. You will not be able to proceed without this one time pass-code.

Note: If you do not have access to the phone where the code was sent we recommend you either ask the person to share the code with you or use an alternative form of payment.

Once the code has been entered, click ok")
        InputBox("ENTER THE OTP CODE and click OK")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        MsgBox("The delivery charge is 200")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
         Const deliverytotal = 200
    Dim order_totall As Integer
        order_totall = firstorder_total + deliverytotal
        Lstvorderdetails.Items.Add(order_totall)
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label10.Text = firstorder_total

    End Sub
End Class