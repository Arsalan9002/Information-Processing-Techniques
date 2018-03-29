using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment5
{
    interface Interface
    {

        void Decimal_With_Single_Thread(int matrixSize);
        void Decimal_With_Ten_Thread(int matrixSize);
        void Decimal_With_TPL(int matrixSize);



        void Double_With_Single_Thread(int matrixSize);
        void Double_With_Ten_Thread(int matrixSize);
        void Double_With_TPL(int matrixSize);




        void Integer_With_single_Thread(int matrixSize);
        void Integer_With_Ten_Thread(int matrixSize);
        void Integer_With_TPL(int matrixSize);



    }
}
