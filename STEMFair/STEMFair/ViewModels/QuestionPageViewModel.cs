using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace STEMFair.ViewModels
{
    public class QuestionPageViewModel : BaseViewModel
    {
        string failedText;
        public string FailedText
        {
            get => failedText;
            set => SetProperty(ref failedText, value);
        }

        string answer;
        public string Answer
        {
            get => answer;
            set => SetProperty(ref answer, value);
        }

        public ICommand SubmitCommand => new Command(async () => await Submit());

        async Task Submit()
        {
            if(!SecretValidator.ValidateQuestion(Answer.ToLower()))
            {
                FailedText = "Wrong Answer";
                return;
            }

            await App.Current.MainPage.Navigation.PushAsync(new SelectionPage());
        }
    }
}
