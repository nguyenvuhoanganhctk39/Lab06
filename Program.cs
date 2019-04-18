using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_7
{
    class Program
    {
        class PhanSo
        {
            int Tu, Mau;
            public PhanSo(int TuSo, int Mauso)
            {
                Tu = TuSo;
                Mau = Mauso;
            }
            public PhanSo(int HoleNumber)
            {
                Tu = HoleNumber;
                Mau = 1;
            }
            public PhanSo()
            {
                Tu = 0;
                Mau = 1;

            }
            public static bool operator == (PhanSo PS1, PhanSo PS2)
            {
                return (PS1.Tu * PS2.Mau == PS2.Tu * PS1.Mau);
            }
            public static bool operator !=(PhanSo PS1, PhanSo PS2)
            {
                return!  (PS1 == PS2);
            }
            public override bool Equals(object o)
            {
                Console.WriteLine("Phuong thuc Equals");
                if (!(o is PhanSo)) return false;
                return this == (PhanSo)o;
            }
            public static PhanSo operator + (PhanSo PS1 , PhanSo PS2)
            {
                int MauMoi = PS1.Mau + PS2.Mau;
                int TuMoi = PS2.Mau + PS1.Tu + PS1.Mau * PS2.Tu;
                return new PhanSo(TuMoi, MauMoi);
            }
            public static PhanSo operator ++ (PhanSo PS)
            {
                PS.Tu = PS.Mau + PS.Tu;
                return PS;
            }
            public override string ToString()
            {
                String s = Tu.ToString() + "/" + Mau.ToString();
                return s;
            }


        }
        class PhanSoApp
        {
            static void Main()
            {
                PhanSo f1 = new PhanSo(3, 4);
                Console.WriteLine("f1 : {0}", f1.ToString());
                PhanSo f2 = new PhanSo(2, 4);
                Console.WriteLine("f2 : {0}", f2.ToString());
                PhanSo f3 = f1 + f2; 
                Console.WriteLine("f1  + f2  = f3 : {0}", f3.ToString());
                PhanSo f4 = f3 + f1;
                Console.WriteLine("f3 + 5 = f4 : {0}", f4.ToString());
                PhanSo f5 = new PhanSo(4, 8);
                if (f5 == f2)
                {
                    Console.WriteLine("f5 :{0} == f2 : {1}", f5.ToString(), f2.ToString());

                }
                Console.ReadLine();
                
            }
        }
    }
}
    

        
			
			