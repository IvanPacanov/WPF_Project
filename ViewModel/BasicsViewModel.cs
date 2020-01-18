using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace WPF.ViewModel
{
    public class BasicsViewModel : INotifyPropertyChanged, ICommand, INotifyCollectionChanged
    {
        #region Konstruktory

        public BasicsViewModel()
        {

        }
        public BasicsViewModel(Action<object> realize, Predicate<object> ifRealize = null)
        {
            this.realize = realize;
            this.ifRealize = ifRealize;
        }


        #endregion

        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string nameProperty)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(nameProperty));
        }


        #endregion

        #region INotifyCollectionChanged

        public event NotifyCollectionChangedEventHandler CollectionChanged;
        protected virtual void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            ObservableCollection<object> obserwowanySender = sender as ObservableCollection<object>;

            List<object> editionOrRemoveElement = new List<object>();
            foreach (object newElement in e.NewItems)
            {
                editionOrRemoveElement.Add(newElement);
            }

            foreach (object oldElement in e.OldItems)
            {
                editionOrRemoveElement.Add(oldElement);
            }

            NotifyCollectionChangedAction action = e.Action;
        }

        #endregion






        #region ICommand

        private readonly Predicate<object> ifRealize;
        private readonly Action<object> realize;


        public event EventHandler CanExecuteChanged;
        public virtual void Execute(object parameter)
        {
            realize(parameter);
        }
        public virtual bool CanExecute(object parameter)
        {
            if (ifRealize == null)
            { return true; }
            return ifRealize(parameter);
        }

        #endregion
    }
}
