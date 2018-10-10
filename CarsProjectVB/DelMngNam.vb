Imports System.Data
Imports System.Data.OleDb
Imports CarsProjectVB

Public Class DelMngNam

    Private Sub DelMngNam_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cmd2 As New OleDbCommand("Select*from Mngmnt_nam", GC.Con)
        Dim Adptr2 As New OleDbDataAdapter(cmd2)
        Dim Dtset2 As New DataSet
        Adptr2.Fill(Dtset2, "Mngmnt_nam")
        cmbx2.DataSource = Dtset2.Tables("Mngmnt_nam")
        cmbx2.ValueMember = "ID"
        cmbx2.DisplayMember = "Mngmnt_nam"
        cmbx2.Text = ""
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If cmbx2.Text = "" Then
            MsgBox("رجاءاً اختر اسم مديرية!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "برنامج تسليم العجلات")
            Return
        End If

        Dim a As DialogResult
        a = MsgBox("هل تريد الحذف بالتأكيد", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "برنامج تسليم العجلات")
        If a = vbYes Then
            Try
                Dim cmd As New OleDbCommand("Delete from Mngmnt_nam where Mngmnt_nam='" + cmbx2.Text + "' ", GC.Con)
                GC.Con.Open()
                cmd.ExecuteNonQuery()
                GC.Con.Close()
                Dim cmd2 As New OleDbCommand("Select*from Mngmnt_nam", GC.Con)
                Dim Adptr2 As New OleDbDataAdapter(cmd2)
                Dim Dtset2 As New DataSet
                Adptr2.Fill(Dtset2, "Mngmnt_nam")
                cmbx2.DataSource = Dtset2.Tables("Mngmnt_nam")
                cmbx2.ValueMember = "ID"
                cmbx2.DisplayMember = "Mngmnt_nam"
                cmbx2.Text = ""
                MsgBox("تم الحذف", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "برنامج تسليم العجلات")
            Catch er As Exception
                GC.Con.Close()
                MsgBox(er.Message, MsgBoxStyle.Exclamation, "برنامج تسليم العجلات")
            End Try
        End If
    End Sub
End Class