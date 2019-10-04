using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;


namespace TestMoto02
{

    class CalculiatorTOKA
    {
        public String CalculiatorT(String strWat, String strVolt, String strCosф, String Strkpd)
        {
            bool test = true; String strTok = "";
            String[] arrayStr = { strWat, strVolt, strCosф, Strkpd };
            double[] arrayVal = new double[4];
            try
            {
                for (byte i = 0; i < 4; i++)
                {
                    arrayVal[i] = Convert.ToDouble(arrayStr[i]);
                    if (arrayVal[i] == 0)
                    {
                        test = false; break;//если в данные равны 0, то выходим.
                    }
                }
            }
            catch (Exception) 
            { 
                test = false; 
            }
            
            if (test)
            {//  Iном = P /√3Ucosφη=   P /1.73Ucosφη=   //формула
                double valTOK = Math.Ceiling((arrayVal[0] * 100000) / (arrayVal[1] * arrayVal[2] * arrayVal[3]));
                strTok = Convert.ToString(valTOK);
                return strTok;
            }
            else
            {
                return "Некорректные данные";
            }
        }
    }
}
