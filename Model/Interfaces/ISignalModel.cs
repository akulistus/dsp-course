using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsp_course.Model.Interfaces
{
    internal interface ISignalModel
    {
        (double[], double[], double[]) getTetaSignals();
        (double[], double[], double[]) getRawSignals();
        (double[], double[], double[]) get50HzSignals();
        (double[], double[], double[]) get50HzLowSignals();
        (double[], double[], double[]) get50HzLowTrdSignals();
        (Dictionary<string, List<double>>, Dictionary<string, List<double>>) getStatistics();
        void updateTetaData(List<double> first, List<double> second, List<double> third);
        void updateRawSignalData(List<double> first, List<double> second, List<double> third);
        void update50HzSignalData(List<double> first, List<double> second, List<double> third);
        void update50HzLowSignalData(List<double> first, List<double> second, List<double> third);
        void update50HzLowTrdSignalData(List<double> first, List<double> second, List<double> third);
    }
}
