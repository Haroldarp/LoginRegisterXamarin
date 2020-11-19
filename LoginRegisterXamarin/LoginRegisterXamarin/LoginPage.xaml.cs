using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace LoginRegisterXamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        async private void Validation(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(emailEntry.Text) || string.IsNullOrEmpty(passwordEntry.Text))
            {
                await DisplayAlert("Error", "Campo Email y/o contraseña no puede estar vacío", "Ok");
            }
            else
            {
                await DisplayAlert("Bienvenido", $"Hola {emailEntry.Text}!", "Ok");
            }
        }
    }
}