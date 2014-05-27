Public Class Form_Home

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewBudgetBTN.Click

        CreateEditForm.Show()
        Me.Close()

    End Sub

    Private Sub LoadBudgetBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LoadBudgetBTN.Click
        Form_Options.Show()
        Me.Close()
    End Sub
End Class
