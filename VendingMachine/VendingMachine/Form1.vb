Public Class Form1
    Dim GreenTea As Integer = 0
    Dim BMuffin As Integer = 0
    Dim Alfafa As Integer = 0
    Dim OatMeal As Integer = 0

    Dim CountGreenTea As Integer = 20
    Dim CountBMuffin As Integer = 20
    Dim CountAlfafa As Integer = 20
    Dim CountOatMeal As Integer = 20

    Dim totalAmount As Double = 0
    Dim totalItemOrdered As Integer = 0


    Private Sub btnGreenTea_Click(sender As Object, e As EventArgs) Handles btnGreenTea.Click
        If (CountGreenTea > 0) Then
            GreenTea = GreenTea + 1
            totalItemOrdered = totalItemOrdered + 1
            totalAmount = totalAmount + 1 * 0.97
            CountGreenTea = CountGreenTea - 1
            lblCountGreenTea.Text = "Count " & CountGreenTea
            lblGreenTea.Text = GreenTea
            lblItemOrdered.Text = totalItemOrdered
            If (totalAmount > 0) Then
                lblTotalAmount.Text = "$ " & totalAmount
            Else
                lblTotalAmount.Text = "$ 0"
            End If

        Else
            MessageBox.Show("Sorry, we are out of GreenTea.")
        End If
    End Sub

    Private Sub btnRemoveGreenTea_Click(sender As Object, e As EventArgs) Handles btnRemoveGreenTea.Click
        If (GreenTea = 0) Then
            MessageBox.Show("You haven't added any Green Tea yet.")

        Else
        GreenTea = GreenTea - 1
        totalItemOrdered = totalItemOrdered - 1
            totalAmount = totalAmount - 1 * 0.97
            CountGreenTea = CountGreenTea + 1
            lblCountGreenTea.Text = "Count " & CountGreenTea
        lblGreenTea.Text = GreenTea
        lblItemOrdered.Text = totalItemOrdered
            If (totalAmount > 0) Then
                lblTotalAmount.Text = "$ " & totalAmount
            Else
                lblTotalAmount.Text = "$ 0"
            End If
        End If
    End Sub



    Private Sub btnBranMuffin_Click(sender As Object, e As EventArgs) Handles btnBranMuffin.Click

        If (CountBMuffin > 0) Then
            BMuffin = BMuffin + 1
            totalItemOrdered = totalItemOrdered + 1
            totalAmount = totalAmount + 1 * 1.71
            CountBMuffin = CountBMuffin - 1

            lblCountBMuffin.Text = "Count " & CountBMuffin
            lblBranMuffin.Text = BMuffin
            lblItemOrdered.Text = totalItemOrdered
            If (totalAmount > 0) Then
                lblTotalAmount.Text = "$ " & totalAmount
            Else
                lblTotalAmount.Text = "$ 0"
            End If
        Else

            MessageBox.Show("Sorry, we are out of Bran Muffin.")

        End If
    End Sub

    Private Sub btnRemoveBMuffin_Click(sender As Object, e As EventArgs) Handles btnRemoveBMuffin.Click
        If (BMuffin = 0) Then
            MessageBox.Show("You haven't added Bran Muffin yet.")

        Else
            BMuffin = BMuffin - 1
            totalItemOrdered = totalItemOrdered - 1
            totalAmount = totalAmount - 1 * 1.71
            CountBMuffin = CountBMuffin + 1
            lblCountBMuffin.Text = "Count: " & CountBMuffin
            lblBranMuffin.Text = BMuffin
            lblItemOrdered.Text = totalItemOrdered
            If (totalAmount > 0) Then
                lblTotalAmount.Text = "$ " & totalAmount
            Else
                lblTotalAmount.Text = "$ 0"
            End If

        End If

    End Sub


    Private Sub btnAlfalfaSprouts_Click(sender As Object, e As EventArgs) Handles btnAlfalfaSprouts.Click
        If (CountAlfafa > 0) Then
            Alfafa = Alfafa + 1
            totalItemOrdered = totalItemOrdered + 1
            totalAmount = totalAmount + 1 * 2.04
            CountAlfafa = CountAlfafa - 1
            lblCountAlfafa.Text = "Count " & CountAlfafa
            lblAlfalfaSprouts.Text = Alfafa
            lblItemOrdered.Text = totalItemOrdered
            If (totalAmount > 0) Then
                lblTotalAmount.Text = "$ " & totalAmount
            Else
                lblTotalAmount.Text = "$ 0"
            End If
        Else
            MessageBox.Show("Sorry, we are out of Alfalfa Sprouts.")
        End If
    End Sub

    Private Sub btnRemoveAlfafa_Click(sender As Object, e As EventArgs) Handles btnRemoveAlfafa.Click
        If (Alfafa = 0) Then
            MessageBox.Show("You haven't added Alfalfa Sprouts item yet.")
        Else
            Alfafa = Alfafa - 1
            totalItemOrdered = totalItemOrdered - 1
            totalAmount = totalAmount - 1 * 2.04
            CountAlfafa = CountAlfafa + 1
            lblCountAlfafa.Text = "Count " & CountAlfafa
            lblAlfalfaSprouts.Text = Alfafa
            lblItemOrdered.Text = totalItemOrdered
            If (totalAmount > 0) Then
                lblTotalAmount.Text = "$ " & totalAmount
            Else
                lblTotalAmount.Text = "$ 0"
            End If

        End If

    End Sub

    Private Sub btnOatMeal_Click(sender As Object, e As EventArgs) Handles btnOatMeal.Click
        If (CountOatMeal > 0) Then
            OatMeal = OatMeal + 1
            totalItemOrdered = totalItemOrdered + 1
            totalAmount = totalAmount + 1 * 1.11
            CountOatMeal = CountOatMeal - 1
            lblCountOatMeal.Text = "Count " & CountOatMeal
            lblOatMeal.Text = OatMeal
            lblItemOrdered.Text = totalItemOrdered
            If (totalAmount > 0) Then
                lblTotalAmount.Text = "$ " & totalAmount
            Else
                lblTotalAmount.Text = "$ 0"
            End If
        Else
            MessageBox.Show("Sorry, we are out of OatMeal.")
        End If
    End Sub

    Private Sub btnRemoveOatMeal_Click(sender As Object, e As EventArgs) Handles btnRemoveOatMeal.Click
        If (OatMeal = 0) Then
            MessageBox.Show("You haven't added any OatMeal yet.")
        Else
            OatMeal = OatMeal - 1
            totalItemOrdered = totalItemOrdered - 1
            totalAmount = totalAmount - 1 * 1.11
            CountOatMeal = CountOatMeal + 1
            lblCountOatMeal.Text = "Count " & CountOatMeal
            lblOatMeal.Text = OatMeal
            lblOatMeal.Text = OatMeal
            lblItemOrdered.Text = totalItemOrdered
            If (totalAmount > 0) Then
                lblTotalAmount.Text = "$ " & totalAmount
            Else
                lblTotalAmount.Text = "$ 0"
            End If
        End If
    End Sub

    Private Sub btnCheckOut_Click(sender As Object, e As EventArgs) Handles btnCheckOut.Click


        Dim AmtReceived As Single = txtAmtReceived.Text
        Dim change As Single = (AmtReceived - totalAmount) * 100
        Dim fifty As Integer = 0
        Dim twenty As Integer = 0
        Dim ten As Integer = 0
        Dim five As Integer = 0
        Dim Dollar As Integer = 0
        Dim quarter As Integer = 0
        Dim Dime As Integer = 0
        Dim Penny As Integer = 0


        If (AmtReceived < totalAmount) Then
            MessageBox.Show("Please insert sufficient bill. You need " & totalAmount - AmtReceived & "$ more")

        Else
            'fifty 
            fifty = change \ 5000
            lblFifty.Text = fifty
            lblFifty.Visible = True

            'twenty
            change = change Mod 5000
            twenty = change \ 2000
            lblTwenty.Text = twenty
            lblTwenty.Visible = True

            'ten
            change = change Mod 2000
            ten = change \ 1000
            lblTen.Text = ten
            lblTen.Visible = True

            'five 
            change = change Mod 1000
            five = change \ 500
            lblFive.Text = five
            lblFive.Visible = True

            'dollar 
            change = change Mod 500
            Dollar = change \ 100
            lblDollar.Text = Dollar
            lblDollar.Visible = True

            'quarter 
            change = change Mod 100
            quarter = change \ 25
            lblQuarter.Text = quarter
            lblQuarter.Visible = True

            'dime 
            change = change Mod 25
            Dime = change \ 10
            lblDime.Text = Dime
            lblDime.Visible = True

            'cent 
            change = change Mod 10
            Penny = change
            lblCent.Text = Penny
            lblCent.Visible = True

            lblOffD.Text = "Your change is " & (AmtReceived - totalAmount)



        End If

        lbl001.Visible = True
        lbl010.Visible = True
        lbl025.Visible = True
        lbl1.Visible = True
        lbl5.Visible = True
        lbl10.Visible = True
        lbl20.Visible = True
        lbl50.Visible = True

        lblOffD.Visible = True



    End Sub

    Private Sub btnClean_Click(sender As Object, e As EventArgs) Handles btnClean.Click
        txtAmtReceived.Text = ""
        lblGreenTea.Text = 0
        lblBranMuffin.Text = 0
        lblAlfalfaSprouts.Text = 0
        lblOatMeal.Text = 0
        lblItemOrdered.Text = 0
        lblTotalAmount.Text = "$ " & 0

        GreenTea = 0
        Alfafa = 0
        OatMeal = 0
        BMuffin = 0
        totalAmount = 0
        totalItemOrdered = 0

        lblCent.Visible = False
        lblDime.Visible = False
        lblQuarter.Visible = False
        lblDollar.Visible = False
        lblFive.Visible = False
        lblTen.Visible = False
        lblTwenty.Visible = False
        lblFifty.Visible = False

        lbl001.Visible = False
        lbl010.Visible = False
        lbl025.Visible = False
        lbl1.Visible = False
        lbl5.Visible = False
        lbl10.Visible = False
        lbl20.Visible = False
        lbl50.Visible = False

        lblOffD.Visible = False

        txtRefill.Visible = False
        txtRefill.Text = ""
        btnRefillOk.Visible = False
    End Sub


    Private Sub btnRefill_Click(sender As Object, e As EventArgs) Handles btnRefill.Click
        MessageBox.Show("Please, provide the security code.", "Refill", MessageBoxButtons.OK)
        txtRefill.Visible = True
        btnRefillOk.Visible = True
    End Sub


    Private Sub btnRefillOk_Click(sender As Object, e As EventArgs) Handles btnRefillOk.Click
        If (txtRefill.Text = "9852086061") Then
            If (CountGreenTea < 20 Or CountBMuffin < 20 Or CountOatMeal < 20 Or CountAlfafa < 20) Then

                CountGreenTea = 20
                CountOatMeal = 20
                CountAlfafa = 20
                CountBMuffin = 20
                lblCountAlfafa.Text = "Count " & CountAlfafa
                lblCountBMuffin.Text = "Count " & CountBMuffin
                lblCountGreenTea.Text = "Count " & CountGreenTea
                lblCountOatMeal.Text = "Count " & CountOatMeal

            Else
                MessageBox.Show("The items are full. Please refill when empty.", "Refill Not Need", MessageBoxButtons.OK)


            End If
        Else
            MessageBox.Show("The security code is wrong. Please try again.", "Security Error", MessageBoxButtons.RetryCancel)
        End If
    End Sub
End Class
