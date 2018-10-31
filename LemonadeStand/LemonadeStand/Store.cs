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
        private Game game;
        public Store(Player player)
        {
            this.player = player;
        }
        public void EnterStore(Game game)
        {
            this.game = game;
            StoreCatalog(0);
        }
        private void StoreCatalog(int iter)
        {
            Console.Clear();
            UI.DisplayStoreInfo("welcome");
            UI.DisplayInventory(player);
            UI.DisplayStoreInfo("storeitems");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    Lemons();
                    break;
                case 2:
                    Sugar();
                    break;
                case 3:
                    Ice();
                    break;
                case 4:
                    Cups();
                    break;
                case 5:
                    game.ShowMenu();
                    return;
                default:
                    UI.DisplayInvalid();
                    StoreCatalog(1);
                    return;
            }
        }
        private void Lemons()
        {
            Console.Clear();
            UI.DisplayInventory(player);
            UI.DisplayStoreInfo("lemons");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    if (player.wallet.CheckIfEnoughMoney(8) == true)
                    {
                        player.wallet.DecrementMoney(8);
                        player.lemons.IncramentInventory(8);
                        Lemons();
                        return;
                    }
                    else
                    {
                        StoreCatalog(1);
                    }
                    break;
                case 2:
                    if (player.wallet.CheckIfEnoughMoney(15) == true)
                    {
                        player.wallet.DecrementMoney(15);
                        player.lemons.IncramentInventory(16);
                        Lemons();
                        return;
                    }
                    else
                    {
                        StoreCatalog(1);
                    }
                    break;
                case 3:
                    if (player.wallet.CheckIfEnoughMoney(29) == true)
                    {
                        player.wallet.DecrementMoney(29);
                        player.lemons.IncramentInventory(32);
                        Lemons();
                        return;
                    }
                    else
                    {
                        StoreCatalog(1);
                    }
                    break;
                case 4:
                    StoreCatalog(1);
                    return;
                default:
                    UI.DisplayInvalid();
                    Lemons();
                    return;
            }
        }
        private void Ice()
        {
            Console.Clear();
            UI.DisplayInventory(player);
            UI.DisplayStoreInfo("ice");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    if (player.wallet.CheckIfEnoughMoney(3) == true)
                    {
                        player.wallet.DecrementMoney(3);
                        player.ice.IncramentInventory(50);
                        Ice();
                        return;
                    }
                    else
                    {
                        StoreCatalog(1);
                    }
                    break;
                case 2:
                    if (player.wallet.CheckIfEnoughMoney(6) == true)
                    {
                        player.wallet.DecrementMoney(6);
                        player.ice.IncramentInventory(100);
                        Ice();
                        return;
                    }
                    else
                    {
                        StoreCatalog(1);
                    }
                    break;
                case 3:
                    if (player.wallet.CheckIfEnoughMoney(10) == true)
                    {
                        player.wallet.DecrementMoney(10);
                        player.ice.IncramentInventory(200);
                        Ice();
                        return;
                    }
                    else
                    {
                        StoreCatalog(1);
                    }
                    break;
                case 4:
                    StoreCatalog(1);
                    return;
                default:
                    UI.DisplayInvalid();
                    Ice();
                    return;
            }
        }
        private void Cups()
        {
            Console.Clear();
            UI.DisplayInventory(player);
            UI.DisplayStoreInfo("cups");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    if (player.wallet.CheckIfEnoughMoney(3) == true)
                    {
                        player.wallet.DecrementMoney(3);
                        player.cups.IncramentInventory(20);
                        Cups();
                        return;
                    }
                    else
                    {
                        StoreCatalog(1);
                    }
                    break;
                case 2:
                    if (player.wallet.CheckIfEnoughMoney(5) == true)
                    {
                        player.wallet.DecrementMoney(5);
                        player.cups.IncramentInventory(40);
                        Cups();
                        return;
                    }
                    else
                    {
                        StoreCatalog(1);
                    }
                    break;
                case 3:
                    if (player.wallet.CheckIfEnoughMoney(10) == true)
                    {
                        player.wallet.DecrementMoney(10);
                        player.cups.IncramentInventory(100);
                        Cups();
                        return;
                    }
                    else
                    {
                        StoreCatalog(1);
                    }
                    break;
                case 4:
                    StoreCatalog(1);
                    return;
                default:
                    UI.DisplayInvalid();
                    Cups();
                    return;
            }
        }
        private void Sugar()
        {
            Console.Clear();
            UI.DisplayInventory(player);
            UI.DisplayStoreInfo("sugar");
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 1:
                    if (player.wallet.CheckIfEnoughMoney(8) == true)
                    {
                        player.wallet.DecrementMoney(8);
                        player.sugar.IncramentInventory(4);
                        Sugar();
                        return;
                    }
                    else
                    {
                        StoreCatalog(1);
                    }
                    break;
                case 2:
                    if (player.wallet.CheckIfEnoughMoney(23) == true)
                    {
                        player.wallet.DecrementMoney(23);
                        player.sugar.IncramentInventory(16);
                        Sugar();
                        return;
                    }
                    else
                    {
                        StoreCatalog(1);
                    }
                    break;
                case 3:
                    if (player.wallet.CheckIfEnoughMoney(43) == true)
                    {
                        player.wallet.DecrementMoney(43);
                        player.sugar.IncramentInventory(32);
                        Sugar();
                        return;
                    }
                    else
                    {
                        StoreCatalog(1);
                    }
                    break;
                case 4:
                    StoreCatalog(1);
                    return;
                default:
                    UI.DisplayInvalid();
                    Sugar();
                    return;
            }
        }
    }
}
