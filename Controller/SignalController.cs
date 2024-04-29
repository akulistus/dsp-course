using dsp_course.Controller.Interfaces;
using dsp_course.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsp_course.Controller
{
    internal class SignalController: ISignalController
    {
        ISignalModel _model;
        IView _view;

        public SignalController(ISignalModel model, IView view)
        {
            _model = model;
            _view = view;
            view.SetController(this);
        }

        public void openFile(string filepath)
        {
            List<double> first = new List<double>();
            List<double> second = new List<double>();
            List<double> third = new List<double>();

            string[] lines = File.ReadAllLines(filepath);
            foreach (string line in lines)
            {
                string[] columns = line.Split((char[])null, StringSplitOptions.RemoveEmptyEntries); ;
                first.Add(double.Parse(columns[0]));
                second.Add(double.Parse(columns[1]));
                third.Add(double.Parse(columns[2]));
            }
            _model.updateRawSignalData(first, second, third);
            _displayGraphs();
        }

        private void _displayGraphs()
        {
            var (first, second, third) = _model.getRawSignals();
            _view.setGraphDataSource(first, second, third);
            _view.refreshGraphs();
        }
    }
}
