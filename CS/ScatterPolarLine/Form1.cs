using DevExpress.XtraCharts;
using System;
using System.Windows.Forms;
using DevExpress.Utils;

namespace ScatterPolarLine {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            // Create a new chart.
            ChartControl scatterPolarLineChart = new ChartControl();

            // Add the chart to the form.
            scatterPolarLineChart.Dock = DockStyle.Fill;
            this.Controls.Add(scatterPolarLineChart);

            // Create a scatter polar line series.
            Series series1 = new Series("Series 1", ViewType.ScatterPolarLine);

            // Add points to it.
            series1.Points.Add(new SeriesPoint(0, 0.523598));
            series1.Points.Add(new SeriesPoint(30, 0.523598));
            series1.Points.Add(new SeriesPoint(60, 1.047197));
            series1.Points.Add(new SeriesPoint(90, 1.570796));
            series1.Points.Add(new SeriesPoint(120, 2.094395));
            series1.Points.Add(new SeriesPoint(150, 2.617993));
            series1.Points.Add(new SeriesPoint(180, 3.141592));
            series1.Points.Add(new SeriesPoint(210, 3.665191));
            series1.Points.Add(new SeriesPoint(240, 4.188790));
            series1.Points.Add(new SeriesPoint(270, 4.712388));
            series1.Points.Add(new SeriesPoint(300, 5.235987));
            series1.Points.Add(new SeriesPoint(330, 5.759586));
            series1.Points.Add(new SeriesPoint(0, 6.283185));
            series1.Points.Add(new SeriesPoint(30, 6.806784));
            series1.Points.Add(new SeriesPoint(60, 7.330382));
            series1.Points.Add(new SeriesPoint(90, 7.853981));
            series1.Points.Add(new SeriesPoint(120, 8.377580));
            series1.Points.Add(new SeriesPoint(150, 8.901179));
            series1.Points.Add(new SeriesPoint(180, 9.424777));
            series1.Points.Add(new SeriesPoint(210, 9.948376));
            series1.Points.Add(new SeriesPoint(240, 10.4719755));
            series1.Points.Add(new SeriesPoint(270, 10.9955742));
            series1.Points.Add(new SeriesPoint(300, 11.5191730));
            series1.Points.Add(new SeriesPoint(330, 12.04277183));
            series1.Points.Add(new SeriesPoint(0, 12.56637061));

            // Add the series to the chart.
            scatterPolarLineChart.Series.Add(series1);

            // Access the view-type-specific options of the series.
            ((ScatterPolarLineSeriesView)series1.View).LineStyle.DashStyle = DashStyle.DashDot;

            // Flip the diagram (if necessary).
            ((PolarDiagram)scatterPolarLineChart.Diagram).StartAngleInDegrees = 180;
            ((PolarDiagram)scatterPolarLineChart.Diagram).RotationDirection =
                RadarDiagramRotationDirection.Counterclockwise;

            // Hide the legend (if necessary).
            scatterPolarLineChart.Legend.Visibility = DefaultBoolean.False;

            // Add a title to the chart (if necessary).
            scatterPolarLineChart.Titles.Add(new ChartTitle());
            scatterPolarLineChart.Titles[0].Text = "A Scatter Polar Line Chart";
        }
    }
}
