using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace WPF.Model.ElementToComboBox
{
   public static class ToComboBoxSource
    {
        public static List<string> Security_Question = new List<string>
        {
            { Application.Current.FindResource("string_Dog").ToString() }
        };

        public static void UpdateClass()
        {
            ConstructorInfo constructor = typeof(ToComboBoxSource).GetConstructor(BindingFlags.Static | BindingFlags.NonPublic, null, new Type[0], null);
            constructor.Invoke(null, null);
        }
    }
}
