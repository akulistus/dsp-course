using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dsp_course.Controller.Interfaces
{
    public interface ISignalController
    {
        void openFile(string filepath);
        void saveFile(string path, string glyph);
        void displayRaw();
        void displayTeta();
        void display50hz();
        void display50hzLow();
        void display50HzLowTrd();
    }
}
