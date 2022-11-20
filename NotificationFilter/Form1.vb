Imports Windows.UI.Notifications

Public Class Form1
    Private WithEvents listen As UserNotificationListener
    Private Sub onnotif(sender As UserNotificationListener, e As UserNotificationChangedEventArgs) Handles listen.NotificationChanged
        Try
            If listen.GetNotification(e.UserNotificationId).Notification.Visual.Bindings.ToList()(0).GetTextElements().ToList()(1).Text = "This site was updated in the background." Then
                listen.RemoveNotification(e.UserNotificationId)
            End If
        Catch ex As System.NullReferenceException

        End Try
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        listen = UserNotificationListener.Current
    End Sub

    Private Sub Form1_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        Hide()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Close()
    End Sub
End Class
