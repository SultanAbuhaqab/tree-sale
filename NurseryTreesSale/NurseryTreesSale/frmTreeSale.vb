Public Class frmTreeSale
    'Define the constants needed in the program
    Private Const KEY_LIME_PRICE As Decimal = 15.95
    Private Const PERSIAN_LIME_PRICE As Decimal = 12.95
    Private Const MEYER_LEMON_PRICE As Decimal = 13.95
    Private Const DELIVERY_FEE As Integer = 10
    Private Const PLANTING_FEE As Integer = 8
    Private Const TAX_RATE As Integer = 7

    Private arrRadTreeType(2) As RadioButton
    Private arrChkAdditionalServices(1) As CheckBox

    Private strTreeType As String
    Private decTreeCost As Decimal

    Private Sub LoadControlArrays()
        arrRadTreeType(0) = radKeyLime
        arrRadTreeType(1) = radPersianLime
        arrRadTreeType(2) = radMeyerLemon

        arrChkAdditionalServices(0) = chkDelivery
        arrChkAdditionalServices(1) = chkPlanting
    End Sub

    Private Sub frmTreeSale_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadControlArrays()
    End Sub

    Private Sub radTreeTypes_CheckedChanged(sender As Object, e As EventArgs) Handles radKeyLime.CheckedChanged,
            radPersianLime.CheckedChanged, radMeyerLemon.CheckedChanged
        Dim rad As RadioButton
        rad = DirectCast(sender, RadioButton)

        If rad.Checked Then
            Dim strTreePreviewImage As String

            strTreeType = rad.Text

            If strTreeType = arrRadTreeType(0).Text Then
                decTreeCost = KEY_LIME_PRICE
                strTreePreviewImage = "key_lime.jpg"
            ElseIf strTreeType = arrRadTreeType(1).Text Then
                decTreeCost = PERSIAN_LIME_PRICE
                strTreePreviewImage = "persian_lime.jpg"
            Else
                decTreeCost = MEYER_LEMON_PRICE
                strTreePreviewImage = "meyer_lemon.jpg"
            End If
            picTreePreview.Load("Resources\" & strTreePreviewImage)
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Dim i As Integer

        'Clear the radio buttons
        For i = 0 To arrRadTreeType.Length - 1
            arrRadTreeType(i).Checked = False
        Next

        'Clear the picture box
        picTreePreview.Image = Nothing

        'Clear the check boxes
        For i = 0 To arrChkAdditionalServices.Length - 1
            arrChkAdditionalServices(i).Checked = False
        Next

        'Clear the text boxes
        txtNumberOfTrees.Clear()
        txtName.Clear()
        txtPhone.Clear()
        txtAddress.Clear()

        'Clear the variables
        strTreeType = ""
        decTreeCost = ""

    End Sub

    Private Sub btnSummary_Click(sender As Object, e As EventArgs) Handles btnSummary.Click
        Dim decTotalCost As Decimal
        Dim decTotalNetCost As Decimal
        Dim decTreePurchaseCost As Decimal
        Dim intDeliveryFee As Integer
        Dim intPlantingFee As Integer

        errP.Clear()

        'Check if we have validation errors and exit subroutine
        If ValidateData() Then
            Exit Sub
        End If

        'Calculate the tree purchase cost
        decTreePurchaseCost = decTreeCost * txtNumberOfTrees.Text

        'Calculate the delivery fee cost
        If chkDelivery.Checked Then
            intDeliveryFee = DELIVERY_FEE
        End If

        'Calculate the planting fee cost
        If chkPlanting.Checked Then
            intPlantingFee = txtNumberOfTrees.Text * PLANTING_FEE
        End If

        decTotalCost = decTreePurchaseCost + intDeliveryFee + intPlantingFee

        decTotalNetCost = decTotalCost * (100 + TAX_RATE) / 100

    End Sub

    Private Function ValidateData()
        Dim binErrors As Boolean

        'Validate that the tree type radio buttons was selected
        If strTreeType = "" Then
            errP.SetError(grpTreeTypes, "You must select a tree type")
            binErrors = True
        End If

        'Validate the number of tree text box
        If Not IsNumeric(txtNumberOfTrees.Text) Then
            errP.SetError(txtNumberOfTrees, "The number of trees must be numeric")
            binErrors = True
        ElseIf txtNumberOfTrees.Text > 5 Or txtNumberOfTrees.Text < 1 Then
            errP.SetError(txtNumberOfTrees, "The number of trees ordered must be not more than 5 and greater than 0")
            binErrors = True
        End If

        'Validate the name text box
        If txtName.Text = "" Then
            errP.SetError(txtName, "You must provide your name")
            binErrors = True
        End If

        'Validate the phone text box
        If txtPhone.Text = "" Then
            errP.SetError(txtPhone, "You must provide your phone number")
            binErrors = True
        End If

        'Validate the address text box
        If txtAddress.Text = "" Then
            errP.SetError(txtAddress, "You must provide your address")
            binErrors = True
        End If

        Return binErrors

    End Function
End Class
