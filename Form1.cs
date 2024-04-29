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
        plot1.Controls.Add(plot_1);
    }

    public void SetController(ISignalController controller)
    {
        this.controller = controller;
    }

    public void refreshGraphs()
    {
        plot_1.Refresh();
        //plot_2.Refresh();
        //plot_3.Refresh();
    }

    public void setGraphDataSource(double[] first, double[] second, double[] third)
    {
        //double[] data = ScottPlot.Generate.Sin();
        //plot_1.Plot.Add.Signal(data);
        plot_1.Plot.Add.Signal(first);
        //plot_2.Plot.Add.Signal(second);
        //plot_3.Plot.Add.Signal(third);
    }

    private void îòêðûòüToolStripMenuItem_Click(object sender, EventArgs e)
    {
       if (openFileDialog1.ShowDialog() == DialogResult.OK)
       {
            controller.openFile(openFileDialog1.FileName);
       }
    }
}
