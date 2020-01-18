using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.Model.DataBase;
using WPF.Model.ElementToComboBox;

namespace WPF.ViewModel.SectionOfUser
{
   public class Register:BasicsViewModel
    {

        private string textBlock_Login;
        public string TextBlock_Login
        {
            get => textBlock_Login;
            set
            {
                textBlock_Login = value;
                OnPropertyChanged("TextBlock_Login");
            }
        }
        private string textBlock_Password;
        public string TextBlock_Password
        {
            get => textBlock_Password;
            set
            {
                textBlock_Password = value;
                OnPropertyChanged("TextBlock_Password");
            }
        }
        private string textBlock_AnswerSecurity;
        public string TextBlock_AnswerSecurity
        {
            get => textBlock_AnswerSecurity;
            set
            {
                textBlock_AnswerSecurity = value;
                OnPropertyChanged("TextBlock_AnswerSecurity");
            }
        }
        private List<string> itemSource_QuestionSecurity;
        public List<string> ItemSource_QuestionSecurity
        {
            get { return itemSource_QuestionSecurity; }
            set
            {
                itemSource_QuestionSecurity = value;
                OnPropertyChanged("ItemSource_QuestionSecurity");
            }
        }
        private string selected_QuestionSecurity;
        public string Selected_QuestionSecurity
        {
            get { return selected_QuestionSecurity; }
            set
            {
                selected_QuestionSecurity = value;
                OnPropertyChanged("Selected_QuestionSecurity");
            }
        }


        private BasicsViewModel button_Registered;
        public BasicsViewModel Button_Registered
        {
            get { return button_Registered; }
            set
            {
                button_Registered = value;
                OnPropertyChanged("Button_Registered");
            }
        }

        private BasicsViewModel button_Register;
        public BasicsViewModel Button_Register
        {
            get { return button_Register; }
            set
            {
                button_Register = value;
                OnPropertyChanged("Button_Register");
            }
        }

        public Register()
        {
            ItemSource_QuestionSecurity = ToComboBoxSource.Security_Question;
            Button_Registered = new BasicsViewModel(Button_Registered_Action);
            Button_Register = new BasicsViewModel(Button_Register_Action);
        }

        private void Button_Register_Action(object obj)
        {
            Task.Run(() => DataBase.InstanceOfDataBase.Register(textBlock_Login, textBlock_Password, selected_QuestionSecurity, textBlock_AnswerSecurity));
        }

        private void Button_Registered_Action(object obj)
        {
            throw new NotImplementedException();
        }
    }
}
