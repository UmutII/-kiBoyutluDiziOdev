using System;

namespace İkiBoyutluDiziOdev
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Kaç Öğrenci Kayıt Etmek İstiyorsunuz?: ");
            byte mevcut = byte.Parse(Console.ReadLine());

            string[,] ogrenciler = new string[mevcut + 1, 6];
            ogrenciler[0, 0] = "Ad";
            ogrenciler[0, 1] = "Soyad";
            ogrenciler[0, 2] = "Vize";
            ogrenciler[0, 3] = "Final";
            ogrenciler[0, 4] = "Ort";
            ogrenciler[0, 5] = "Harf Notu";


            for (int i = 1; i < ogrenciler.GetLength(0); i++)
            {
                double ort = 0;
                int vize = 0;
                int final = 0;
                for (int j = 0; j < ogrenciler.GetLength(1); j++)
                {
                    switch (j)
                    {
                        case 0:
                            Console.Write("Ad Giriniz: ");
                            ogrenciler[i, j] = Console.ReadLine();

                            break;
                        case 1:
                            Console.Write("Soyad Giriniz: ");
                            ogrenciler[i, j] = Console.ReadLine();

                            break;
                        case 2:
                            Console.Write("Vize Sonucunu Giriniz: ");
                            vize = int.Parse(Console.ReadLine());
                            ogrenciler[i, j] = Convert.ToString(vize);
                            break;
                        case 3:
                            Console.Write("Final Sonucunu Giriniz: ");
                            final = int.Parse(Console.ReadLine());
                            ogrenciler[i, j] = Convert.ToString(final);
                            break;
                        case 4:
                            ort = (vize * 0.4 + final * 0.6);
                            ogrenciler[i, j] = Convert.ToString(ort);
                            break;
                        case 5:
                            string harf = "";
                            double ortharfnot;
                            ortharfnot = (ort * 4) / 100;
                            if (ortharfnot >= 3.5 && ortharfnot <= 4.0)
                            {
                                harf = "AA";
                            }
                            else if (ortharfnot >= 3.0 && ortharfnot < 3.5)
                            {
                                harf = "BA";
                            }
                            else if (ortharfnot >= 2.5 && ortharfnot < 3.0)
                            {
                                harf = "BB";
                            }
                            else if (ortharfnot >= 2.0 && ortharfnot < 2.5)
                            {
                                harf = "CB";
                            }
                            else if (ortharfnot >= 1.5 && ortharfnot < 2.0)
                            {
                                harf = "CC";
                            }
                            else if (ortharfnot >= 1.0 && ortharfnot < 1.5)
                            {
                                harf = "DC";
                            }
                            else if (ortharfnot >= 0.5 && ortharfnot < 1.0)
                            {
                                harf = "DD";
                            }
                            else if (ortharfnot > 0.0 && ortharfnot < 0.5)
                            {
                                harf = "FD";
                            }
                            else if (ortharfnot >= 0.0 && ortharfnot <= 0.0)
                            {
                                harf = "FF";
                            }
                            ogrenciler[i, j] = harf;
                            break;

                        default:
                            break;
                    }
                }
                Console.Clear();

            }

            for (int i = 0; i < ogrenciler.GetLength(0); i++)
            {
                for (int j = 0; j < ogrenciler.GetLength(1); j++)
                {
                    Console.Write(ogrenciler[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
