Imports System
Imports System.IO
Imports System.Drawing
Imports System.Data
Imports System.Data.OleDb
Imports System.Windows.Forms
Imports CarsProjectVB
Public Class Form1

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    
        If Not (Directory.Exists(Application.StartupPath + "\Save Folder")) Then
            Directory.CreateDirectory(Application.StartupPath + "\Save Folder")
        End If

        Dim cmd1 As New OleDbCommand("select*from car_Type", GC.Con)
        Dim Adptr As New OleDbDataAdapter(cmd1)
        Dim Dtset As New DataSet
        Adptr.Fill(Dtset, "car_Type")
        cmbx1.DataSource = Dtset.Tables("car_Type")
        cmbx1.ValueMember = "ID"
        cmbx1.DisplayMember = "car_Type"
        cmbx1.Text = ""

        Dim cmd2 As New OleDbCommand("Select*from Mngmnt_nam", GC.Con)
        Dim Adptr2 As New OleDbDataAdapter(cmd2)
        Dim Dtset2 As New DataSet
        Adptr2.Fill(Dtset2, "Mngmnt_nam")
        cmbx2.DataSource = Dtset2.Tables("Mngmnt_nam")
        cmbx2.ValueMember = "ID"
        cmbx2.DisplayMember = "Mngmnt_nam"
        cmbx2.Text = ""
        txt1.Text = " "
    End Sub

    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        
        Try
            Dim Inpt As String = ""
            Inpt = InputBox("ادخل نوع العجلة", "برنامج تسليم العجلات", "")
            Dim cmd1 As New OleDbCommand("Select*from car_Type where car_Type='" + Inpt + "' ", GC.Con)
            Dim cmd2 As New OleDbCommand("Insert into car_Type (car_Type) values ('" + Inpt + "') ", GC.Con)
            If Inpt.Length > 0 Then
                GC.Con.Open()
                Dim Dr As OleDbDataReader
                Dr = cmd1.ExecuteReader()
                If Dr.Read Then
                    MsgBox("رجاءا لقد تم ادخال نوع العجلة من قبل!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "برنامج تسليم العجلات")
                    GC.Con.Close()
                Else
                    GC.Con.Close()
                    GC.Con.Open()
                    cmd2.ExecuteNonQuery()
                    GC.Con.Close()

                    Dim cmd3 As New OleDbCommand("select*from car_Type", GC.Con)
                    Dim Adptr As New OleDbDataAdapter(cmd3)
                    Dim Dtset As New DataSet
                    Adptr.Fill(Dtset, "car_Type")
                    cmbx1.DataSource = Dtset.Tables("car_Type")
                    cmbx1.ValueMember = "ID"
                    cmbx1.DisplayMember = "car_Type"
                    cmbx1.Text = ""
                    MsgBox("تم الحفظ", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "برنامج تسليم العجلات")
                End If

                GC.Con.Close()

            Else
                GC.Con.Close()
                MsgBox("تم الالغاء", MsgBoxStyle.Exclamation, "برنامج تسليم العجلات")

            End If

        Catch er As Exception
            GC.Con.Close()
            MsgBox(er.Message, MsgBoxStyle.Exclamation, "برنامج تسليم العجلات")
        End Try


    End Sub

    Private Sub button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button2.Click
        Try
            Dim Inpt As String = ""
            Inpt = InputBox("ادخل اسم المديرية", "برنامج تسليم العجلات", "")
            Dim cmd1 As New OleDbCommand("Select*from Mngmnt_nam where Mngmnt_nam='" + Inpt + "' ", GC.Con)
            Dim cmd2 As New OleDbCommand("Insert into Mngmnt_nam (Mngmnt_nam) values ('" + Inpt + "') ", GC.Con)
            If Inpt.Length > 0 Then
                GC.Con.Open()
                Dim Dr As OleDbDataReader
                Dr = cmd1.ExecuteReader()
                If Dr.Read Then
                    MsgBox("رجاءا لقد تم ادخال اسم المديرية من قبل!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "برنامج تسليم العجلات")
                    GC.Con.Close()
                Else
                    GC.Con.Close()
                    GC.Con.Open()
                    cmd2.ExecuteNonQuery()
                    GC.Con.Close()

                    Dim cmd3 As New OleDbCommand("select*from Mngmnt_nam", GC.Con)
                    Dim Adptr As New OleDbDataAdapter(cmd3)
                    Dim Dtset As New DataSet
                    Adptr.Fill(Dtset, "Mngmnt_nam")
                    cmbx2.DataSource = Dtset.Tables("Mngmnt_nam")
                    cmbx2.ValueMember = "ID"
                    cmbx2.DisplayMember = "Mngmnt_nam"
                    cmbx2.Text = ""
                    MsgBox("تم الحفظ", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "برنامج تسليم العجلات")
                End If

                GC.Con.Close()

            Else
                GC.Con.Close()
                MsgBox("تم الالغاء", MsgBoxStyle.Exclamation, "برنامج تسليم العجلات")

            End If

        Catch er As Exception
            GC.Con.Close()
            MsgBox(er.Message, MsgBoxStyle.Exclamation, "برنامج تسليم العجلات")
        End Try

    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim DelMngNam As New DelMngNam
        DelMngNam.Show()

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim DelCarFrm As New DelCarFrm
        DelCarFrm.Show()

    End Sub

    Private Sub button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button3.Click
        Dim InsrtCrDtFrm As New InsrtCrDtFrm
        InsrtCrDtFrm.Show()

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        Try
            Dim cmd As New OleDbCommand("Select*from tbl1", GC.Con)
            Dim Aptr As New OleDbDataAdapter(cmd)
            Dim Dtset As New DataSet
            Aptr.Fill(Dtset, "tbl1")
            dataGridView1.DataSource = Dtset.Tables("tbl1")
            Tbl1BindingSource.DataSource = Dtset.Tables("tbl1")
            Tbl1TableAdapter.Connection = GC.Con
            Tbl1TableAdapter.Adapter.SelectCommand = cmd
            ReportViewer1.LocalReport.ReportPath = "Report1.rdlc"
            ReportViewer1.RefreshReport()
            ReportViewer1.Refresh()

        Catch er As Exception
            GC.Con.Close()
            MsgBox(er.Message, MsgBoxStyle.Exclamation, "برنامج تسليم العجلات")
        End Try
        

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Dim msg As DialogResult
        msg = MsgBox("هل بالتأكيد تريد حذف بيانات السيارة", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "برنامج تسليم العجلات")
        If msg = vbYes Then
            Try
                Dim No As Integer = Int(dataGridView1.CurrentRow.Cells(0).Value)

                Dim S1, S2, Pic As String
                S1 = dataGridView1.CurrentRow.Cells(1).Value.ToString
                S2 = dataGridView1.CurrentRow.Cells(2).Value.ToString
                Pic = dataGridView1.CurrentRow.Cells(11).Value.ToString
                Dim cmd As New OleDbCommand("Delete from tbl1 where ID=@ID and Car_no=@Car_no and Car_Type=@Car_Type", GC.Con)
                cmd.Parameters.AddWithValue("@ID", No)
                cmd.Parameters.AddWithValue("@Car_no", S1)
                cmd.Parameters.AddWithValue("@Car_type", S2)
                GC.Con.Open()
                cmd.ExecuteNonQuery()
                GC.Con.Close()

                Dim cmd1 As New OleDbCommand("Select*from tbl1", GC.Con)
                Dim Aptr As New OleDbDataAdapter(cmd1)
                Dim Dtset As New DataSet
                Aptr.Fill(Dtset, "tbl1")
                dataGridView1.DataSource = Dtset.Tables("tbl1")

                File.Delete(Pic)

                MsgBox("تم الحذف", MsgBoxStyle.Information, "برنامج تسليم العجلات")

            Catch er As Exception
                GC.Con.Close()
                MsgBox(er.Message, MsgBoxStyle.Exclamation, "برنامج تسليم العجلات")
            End Try
        End If
    End Sub

    Private Sub dataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataGridView1.CellContentClick
        Dim picfrm As New Picfrm
        If e.ColumnIndex = 11 Then
            GC.PicPath = dataGridView1.CurrentRow.Cells(11).Value.ToString
            picfrm.Show()
        End If

    End Sub

    Private Sub dataGridView1_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles dataGridView1.CellClick
     
    End Sub

    Private Sub cmbx1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbx1.SelectedIndexChanged, cmbx1.SelectionChangeCommitted
        Try
            Dim cmd As New OleDbCommand("select*from tbl1 where car_type='" + cmbx1.Text + "' ", GC.Con)
            Dim adptr As New OleDbDataAdapter(cmd)
            Dim Dtset As New DataSet
            adptr.Fill(Dtset, "tbl1")
            dataGridView1.DataSource = Dtset.Tables("tbl1")
            Tbl1BindingSource.DataSource = Dtset.Tables("tbl1")
            Tbl1TableAdapter.Connection = GC.Con
            Tbl1TableAdapter.Adapter.SelectCommand = cmd
            ReportViewer1.LocalReport.ReportPath = "Report1.rdlc"
            ReportViewer1.RefreshReport()
            ReportViewer1.Refresh()
        Catch er As Exception
            GC.Con.Close()
            MsgBox(er.Message, MsgBoxStyle.Exclamation, "برنامج تسليم العجلات")
        End Try
    End Sub

    Private Sub txt1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txt1.TextChanged
        Try
            Dim cmd As New OleDbCommand("select*from tbl1 where Srce_Nam like '%" + txt1.Text + "%' ", GC.Con)
            Dim adptr As New OleDbDataAdapter(cmd)
            Dim Dtset As New DataSet
            adptr.Fill(Dtset, "tbl1")
            dataGridView1.DataSource = Dtset.Tables("tbl1")
            Tbl1BindingSource.DataSource = Dtset.Tables("tbl1")
            Tbl1TableAdapter.Connection = GC.Con
            Tbl1TableAdapter.Adapter.SelectCommand = cmd
            ReportViewer1.LocalReport.ReportPath = "Report1.rdlc"
            ReportViewer1.RefreshReport()
            ReportViewer1.Refresh()
        Catch er As Exception
            GC.Con.Close()
            MsgBox(er.Message, MsgBoxStyle.Exclamation, "برنامج تسليم العجلات")
        End Try
    End Sub

    Private Sub cmbx2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmbx2.SelectedIndexChanged, cmbx2.SelectionChangeCommitted
        Try
            Dim cmd As New OleDbCommand("select*from tbl1 where Mngmnt_Nam='" + cmbx2.Text + "' ", GC.Con)
            Dim adptr As New OleDbDataAdapter(cmd)
            Dim Dtset As New DataSet
            adptr.Fill(Dtset, "tbl1")
            dataGridView1.DataSource = Dtset.Tables("tbl1")
            Tbl1BindingSource.DataSource = Dtset.Tables("tbl1")
            Tbl1TableAdapter.Connection = GC.Con
            Tbl1TableAdapter.Adapter.SelectCommand = cmd
            ReportViewer1.LocalReport.ReportPath = "Report1.rdlc"
            ReportViewer1.RefreshReport()
            ReportViewer1.Refresh()
        Catch er As Exception
            GC.Con.Close()
            MsgBox(er.Message, MsgBoxStyle.Exclamation, "برنامج تسليم العجلات")
        End Try
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        ReportViewer1.Visible = True
        Button9.Visible = True
        Button9.BringToFront()



    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        ReportViewer1.Visible = False
        Button9.Visible = False

    End Sub
End Class
