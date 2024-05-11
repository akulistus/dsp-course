using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsp_course.Model.Interfaces
{
    internal interface IFilterModel
    {
        double[] applyNotching(List<double> initialSignal);
        double[] applyLowPass(List<double> initialSignal);
        double[] applyDetrend(List<double> initialSignal);
        double[] applyBandPass(List<double> initialSignal);
    }
}
