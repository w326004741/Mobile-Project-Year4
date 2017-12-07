using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuAPP.ViewModel
{
    // ViewModel的基类,作用是通知ViewModels的变化
    public class NotificationObject : INotifyPropertyChanged 
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void RaisePropertyChanged(string ProperyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(ProperyName));
            }


        }
    }
}
