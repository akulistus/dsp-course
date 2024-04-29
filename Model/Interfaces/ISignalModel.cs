using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsp_course.Model.Interfaces
{
    internal interface ISignalModel
    {
        (double[], double[], double[]) getRawSignals();
        void updateRawSignalData(List<double> first, List<double> second, List<double> third);
    }
}
