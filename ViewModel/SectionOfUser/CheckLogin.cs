using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.Model.DataBase;

namespace WPF.ViewModel.SectionOfUser
{
    public class CheckLogin:BasicsViewModel
    {
        private BasicsViewModel button_Login;
        public BasicsViewModel Button_Login
        {
            get { return button_Login; }
            set
            {
                button_Login = value;
                OnPropertyChanged("Button_Login");
            }
        }
        public CheckLogin()
        {
            Button_Login = new BasicsViewModel(Button_LoginAction);
        }

        private void Button_LoginAction(object obj)
        {
            Task.Run(() => DataBase.InstanceOfDataBase.CheckTheLogin("Admin","Admin"));
        }
    }
}
