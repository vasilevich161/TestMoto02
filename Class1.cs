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

            for (byte i = 0; i < 4; i++)
            {
                if (arrayStr[i] == string.Empty)
                {
                    test = false; break;//если пусто 
                }
                else
                {
                    arrayVal[i] = ConvertorNoSimvol(arrayStr[i]);
                    if (arrayVal[i] == 0)
                    {
                        test = false; break;//если в данные равны 0, то выходим.
                    }
                }
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
          
        double ConvertorNoSimvol(string str1)
        {
            string str = str1;
            string str2 = "";
            foreach (char ch in str.ToCharArray())
            {
                if ((Char.IsNumber(ch)) || (Char.IsPunctuation(ch)))
                {
                    if (ch == '.') str2 += ','; // пропускаем точку при вводе ватт 
                    else str2 += ch.ToString();
                }
            }
            if (String.IsNullOrEmpty(str2) || str2==",") str2 = "0"; // если небыло цифр
                                                        
            return Convert.ToDouble(str2);
        }
    }
}
