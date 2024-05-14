using dsp_course.Model.Interfaces;
using ScottPlot.TickGenerators.TimeUnits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace dsp_course.Model
{
    internal class SignalModel : ISignalModel
    {
        public string _filename { get; set; }

        private Dictionary<string, List<double>> _filterStatistics = new Dictionary<string, List<double>>()
        {
            ["MD"] = new List<double>(),
            ["MaxD"] = new List<double>(),
            ["SD"] = new List<double>(),
            ["Var"] = new List<double>(),
        };

        private Dictionary<string, List<double>> _tetaStatistics = new Dictionary<string, List<double>>()
        {
            ["MD"] = new List<double>(),
            ["MaxD"] = new List<double>(),
            ["SD"] = new List<double>(),
            ["Var"] = new List<double>(),
        };

        private Dictionary<string, List<double>> _rawSignals = new Dictionary<string, List<double>>
        {
            ["first"] = new List<double>(),
            ["second"] = new List<double>(),
            ["third"] = new List<double>(),
        };

        private Dictionary<string, List<double>> _50HzSiganls = new Dictionary<string, List<double>>
        {
            ["first"] = new List<double>(),
            ["second"] = new List<double>(),
            ["third"] = new List<double>(),
        };

        private Dictionary<string, List<double>> _50HzLowSiganls = new Dictionary<string, List<double>>
        {
            ["first"] = new List<double>(),
            ["second"] = new List<double>(),
            ["third"] = new List<double>(),
        };

        private Dictionary<string, List<double>> _50HzLowTrdSiganls = new Dictionary<string, List<double>>
        {
            ["first"] = new List<double>(),
            ["second"] = new List<double>(),
            ["third"] = new List<double>(),
        };

        private Dictionary<string, List<double>> _TetaSiganls = new Dictionary<string, List<double>>
        {
            ["first"] = new List<double>(),
            ["second"] = new List<double>(),
            ["third"] = new List<double>(),
        };

        public (double[], double[], double[]) getRawSignals()
        {
            return (_rawSignals["first"].ToArray(), _rawSignals["second"].ToArray(), _rawSignals["third"].ToArray());
        }

        public (double[], double[], double[]) get50HzSignals()
        {
            return (_50HzSiganls["first"].ToArray(), _50HzSiganls["second"].ToArray(), _50HzSiganls["third"].ToArray());
        }

        public (double[], double[], double[]) get50HzLowSignals()
        {
            return (_50HzLowSiganls["first"].ToArray(), _50HzLowSiganls["second"].ToArray(), _50HzLowSiganls["third"].ToArray());
        }

        public (double[], double[], double[]) get50HzLowTrdSignals()
        {
            return (_50HzLowTrdSiganls["first"].ToArray(), _50HzLowTrdSiganls["second"].ToArray(), _50HzLowTrdSiganls["third"].ToArray());
        }

        public (double[], double[], double[]) getTetaSignals()
        {
            return (_TetaSiganls["first"].ToArray(), _TetaSiganls["second"].ToArray(), _TetaSiganls["third"].ToArray());
        }

        public void updateRawSignalData(List<double> first, List<double> second, List<double> third)
        {
            _rawSignals["first"] = first;
            _rawSignals["second"] = second;
            _rawSignals["third"] = third;
        }

        public void update50HzSignalData(List<double> first, List<double> second, List<double> third)
        {
            _50HzSiganls["first"] = first;
            _50HzSiganls["second"] = second;
            _50HzSiganls["third"] = third;
        }

        public void update50HzLowSignalData(List<double> first, List<double> second, List<double> third)
        {
            _50HzLowSiganls["first"] = first;
            _50HzLowSiganls["second"] = second;
            _50HzLowSiganls["third"] = third;
        }

        public void update50HzLowTrdSignalData(List<double> first, List<double> second, List<double> third)
        {
            _50HzLowTrdSiganls["first"] = first;
            _50HzLowTrdSiganls["second"] = second;
            _50HzLowTrdSiganls["third"] = third;
            updateStatistics(_50HzLowTrdSiganls, _filterStatistics);
        }

        public void updateTetaData(List<double> first, List<double> second, List<double> third)
        {
            _TetaSiganls["first"] = first;
            _TetaSiganls["second"] = second;
            _TetaSiganls["third"] = third;
            updateStatistics(_TetaSiganls, _tetaStatistics);
        }

        private void updateStatistics(Dictionary<string, List<double>> signals, Dictionary<string, List<double>> stats)
        {
            foreach( var item in signals)
            {
                double mean = item.Value.Average();
                double MD = item.Value.Select(x => Math.Abs(x - mean)).Average();
                stats["MD"].Add(MD);

                double MaxD = item.Value.Max(x => Math.Abs(x - mean));
                stats["MaxD"].Add(MaxD);

                double sumOfSquares = item.Value.Sum(x => Math.Pow(x - mean, 2));
                double variance = sumOfSquares / item.Value.Count;
                stats["Var"].Add(variance);

                double standardDeviation = Math.Sqrt(variance);
                stats["SD"].Add(standardDeviation);
            }
        }

        public (Dictionary<string, List<double>>, Dictionary<string, List<double>>) getStatistics()
        {
            return (_filterStatistics, _tetaStatistics);
        }

    }
}
