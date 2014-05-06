Public Class Form3

    
    Sub AddAxis(ByVal label As String, ByVal value As Double)

        Chart1.Series(0).Points.AddY(value)
        Chart1.Series(0).Points(Chart1.Series(0).Points.Count - 1).AxisLabel = label

    End Sub

    Sub CalcuLateTotal()



    End Sub

    Private Sub Form3_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        AddAxis("Dairy", TxtDairy.Text)

    End Sub

    Private Sub SaveBudgetBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveBudgetBTN.Click

    End Sub
End Class