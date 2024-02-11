Class MainWindow
    Private Sub CmdResult_Click(sender As Object, e As RoutedEventArgs) Handles CmdResult.Click
        Dim n, s As Integer
        Dim info, SInfo As String

        n = Val(TxtLet.Text)
        s = Val(SField.Text)

        Select Case s
            Case 12, 1, 2
                SInfo = "Winter"
            Case 3 To 5
                SInfo = "Spring"
            Case 6 To 8
                SInfo = "Summer"
            Case 9 To 11
                SInfo = "Autumn"
        End Select

        Select Case n
            Case Is < 7
                info = "Preschool"
            Case 7 To 16
                info = "You need to go to school"
            Case 17 To 21
                info = "University"
            Case 22 To 55
                info = "Work"
            Case Else
                info = "Well-deserved rest "
        End Select

        LblInfo.Content = info
        If String.IsNullOrEmpty(SField.Text) Then
            LblSeasonOfYear.Content = "You forgot to enter month:)"
        Else
            LblSeasonOfYear.Content = "Your season of year: " + SInfo
        End If

    End Sub

    Private Sub TxtLet_TextChanged(sender As Object, e As TextChangedEventArgs) Handles TxtLet.TextChanged

    End Sub

    Private Sub ExitBTN_Click(sender As Object, e As RoutedEventArgs) Handles ExitBTN.Click
        If MsgBox("Close the app?", vbYesNo, "Confirming") = vbYes Then
            Windows.Application.Current.Shutdown()
        End If
    End Sub

    Private Sub Button_Click(sender As Object, e As RoutedEventArgs)

    End Sub
End Class
