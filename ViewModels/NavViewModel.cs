using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace hamburgerExample.ViewModels
{
    public class MenuItem
    {
        public Symbol Icon { get; set; }
        public string Name { get; set; }
        public Type PageType { get; set; }

    }
    public class NavViewModel
    {
        public List<MenuItem> MainMenuItems = new List<MenuItem>();
        public List<MenuItem> OptionalMenuItems = new List<MenuItem>();

        public NavViewModel()
        {
            if (MainMenuItems.Count == 0 && OptionalMenuItems.Count == 0)
            {
                MainMenuItems.Add(new MenuItem()
                {
                    Icon = Symbol.Contact,
                    Name = "My Account",
                    PageType = typeof(Views.AccountsView)
                });
                MainMenuItems.Add(new MenuItem()
                {
                    Icon = Symbol.Shop,
                    Name = "Exchange",
                    PageType = typeof(Views.ExchangeView)
                });
                MainMenuItems.Add(new MenuItem()
                {
                    Icon = Symbol.ViewAll,
                    Name = "Summary",
                    PageType = typeof(Views.SummaryView)
                });
                MainMenuItems.Add(new MenuItem()
                {
                    Icon = Symbol.Find,
                    Name = "Search",
                    PageType = typeof(Views.SearchView)
                });

                OptionalMenuItems.Add(new MenuItem()
                {
                    Icon = Symbol.Back,
                    Name = "Logout",
                    PageType = typeof(Views.LoginView)
                });
            }
        }
    }
}
