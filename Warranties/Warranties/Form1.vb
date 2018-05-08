Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports System.Web.Script.Serialization
Imports System.IO
Imports System.Web.UI.WebControls
Imports System.Data.DataTable

Public Class Form1
    ' Set path of json file
    Dim path As String = Application.StartupPath & "warranties.json"
    Dim source As New BindingSource()
    Dim jss = New JavaScriptSerializer()
    Dim dict As Dictionary(Of String, Object) = jss.Deserialize(Of Dictionary(Of String, Object))(ReadFile())

    Dim dt As New DataTable()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BindData()

    End Sub


    ' *******  WriteToFile Writes To JSON, Uses JavaScriptSerializer. Got Replaced By WriteToJson, which uses Json.net *****************
    '
    'Sub WriteToFile()
    'Dim ser As New JavaScriptSerializer()
    '
    ' Enter data from textboxes into Warranty Class
    'Dim w = New Warranty
    '
    '   w.FirstName = FNameTxtBox.Text
    '   w.LastName = LNameTxtBox.Text
    '   w.Model = ModelTxtBox.Text
    '   w.SerialNumber = SerialTxtBox.Text
    '   w.DateInstalled = DateInstalledTxtBox.Text
    '
    ' Serialize Warranty object into json file
    'Dim result As String = ser.Serialize(w) + Environment.NewLine
    '
    ' Write to json file
    'Dim lines As String() = File.ReadAllLines(path)
    'For i As Integer = 0 To lines.Length - 1
    'Dim line As String = lines(i)
    'If line.StartsWith("""Warranties"":[") Then
    '           lines(i) = line & Environment.NewLine & result & ","
    'End If
    'Next
    '   File.WriteAllLines(path, lines)
    '  'File.AppendAllText(path, result)
    '
    '    BindData()
    'End Sub

    Sub WriteToJson()
        Dim smallDict As New Dictionary(Of String, String)

        smallDict.Add("FirstName", FNameTxtBox.Text)
        smallDict.Add("LastName", LNameTxtBox.Text)
        smallDict.Add("Brand", BrandTxtBox.Text)
        smallDict.Add("Model", ModelTxtBox.Text)
        smallDict.Add("SerialNumber", SerialTxtBox.Text)
        smallDict.Add("DateInstalled", DateInstalledTxtBox.Text)

        dict("Warranties").Add(smallDict)


        Dim Json As String = JsonConvert.SerializeObject(dict, Formatting.Indented)
        File.WriteAllText(path, Json)
        BindData()
    End Sub

    Private Sub AddFurnaceBtn_Click(sender As Object, e As EventArgs) Handles AddFurnaceBtn.Click
        'WriteToFile()
        WriteToJson()
    End Sub

    ' ***************** These Classes Not Used Since WriteToFile Is Not Used *******************
    ' VB Data Structure Of Json Data
    Public Class Warranty
        Public Property FirstName As String
        Public Property LastName As String
        Public Property Brand As String
        Public Property Model As String
        Public Property SerialNumber As String
        Public Property DateInstalled As String
    End Class



    Function ReadFile() As String
            Dim fileReader As String
            fileReader = File.ReadAllText(path)
            Return fileReader
        End Function

    Private Sub BindData()
        DataGridView1.AutoGenerateColumns = True
        'Dim jss = New JavaScriptSerializer()
        'Dim dict As Dictionary(Of String, Object) = jss.Deserialize(Of Dictionary(Of String, Object))(ReadFile())
        dict = jss.Deserialize(Of Dictionary(Of String, Object))(ReadFile())

        Dim dt As New DataTable()
        dt.Columns.AddRange(New DataColumn(5) {New DataColumn("FirstName", GetType(String)),
                                                New DataColumn("LastName", GetType(String)),
                                                New DataColumn("Brand", GetType(String)),
                                                New DataColumn("Model", GetType(String)),
                                                New DataColumn("SerialNumber", GetType(String)),
                                                New DataColumn("DateInstalled", GetType(String))
        })

        For Each item In dict("Warranties")

            dt.Rows.Add(New String() {item("FirstName"), item("LastName"), item("Brand"), item("Model"), item("SerialNumber"), item("DateInstalled")})
        Next

        source.DataSource = dt
        DataGridView1.DataSource = dt
        DataGridView1.Refresh()
    End Sub

    Private Sub FilterTxtBox_TextChanged(sender As Object, e As EventArgs) Handles FilterTxtBox.TextChanged
        source.Filter = "[LastName] like '" & FilterTxtBox.Text & "%'"
        DataGridView1.Refresh()
    End Sub

    Private Sub ClearBtn_Click(sender As Object, e As EventArgs) Handles ClearBtn.Click
        source.Filter = String.Empty
    End Sub

    Private Sub Form1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        TabControl1.Width = Me.Width - 20
        TabControl1.Height = Me.Height - 20
    End Sub

    ' DELETE JSON Sub not done ****************************
    'Private Sub DeleteJson()
    '    Dim fName As String = DataGridView1.Item(0, SelectedRow).Value
    '    Dim smallDict As New Dictionary(Of String, String)

    '    smallDict.Add("FirstName", FNameTxtBox.Text)
    '    smallDict.Add("LastName", LNameTxtBox.Text)
    '    smallDict.Add("Brand", BrandTxtBox.Text)
    '    smallDict.Add("Model", ModelTxtBox.Text)
    '    smallDict.Add("SerialNumber", SerialTxtBox.Text)
    '    smallDict.Add("DateInstalled", DateInstalledTxtBox.Text)

    '    dict("Warranties").Remove(smallDict)


    '    Dim Json As String = JsonConvert.SerializeObject(dict, Formatting.Indented)
    '    File.WriteAllText(path, Json)
    '    BindData()
    'End Sub

End Class
