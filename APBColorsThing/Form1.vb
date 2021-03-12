Imports System.EventArgs
Public Class Form1
    Private Sub Input_H_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Input_H.KeyPress
        If Char.IsNumber(e.KeyChar) = False Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(8) Then
            e.Handled = False
        End If
    End Sub
    Private Sub Input_S_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Input_S.KeyPress
        If Char.IsNumber(e.KeyChar) = False Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(8) Then
            e.Handled = False
        End If
    End Sub
    Private Sub Input_L_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Input_L.KeyPress
        If Char.IsNumber(e.KeyChar) = False Then
            e.Handled = True
        End If
        If e.KeyChar = ChrW(8) Then
            e.Handled = False
        End If
    End Sub
    Private Sub Output_H_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Output_H.KeyPress
        e.Handled = True
    End Sub
    Private Sub Output_S_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Output_S.KeyPress
        e.Handled = True
    End Sub
    Private Sub Output_L_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Output_L.KeyPress
        e.Handled = True
    End Sub
    Private Sub Input_H_TextChanged(sender As Object, e As EventArgs) Handles Input_H.TextChanged
        If String.IsNullOrEmpty(Input_H.Text) Then
            Return
        End If
        Dim Output_HText As Integer
        Output_HText = Input_H.Text / 11.612903225806452
        Output_H.Text = (Math.Round(Output_HText * 1) / 1).ToString()
        If Input_H.Text > 360 Then
            Input_H.Text = 360
        End If
    End Sub

    Private Sub Input_S_TextChanged(sender As Object, e As EventArgs) Handles Input_S.TextChanged
        If String.IsNullOrEmpty(Input_S.Text) Then
            Return
        End If
        Dim Output_SText As Integer
        Output_SText = Input_S.Text / 14.285714285714287
        Output_S.Text = (Math.Round(Output_SText * 1) / 1).ToString()
        If Input_S.Text > 100 Then
            Input_S.Text = 100
        End If
    End Sub

    Private Sub Input_L_TextChanged(sender As Object, e As EventArgs) Handles Input_L.TextChanged
        If String.IsNullOrEmpty(Input_L.Text) Then
            Return
        End If
        Dim Output_LText As Integer
        Output_LText = Input_L.Text / 6.666666666666667
        Output_L.Text = (Math.Round(Output_LText * 1) / 1).ToString()
        If Input_L.Text > 100 Then
            Input_L.Text = 100
        End If
    End Sub

    Private Sub Clear_Input_H_Click(sender As Object, e As EventArgs) Handles Clear_Input_H.Click
        Input_H.Text = ""
        Output_H.Text = ""
    End Sub

    Private Sub Clear_Input_S_Click(sender As Object, e As EventArgs) Handles Clear_Input_S.Click
        Input_S.Text = ""
        Output_S.Text = ""
    End Sub

    Private Sub Clear_Input_L_Click(sender As Object, e As EventArgs) Handles Clear_Input_L.Click
        Input_L.Text = ""
        Output_L.Text = ""
    End Sub

    Private Sub ColorConverter_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles ColorConverter.LinkClicked
        Process.Start("https://www.w3schools.com/colors/colors_converter.asp")
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
