using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica_ASE_Basics
{
    public interface ICar1
    {
        //interfetele contin doar semnaturi de metode
        void Run();
        int GetNoOfSeats(string model);
    }
}
