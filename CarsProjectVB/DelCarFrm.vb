Imports System.Data
Imports System.Data.OleDb
Imports CarsProjectVB
Public Class DelCarFrm

    Private Sub DelCarFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim cmd1 As New OleDbCommand("select*from car_Type", GC.Con)
        Dim Adptr As New OleDbDataAdapter(cmd1)
        Dim Dtset As New DataSet
        Adptr.Fill(Dtset, "car_Type")
        cmbx1.DataSource = Dtset.Tables("car_Type")
        cmbx1.ValueMember = "ID"
        cmbx1.DisplayMember = "car_Type"
        cmbx1.Text = ""
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If cmbx1.Text = "" Then
            MsgBox("رجاءاً اختر نوع العجلة!", MsgBoxStyle.OkOnly + MsgBoxStyle.Critical, "برنامج تسليم العجلات")
            Return
        End If

        Dim a As DialogResult
        a = MsgBox("هل تريد الحذف بالتأكيد", MsgBoxStyle.YesNo + MsgBoxStyle.Question, "برنامج تسليم العجلات")
        If a = vbYes Then
            Try
                Dim cmd As New OleDbCommand("Delete from car_Type where car_Type='" + cmbx1.Text + "' ", GC.Con)
                GC.Con.Open()
                cmd.ExecuteNonQuery()
                GC.Con.Close()
                Dim cmd2 As New OleDbCommand("Select*from car_Type", GC.Con)
                Dim Adptr2 As New OleDbDataAdapter(cmd2)
                Dim Dtset2 As New DataSet
                Adptr2.Fill(Dtset2, "car_Type")
                cmbx1.DataSource = Dtset2.Tables("car_Type")
                cmbx1.ValueMember = "ID"
                cmbx1.DisplayMember = "car_Type"
                cmbx1.Text = ""
                MsgBox("تم الحذف", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "برنامج تسليم العجلات")
            Catch er As Exception
                GC.Con.Close()
                MsgBox(er.Message, MsgBoxStyle.Exclamation, "برنامج تسليم العجلات")
            End Try
        End If

    End Sub
End Class