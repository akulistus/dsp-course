using dsp_course.Controller;
using dsp_course.Model;

namespace dsp_course;

static class Program
{
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();
        var f = new Form1();
        var m = new SignalModel();
        var c = new SignalController(m, f);
        f.ShowDialog();
        //Application.Run(new Form1()); 
    }    
}