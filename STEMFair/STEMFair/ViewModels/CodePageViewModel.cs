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
        string code;
        public string Code
        {
            get => code;
            set => SetProperty(ref code, value);
        }

        string failedText;
        public string FailedText
        {
            get => failedText;
            set => SetProperty(ref failedText, value);
        }

        public CodePageViewModel()
        {
            Code = string.Empty;
        }

        public ICommand NumberCommand => new Command<string>(NumberSelected);
        public ICommand DeleteCommand => new Command(NumberDeleted);
        public ICommand SubmitCommand => new Command(Submit);

        void NumberSelected(string number)
        {
            if (Code.Count() < 4)
            {
                Code += number;
            }
        }

        void NumberDeleted()
        {
            if (Code.Any())
            {
                Code = Code.Remove(Code.Count()-1);
            }

            if(!string.IsNullOrEmpty(FailedText))
            {
                FailedText = string.Empty;
            }
        }

        void Submit()
        {
            FailedText = "Code Failed";
        }




    }
}
