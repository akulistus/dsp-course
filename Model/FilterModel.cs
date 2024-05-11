using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using dsp_course.Model.Interfaces;
using Python.Runtime;


namespace dsp_course.Model
{
    internal class FilterModel: IFilterModel
    {
        int _samplingRate;
        int q = 30;
        public FilterModel(int samplingRate)
        {
            _samplingRate = samplingRate;
            Runtime.PythonDLL = @"C:\Users\8cara\AppData\Local\Programs\Python\Python312\python312.dll";
            PythonEngine.Initialize();
        }

        public double[] applyNotching(List<double> initialSignal)
        {
            using (Py.GIL())
            {
                dynamic sp = Py.Import("scipy.signal");
                dynamic coeff = sp.iirnotch(50, q, _samplingRate);
                dynamic b = coeff[0];
                dynamic a = coeff[1];
                dynamic result = sp.lfilter(b, a, initialSignal);
                return result;
            }
        }

        public double[] applyLowPass(List<double> initialSignal)
        {
            using (Py.GIL())
            {
                dynamic sp = Py.Import("scipy.signal");
                dynamic coeff = sp.butter(10, 30, "low", fs:_samplingRate);
                dynamic b = coeff[0];
                dynamic a = coeff[1];
                dynamic result = sp.lfilter(b, a, initialSignal);
                return result;
            }
        }

        public double[] applyDetrend(List<double> initialSignal)
        {
            using (Py.GIL())
            {
                dynamic sp = Py.Import("scipy.signal");
                dynamic result = sp.detrend(initialSignal);
                return result;
            }
        }

        public double[] applyBandPass(List<double> initialSignal)
        {
            using (Py.GIL())
            {   double nyq = 0.5 * _samplingRate;
                double low = 4 / nyq;
                double high = 10 / nyq;
                dynamic sp = Py.Import("scipy.signal");
                dynamic coeff = sp.butter(5, new List<double> { low, high }, btype: "band");
                dynamic b = coeff[0];
                dynamic a = coeff[1];
                dynamic result = sp.lfilter(b, a, initialSignal);
                return result;
            }
        }
    }
}
