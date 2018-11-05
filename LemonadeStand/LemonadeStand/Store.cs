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
            try
            {
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
            catch
            {
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
            try
            {
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        if (player.wallet.CheckIfEnoughMoney(8) == true)
                        {
                            player.wallet.DecrementMoney(8);
                            player.lemons.IncrementInventory(8);
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
                            player.lemons.IncrementInventory(16);
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
                            player.lemons.IncrementInventory(32);
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
            catch
            {
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
            try
            {
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        if (player.wallet.CheckIfEnoughMoney(3) == true)
                        {
                            player.wallet.DecrementMoney(3);
                            player.ice.IncrementInventory(50);
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
                            player.ice.IncrementInventory(100);
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
                            player.ice.IncrementInventory(200);
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
            catch
            {
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
            try
            {
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        if (player.wallet.CheckIfEnoughMoney(3) == true)
                        {
                            player.wallet.DecrementMoney(3);
                            player.cups.IncrementInventory(20);
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
                            player.cups.IncrementInventory(40);
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
                            player.cups.IncrementInventory(100);
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
            catch
            {
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
            try
            {
                switch (Convert.ToInt32(Console.ReadLine()))
                {
                    case 1:
                        if (player.wallet.CheckIfEnoughMoney(8) == true)
                        {
                            player.wallet.DecrementMoney(8);
                            player.sugar.IncrementInventory(4);
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
                            player.sugar.IncrementInventory(16);
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
                            player.sugar.IncrementInventory(32);
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
            catch
            {
                UI.DisplayInvalid();
                Sugar();
                return;
            }

        }
    }
}
