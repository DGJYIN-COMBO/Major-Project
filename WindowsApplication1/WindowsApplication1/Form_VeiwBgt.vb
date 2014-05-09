Public Class BudgetViewer

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HomeBtn.Click
        Form_Home.Show()
        Me.Close()
    End Sub

    Private Sub LoadBudgetBTN_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditBtn.Click
        CreateEditBgt.Show()
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteBtn.Click
        ' Sub RemoveACar()

        'Dim selection As Integer

        'Console.ForegroundColor = ConsoleColor.DarkGreen
        'Console.WriteLine("Select from the following list to remove")

        ''''loop throught the statements
        'For i = 0 To car_count - 1
        'Console.WriteLine(i & ": " & Cars(i).Brand & " " & Cars(i).Make & " " & Cars(i).Model)

        'Next

        'Console.WriteLine()
        'Console.Write("selection: ")
        'selection = Console.ReadLine

        'For i As Integer = selection To car_count
        'Cars(i).Brand = Cars(i + 1).Brand
        'Cars(i).Brand = Cars(i + 1).Make
        'Cars(i).Brand = Cars(i + 1).Model
        'Cars(i).Brand = Cars(i + 1).Year
        'Cars(i).Brand = Cars(i + 1).BaseCost
        'Cars(i).Brand = Cars(i + 1).DealerMarkupPercentage

        'Next

        'car_count -= 1
        'SaveCar()
        'Menu()

        'Console.ReadLine()

        ' End Sub
    End Sub

End Class