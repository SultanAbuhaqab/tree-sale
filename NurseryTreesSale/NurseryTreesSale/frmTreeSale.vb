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
End Class
