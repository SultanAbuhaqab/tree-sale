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
    Private intNumberOfTrees As Integer
    Private intDeliveryCost As Integer
    Private intPlantingCost As Integer

    Private strName As String
    Private strPhone As String
    Private strAddress As String

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

        'clear the radio buttons
        For i = 0 To arrRadTreeType.Length - 1
            arrRadTreeType(i).Checked = False
        Next

        'clear the check boxes
        For i = 0 To arrChkAdditionalServices.Length - 1
            arrChkAdditionalServices(i).Checked = False
        Next

        'clear the text boxes
        txtNumberOfTrees.Clear()
        txtName.Clear()
        txtPhone.Clear()
        txtAddress.Clear()

        'clear the variables

    End Sub
End Class
