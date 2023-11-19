namespace temp_scope;
public partial class Form1 : Form
{
    readonly ScottPlot.FormsPlot formsPlot1;
    public Form1()
    {
        InitializeComponent();

        //Add the FormsPlot
        //formsPlot1 = new() { Dock = DockStyle.Fill };
        formsPlot1 = new();
        formsPlot1.Width = 600; // Установите желаемую ширину элемента
        formsPlot1.Height = 420; // Установите желаемую высоту элемента
        formsPlot1.Location = new Point(300, 20);
        Controls.Add(formsPlot1);
 
        // Add sample data to the plot
        double[,] data = { { 1, 2, 3 }, { 4, 5, 6 } };
        var hm = formsPlot1.Plot.AddHeatmap(data);
        var cb = formsPlot1.Plot.AddColorbar(hm);
        formsPlot1.Plot.Title("Температурная карта");
        formsPlot1.Refresh();
        //var plt = new ScottPlot.Plot(200, 200);
        //double[,] data2D = { { 1, 2, 3 },
        //{ 4, 5, 6 } };

        //plt.AddHeatmap(data2D);
        //plt.Refresh();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        MessageBox.Show("Привет, мир!");
    }
}
