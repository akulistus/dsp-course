using dsp_course.Controller.Interfaces;
using dsp_course.Model;
using dsp_course.Model.Interfaces;
using ScottPlot.WinForms;
namespace dsp_course;

public partial class Form1 : Form, IView
{
    ISignalController controller;
    FormsPlot plot_1;
    FormsPlot plot_2;
    FormsPlot plot_3;

    public Form1()
    {
        InitializeComponent();
        plot_1 = new FormsPlot() { Dock = DockStyle.Fill };
        plot_2 = new FormsPlot() { Dock = DockStyle.Fill };
        plot_3 = new FormsPlot() { Dock = DockStyle.Fill };
        plot1.Controls.Add(plot_1);
        plot2.Controls.Add(plot_2);
        plot3.Controls.Add(plot_3);
        comboBox1.SelectedIndex = 0;
    }

    public void SetController(ISignalController controller)
    {
        this.controller = controller;
    }

    public void refreshGraphs()
    {
        plot_1.Refresh();
        plot_2.Refresh();
        plot_3.Refresh();
    }

    public void setGraphDataSource(double[] first, double[] second, double[] third)
    {
        plot_1.Plot.Clear();
        plot_2.Plot.Clear();
        plot_3.Plot.Clear();

        plot_1.Plot.Add.Signal(first);
        plot_1.Plot.Axes.AutoScale();
        plot_2.Plot.Add.Signal(second);
        plot_2.Plot.Axes.AutoScale();
        plot_3.Plot.Add.Signal(third);
        plot_3.Plot.Axes.AutoScale();
    }

    public void updateTable(Dictionary<string, List<double>> filtered, Dictionary<string, List<double>> teta)
    {
        foreach (var item in filtered)
        {
            DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
            row.Cells[0].Value = $"{item.Key}";
            row.Cells[1].Value = $"{Math.Round(item.Value[0], 3)} / {Math.Round(teta[item.Key][0], 3)}";
            row.Cells[2].Value = $"{Math.Round(item.Value[1], 3)} / {Math.Round(teta[item.Key][1], 3)}";
            row.Cells[3].Value = $"{Math.Round(item.Value[2], 3)} / {Math.Round(teta[item.Key][2], 3)}";
            dataGridView1.Rows.Add(row);
        }
    }

    private void îòêðûòüToolStripMenuItem_Click(object sender, EventArgs e)
    {
        if (openFileDialog1.ShowDialog() == DialogResult.OK)
        {
            controller.openFile(openFileDialog1.FileName);
        }
    }

    private void radioButton1_CheckedChanged(object sender, EventArgs e)
    {
        controller.display50hz();
    }

    private void radioButton5_CheckedChanged(object sender, EventArgs e)
    {
        controller.displayRaw();
    }

    private void radioButton2_CheckedChanged(object sender, EventArgs e)
    {
        controller.display50hzLow();
    }

    private void radioButton3_CheckedChanged(object sender, EventArgs e)
    {
        controller.display50HzLowTrd();
    }

    private void radioButton4_CheckedChanged(object sender, EventArgs e)
    {
        controller.displayTeta();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        if (folderBrowserDialog1.ShowDialog() == DialogResult.Cancel)
        {
            return;
        }

        string path = folderBrowserDialog1.SelectedPath;
        controller.saveFile(path, comboBox1.Text);
    }
}
