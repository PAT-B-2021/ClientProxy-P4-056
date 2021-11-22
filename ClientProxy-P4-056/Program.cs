using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ClientProxy_P4_043
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ClientProxy_P4_056.ServiceReference1.MatematikaClient obj = new ClientProxy_P4_056.ServiceReference1.MatematikaClient();
                double hasilTambah = obj.Tambah(1, 2);
                Console.WriteLine("1 + 2 = " + hasilTambah);
                double hasilKurang = obj.Kurang(3, 2);
                Console.WriteLine("3 - 2 = " + hasilKurang);
                double hasilKali = obj.Kali(2, 2);
                Console.WriteLine("2 x 2 = " + hasilKali);
                double hasilBagi = obj.Bagi(2, 0);
                Console.WriteLine("2 / 0 = " + hasilBagi);

                ClientProxy_P4_056.ServiceReference1.Koordinat a = new ClientProxy_P4_056.ServiceReference1.Koordinat();
                ClientProxy_P4_056.ServiceReference1.Koordinat b = new ClientProxy_P4_056.ServiceReference1.Koordinat();

                a.X = 7;
                a.Y = 8;
                b.X = 5;
                b.Y = 6;

                double selisihX = a.X - b.X;
                double selisihY = a.Y - b.Y;

                double jarak = Math.Sqrt(Math.Pow(selisihX, 2) + Math.Pow(selisihY, 2));
                Console.WriteLine("Hasil Koordinat " + jarak);

            }
            catch (FaultException<ClientProxy_P4_056.ServiceReference1.MathFault> mf)
            {
                Console.WriteLine(mf.Detail.Kode);
                Console.WriteLine(mf.Detail.Pesan);
            }
            Console.ReadLine();
        }
    }
}