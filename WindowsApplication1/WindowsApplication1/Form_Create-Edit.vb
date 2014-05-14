Imports System.Data.OleDb
Imports System.Windows.Forms.DataVisualization.Charting

Public Class CreateEditForm

    '~~> Code required to browse for the Access Database File
    Private Sub Button1_Click(ByVal sender As System.Object, _
    ByVal e As System.EventArgs) Handles SaveBudgetBTN.Click
        With OpenFileDialog1
            .DefaultExt = "accdb"
            .DereferenceLinks = True
            .Filter = _
             "Access files (*.accdb)|*.accdb"
            .Multiselect = False
            .Title = "Select an Access Database file to open"
            .ValidateNames = True

            If .ShowDialog = Windows.Forms.DialogResult.OK Then
                Try
                    TextBox1.Text = .FileName
                Catch fileException As Exception
                    Throw fileException
                End Try
            End If
        End With
    End Sub

   

    Private Sub HomeBtn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HomeBtn.Click
        '~~> Connection String to connect to the access Database
        '~~> If you are planning to use SQL Database then 
        '~~> please visit www.connectionstrings.com for an
        '~~> appropriate connection string
        Dim strConn As String = _
        "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & TextBox1.Text & _
        ";Persist Security Info=False;"

        '~~> Query string
        Dim tblFields As String = "SELECT * from Table1"

        '~~> Connecting to Data base and storing the data in a dataset
        Dim conn As New OleDbConnection(strConn)
        Dim oCmd As New OleDbCommand(tblFields, conn)
        Dim oData As New OleDbDataAdapter(tblFields, conn)
        Dim ds As New DataSet

        conn.Open()
        oData.Fill(ds, "Table1")
        conn.Close()

        '''''''''''''''''''''''''''''
        '~~> SET DATA SOURCE <~~'
        '''''''''''''''''''''''''''''
        Chart1.DataSource = ds.Tables("Table1")

        ''''''''''''''''''''''''''''''''
        '~~> WORKING WITH CHARTAREA <~~'
        ''''''''''''''''''''''''''''''''
        Dim CArea As ChartArea = Chart1.ChartAreas(0)
        CArea.BackColor = Color.Azure           '~~> Changing the Back Color of the Chart Area 
        CArea.ShadowColor = Color.Red           '~~> Changing the Shadow Color of the Chart Area 
        CArea.Area3DStyle.Enable3D = True       '~~> Changing the Chart Style to 3D 

        '~~> Formatting X Axis
        CArea.AxisX.MajorGrid.Enabled = False   '~~> Removed the X axis major grids
        CArea.AxisX.LabelStyle.Font = New System.Drawing.Font("Times New Roman", _
        11.0F, System.Drawing.FontStyle.Italic) '~~> Setting Font, Font Size and Italicizing

        '~~> Formatting Y Axis
        CArea.AxisY.MajorGrid.Enabled = False   '~~> Removed the Y axis major grids
        CArea.AxisY.LabelStyle.Format = "0.00%" '~~> Formatting Y axis to display values in %age
        CArea.AxisY.Interval = 0.2              '~~> Formatting Y axis Interval to 20%

        ''''''''''''''''''''''''''''
        '~~> WORKING WITH TITLE <~~'
        ''''''''''''''''''''''''''''
        '~~> Adding a Title
        Dim T As Title = Chart1.Titles.Add("Sales Report Fruits - Year 2010")
        '~~> Formatting the Title
        With T
            .ForeColor = Color.Black            '~~> Changing the Fore Color of the Title 
            .BackColor = Color.Coral            '~~> Changing the Back Color of the Title 

            '~~> Setting Font, Font Size and Bold/Italicizing
            .Font = New System.Drawing.Font("Times New Roman", 11.0F, System.Drawing.FontStyle.Bold)
            .Font = New System.Drawing.Font("Times New Roman", 11.0F, System.Drawing.FontStyle.Underline)
            .BorderColor = Color.Black          '~~> Changing the Border Color of the Title 
            .BorderDashStyle = ChartDashStyle.DashDotDot '~~> Changing the Border Dash Style of the Title 
        End With

        '''''''''''''''''''''''''''''
        '~~> WORKING WITH SERIES <~~'
        '''''''''''''''''''''''''''''
        Dim Series1 As Series = Chart1.Series("Series1")
        '~~> Setting the series Name
        Series1.Name = "Sales"
        '~~> Assigning values to X and Y Axis
        Chart1.Series(Series1.Name).XValueMember = "nFruits"
        Chart1.Series(Series1.Name).YValueMembers = "nSales"
        '~~> Setting Font, Font Size and Bold
        Chart1.Series(Series1.Name).Font = New System.Drawing.Font("Times New Roman", 11.0F, System.Drawing.FontStyle.Bold)
        '~~> Setting Value Type
        Chart1.Series(Series1.Name).YValueType = ChartValueType.Double
        '~~> Setting the Chart Type for Display 
        Chart1.Series(Series1.Name).ChartType = SeriesChartType.Radar
        '~~> Display Data Labels
        Chart1.Series(Series1.Name).IsValueShownAsLabel = True
        '~~> Setting label's Fore Color
        Chart1.Series(Series1.Name).LabelForeColor = Color.DarkGreen
        '~~> Setting label's Format to %age
        Chart1.Series(Series1.Name).LabelFormat = "0.00%"

        '''''''''''''''''''''''''''''
        '~~> WORKING WITH LEGEND <~~'
        '''''''''''''''''''''''''''''
        Dim LG As Legend = Chart1.Legends(0)
        '~~> Changing the Back Color of the Legend 
        LG.BackColor = Color.Wheat
        '~~> Changing the Fore Color of the Legend
        LG.ForeColor = Color.DarkSlateBlue
        '~~> Setting Font, Font Size and Bold
        LG.Font = New System.Drawing.Font("Times New Roman", 11.0F, System.Drawing.FontStyle.Bold)
        '~~> Assigning a title for the legend
        LG.Title = "Legend"

        '~~> Setting the location for the chart
        Chart1.Size = New System.Drawing.Size(780, 350)
    End Sub
End Class

