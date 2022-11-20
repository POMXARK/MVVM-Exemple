
using System.ComponentModel;


namespace MVVMExemple2
{
    public class MainVM : INotifyPropertyChanged
    {
        private int _number1;
        public int Number1
        {
            get { return _number1; }
            set
            {
                _number1 = value;
                OnPropertyChanged("Number3"); // уведомление View о том, что изменилась сумма
            }
        }

        private int _number2;
        public int Number2
        {
            get { return _number2; }
            set { _number2 = value; OnPropertyChanged("Number3"); }
        }

        //свойство только для чтения, оно считывается View каждый раз, когда обновляется Number1 или Number2
        public int Number3
        {
            get
            {
                return Number1 + Number2;
            }
        }

        /// <summary>
        /// Магия MVVM, обработчик события, используется при вызове свойств
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
