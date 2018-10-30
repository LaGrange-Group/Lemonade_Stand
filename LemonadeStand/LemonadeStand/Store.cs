using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        private Player player;
        public Store(Player player)
        {
            this.player = player;
        }
        public void EnterStore()
        {
            Console.Clear();
            Console.WriteLine("Welcome to the store!");
            StoreCatalog(0);
        }
        private void StoreCatalog(int iter)
        { 
            if (iter != 0)
            {
                Console.Clear();
            }
            Console.WriteLine("\nTo view price and amounts of an item enter their relative number index. \n(1) Lemons \n(2) Sugar \n(3) Ice \n(4) Cups\n(5) Finished with the store!");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    Lemons();
                    break;
                case 2:
                    Ice();
                    break;
                case 3:
                    Cups();
                    break;
                case 4:
                    Sugar();
                    break;
                case 5:
                    return;
                default:
                    Console.WriteLine("You have entered an invalid input. Please try again.");
                    StoreCatalog(1);
                    return;
            }
        }
        private void Lemons()
        {
            Console.Clear();
            Console.WriteLine("\n--Lemons--\n(1) 8 Lemons Cost: $ 8.00\n(2) 16 Lemons Cost: $ 15.00\n(3) 32 Lemons Cost: $29\n(4) Go Back ");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    if (player.wallet.CheckIfEnoughMoney(8) == true)
                    {
                        player.wallet.DecrementMoney(8);
                        player.lemons.IncramentInventory(8);
                    }
                    break;
                case 2:
                    if (player.wallet.CheckIfEnoughMoney(15) == true)
                    {
                        player.wallet.DecrementMoney(15);
                        player.lemons.IncramentInventory(16);
                    }
                    break;
                case 3:
                    if (player.wallet.CheckIfEnoughMoney(29) == true)
                    {
                        player.wallet.DecrementMoney(29);
                        player.lemons.IncramentInventory(32);
                    }
                    break;
                case 4:
                    StoreCatalog(1);
                    return;
                default:
                    Console.WriteLine("You have entered an invalid input. Please try again.");
                    Lemons();
                    return;
            }
        }
        private void Ice()
        {
            Console.Clear();
            Console.WriteLine("\n--Ice--\n(1) 50 Pieces of Ice Cost: $ 3.00\n(2) 100 Pieces of Ice Cost: $ 6.00\n(3) 200 Pieces of Ice Cost: $10\n(4) Go Back");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    if (player.wallet.CheckIfEnoughMoney(3) == true)
                    {
                        player.wallet.DecrementMoney(3);
                        player.ice.IncramentInventory(50);
                    }
                    break;
                case 2:
                    if (player.wallet.CheckIfEnoughMoney(6) == true)
                    {
                        player.wallet.DecrementMoney(6);
                        player.ice.IncramentInventory(100);
                    }
                    break;
                case 3:
                    if (player.wallet.CheckIfEnoughMoney(10) == true)
                    {
                        player.wallet.DecrementMoney(10);
                        player.ice.IncramentInventory(200);
                    }
                    break;
                case 4:
                    StoreCatalog(1);
                    return;
                default:
                    Console.WriteLine("You have entered an invalid input. Please try again.");
                    Ice();
                    return;
            }
        }
        private void Cups()
        {
            Console.Clear();
            Console.WriteLine("\n--Cups--\n(1) 20 Cups Cost: $ 3.00\n(2) 40 Cups Cost: $ 5.00\n(3) 100 Cups Cost: $10\n(4) Go Back");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    if (player.wallet.CheckIfEnoughMoney(3) == true)
                    {
                        player.wallet.DecrementMoney(3);
                        player.cups.IncramentInventory(20);
                    }
                    break;
                case 2:
                    if (player.wallet.CheckIfEnoughMoney(5) == true)
                    {
                        player.wallet.DecrementMoney(5);
                        player.cups.IncramentInventory(40);
                    }
                    break;
                case 3:
                    if (player.wallet.CheckIfEnoughMoney(10) == true)
                    {
                        player.wallet.DecrementMoney(10);
                        player.cups.IncramentInventory(100);
                    }
                    break;
                case 4:
                    StoreCatalog(1);
                    return;
                default:
                    Console.WriteLine("You have entered an invalid input. Please try again.");
                    Cups();
                    return;
            }
        }
        private void Sugar()
        {
            Console.Clear();
            Console.WriteLine("\n--Sugar--\n(1) 4 Cups of Sugar Cost: $ 8.00\n(2) 16 Cups of Sugar Cost: $ 23.00\n(3) 32 Cups of Sugar Cost: $43\n(4) Go Back");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    if (player.wallet.CheckIfEnoughMoney(8) == true)
                    {
                        player.wallet.DecrementMoney(8);
                        player.sugar.IncramentInventory(4);
                    }
                    break;
                case 2:
                    if (player.wallet.CheckIfEnoughMoney(23) == true)
                    {
                        player.wallet.DecrementMoney(23);
                        player.sugar.IncramentInventory(16);
                    }
                    break;
                case 3:
                    if (player.wallet.CheckIfEnoughMoney(43) == true)
                    {
                        player.wallet.DecrementMoney(43);
                        player.sugar.IncramentInventory(32);
                    }
                    break;
                case 4:
                    StoreCatalog(1);
                    return;
                default:
                    Console.WriteLine("You have entered an invalid input. Please try again.");
                    Sugar();
                    return;
            }
        }
    }
}
