// See https://aka.ms/new-console-template for more information
using System;
namespace BTLAB8_2
{
    class Program
    {
        public static void Main()
        {
            string chuoi;
            int n = 0;
            
           
            Console.Write("Nhap mot chuoi: ");
            chuoi = Console.ReadLine();

            //KIEM TRA SO KY TU TRONG CHUOI
            foreach (char chr in chuoi)
            {
                n += 1;

            }
            //KIEM TRA NGUYEN AM PHU AM
            int i, len, nguyen_am, phu_am;
            nguyen_am = 0;
            phu_am = 0;
            len =chuoi.Length;

            for (i = 0; i < len; i++)
            {

                if (chuoi[i] == 'a' || chuoi[i] == 'e' || chuoi[i] == 'i' || chuoi[i] == 'o' ||
                    chuoi[i] == 'u' || chuoi[i] == 'A' ||chuoi[i] == 'E' || chuoi[i] == 'I' ||
                    chuoi[i] == 'O' || chuoi[i] == 'U')
                {
                    nguyen_am++;
                }
                else if ((chuoi[i] >= 'a' && chuoi[i] <= 'z') || (chuoi[i] >= 'A' && chuoi[i] <= 'Z'))
                {
                    phu_am++;
                }
            }
            //KIEM TRA SO TU TRONG CHUOI 
            int dem, l;
            l = 0;
            dem = 1;
            while (l <= chuoi.Length - 1)
            {

                if (chuoi[l] == ' ' || chuoi[l] == '\n' || chuoi[l] == '\t')
                {
                    dem++;
                }

                l++;
            }
            Console.Write("SO KY TU TRONG CHUOI LA: {0}\n", n);
            Console.Write("So nguyen am co trong chuoi la: {0}\n",nguyen_am);
            Console.Write("So phu am co trong chuoi la: {0}\n", phu_am);
            Console.WriteLine("So tu co trong chuoi la :{0}\n", dem);


        }
    }
}
     