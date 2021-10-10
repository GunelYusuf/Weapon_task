using System;

namespace Avtomat
{
    
    class Program
    {
        static void Main(string[] args)
        {

            Woon kalashnik = new Woon();
            
            kalashnik.Menu();
            kalashnik.AutoFill(30);
            //kalashnik.EvenToFill(9, 19);
            //kalashnik.AutoShoot(5,7);
            //kalashnik.EvenToShoot(8,11);
        }

        
        
    }
}
