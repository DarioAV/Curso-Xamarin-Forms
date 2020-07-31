using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App2
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Entry_Focused(object sender, FocusEventArgs e) => ModifyStrokeColor();

        private void Entry_Unfocused(object sender, FocusEventArgs e) => ModifyStrokeColor();

        private void ModifyStrokeColor()
        {
            var focused = Color.FromHex("#ce6767");
            var unFocused = Color.FromHex("#c7cdd2");
            RectangleEmpresa.Stroke = EntryEmpresa.IsFocused ? focused : unFocused;
            RectangleUsuario.Stroke = EntryUsuario.IsFocused ? focused : unFocused;
            RectangleContraseña.Stroke = EntryPassword.IsFocused ? focused : unFocused;
        }

        private void EntryTextChanged(object sender, TextChangedEventArgs e) => Validate();
        
        private void Validate() => LoginButton.IsEnabled = ValidateField(EntryEmpresa.Text)
                && ValidateField(EntryUsuario.Text)
                && ValidateField(EntryPassword.Text);
        

        private bool ValidateField(string field) => !string.IsNullOrWhiteSpace(field) && field.Trim().Length>=3;

        private void TapGestureRecognizer_Tapped(object sender, EventArgs e)
        {
            Xamarin.Essentials.Browser.OpenAsync("https://www.google.es");
        }

        private void LoginButton_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage.Navigation.PushAsync(new Page());
        }
    }
}
