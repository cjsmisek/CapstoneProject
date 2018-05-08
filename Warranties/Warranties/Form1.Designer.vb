<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BrandTxtBox = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DateInstalledTxtBox = New System.Windows.Forms.TextBox()
        Me.AddFurnaceBtn = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SerialTxtBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ModelTxtBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LNameTxtBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FNameTxtBox = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ClearBtn = New System.Windows.Forms.Button()
        Me.FilterTxtBox = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.WarrantyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WarrantyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.ItemSize = New System.Drawing.Size(200, 65)
        Me.TabControl1.Location = New System.Drawing.Point(12, 12)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1980, 1324)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Label9)
        Me.TabPage1.Controls.Add(Me.BrandTxtBox)
        Me.TabPage1.Controls.Add(Me.Label6)
        Me.TabPage1.Controls.Add(Me.DateInstalledTxtBox)
        Me.TabPage1.Controls.Add(Me.AddFurnaceBtn)
        Me.TabPage1.Controls.Add(Me.Label5)
        Me.TabPage1.Controls.Add(Me.SerialTxtBox)
        Me.TabPage1.Controls.Add(Me.Label4)
        Me.TabPage1.Controls.Add(Me.ModelTxtBox)
        Me.TabPage1.Controls.Add(Me.Label3)
        Me.TabPage1.Controls.Add(Me.LNameTxtBox)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.FNameTxtBox)
        Me.TabPage1.Location = New System.Drawing.Point(10, 75)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1960, 1239)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Add"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(102, 598)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(131, 48)
        Me.Label9.TabIndex = 13
        Me.Label9.Text = "Brand"
        '
        'BrandTxtBox
        '
        Me.BrandTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BrandTxtBox.Location = New System.Drawing.Point(98, 659)
        Me.BrandTxtBox.Name = "BrandTxtBox"
        Me.BrandTxtBox.Size = New System.Drawing.Size(747, 55)
        Me.BrandTxtBox.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(1052, 598)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(276, 48)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Date Installed"
        '
        'DateInstalledTxtBox
        '
        Me.DateInstalledTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateInstalledTxtBox.Location = New System.Drawing.Point(1048, 659)
        Me.DateInstalledTxtBox.Name = "DateInstalledTxtBox"
        Me.DateInstalledTxtBox.Size = New System.Drawing.Size(747, 55)
        Me.DateInstalledTxtBox.TabIndex = 10
        '
        'AddFurnaceBtn
        '
        Me.AddFurnaceBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddFurnaceBtn.Location = New System.Drawing.Point(742, 1040)
        Me.AddFurnaceBtn.Name = "AddFurnaceBtn"
        Me.AddFurnaceBtn.Size = New System.Drawing.Size(446, 134)
        Me.AddFurnaceBtn.TabIndex = 9
        Me.AddFurnaceBtn.Text = "Submit"
        Me.AddFurnaceBtn.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(1054, 421)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(287, 48)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Serial Number"
        '
        'SerialTxtBox
        '
        Me.SerialTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SerialTxtBox.Location = New System.Drawing.Point(1048, 482)
        Me.SerialTxtBox.Name = "SerialTxtBox"
        Me.SerialTxtBox.Size = New System.Drawing.Size(747, 55)
        Me.SerialTxtBox.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(1054, 258)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(134, 48)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Model"
        '
        'ModelTxtBox
        '
        Me.ModelTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ModelTxtBox.Location = New System.Drawing.Point(1048, 319)
        Me.ModelTxtBox.Name = "ModelTxtBox"
        Me.ModelTxtBox.Size = New System.Drawing.Size(747, 55)
        Me.ModelTxtBox.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(93, 421)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(221, 48)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Last Name"
        '
        'LNameTxtBox
        '
        Me.LNameTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LNameTxtBox.Location = New System.Drawing.Point(89, 482)
        Me.LNameTxtBox.Name = "LNameTxtBox"
        Me.LNameTxtBox.Size = New System.Drawing.Size(747, 55)
        Me.LNameTxtBox.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(102, 258)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(225, 48)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "First Name"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(97, 73)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(601, 82)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Add Furnace Info"
        '
        'FNameTxtBox
        '
        Me.FNameTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FNameTxtBox.Location = New System.Drawing.Point(98, 319)
        Me.FNameTxtBox.Name = "FNameTxtBox"
        Me.FNameTxtBox.Size = New System.Drawing.Size(738, 55)
        Me.FNameTxtBox.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Label8)
        Me.TabPage2.Controls.Add(Me.ClearBtn)
        Me.TabPage2.Controls.Add(Me.FilterTxtBox)
        Me.TabPage2.Controls.Add(Me.Label7)
        Me.TabPage2.Controls.Add(Me.DataGridView1)
        Me.TabPage2.Location = New System.Drawing.Point(10, 75)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1960, 1239)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "List"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(839, 57)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(339, 48)
        Me.Label8.TabIndex = 5
        Me.Label8.Text = "Filter Last Name:"
        '
        'ClearBtn
        '
        Me.ClearBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ClearBtn.Location = New System.Drawing.Point(1678, 48)
        Me.ClearBtn.Name = "ClearBtn"
        Me.ClearBtn.Size = New System.Drawing.Size(276, 64)
        Me.ClearBtn.TabIndex = 4
        Me.ClearBtn.Text = "Clear"
        Me.ClearBtn.UseVisualStyleBackColor = True
        '
        'FilterTxtBox
        '
        Me.FilterTxtBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FilterTxtBox.Location = New System.Drawing.Point(1203, 57)
        Me.FilterTxtBox.Name = "FilterTxtBox"
        Me.FilterTxtBox.Size = New System.Drawing.Size(458, 48)
        Me.FilterTxtBox.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(22, 39)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(479, 82)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Warranty Info"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(0, 159)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 37
        Me.DataGridView1.Size = New System.Drawing.Size(1960, 1105)
        Me.DataGridView1.TabIndex = 0
        '
        'WarrantyBindingSource
        '
        Me.WarrantyBindingSource.DataSource = GetType(Warranties.Form1.Warranty)
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(14.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(2004, 1348)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WarrantyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Label1 As Label
    Friend WithEvents FNameTxtBox As TextBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents AddFurnaceBtn As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents SerialTxtBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ModelTxtBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents LNameTxtBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents DateInstalledTxtBox As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label7 As Label
    Friend WithEvents WarrantyBindingSource As BindingSource
    Friend WithEvents ClearBtn As Button
    Friend WithEvents FilterTxtBox As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents BrandTxtBox As TextBox
End Class
