Imports System.Data
Imports System.Data.OleDb
Imports CarsProjectVB
Public Class InsrtCrDtFrm

    Private Sub InsrtCrDtFrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtp1.Value = "01/01/2014"
        dtp2.Value = "01/01/2014"
        dtp3.Value = "01/01/2014"
        OpenFileDialog1.FileName = ""
        Dim Cmd1 As New OleDbCommand("select*from car_type", GC.Con)
        Dim Adptr As New OleDbDataAdapter(Cmd1)
        Dim Dtset As New DataSet
        Adptr.Fill(Dtset, "car_type")
        cmbx1.DataSource = Dtset.Tables("car_type")
        cmbx1.ValueMember = "ID"
        cmbx1.DisplayMember = "car_type"
        cmbx1.SelectedText = ""

        Dim Cmd2 As New OleDbCommand("select*from Mngmnt_Nam", GC.Con)
        Dim Adptr2 As New OleDbDataAdapter(Cmd2)
        Dim dtset2 As New DataSet
        Adptr2.Fill(dtset2, "Mngmnt_Nam")
        cmbx2.DataSource = dtset2.Tables("Mngmnt_Nam")
        cmbx2.ValueMember = "ID"
        cmbx2.DisplayMember = "Mngmnt_Nam"


    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub dtp1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles dtp1.ValueChanged

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If txt1.Text = "" Then
                MsgBox("رجاءاً ادخل رقم العجلة", MsgBoxStyle.Exclamation, "برنامج تسليم العجلات")
                Return
            End If

            If cmbx1.Text = "" Then
                MsgBox("رجاءاً اختر نوع العجلة", MsgBoxStyle.Exclamation, "برنامج تسليم العجلات")
                Return
            End If

            If txt2.Text = "" Then
                MsgBox("رجاءاً ادخل لون العجلة", MsgBoxStyle.Exclamation, "برنامج تسليم العجلات")
                Return
            End If

            If txt3.Text = "" Then
                MsgBox("رجاءاً ادخل اسم المستلم", MsgBoxStyle.Exclamation, "برنامج تسليم العجلات")
                Return
            End If

            If cmbx2.Text = "" Then
                MsgBox("رجاءاً ادخل اسم المديرية", MsgBoxStyle.Exclamation, "برنامج تسليم العجلات")
                Return
            End If

            If txt4.Text = "" Then
                MsgBox("رجاءاً ادخل اسم المديرية", MsgBoxStyle.Exclamation, "برنامج تسليم العجلات")
                Return
            End If

            If dtp3.Value = "01/01/2014" Then
                MsgBox("رجاءاً ادخل تاريخ العطل", MsgBoxStyle.Exclamation, "برنامج تسليم العجلات")
                Return
            End If

            If OpenFileDialog1.FileName = "" Then
                MsgBox("رجاءاً اختر صورة المستند", MsgBoxStyle.Exclamation, "برنامج تسليم العجلات")
                Return
            End If

            Dim cmdSav As New OleDbCommand("insert into tbl1 (Car_No,Car_Type,Car_Color,Srce_Nam,Mngmnt_Nam,Chek_Nam,Chek_Dat,Tir_Dat,Battry_Dat,Notes,Attachs) values (@Car_No,@Car_Type,@Car_Color,@Srce_Nam,@Mngmnt_Nam,@Chek_Nam,@Chek_Dat,@Tir_Dat,@Battry_Dat,@Notes,@Attachs)", GC.Con)
            cmdSav.Parameters.AddWithValue("@Car_No", txt1.Text)
            cmdSav.Parameters.AddWithValue("@Car_Type", cmbx1.Text)
            cmdSav.Parameters.AddWithValue("@Car_Color", txt2.Text)
            cmdSav.Parameters.AddWithValue("@Srce_Nam", txt3.Text)
            cmdSav.Parameters.AddWithValue("@Mngmnt_Nam", cmbx2.Text)
            cmdSav.Parameters.AddWithValue("@Chek_Nam", txt4.Text)
            cmdSav.Parameters.AddWithValue("@Chek_Dat", dtp3.Text)
            If dtp1.Value = "01/01/2014" Then
                cmdSav.Parameters.AddWithValue("@Tir_Dat", " ")
            Else
                cmdSav.Parameters.AddWithValue("@Tir_Dat", dtp1.Text)
            End If
            If dtp2.Value = "01/01/2014" Then
                cmdSav.Parameters.AddWithValue("@Battry_Dat", " ")
            Else
                cmdSav.Parameters.AddWithValue("@Battry_Dat", dtp2.Text)
            End If
            cmdSav.Parameters.AddWithValue("@Notes", txt5.Text)
            cmdSav.Parameters.AddWithValue("@Attachs", Application.StartupPath + "\Save Folder\" + txt3.Text + "_" + txt1.Text + "_" + cmbx1.Text + DateTime.Now.Day.ToString + "_" + DateTime.Now.Month.ToString + "_" + DateTime.Now.Year.ToString + "_" + DateTime.Now.Hour.ToString + DateTime.Now.Minute.ToString + DateTime.Now.Second.ToString + ".jpg")
            GC.Con.Open()
            cmdSav.ExecuteNonQuery()
            GC.Con.Close()
            FileCopy(OpenFileDialog1.FileName, Application.StartupPath + "\Save Folder\" + txt3.Text + "_" + txt1.Text + "_" + cmbx1.Text + DateTime.Now.Day.ToString + "_" + DateTime.Now.Month.ToString + "_" + DateTime.Now.Year.ToString + "_" + DateTime.Now.Hour.ToString + DateTime.Now.Minute.ToString + DateTime.Now.Second.ToString + ".jpg")
            txt1.Text = ""
            txt2.Text = ""
            txt3.Text = ""
            txt4.Text = ""
            txt5.Text = ""
            dtp1.Value = "01/01/2014"
            dtp2.Value = "01/01/2014"
            dtp3.Value = "01/01/2014"
            OpenFileDialog1.FileName = ""
            MsgBox("تم الحفظ", MsgBoxStyle.Information, "برنامج تسليم العجلات")
        Catch er As Exception
            GC.Con.Close()
            MsgBox(er.Message, MsgBoxStyle.Exclamation, "برنامج تسليم العجلات")
        End Try

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        OpenFileDialog1.Title = "اختر صورة المستند"
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "صورة نوع (*.jpg)|*.jpg|(كل الملفات)|*.*"
        OpenFileDialog1.CheckFileExists = True
        OpenFileDialog1.CheckPathExists = True
        OpenFileDialog1.ShowDialog()
    End Sub
End Class