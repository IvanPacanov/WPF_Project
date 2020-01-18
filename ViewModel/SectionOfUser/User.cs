using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF.ViewModel.SectionOfUser
{
   public class User:BasicsViewModel
    {
        private CheckLogin checkLogin;
        public CheckLogin CheckLogin
        {
            get => checkLogin;
            set
            {
                checkLogin = value;
                OnPropertyChanged("CheckLogin");
            }
        }
        private Register register;
        public Register Register
        {
            get => register;
            set
            {
                register = value;
                OnPropertyChanged("Register");
            }
        }
        public User()
        {
            CheckLogin = new CheckLogin();
            Register = new Register();
        }
    }
}
