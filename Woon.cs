using System;
namespace Avtomat
{
    public class Woon
    {

        public int Weapon;

        public void Menu()
        {
            string command = "";
            do
            {
                Console.WriteLine(" 1-AutoFill 2-EvenToFill 3-AutoShoot 4-EvenToShoot Exit-e ");
                Console.Write("Seçiminiz:");
                command = Console.ReadLine();

                switch (command)
                {
                    case "1":
                        AutoFill(30);
                        break;
                    case "2":
                        EvenToFill(17,2);
                        break;
                    case "3":
                        AutoShoot(20,9);
                        break;
                    case "4":
                        EvenToShoot(5,19);
                        break;

                    default:
                        Console.WriteLine("Yanlis sechim");
                        break;
                }
            } while (command != "e");
        }
            public void AutoFill(int BulletCount)
            {
                int Weapon = 30;
                if (BulletCount == Weapon)
                {
                    Console.WriteLine("Changed the store of the bullet");
                }
            }

            public void EvenToFill(int BulletCount, int InsideBullet)
            {
                int SumGum = InsideBullet + BulletCount;
                if ((InsideBullet + BulletCount) <= 30)
                {
                    Console.WriteLine($"Avtomatda {InsideBullet} var idi ve {BulletCount} güllə daxil etdikdən sonra:yeni gullə sayı {SumGum}");
                }
                else
                {
                    Console.WriteLine("Don't enter more than 30 bullets");
                }
            }

            public void AutoShoot(int InsideBullet, int BulletCount)
            {
                int SumGum = InsideBullet + BulletCount;
                if (SumGum > 30)
                {
                    Console.WriteLine("Don't enter more than 30 bullets");
                }
                else
                {
                    Console.WriteLine($"Avtomatda {InsideBullet} var idi ve {BulletCount} güllə daxil etdikdən sonra:{SumGum} gulle atildi");
                }

            }

            public int EvenToShoot(int BulletCount, int InsideBullet)
            {
                int SumGum = InsideBullet + BulletCount;

                if (SumGum <= 30)
                {
                    int Weapon = 30;
                    for (int i = SumGum; i >= 0; i--)
                    {
                        Weapon--;
                    }

                }
                Console.WriteLine($"{SumGum} güllə tək-tək atıldı");
                return Weapon;
            }

        
    }
}
