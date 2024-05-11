using dsp_course.Controller.Interfaces;
using dsp_course.Model;
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
        IFilterModel _filterModel;
        IView _view;

        public SignalController(ISignalModel model, IFilterModel filterModel, IView view)
        {
            _model = model;
            _view = view;
            _filterModel = filterModel;
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
            _model.updateTetaData(
                _filterModel.applyBandPass(first).ToList(),
                _filterModel.applyBandPass(second).ToList(),
                _filterModel.applyBandPass(third).ToList());

            _model.updateRawSignalData(first, second, third);
            first = _filterModel.applyNotching(first).ToList();
            second = _filterModel.applyNotching(second).ToList();
            third = _filterModel.applyNotching(third).ToList();
            _model.update50HzSignalData(first, second, third);

            first = _filterModel.applyLowPass(first).ToList();
            second = _filterModel.applyLowPass(second).ToList();
            third = _filterModel.applyLowPass(third).ToList();
            _model.update50HzLowSignalData(first, second, third);

            first = _filterModel.applyDetrend(first).ToList();
            second = _filterModel.applyDetrend(second).ToList();
            third = _filterModel.applyDetrend(third).ToList();
            _model.update50HzLowTrdSignalData(first, second, third);
            _displayGraphs(_model.getRawSignals);

            var (stat1, stat2) = _model.getStatistics();

            _view.updateTable(stat1, stat2);
        }

        public void displayRaw()
        {
            _displayGraphs(_model.getRawSignals);
        }

        public void display50hz()
        {
            _displayGraphs(_model.get50HzSignals);
        }

        public void display50hzLow()
        {
            _displayGraphs(_model.get50HzLowSignals);
        }

        public void display50HzLowTrd()
        {
            _displayGraphs(_model.get50HzLowTrdSignals);
        }

        public void displayTeta()
        {
            _displayGraphs(_model.getTetaSignals);
        }

        private void _displayGraphs(Func<(double[], double[], double[])> func)
        {
            var (first, second, third) = func();
            _view.setGraphDataSource(first, second, third);
            _view.refreshGraphs();
        }
    }
}
