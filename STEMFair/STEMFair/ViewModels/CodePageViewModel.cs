using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace STEMFair.ViewModels
{
    public class CodePageViewModel : BaseViewModel
    {
        ObservableCollection<string> code;
        public ObservableCollection<string> Code
        {
            get => code;
            set => SetProperty(ref code, value);
        }

        public CodePageViewModel()
        {
            Code = new ObservableCollection<string>();
        }

        public ICommand NumberCommand => new Command<string>(NumberSelected);

        void NumberSelected(string number)
        {
            if (Code.Count < 4)
            {
                Code.Add(number);
            }
        }

        void NumberDeleted()
        {
            if (Code.Any())
            {
                Code.Remove(Code.Last());
            }
        }

        void Submit()
        {

        }

    }
}
