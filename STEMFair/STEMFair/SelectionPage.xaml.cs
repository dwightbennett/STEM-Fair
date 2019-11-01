
using STEMFair.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace STEMFair
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SelectionPage : ContentPage
    {
        public static BindableProperty SelectionProperty = BindableProperty.Create(nameof(Selection), typeof(int), typeof(SelectionPage), -1, BindingMode.TwoWay);

        public int Selection
        {
            get => (int)GetValue(SelectionProperty);
            set => SetValue(SelectionProperty, value);
        }
        public SelectionPage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            BindingContext = new SelectionPageViewModel();
        }

        private void Answer1Checkbox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (e.Value)
            {
                Selection = 1;

                Answer2Checkbox.IsChecked = false;
                Answer3Checkbox.IsChecked = false; 
                Answer4Checkbox.IsChecked = false;
            }
        }

        private void Answer2Checkbox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (e.Value)
            {
                Selection = 2;

                Answer1Checkbox.IsChecked = false;
                Answer3Checkbox.IsChecked = false;
                Answer4Checkbox.IsChecked = false;
            }
        }

        private void Answer3Checkbox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (e.Value)
            {
                Selection = 3;

                Answer1Checkbox.IsChecked = false;
                Answer2Checkbox.IsChecked = false;
                Answer4Checkbox.IsChecked = false;
            }
        }

        private void Answer4Checkbox_CheckedChanged(object sender, CheckedChangedEventArgs e)
        {
            if (e.Value)
            {
                Selection = 4;

                Answer1Checkbox.IsChecked = false;
                Answer2Checkbox.IsChecked = false;
                Answer3Checkbox.IsChecked = false;
            }
        }
    }
}