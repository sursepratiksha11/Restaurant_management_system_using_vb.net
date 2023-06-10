Imports System.Data
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class HomeForm1
    Dim con As SqlConnection
    Dim cmd As SqlCommand

    Private Sub HomeForm1_Load(ByVal sendr As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        con = New SqlConnection("Data Source=DESKTOP-6RB83T5\SQLEXPRESS;Initial Catalog=records;Integrated Security=True")
        con.Open()
        ComboBox1.Items.Add("")
        ComboBox1.Items.Add("Foods")
        ComboBox1.Items.Add("Drink")
        ComboBox1.Items.Add("Desert")
    End Sub


    Private Sub btnfood_Click(sender As Object, e As EventArgs) Handles btnfood.Click
        Panelfood.Visible = True
        Paneldrinks.Visible = False
        Paneldesert.Visible = False
        Panelabout.Visible = False
        Panelorder.Visible = False

    End Sub

    Private Sub btndrink_Click(sender As Object, e As EventArgs) Handles btndrink.Click
        Panelfood.Visible = False
        Paneldrinks.Visible = True
        Paneldesert.Visible = False
        Panelabout.Visible = False
        Panelorder.Visible = False
    End Sub

    Private Sub btndesert_Click(sender As Object, e As EventArgs) Handles btndesert.Click
        Panelfood.Visible = False
        Paneldrinks.Visible = False
        Paneldesert.Visible = True
        Panelabout.Visible = False
        Panelorder.Visible = False
    End Sub

    Private Sub btnabout_Click(sender As Object, e As EventArgs) Handles btnabout.Click
        Panelfood.Visible = False
        Paneldrinks.Visible = False
        Paneldesert.Visible = False
        Panelabout.Visible = True
        Panelorder.Visible = False
    End Sub

    Private Sub btnclose_Click(sender As Object, e As EventArgs) Handles btnclose.Click
        Me.Close()

    End Sub

    Private Sub btnburger_Click(sender As Object, e As EventArgs) Handles btnburger.Click
        MsgBox("Burger Price is Only 50 rs, Order Now", MsgBoxStyle.OkCancel)

    End Sub

    Private Sub btnpizza_Click(sender As Object, e As EventArgs) Handles btnpizza.Click
        MsgBox("Pizza Price is Only 150 rs, Order Now", MsgBoxStyle.OkCancel)
    End Sub

    Private Sub btnsandwich_Click(sender As Object, e As EventArgs) Handles btnsandwich.Click
        MsgBox("Sandwitch Price is Only 100 rs, Order Now", MsgBoxStyle.OkCancel)
    End Sub

    Private Sub btnpasta_Click(sender As Object, e As EventArgs) Handles btnpasta.Click
        MsgBox("Pasta Price is Only 85 rs, Order Now", MsgBoxStyle.OkCancel)
    End Sub

    Private Sub btnmomous_Click(sender As Object, e As EventArgs) Handles btnmomous.Click
        MsgBox("Momous Price is Only 150 rs, Order Now", MsgBoxStyle.OkCancel)
    End Sub

    Private Sub btnfries_Click(sender As Object, e As EventArgs) Handles btnfries.Click
        MsgBox("Fries Price is Only 65 rs, Order Now", MsgBoxStyle.OkCancel)
    End Sub

    Private Sub btncooffe_Click(sender As Object, e As EventArgs) Handles btncooffe.Click
        MsgBox("coffe Price is Only 50 rs, Order Now", MsgBoxStyle.OkCancel)
    End Sub

    Private Sub btnmilkshek_Click(sender As Object, e As EventArgs) Handles btnmilkshek.Click
        MsgBox("Milkshek Price is Only 75 rs, Order Now", MsgBoxStyle.OkCancel)
    End Sub

    Private Sub btnjuice_Click(sender As Object, e As EventArgs) Handles btnjuice.Click
        MsgBox("Juice Price is Only 65 rs, Order Now", MsgBoxStyle.OkCancel)
    End Sub

    Private Sub btnchoclate_Click(sender As Object, e As EventArgs) Handles btnchoclate.Click
        MsgBox(" Price is Only 85 rs, Order Now", MsgBoxStyle.OkCancel)
    End Sub

    Private Sub btnpinappl_Click(sender As Object, e As EventArgs) Handles btnpinappl.Click
        MsgBox(" Price is Only 85 rs, Order Now", MsgBoxStyle.OkCancel)
    End Sub

    Private Sub btnstr_Click(sender As Object, e As EventArgs) Handles btnstr.Click
        MsgBox(" Price is Only 85 rs, Order Now", MsgBoxStyle.OkCancel)
    End Sub

    Private Sub btnbutter_Click(sender As Object, e As EventArgs) Handles btnbutter.Click
        MsgBox(" Price is Only 85 rs, Order Now", MsgBoxStyle.OkCancel)
    End Sub

    Private Sub btnredvelvet_Click(sender As Object, e As EventArgs) Handles btnredvelvet.Click
        MsgBox(" Price is Only 85 rs", MsgBoxStyle.OkCancel)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        MsgBox(" Price is Only 85 rs, Order Now", MsgBoxStyle.OkCancel)
    End Sub

    Private Sub btnorder_Click(sender As Object, e As EventArgs) Handles btnorder.Click
        Panelfood.Visible = False
        Paneldrinks.Visible = False
        Paneldesert.Visible = False
        Panelabout.Visible = False
        Panelorder.Visible = True

    End Sub

    Private Sub Panelfood_Paint(sender As Object, e As PaintEventArgs) Handles Panelfood.Paint

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            Panelinfofood.Visible = False
            Panelinfodrinks.Visible = False
            Panelinfodesert.Visible = False

        End If
        If ComboBox1.SelectedIndex = 1 Then
            Panelinfofood.Visible = True
            Panelinfodrinks.Visible = False
            Panelinfodesert.Visible = False

        End If
        If ComboBox1.SelectedIndex = 2 Then
            Panelinfofood.Visible = False
            Panelinfodrinks.Visible = True
            Panelinfodesert.Visible = False

        End If
        If ComboBox1.SelectedIndex = 3 Then
            Panelinfofood.Visible = False
            Panelinfodrinks.Visible = False
            Panelinfodesert.Visible = True

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click


        Dim regex As Regex = New Regex("[a-zA-z]")
        Dim valid As Boolean = regex.IsMatch(TextBox1.Text.Trim)
        If Not valid Then
            ErrorProvider1.SetError(TextBox1, "Please Enter Your Name")

        Else

        End If


        Dim obj As Regex = New Regex("[a-zA-Z]")
        Dim ableto As Boolean = obj.IsMatch(TextBox2.Text.Trim)
        If Not ableto Then
            ErrorProvider1.SetError(TextBox2, "Please Enter Your Address")
        Else

        End If

        Dim number As Regex = New Regex("[0-9]{10}")
        Dim valid2 As Boolean = number.IsMatch(TextBox3.Text)
        If Not valid2 Then
            ErrorProvider1.SetError(TextBox3, "Invalid Phone Number ")
        Else

        End If


        If ComboBox1.SelectedItem = "" Then
            ErrorProvider1.SetError(ComboBox1, "Please choose Your Items")
        ElseIf TextBox1.Text = "" Then
            ErrorProvider1.SetError(TextBox1, "Please Enter Your Name")

        ElseIf TextBox2.Text = "" Then
            ErrorProvider1.SetError(TextBox2, "Please Enter Your Address")

        ElseIf TextBox3.Text = "" Then
            ErrorProvider1.SetError(TextBox3, "Please Enter Your Number")


        Else
            Dim str As String
            str = "INSERT INTO [dbo].[records1]([name],[address],[phone],[menu],[total])VALUES ('" & TextBox1.Text & "', '" & TextBox2.Text & "','" & TextBox3.Text & "','" & ComboBox1.SelectedItem.ToString & "','" & labltotal.Text & "')"
            cmd = New SqlCommand(str, con)

            Dim rd As Integer
            rd = cmd.ExecuteNonQuery()
            MessageBox.Show("Your Order Is Place ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            con.Close()
            MsgBox("Thank You", MsgBoxStyle.OkCancel)
        End If




    End Sub

    Private Sub Panelorder_Paint(sender As Object, e As PaintEventArgs) Handles Panelorder.Paint



    End Sub

    ' Private Sub btnback_Click(sender As Object, e As EventArgs)

    ' End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles chekburger.CheckedChanged

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panelinfodrinks.Paint

    End Sub

    Private Sub chekmangojuice_CheckedChanged(sender As Object, e As EventArgs) Handles chekmangojuice.CheckedChanged

    End Sub

    Private Sub chekoreomilk_CheckedChanged(sender As Object, e As EventArgs) Handles chekoreomilk.CheckedChanged

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btntotal.Click
        Const price_burger As Decimal = 50
        Const price_pizza As Decimal = 150
        Const price_sandwitch As Decimal = 100
        Const price_pasta As Decimal = 100

        Const price_momous As Decimal = 150
        Const price_fries As Decimal = 65
        Const price_coffe As Decimal = 50
        Const price_milkshek As Decimal = 75
        Const price_juice As Decimal = 65
        Const price_cake As Decimal = 85
        Const price_icecream As Decimal = 85


        Dim itax As Decimal
        Dim isubtotal As Decimal

        Dim itemcost(26) As Decimal



        itemcost(0) = Convert.ToDecimal(chekburger.Checked) * price_burger
        itemcost(1) = Convert.ToDecimal(chekstrwberrypestry.Checked) * price_pizza
        itemcost(2) = Convert.ToDecimal(cheksandwitch.Checked) * price_sandwitch
        itemcost(3) = Convert.ToDecimal(chekpasta.Checked) * price_pasta
        itemcost(4) = Convert.ToDecimal(chekmomous.Checked) * price_momous
        itemcost(5) = Convert.ToDecimal(chekfries.Checked) * price_fries
        itemcost(6) = Convert.ToDecimal(chekcappuccino.Checked) * price_coffe
        itemcost(7) = Convert.ToDecimal(checkcoffee.Checked) * price_coffe
        itemcost(8) = Convert.ToDecimal(chekcold.Checked) * price_coffe
        itemcost(9) = Convert.ToDecimal(chekmangomilk.Checked) * price_milkshek
        itemcost(10) = Convert.ToDecimal(chekoreomilk.Checked) * price_milkshek
        itemcost(11) = Convert.ToDecimal(chekbananamilk.Checked) * price_milkshek
        itemcost(12) = Convert.ToDecimal(chekvanillamilk.Checked) * price_milkshek
        itemcost(13) = Convert.ToDecimal(chekapplejuice.Checked) * price_juice
        itemcost(14) = Convert.ToDecimal(chekorangejuice.Checked) * price_juice
        itemcost(15) = Convert.ToDecimal(chekmangojuice.Checked) * price_juice
        itemcost(16) = Convert.ToDecimal(chekblankforestpestry.Checked) * price_cake
        itemcost(17) = Convert.ToDecimal(chekbutterscotchpestry.Checked) * price_cake
        itemcost(18) = Convert.ToDecimal(chekpineapplepestry.Checked) * price_cake
        itemcost(19) = Convert.ToDecimal(chekredvelvetpestry.Checked) * price_cake
        itemcost(20) = Convert.ToDecimal(chekstrwberrypestry.Checked) * price_cake
        itemcost(21) = Convert.ToDecimal(chekvanillaice.Checked) * price_icecream
        itemcost(22) = Convert.ToDecimal(chekchocolateice.Checked) * price_icecream
        itemcost(23) = Convert.ToDecimal(chekstrawberryice.Checked) * price_icecream
        itemcost(24) = Convert.ToDecimal(chekbutterice.Checked) * price_icecream
        itemcost(25) = Convert.ToDecimal(chekmangoice.Checked) * price_icecream



        isubtotal = itemcost(0) + itemcost(1) + itemcost(2) + itemcost(3) + itemcost(4) + itemcost(5) + itemcost(6) +
            itemcost(7) + itemcost(8) + itemcost(9) + itemcost(10) + itemcost(11) + itemcost(12) + itemcost(13) + itemcost(14) + itemcost(15) +
        itemcost(16) + itemcost(17) + itemcost(18) + itemcost(19) + itemcost(20) + itemcost(21) + itemcost(22) + itemcost(23) + itemcost(24) + itemcost(25)

        labltotal.Text = itax + isubtotal
        labltotal.Text = FormatCurrency(labltotal.Text)



    End Sub

    Private Sub btnback_Click(sender As Object, e As EventArgs) Handles btnback.Click
        Dim con As SqlConnection = New SqlConnection("Data Source=DESKTOP-6RB83T5\SQLEXPRESS;Initial Catalog=records;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("DELETE From [dbo].[records1] Where[address]='" & TextBox2.Text & "' ", con)
        con.Open()
        Dim rd As Integer
        rd = cmd.ExecuteNonQuery()
        MessageBox.Show("Your Order Deleted Successfuly ", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        con.Close()
    End Sub

    Private Sub Paneldrinks_Paint(sender As Object, e As PaintEventArgs) Handles Paneldrinks.Paint

    End Sub
End Class

