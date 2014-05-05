Public Class Form3

    Private Sub Chart1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
    Sub AddAxis(ByVal label As String, ByVal value As Double)

        Chart1.Series(0).Points.AddY(value)
        Chart1.Series(0).Points(Chart1.Series(0).Points.Count - 1).AxisLabel = label

    End Sub

    Private Sub Form3_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load


    End Sub



    Private Sub Chart1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Chart1.Click

    End Sub

    Private Sub TextBox15_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox15.TextChanged

    End Sub
End Class