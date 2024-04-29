using dsp_course.Controller.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsp_course
{
    internal interface IView
    {
        void refreshGraphs();
        void SetController(ISignalController controller);
        void setGraphDataSource(double[] first, double[] second, double[] third);
    }
}
