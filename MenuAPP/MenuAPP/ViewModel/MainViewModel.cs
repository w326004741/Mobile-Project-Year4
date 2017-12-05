using MenuAPP.Command;
using MenuAPP.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace MenuAPP.ViewModel
{
    public class MainViewModel : NotificationObject
    {
        // Menu List  菜单集合
        private ObservableCollection<MenuItem> _menuItems;
        public ObservableCollection<MenuItem> MenuItems
        {
            get { return _menuItems; }
            set
            {
                _menuItems = value;
                ProperyChange("MenuItems");
            }
        }

        // Menu Open check 检查菜单是否打开
        private bool _isPaneOpen;
        public bool IsPaneOpen
        {
            get { return _isPaneOpen; }
            set
            {
                _isPaneOpen = value;
                ProperyChange("IsPaneOpen");
            }
        }

        // Menu Title 菜单标题
        private string _hamburgTitle;
        public string HamburgTitle
        {
            get { return _hamburgTitle; }
            set
            {
                _hamburgTitle = value;
                ProperyChange("HamburgTitle");
            }
        }

        public DelegateCommand HamburgButtonCommand { get; private set; }

        public MainViewModel()
        {
            HamburgTitle = "Menu";
            MenuItems = new ObservableCollection<MenuItem>()
            {
                new MenuItem() { Icon=Symbol.People, Text="People"},
                new MenuItem() { Icon=Symbol.Phone, Text="Phone"},
                new MenuItem() { Icon=Symbol.Message, Text="Message"},
                new MenuItem() { Icon=Symbol.Mail, Text="Mail"}
            };
            HamburgButtonCommand = new DelegateCommand();
            HamburgButtonCommand.ExecuteAction = new Action<object>(HamburgButton);
        }

        private void HamburgButton(object paramenter)
        {
            IsPaneOpen = IsPaneOpen ? false : true;
            //throw new NotImplementedException();
        }
    }
}
