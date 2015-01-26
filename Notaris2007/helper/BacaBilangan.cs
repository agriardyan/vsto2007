using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Notaris2007.helper
{
    class BacaBilangan
    {

        public BacaBilangan()
        {
            //empty constructor
        }

        public static String changeNumericToMonth(String numb)
        {
            String result = "";
            switch (numb)
            {
                case "01":
                    result = "Januari ";
                    break;
                case "02":
                    result = "Februari ";
                    break;
                case "03":
                    result = "Maret ";
                    break;
                case "04":
                    result = "April ";
                    break;
                case "05":
                    result = "Mei ";
                    break;
                case "06":
                    result = "Juni ";
                    break;
                case "07":
                    result = "Juli ";
                    break;
                case "08":
                    result = "Agustus ";
                    break;
                case "09":
                    result = "September ";
                    break;
                case "10":
                    result = "Oktober ";
                    break;
                case "11":
                    result = "November ";
                    break;
                case "12":
                    result = "Desember ";
                    break;
                default :
                    break;
            }
            return result;
        }

        public static String changeNumericToWords(double numb)
        {
            String num = numb.ToString();
            String result = changeToWords(num, false);
            result = result.Replace("satu ratus", "seratus");
            if (num.Length <= 4)
            {
                result = result.Replace("satu ribu", "seribu");
            }
            return result;
        }

        public static String changeNumericToWords(String numb)
        {
            String result = changeToWords(numb, false);
            result = result.Replace("satu ratus", "seratus");
            if (numb.Length <= 4)
            {
                result = result.Replace("satu ribu", "seribu");
            }
            return result;
        }

        public static String changeCurrencyToWords(String numb)
        {
            String result = changeToWords(numb, true);
            result = result.Replace("satu ratus", "seratus");
            result = result.Replace("satu ribu", "seribu");
            return result;
        }

        public static String changeCurrencyToWords(double numb)
        {
            String result = changeToWords(numb.ToString(), true);
            result = result.Replace("satu ratus", "seratus");
            result = result.Replace("satu ribu", "seribu");
            return result;
        }

        private static String changeToWords(String numb, bool isCurrency)
        {
            String val = "";
            String wholeNo = numb;
            String points = "";
            String andStr = "";
            String pointStr = "";
            String endStr = (isCurrency) ? ("Rupiah") : ("");
            try
            {
                int decimalPlace = numb.IndexOf(".");
                if (decimalPlace > 0)
                {
                    wholeNo = numb.Substring(0, decimalPlace);
                    points = numb.Substring(decimalPlace + 1);
                    if (Convert.ToInt64(points) > 0)
                    {
                        andStr = (isCurrency) ? ("and") : ("point");// just to separate whole numbers from > points/cents
                        endStr = (isCurrency) ? ("Cents " + endStr) : ("");
                        pointStr = translateCents(points);
                    }
                }
                val = String.Format("{0} {1}{2} {3}", translateWholeNumber(wholeNo).Trim(), andStr, pointStr, endStr);
            }
            catch
            {
                ;
            }
            return val;
        }

        private static String translateWholeNumber(String number)
        {
            string word = "";
            try
            {
                bool beginsZero = false;    //tests for 0XX
                bool isDone = false;        //test if already translated
                double dblAmt = (Convert.ToDouble(number));

                //if ((dblAmt > 0) && number.StartsWith("0"))
                if (dblAmt > 0)
                {//test for zero or digit zero in a nuemric
                    beginsZero = number.StartsWith("0");

                    int numDigits = number.Length;
                    int pos = 0;//store digit grouping
                    String place = "";//digit grouping name:hundres,thousand,etc...
                    switch (numDigits)
                    {
                        case 1://ones' range
                            word = ones(number);
                            isDone = true;
                            break;
                        case 2://tens' range
                            word = tens(number);
                            isDone = true;
                            break;
                        case 3://hundreds' range
                            pos = (numDigits % 3) + 1;
                            if (beginsZero)
                            {
                                place = " ";
                            }
                            else
                            {
                                place = " ratus ";
                            }
                            break;
                        case 4://thousands' range
                        case 5:
                        case 6:
                            pos = (numDigits % 4) + 1;
                            if (beginsZero)
                            {
                                place = " ";
                            }
                            else
                            {
                                place = " ribu ";
                            }
                            break;
                        case 7://millions' range
                        case 8:
                        case 9:
                            pos = (numDigits % 7) + 1;
                            place = " juta ";
                            break;
                        case 10://Billions's range
                            pos = (numDigits % 10) + 1;
                            place = " miliar ";
                            break;
                        case 11:
                        case 12:
                        case 13://Billions's range
                            pos = (numDigits % 13) + 1;
                            place = " triliun ";
                            break;
                        //tambah case extra untuk diatas triliun ... (nearly impossible kayaknya)
                        default:
                            isDone = true;
                            break;
                    }
                    if (!isDone)
                    {//if transalation is not done, continue...(Recursion comes in now!!)
                        word = translateWholeNumber(number.Substring(0, pos)) + place + translateWholeNumber(number.Substring(pos));
                        //check for trailing zeros
                        if (beginsZero) word = " " + word.Trim();
                    }
                    //ignore digit grouping names
                    if (word.Trim().Equals(place.Trim())) word = "";
                }
            }
            catch { ;}
            return word.Trim();
        }

        private static String tens(String digit)
        {
            long digt = Convert.ToInt64(digit);
            String name = null;
            switch (digt)
            {
                case 10:
                    name = "sepuluh ";
                    break;
                case 11:
                    name = "sebelas ";
                    break;
                case 12:
                    name = "duabelas ";
                    break;
                case 13:
                    name = "tigabelas ";
                    break;
                case 14:
                    name = "empatbelas ";
                    break;
                case 15:
                    name = "limabelas ";
                    break;
                case 16:
                    name = "enambelas ";
                    break;
                case 17:
                    name = "tujuhbelas ";
                    break;
                case 18:
                    name = "delapanbelas ";
                    break;
                case 19:
                    name = "sembilanbelas ";
                    break;
                case 20:
                    name = "duapuluh ";
                    break;
                case 30:
                    name = "tigapuluh ";
                    break;
                case 40:
                    name = "empatpuluh ";
                    break;
                case 50:
                    name = "limapuluh ";
                    break;
                case 60:
                    name = "enampuluh ";
                    break;
                case 70:
                    name = "tujuhpuluh ";
                    break;
                case 80:
                    name = "delapanpuluh ";
                    break;
                case 90:
                    name = "sembilanpuluh ";
                    break;
                case 100:
                    name = "seratus ";
                    break;
                case 1000:
                    name = "seribu ";
                    break;
                default:
                    if (digt > 0)
                    {
                        name = tens(digit.Substring(0, 1) + "0") + "" + ones(digit.Substring(1));
                    }
                    break;
            }
            return name;
        }

        private static String ones(String digit)
        {
            long digt = Convert.ToInt64(digit);
            String name = "";
            switch (digt)
            {
                case 1:
                    name = "satu ";
                    break;
                case 2:
                    name = "dua ";
                    break;
                case 3:
                    name = "tiga ";
                    break;
                case 4:
                    name = "empat ";
                    break;
                case 5:
                    name = "lima ";
                    break;
                case 6:
                    name = "enam ";
                    break;
                case 7:
                    name = "tujuh ";
                    break;
                case 8:
                    name = "delapan ";
                    break;
                case 9:
                    name = "sembilan ";
                    break;
            }
            return name;
        }

        private static String translateCents(String cents)
        {
            String cts = "", digit = "", engOne = "";
            for (int i = 0; i < cents.Length; i++)
            {
                digit = cents[i].ToString();
                if (digit.Equals("0"))
                {
                    engOne = "nol ";
                }
                else
                {
                    engOne = ones(digit);
                }
                cts += " " + engOne;
            }
            return cts;
        }

    }
}
