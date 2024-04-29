using dsp_course.Model.Interfaces;
using ScottPlot.TickGenerators.TimeUnits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsp_course.Model
{
    internal class SignalModel: ISignalModel
    {
        private string _filepath;
        private Dictionary<string, List<double>> _rawSignals = new Dictionary<string, List<double>>
        {
            ["first"] = new List<double>(),
            ["second"] = new List<double>(),
            ["third"] = new List<double>(),
        };

        public (double[], double[], double[]) getRawSignals()
        {
            return (_rawSignals["first"].ToArray(), _rawSignals["second"].ToArray(), _rawSignals["third"].ToArray());
        }

        private Dictionary<string, List<double>> _filteredSiganls = new Dictionary<string, List<double>>
        {
            ["first"] = new List<double>(),
            ["second"] = new List<double>(),
            ["third"] = new List<double>(),
        };

        public void updateRawSignalData(List<double> first, List<double> second, List<double> third)
        {
            _rawSignals["first"] = first;
            _rawSignals["second"] = second;
            _rawSignals["third"] = third;
        }
    }
}
