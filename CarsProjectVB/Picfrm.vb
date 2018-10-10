Imports System
Imports System.Data
Imports System.Windows.Forms
Imports System.Drawing.Printing
Imports System.IO

Public Class Picfrm
    Dim WithEvents PrtDoc As New PrintDocument
    Private Sub PrntDoc_printPage(ByVal sneder As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrtDoc.PrintPage
        e.Graphics.DrawImage(Me.PictureBox1.Image, 0, 0)
    End Sub
    Private Sub Picfrm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PictureBox1.Load(GC.PicPath)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim PrtDialog As New PrintDialog()
            PrtDialog.Document = PrtDoc
            Dim r As DialogResult = PrtDialog.ShowDialog
            If r = DialogResult.OK Then
                PrtDoc.Print()
            End If
        Catch er As Exception
            MsgBox(er.Message, MsgBoxStyle.Exclamation, "برنامج تسليم العجلات")
        End Try
       

    End Sub
End Class