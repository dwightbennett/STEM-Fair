using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace STEMFair.ViewModels
{
    public class SelectionPageViewModel : BaseViewModel
    {
        int selection;
        public int Selection
        {
            get => selection;
            set => SetProperty(ref selection, value);
        }

        string failedText;
        public string FailedText
        {
            get => failedText;
            set => SetProperty(ref failedText, value);
        }

        public ICommand SubmitCommand => new Command(async () => await Submit());

        async Task Submit()
        {
            if(!SecretValidator.ValidateSelection(Selection))
            {
                FailedText = "Wrong Answer";
                return;
            }

            await App.Current.MainPage.Navigation.PushAsync(new CodePage());
        }
    }
}
