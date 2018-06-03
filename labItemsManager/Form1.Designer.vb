<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm_Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grid_Main = New System.Windows.Forms.DataGridView()
        Me.lbl_Item_Name = New System.Windows.Forms.Label()
        Me.tBox_Item_Name = New System.Windows.Forms.TextBox()
        Me.lbl_Item_Description = New System.Windows.Forms.Label()
        Me.tBox_Item_Description = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cBox_Item_Category = New System.Windows.Forms.ComboBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btn_Item_Id = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.cBox_Item_Data_Value = New System.Windows.Forms.ComboBox()
        Me.btn_Delete_Data = New System.Windows.Forms.Button()
        Me.grid_Data = New System.Windows.Forms.DataGridView()
        Me.btn_Add_Data = New System.Windows.Forms.Button()
        Me.lbl_Item_Data_Value = New System.Windows.Forms.Label()
        Me.cBox_Item_Data_Name = New System.Windows.Forms.ComboBox()
        Me.lbl_Item_Data_Name = New System.Windows.Forms.Label()
        Me.lbl_Item_Id = New System.Windows.Forms.Label()
        Me.btn_Clear = New System.Windows.Forms.Button()
        Me.btn_Add_Item = New System.Windows.Forms.Button()
        Me.btn_Delete_Item = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.rBtn_Item_List = New System.Windows.Forms.RadioButton()
        Me.rBtn_RFID_List = New System.Windows.Forms.RadioButton()
        CType(Me.grid_Main, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.grid_Data, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'grid_Main
        '
        Me.grid_Main.AllowUserToAddRows = False
        Me.grid_Main.AllowUserToDeleteRows = False
        Me.grid_Main.AllowUserToOrderColumns = True
        Me.grid_Main.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grid_Main.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_Main.Location = New System.Drawing.Point(10, 21)
        Me.grid_Main.Name = "grid_Main"
        Me.grid_Main.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid_Main.Size = New System.Drawing.Size(684, 467)
        Me.grid_Main.TabIndex = 2
        '
        'lbl_Item_Name
        '
        Me.lbl_Item_Name.AutoSize = True
        Me.lbl_Item_Name.Location = New System.Drawing.Point(14, 57)
        Me.lbl_Item_Name.Name = "lbl_Item_Name"
        Me.lbl_Item_Name.Size = New System.Drawing.Size(58, 13)
        Me.lbl_Item_Name.TabIndex = 0
        Me.lbl_Item_Name.Text = "Item Name"
        '
        'tBox_Item_Name
        '
        Me.tBox_Item_Name.Location = New System.Drawing.Point(131, 54)
        Me.tBox_Item_Name.Name = "tBox_Item_Name"
        Me.tBox_Item_Name.Size = New System.Drawing.Size(151, 20)
        Me.tBox_Item_Name.TabIndex = 1
        '
        'lbl_Item_Description
        '
        Me.lbl_Item_Description.AutoSize = True
        Me.lbl_Item_Description.Location = New System.Drawing.Point(14, 380)
        Me.lbl_Item_Description.Name = "lbl_Item_Description"
        Me.lbl_Item_Description.Size = New System.Drawing.Size(83, 13)
        Me.lbl_Item_Description.TabIndex = 2
        Me.lbl_Item_Description.Text = "Item Description"
        '
        'tBox_Item_Description
        '
        Me.tBox_Item_Description.Location = New System.Drawing.Point(47, 406)
        Me.tBox_Item_Description.Multiline = True
        Me.tBox_Item_Description.Name = "tBox_Item_Description"
        Me.tBox_Item_Description.Size = New System.Drawing.Size(235, 82)
        Me.tBox_Item_Description.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Item Category"
        '
        'cBox_Item_Category
        '
        Me.cBox_Item_Category.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cBox_Item_Category.FormattingEnabled = True
        Me.cBox_Item_Category.Location = New System.Drawing.Point(131, 91)
        Me.cBox_Item_Category.Name = "cBox_Item_Category"
        Me.cBox_Item_Category.Size = New System.Drawing.Size(151, 21)
        Me.cBox_Item_Category.TabIndex = 5
        Me.cBox_Item_Category.ValueMember = "Category_Id"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btn_Item_Id)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.lbl_Item_Id)
        Me.Panel1.Controls.Add(Me.btn_Clear)
        Me.Panel1.Controls.Add(Me.btn_Add_Item)
        Me.Panel1.Controls.Add(Me.cBox_Item_Category)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.tBox_Item_Description)
        Me.Panel1.Controls.Add(Me.lbl_Item_Description)
        Me.Panel1.Controls.Add(Me.tBox_Item_Name)
        Me.Panel1.Controls.Add(Me.lbl_Item_Name)
        Me.Panel1.Location = New System.Drawing.Point(726, 12)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(305, 559)
        Me.Panel1.TabIndex = 1
        '
        'btn_Item_Id
        '
        Me.btn_Item_Id.Location = New System.Drawing.Point(131, 11)
        Me.btn_Item_Id.Name = "btn_Item_Id"
        Me.btn_Item_Id.Size = New System.Drawing.Size(151, 23)
        Me.btn_Item_Id.TabIndex = 18
        Me.btn_Item_Id.Text = "Click for New Id"
        Me.btn_Item_Id.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.cBox_Item_Data_Value)
        Me.Panel3.Controls.Add(Me.btn_Delete_Data)
        Me.Panel3.Controls.Add(Me.grid_Data)
        Me.Panel3.Controls.Add(Me.btn_Add_Data)
        Me.Panel3.Controls.Add(Me.lbl_Item_Data_Value)
        Me.Panel3.Controls.Add(Me.cBox_Item_Data_Name)
        Me.Panel3.Controls.Add(Me.lbl_Item_Data_Name)
        Me.Panel3.Location = New System.Drawing.Point(16, 130)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(276, 235)
        Me.Panel3.TabIndex = 17
        '
        'cBox_Item_Data_Value
        '
        Me.cBox_Item_Data_Value.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple
        Me.cBox_Item_Data_Value.FormattingEnabled = True
        Me.cBox_Item_Data_Value.Location = New System.Drawing.Point(114, 55)
        Me.cBox_Item_Data_Value.Name = "cBox_Item_Data_Value"
        Me.cBox_Item_Data_Value.Size = New System.Drawing.Size(151, 21)
        Me.cBox_Item_Data_Value.TabIndex = 14
        '
        'btn_Delete_Data
        '
        Me.btn_Delete_Data.Location = New System.Drawing.Point(91, 196)
        Me.btn_Delete_Data.Name = "btn_Delete_Data"
        Me.btn_Delete_Data.Size = New System.Drawing.Size(75, 23)
        Me.btn_Delete_Data.TabIndex = 13
        Me.btn_Delete_Data.Text = "Delete Data"
        Me.btn_Delete_Data.UseVisualStyleBackColor = True
        '
        'grid_Data
        '
        Me.grid_Data.AllowUserToAddRows = False
        Me.grid_Data.AllowUserToDeleteRows = False
        Me.grid_Data.AllowUserToResizeColumns = False
        Me.grid_Data.AllowUserToResizeRows = False
        Me.grid_Data.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grid_Data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_Data.Location = New System.Drawing.Point(13, 84)
        Me.grid_Data.Name = "grid_Data"
        Me.grid_Data.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid_Data.Size = New System.Drawing.Size(252, 106)
        Me.grid_Data.TabIndex = 12
        '
        'btn_Add_Data
        '
        Me.btn_Add_Data.Location = New System.Drawing.Point(190, 196)
        Me.btn_Add_Data.Name = "btn_Add_Data"
        Me.btn_Add_Data.Size = New System.Drawing.Size(75, 23)
        Me.btn_Add_Data.TabIndex = 10
        Me.btn_Add_Data.Text = "Add Data"
        Me.btn_Add_Data.UseVisualStyleBackColor = True
        '
        'lbl_Item_Data_Value
        '
        Me.lbl_Item_Data_Value.AutoSize = True
        Me.lbl_Item_Data_Value.Location = New System.Drawing.Point(8, 58)
        Me.lbl_Item_Data_Value.Name = "lbl_Item_Data_Value"
        Me.lbl_Item_Data_Value.Size = New System.Drawing.Size(83, 13)
        Me.lbl_Item_Data_Value.TabIndex = 8
        Me.lbl_Item_Data_Value.Text = "Item Data Value"
        '
        'cBox_Item_Data_Name
        '
        Me.cBox_Item_Data_Name.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cBox_Item_Data_Name.FormattingEnabled = True
        Me.cBox_Item_Data_Name.Location = New System.Drawing.Point(114, 21)
        Me.cBox_Item_Data_Name.Name = "cBox_Item_Data_Name"
        Me.cBox_Item_Data_Name.Size = New System.Drawing.Size(151, 21)
        Me.cBox_Item_Data_Name.TabIndex = 7
        Me.cBox_Item_Data_Name.ValueMember = "Data_Name_Id"
        '
        'lbl_Item_Data_Name
        '
        Me.lbl_Item_Data_Name.AutoSize = True
        Me.lbl_Item_Data_Name.Location = New System.Drawing.Point(7, 24)
        Me.lbl_Item_Data_Name.Name = "lbl_Item_Data_Name"
        Me.lbl_Item_Data_Name.Size = New System.Drawing.Size(84, 13)
        Me.lbl_Item_Data_Name.TabIndex = 6
        Me.lbl_Item_Data_Name.Text = "Item Data Name"
        '
        'lbl_Item_Id
        '
        Me.lbl_Item_Id.AutoSize = True
        Me.lbl_Item_Id.Location = New System.Drawing.Point(14, 16)
        Me.lbl_Item_Id.Name = "lbl_Item_Id"
        Me.lbl_Item_Id.Size = New System.Drawing.Size(39, 13)
        Me.lbl_Item_Id.TabIndex = 15
        Me.lbl_Item_Id.Text = "Item Id"
        '
        'btn_Clear
        '
        Me.btn_Clear.Location = New System.Drawing.Point(27, 523)
        Me.btn_Clear.Name = "btn_Clear"
        Me.btn_Clear.Size = New System.Drawing.Size(75, 23)
        Me.btn_Clear.TabIndex = 14
        Me.btn_Clear.Text = "Clear"
        Me.btn_Clear.UseVisualStyleBackColor = True
        '
        'btn_Add_Item
        '
        Me.btn_Add_Item.Location = New System.Drawing.Point(207, 523)
        Me.btn_Add_Item.Name = "btn_Add_Item"
        Me.btn_Add_Item.Size = New System.Drawing.Size(75, 23)
        Me.btn_Add_Item.TabIndex = 11
        Me.btn_Add_Item.Text = "Add Item"
        Me.btn_Add_Item.UseVisualStyleBackColor = True
        '
        'btn_Delete_Item
        '
        Me.btn_Delete_Item.Location = New System.Drawing.Point(619, 523)
        Me.btn_Delete_Item.Name = "btn_Delete_Item"
        Me.btn_Delete_Item.Size = New System.Drawing.Size(75, 23)
        Me.btn_Delete_Item.TabIndex = 3
        Me.btn_Delete_Item.Text = "Delete Item"
        Me.btn_Delete_Item.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.rBtn_Item_List)
        Me.Panel2.Controls.Add(Me.rBtn_RFID_List)
        Me.Panel2.Controls.Add(Me.btn_Delete_Item)
        Me.Panel2.Controls.Add(Me.grid_Main)
        Me.Panel2.Location = New System.Drawing.Point(13, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(707, 559)
        Me.Panel2.TabIndex = 4
        '
        'rBtn_Item_List
        '
        Me.rBtn_Item_List.AutoSize = True
        Me.rBtn_Item_List.Location = New System.Drawing.Point(145, 523)
        Me.rBtn_Item_List.Name = "rBtn_Item_List"
        Me.rBtn_Item_List.Size = New System.Drawing.Size(90, 17)
        Me.rBtn_Item_List.TabIndex = 5
        Me.rBtn_Item_List.TabStop = True
        Me.rBtn_Item_List.Text = "Item List View"
        Me.rBtn_Item_List.UseVisualStyleBackColor = True
        '
        'rBtn_RFID_List
        '
        Me.rBtn_RFID_List.AutoSize = True
        Me.rBtn_RFID_List.Location = New System.Drawing.Point(30, 523)
        Me.rBtn_RFID_List.Name = "rBtn_RFID_List"
        Me.rBtn_RFID_List.Size = New System.Drawing.Size(95, 17)
        Me.rBtn_RFID_List.TabIndex = 4
        Me.rBtn_RFID_List.TabStop = True
        Me.rBtn_RFID_List.Text = "RFID List View"
        Me.rBtn_RFID_List.UseVisualStyleBackColor = True
        '
        'frm_Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1039, 596)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "frm_Main"
        Me.Text = "Lab Items Manager"
        CType(Me.grid_Main, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.grid_Data, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grid_Main As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_Item_Name As System.Windows.Forms.Label
    Friend WithEvents tBox_Item_Name As System.Windows.Forms.TextBox
    Friend WithEvents lbl_Item_Description As System.Windows.Forms.Label
    Friend WithEvents tBox_Item_Description As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cBox_Item_Category As System.Windows.Forms.ComboBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents cBox_Item_Data_Name As System.Windows.Forms.ComboBox
    Friend WithEvents lbl_Item_Data_Name As System.Windows.Forms.Label
    Friend WithEvents lbl_Item_Data_Value As System.Windows.Forms.Label
    Friend WithEvents btn_Add_Item As System.Windows.Forms.Button
    Friend WithEvents btn_Add_Data As System.Windows.Forms.Button
    Friend WithEvents grid_Data As System.Windows.Forms.DataGridView
    Friend WithEvents btn_Delete_Data As System.Windows.Forms.Button
    Friend WithEvents btn_Delete_Item As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents btn_Clear As System.Windows.Forms.Button
    Friend WithEvents rBtn_Item_List As System.Windows.Forms.RadioButton
    Friend WithEvents rBtn_RFID_List As System.Windows.Forms.RadioButton
    Friend WithEvents ItemIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lbl_Item_Id As System.Windows.Forms.Label
    Friend WithEvents btn_Item_Id As System.Windows.Forms.Button
    Friend WithEvents cBox_Item_Data_Value As System.Windows.Forms.ComboBox

End Class
