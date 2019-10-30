using STEMFair.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace STEMFair
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CodePage : ContentPage
    {
        public CodePage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            BindingContext = new CodePageViewModel();
        }
    }
}