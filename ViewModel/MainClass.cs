using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using WPF.Model.DataBase;
using WPF.ViewModel;
using WPF.ViewModel.SectionOfUser;

namespace WPF.ViewModel
{
   public class MainClass : BasicsViewModel
    {

        private User user;
        public User User
        {
            get => user;
            set
            {
                user = value;
                OnPropertyChanged("User");
            }
        }


        private BasicsViewModel bT_Minimize;
        public BasicsViewModel BT_Minimize
        {
            get { return bT_Minimize; }
            set
            {
                bT_Minimize = value;
                OnPropertyChanged("BT_Minimize");
            }
        }
        private BasicsViewModel bT_Maximize;
        public BasicsViewModel BT_Maximize
        {
            get { return bT_Maximize; }
            set
            {
                bT_Maximize = value;
                OnPropertyChanged("BT_Maximize");
            }
        }

        internal static void IsLogin(bool IsOk)
        {
            if(IsOk) {

            }
            else
            {
                MessageBox.Show("XDDD");
            }
        }

        private BasicsViewModel bT_Power;
        public BasicsViewModel BT_Power
        {
            get { return bT_Power; }
            set
            {
                bT_Power = value;
                OnPropertyChanged("BT_Power");
            }
        }
        private WindowState _curWindowState;
        public WindowState CurWindowState
        {
            get { return _curWindowState; }
            set
            {
                _curWindowState = value;
                base.OnPropertyChanged("CurWindowState");
            }
        }
        public MainClass()
        {
            BT_Minimize = new BasicsViewModel(MinimizeWindow);
            BT_Maximize = new BasicsViewModel(MaximizeWindow);
            BT_Power = new BasicsViewModel(CloseWindow);
            User = new User();




        }
        private void CloseWindow(object obj)
        {
            Application.Current.Shutdown();
        }

        private void MinimizeWindow(object obj)
        {
            CurWindowState = WindowState.Minimized;
        }
        private void MaximizeWindow(object obj)
        {
            if (CurWindowState == WindowState.Normal)
            {
                CurWindowState = WindowState.Maximized;
            }
            else
            {
                CurWindowState = WindowState.Normal;
            }
        }
    }
}
