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
        //  public CalculiatorTOKA() { }
        public String CalculiatorT(String strWat, String strVolt, String strCosф, String kpd)
        {
            double valWAT, valCosф, valKPD, valTOK, valVOLT;
            String strTok = "";
            if (strWat != string.Empty && strCosф != string.Empty && kpd != string.Empty && strVolt != string.Empty)//если все поля заполнены 
            {
                valWAT  =  ConvertorNoSimvol(strWat);
                valCosф =  ConvertorNoSimvol(strCosф);
                valKPD  =  ConvertorNoSimvol(kpd);
                valVOLT =  ConvertorNoSimvol(strVolt);
                //  Iном = P /√3Ucosφη=   P /1.73Ucosφη=   //формула
                valTOK = (valWAT * 100000) / (1.73 * valVOLT * valCosф * valKPD);// считаем
                valTOK = Math.Ceiling(valTOK);// округляем
                strTok = Convert.ToString(valTOK);
            }
            return strTok;
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
