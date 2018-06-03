Public Class frm_Main

    Private Sub frm_Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        reset_Fields()
        Me.rBtn_RFID_List.Select()
    End Sub

    Private Sub cBox_Item_Category_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cBox_Item_Category.SelectedIndexChanged
        If (cBox_Item_Category.SelectedValue < 4) Then
            'Me.Tbl_Item_Data_NamesTableAdapter1.FillBy(Me.LabItemsDataSet1.tbl_Item_Data_Names, cBox_Item_Category.SelectedValue)
            cBox_Item_Data_Name.SelectedIndex = -1
            cBox_Item_Data_Value.DataSource = Nothing
            cBox_Item_Data_Name.Enabled = True
            cBox_Item_Data_Value.Enabled = True
        Else
            cBox_Item_Data_Value.DataSource = Nothing
            cBox_Item_Data_Name.SelectedIndex = -1
            cBox_Item_Data_Name.Enabled = False
            cBox_Item_Data_Value.Enabled = False
        End If
        grid_Data.DataSource = Nothing
        grid_Data.Rows.Clear()
    End Sub

    Private Sub btn_Add_Data_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Add_Data.Click
        If cBox_Item_Data_Name.Text <> "" And cBox_Item_Data_Value.Text <> "" Then
            'Tbl_Item_DataTableAdapter.Insert("" & btn_Item_Id.Text, "" & cBox_Item_Data_Name.Text, "" & cBox_Item_Data_Value.Text)
            'Tbl_Item_DataTableAdapter.FillBy(Me.LabItemsDataSet1.tbl_Item_Data, btn_Item_Id.Text)
            'grid_Data.DataSource = TblItemDataBindingSource
        End If
    End Sub



    Private Sub btn_Delete_Data_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Delete_Data.Click
        Dim i As Integer
        Dim col1, col2, col3 As String
        Dim col4 As Integer

        For i = Me.grid_Data.SelectedRows.Count - 1 To 0 Step -1
            col1 = Me.grid_Data.SelectedRows(i).Cells(0).Value
            col2 = Me.grid_Data.SelectedRows(i).Cells(1).Value
            col3 = Me.grid_Data.SelectedRows(i).Cells(2).Value
            col4 = Me.grid_Data.SelectedRows(i).Cells(3).Value
            'Tbl_Item_DataTableAdapter.Delete(col4, col1, col2, col3)
        Next
        If IsNumeric(btn_Item_Id.Text) Then
            'Tbl_Item_DataTableAdapter.FillBy(Me.LabItemsDataSet1.tbl_Item_Data, btn_Item_Id.Text)
        End If
    End Sub

    Private Sub cBox_Item_Data_Name_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cBox_Item_Data_Name.SelectedIndexChanged
        Select cBox_Item_Data_Name.Text
            Case "Size"
                cBox_Item_Data_Value.DropDownStyle = ComboBoxStyle.DropDownList
                'Tbl_Item_SizesTableAdapter1.Fill(LabItemsDataSet1.tbl_Item_Sizes)
                'cBox_Item_Data_Value.DataSource = TblItemSizeBindingSource
                'cBox_Item_Data_Value.DisplayMember = "Size_Name"
                cBox_Item_Data_Value.SelectedIndex = -1
            Case "Color"
                cBox_Item_Data_Value.DropDownStyle = ComboBoxStyle.DropDownList
                'Tbl_Item_ColorTableAdapter1.Fill(LabItemsDataSet1.tbl_Item_Color)
                'cBox_Item_Data_Value.DataSource = TblItemColorBindingSource
                'cBox_Item_Data_Value.DisplayMember = "Color_Name"
                cBox_Item_Data_Value.SelectedIndex = -1
            Case "Wearable_Type"
                cBox_Item_Data_Value.DropDownStyle = ComboBoxStyle.DropDownList
                'Tbl_Item_TypeTableAdapter1.Fill(LabItemsDataSet1.tbl_Item_Type)
                'cBox_Item_Data_Value.DataSource = TblItemTypeBindingSource
                'cBox_Item_Data_Value.DisplayMember = "Type_Name"
                cBox_Item_Data_Value.SelectedIndex = -1
            Case Else
                cBox_Item_Data_Value.DataSource = Nothing
                cBox_Item_Data_Value.DropDownStyle = ComboBoxStyle.Simple
        End Select
    End Sub

    Private Sub rBtn_RFID_List_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rBtn_RFID_List.CheckedChanged
        'grid_Main.DataSource = TblRFIDDataBindingSource
        grid_Main.AutoGenerateColumns = True
        reset_Fields()
    End Sub

    Private Sub rBtn_Item_List_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rBtn_Item_List.CheckedChanged
        'grid_Main.DataSource = TblItemsBindingSource
        grid_Main.AutoGenerateColumns = True
        view_Item()
    End Sub

    Private Sub btn_Delete_Item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Delete_Item.Click
        Dim i As Integer
        Dim col1, col2, col3 As String

        For i = Me.grid_Main.SelectedRows.Count - 1 To 0 Step -1
            col1 = Me.grid_Main.SelectedRows(i).Cells(0).Value
            col2 = Me.grid_Main.SelectedRows(i).Cells(1).Value
            col3 = Me.grid_Main.SelectedRows(i).Cells(2).Value
            If rBtn_Item_List.Checked = True Then
                'Tbl_ItemsTableAdapter1.Delete(col1, col2, col3)
                'Tbl_ItemsTableAdapter1.Fill(Me.LabItemsDataSet1.tbl_Items)
            Else
                'Tbl_RFID_DataTableAdapter1.Delete(col1, col2, col3)
                'Tbl_RFID_DataTableAdapter1.Fill(Me.LabItemsDataSet1.tbl_RFID_Data)
            End If
        Next
    End Sub

    Private Sub btn_Add_Item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Add_Item.Click
        If btn_Add_Item.Text = "Update Item" Then
            'Tbl_ItemsTableAdapter1.UpdateCmd(tBox_Item_Name.Text, cBox_Item_Category.Text, tBox_Item_Description.Text, CInt(btn_Item_Id.Text))
        Else
            'Tbl_ItemsTableAdapter1.Insert("" & btn_Item_Id.Text, "" & tBox_Item_Name.Text, "" & cBox_Item_Category.Text, "" & tBox_Item_Description.Text)
        End If
        'Tbl_ItemsTableAdapter1.Fill(Me.LabItemsDataSet1.tbl_Items)
        reset_Fields()
        rBtn_Item_List.Select()
    End Sub

    Private Function Generate_ItemID()
        Generate_ItemID = Convert.ToInt32(DateTime.Now.ToString("MMddHHmmss"))

    End Function

    Private Sub grid_Main_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid_Main.CellContentClick
        view_Item()
    End Sub


    Private Sub view_Item()
        Dim col1, col2, col3, col4 As String
        If (rBtn_Item_List.Checked = True And Me.grid_Main.RowCount > 0) Then
            col1 = Me.grid_Main.SelectedRows(0).Cells(0).Value
            col2 = Me.grid_Main.SelectedRows(0).Cells(1).Value
            col3 = Me.grid_Main.SelectedRows(0).Cells(2).Value
            col4 = Me.grid_Main.SelectedRows(0).Cells(3).Value

            btn_Item_Id.Text = col1
            btn_Item_Id.Enabled = False
            tBox_Item_Name.Text = col2
            cBox_Item_Category.Text = col3
            tBox_Item_Description.Text = col4

            'Tbl_Item_DataTableAdapter.FillBy(Me.LabItemsDataSet1.tbl_Item_Data, btn_Item_Id.Text)
            'grid_Data.DataSource = TblItemDataBindingSource
            btn_Add_Item.Text = "Update Item"
            enable_Fields()
        End If
    End Sub

    Private Sub btn_Item_Id_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Item_Id.Click
        btn_Item_Id.Text = Generate_ItemID()
        btn_Item_Id.Enabled = False
        enable_Fields()
    End Sub

    Private Sub btn_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Clear.Click
        reset_Fields()
    End Sub

    Private Sub reset_Fields()
        btn_Item_Id.Enabled = True
        btn_Item_Id.Text = "Click for New Id"
        btn_Add_Item.Text = "Add Item"
        disable_Fields()
    End Sub

    Private Sub disable_Fields()
        tBox_Item_Name.Clear()
        tBox_Item_Name.Enabled = False
        cBox_Item_Category.SelectedIndex = -1
        cBox_Item_Category.Enabled = False
        cBox_Item_Data_Name.SelectedIndex = -1
        cBox_Item_Data_Name.Enabled = False
        cBox_Item_Data_Value.DataSource = Nothing
        cBox_Item_Data_Value.Enabled = False
        grid_Data.DataSource = Nothing
        btn_Delete_Data.Enabled = False
        btn_Add_Data.Enabled = False
        tBox_Item_Description.Clear()
        tBox_Item_Description.Enabled = False
        btn_Add_Item.Visible = False
    End Sub

    Private Sub enable_Fields()
        tBox_Item_Name.Enabled = True
        cBox_Item_Category.Enabled = True
        btn_Delete_Data.Enabled = True
        btn_Add_Data.Enabled = True
        tBox_Item_Description.Enabled = True
        btn_Add_Item.Visible = True
    End Sub

End Class
