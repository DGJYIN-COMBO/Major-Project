Public Class CreateEditBgt


    Sub AddAxis(ByVal label As String, ByVal value As Double)

        Chart1.Series(0).Points.AddY(value)
        Chart1.Series(0).Points(Chart1.Series(0).Points.Count - 1).AxisLabel = label

    End Sub

    Sub CalcuLateTotal()

        

    End Sub

    Private Sub Form3_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load



    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Form_Home.Show()
        Me.Close()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form_Home.Show()
        Me.Close()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HomeBtn.Click
        Form_Home.Show()
        Me.Close()
    End Sub
End Class
