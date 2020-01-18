using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPF.ViewModel;

namespace WPF.Model.DataBase
{
   public class DataBase
    {
        private static DataBase dataBase = null;
        public static DataBase InstanceOfDataBase
        {
            get
            {
                if(dataBase==null)
                {
                    dataBase = new DataBase();
                }
                return dataBase;
            }
        }
        private MyProjectEntities myProject;

        private DataBase()
        {
            myProject = new MyProjectEntities();
        }

        public void CheckTheLogin(string login, string password)
        {
            if (CorectLogin == null)
            {
                CorectLogin += MainClass.IsLogin;
            }
                CorectLogin(myProject.Account.Any(x => x.Nick == login && x.Pass == password));    
        }
        public void Register(string login, string password, string security_Question, string security_Answer)
        {
            myProject.Account.Add(new Account() { Id = myProject.Account.Max(x => x.Id) + 1, Nick = login, Pass = password, LastActivity = DateTime.Now, Security_Question = security_Question, Security_Answer = security_Answer });
            myProject.SaveChanges();
        }


        public delegate void IsLogin(bool IsOk);
        public event IsLogin CorectLogin;

        protected virtual void OnCorectLogin(bool sender)
        {
            if (CorectLogin != null)
            {
                CorectLogin(true);
            }
        }
    }
}
