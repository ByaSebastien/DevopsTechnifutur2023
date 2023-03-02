using Logique;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devops.Exercices.Conditions
{
    public class IBAN : ICommand
    {
        public string Name => "IBAN";

        public void Execute()
        {
            //Belgique
            //string compte1 = "970000000097";
            //string compte2 = "000000014245";
            //string compte3 = "000000014246";

            //string countryCode = "1114";

            //string compte = compte1;
            //Console.WriteLine($"BBAN : {compte}");

            //long tenFirst = long.Parse(compte.Substring(0, 10));
            //int twoLast = int.Parse(compte.Substring(10, 2));

            //string tempIban = compte + countryCode + "00";

            //if (twoLast == ((tenFirst % 97 == 0) ? 97 : tenFirst % 97))
            //{
            //    int result = 98 - (int)(long.Parse(tempIban) % 97);
            //    string resultIban = ((result == 98) ? 1 : result).ToString("D2");
            //    string iban = "BE" + resultIban + compte;
            //    Console.WriteLine($"IBAN : {iban}");
            //}
            //else
            //{
            //    Console.WriteLine("BBAN invalide");
            //}

            //Version internationalle
            string values = "0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            string compte1 = "970000000097";
            string compte2 = "000000014245";
            string compte3 = "000000014246";

            Console.WriteLine("Code pays : ");
            string countryCode = Console.ReadLine().ToUpper();

            string compte = compte1;
            Console.WriteLine($"BBAN : {compte}");

            long tenFirst = long.Parse(compte.Substring(0, 10));
            int twoLast = int.Parse(compte.Substring(10, 2));

            string tempIban = compte + countryCode + "00";
            string temp = "";

            foreach (char c in tempIban)
            {
                temp += values.IndexOf(c).ToString();
            }

            tempIban = temp;

            if (twoLast == ((tenFirst % 97 == 0) ? 97 : tenFirst % 97))
            {
                int result = 98 - (int)(long.Parse(tempIban) % 97);
                string resultIban = ((result == 98) ? 1 : result).ToString("D2");
                string iban = countryCode + resultIban + compte;
                Console.WriteLine($"IBAN : {iban}");
            }
            else
            {
                Console.WriteLine("BBAN invalide");
            }
        }
    }
}
