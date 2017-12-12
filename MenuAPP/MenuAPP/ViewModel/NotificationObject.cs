using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MenuAPP.ViewModel
{
    // ViewModel的基类,作用是通知ViewModels的变化
    // ViewModel base class, the role of notification ViewModels changes

    // implements the IPropertyChange interface.
    public class NotificationObject : INotifyPropertyChanged 
    {
        public event PropertyChangedEventHandler PropertyChanged;

        // RaisePropertyChanging事件用于通知UI或绑定元素数据已更改。
        // 例如，当底层数据发生变化时，TextBox需要接收通知，以便它可以更新您在UI中看到的文本。
        // 如果没有NotifyPropertyChanged事件，TextBox将不知道数据已更改。

        // The RaisePropertyChanging event is used to notify UI or bound elements that the data has changed. 
        // For example a TextBox needs to receive a notification when the underlying data changes, 
        // so that it can update the text you see in the UI. 
        // Without the NotifyPropertyChanged event, the TextBox would have no idea that the data changed.

        // https://stackoverflow.com/questions/24562336/what-is-the-importance-of-raisepropertychanged
        // https://msdn.microsoft.com/en-us/library/system.componentmodel.inotifypropertychanged.aspx

        public void RaisePropertyChanged(string ProperyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(ProperyName));
            }


        }
    }
}
