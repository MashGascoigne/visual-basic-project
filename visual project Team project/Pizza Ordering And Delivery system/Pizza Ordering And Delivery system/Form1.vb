Imports System.Net
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Dim Cheese_pizza As String
    Dim Veggie_pizza As String
    Dim Pepperoni_Pizza As String
    Dim Meat_pizza As String
    Dim Marghareta_pizza As String
    Dim BBQ_ChickenPizza As String
    Dim hawaiian_pizza As String
    Dim buffalo_pizza As String
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim Extra_large As Integer
        Dim Large As Integer
        Dim Medium As Integer
        Dim Small As Integer
        Dim Quantity As Integer
        Const drinks = 70
        Dim order_total As Integer
        Quantity = numquantity.Value
        Extra_large = 1800
        Large = 1400
        Medium = 1000
        Small = 600

        If rdbextralarge.Checked Then
            order_total = Quantity * Extra_large + drinks
            MsgBox(order_total)
        ElseIf rdblarge.Checked Then
            order_total = Quantity * Large + drinks
            MsgBox(order_total)
        ElseIf rdbmedium.Checked Then
            order_total = Quantity * Medium + drinks
            MsgBox(order_total)
        ElseIf rdbsmall.Checked Then
            order_total = Quantity * Small + drinks
            MsgBox(order_total)
        End If
        lstborderdetails.Items.Add("costing;")
        lstborderdetails.Items.Add(order_total)
        Dim OBJ As New Form2
        OBJ.firstorder_total = order_total
        OBJ.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If rdbextralarge.Checked Then
            lstborderdetails.Items.Add("Ordered An Extra large sized pizza")
        ElseIf rdblarge.Checked Then
            lstborderdetails.Items.Add("Ordered A large sized pizza")
        ElseIf rdbmedium.Checked Then
            lstborderdetails.Items.Add("Ordered A medium sized pizza")
        ElseIf rdbsmall.Checked Then
            lstborderdetails.Items.Add("Ordered A small sized pizza")
        End If
        If rdbpineapple.Checked Then
                lstborderdetails.Items.Add("Extra toppings of Pineapple")
            ElseIf rdbpepperoni.Checked Then
                lstborderdetails.Items.Add("Extra toppings of Pepperoni")
            ElseIf rdbmushroom.Checked Then
                lstborderdetails.Items.Add("Extra toppings of Mushroom")
            ElseIf rdbblackolives.Checked Then
                lstborderdetails.Items.Add("Extra toppings of Black Olives")
            ElseIf rdbcheese.Checked Then
                lstborderdetails.Items.Add("Extra toppings of Cheese")
            ElseIf rdbsausages.Checked Then
                lstborderdetails.Items.Add("Extra toppings of Sausages")
            Else
                lstborderdetails.Items.Add("You haven't selected any Extra Toppings")
            End If
            If rdbhoneychipotlebbq.Checked Then
                lstborderdetails.Items.Add("The Dipping Sauce is Honey Chipotle BBQ")
            ElseIf rdbgarlicmayonnaise.Checked Then
                lstborderdetails.Items.Add("The Dipping Sauce is Garlic Mayonnaise")
            ElseIf rdbscotchbonnetjam.Checked Then
                lstborderdetails.Items.Add("The Dipping Sauce is Scotch Bonnet Jam")
            ElseIf rdbsmokychipotlemayo.Checked Then
                lstborderdetails.Items.Add("The Dipping Sauce is Smocky Chipotle Mayo")
            ElseIf rdbhoneysrirachadrizzle.Checked Then
                lstborderdetails.Items.Add("The Dipping Sauce is Honey Sriracha Drizzle")
            ElseIf rdbspicymarinara.Checked Then
                lstborderdetails.Items.Add("The Dipping Sauce is Spicy Marinara")
            Else
                lstborderdetails.Items.Add("You haven't selected any Dipping Sauce")
            End If
            If rdbwater.Checked Then
                lstborderdetails.Items.Add("Selected Drink is Water")
            ElseIf rdbcoke.Checked Then
                lstborderdetails.Items.Add("Selected Drink is Coke")
            ElseIf rdbfantapassion.Checked Then
                lstborderdetails.Items.Add("Selected Drink is Fanta Passion")
            ElseIf rdbfantaorange.Checked Then
                lstborderdetails.Items.Add("Selected Drink is Fanta Orange")
            ElseIf rdbfantablackcurent.Checked Then
                lstborderdetails.Items.Add("Selected Drink is Fanta Blackcurrent")
            ElseIf rdbkrest.Checked Then
                lstborderdetails.Items.Add("Selected Drink is Krest")
            ElseIf rdbsprite.Checked Then
                lstborderdetails.Items.Add("Selected Drink is Sprite")
            ElseIf rdbsparklingwater.Checked Then
                lstborderdetails.Items.Add("Selected Drink is Sparkling Water")
            Else
                lstborderdetails.Items.Add("You haven't selected any Drink")
            End If

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        lstborderdetails.Items.Clear()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ComboBox1.SelectedIndex > -1 Then
            Dim sindex As Integer
            sindex = ComboBox1.SelectedIndex
            Dim sitem As Object
            sitem = ComboBox1.SelectedItem
            lstborderdetails.Items.Add(sitem)
        End If
    End Sub
End Class
