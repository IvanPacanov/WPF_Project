using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF.Model.Accounts
{
   public abstract class BasicsAccount
    {
        private string nick;
        private string pass;
        private DateTime dateTime;
        private string Security_Question;
        private string Security_Answer;
        
   
        /// <summary>
        /// This method allows to set or change the nick
        /// </summary>
        /// <param name="nick"></param>
        public void SetNick(string nick)
        {
            this.nick = nick;
        }
    }
}
