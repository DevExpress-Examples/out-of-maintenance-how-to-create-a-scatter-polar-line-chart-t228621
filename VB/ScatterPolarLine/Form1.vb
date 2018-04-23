Imports DevExpress.XtraCharts
Imports System
Imports System.Windows.Forms
Imports DevExpress.Utils

Namespace ScatterPolarLine
    Partial Public Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
            ' Create a new chart.
            Dim scatterPolarLineChart As New ChartControl()

            ' Add the chart to the form.
            scatterPolarLineChart.Dock = DockStyle.Fill
            Me.Controls.Add(scatterPolarLineChart)

            ' Create a scatter polar line series.
            Dim series1 As New Series("Series 1", ViewType.ScatterPolarLine)

            ' Add points to it.
            series1.Points.Add(New SeriesPoint(0, 0.523598))
            series1.Points.Add(New SeriesPoint(30, 0.523598))
            series1.Points.Add(New SeriesPoint(60, 1.047197))
            series1.Points.Add(New SeriesPoint(90, 1.570796))
            series1.Points.Add(New SeriesPoint(120, 2.094395))
            series1.Points.Add(New SeriesPoint(150, 2.617993))
            series1.Points.Add(New SeriesPoint(180, 3.141592))
            series1.Points.Add(New SeriesPoint(210, 3.665191))
            series1.Points.Add(New SeriesPoint(240, 4.188790))
            series1.Points.Add(New SeriesPoint(270, 4.712388))
            series1.Points.Add(New SeriesPoint(300, 5.235987))
            series1.Points.Add(New SeriesPoint(330, 5.759586))
            series1.Points.Add(New SeriesPoint(0, 6.283185))
            series1.Points.Add(New SeriesPoint(30, 6.806784))
            series1.Points.Add(New SeriesPoint(60, 7.330382))
            series1.Points.Add(New SeriesPoint(90, 7.853981))
            series1.Points.Add(New SeriesPoint(120, 8.377580))
            series1.Points.Add(New SeriesPoint(150, 8.901179))
            series1.Points.Add(New SeriesPoint(180, 9.424777))
            series1.Points.Add(New SeriesPoint(210, 9.948376))
            series1.Points.Add(New SeriesPoint(240, 10.4719755))
            series1.Points.Add(New SeriesPoint(270, 10.9955742))
            series1.Points.Add(New SeriesPoint(300, 11.5191730))
            series1.Points.Add(New SeriesPoint(330, 12.04277183))
            series1.Points.Add(New SeriesPoint(0, 12.56637061))

            ' Add the series to the chart.
            scatterPolarLineChart.Series.Add(series1)

            ' Access the view-type-specific options of the series.
            CType(series1.View, ScatterPolarLineSeriesView).LineStyle.DashStyle = DashStyle.DashDot

            ' Flip the diagram (if necessary).
            CType(scatterPolarLineChart.Diagram, PolarDiagram).StartAngleInDegrees = 180
            CType(scatterPolarLineChart.Diagram, PolarDiagram).RotationDirection = RadarDiagramRotationDirection.Counterclockwise

            ' Hide the legend (if necessary).
            scatterPolarLineChart.Legend.Visibility = DefaultBoolean.False

            ' Add a title to the chart (if necessary).
            scatterPolarLineChart.Titles.Add(New ChartTitle())
            scatterPolarLineChart.Titles(0).Text = "A Scatter Polar Line Chart"
        End Sub
    End Class
End Namespace
