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
    public partial class RegisterPage : ContentPage
    {
        public RegisterPage()
        {
            InitializeComponent();
        }

        async private void Validation(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameEntry.Text) || string.IsNullOrEmpty(emailEntry.Text) || 
                string.IsNullOrEmpty(passwordEntry.Text) || string.IsNullOrEmpty(confirmPasswordEntry.Text))
            {
                await DisplayAlert("Error", "No puede haber ningun campo vacio", "Ok");
            }
            else
            {
                if(passwordEntry.Text != confirmPasswordEntry.Text)
                {
                    await DisplayAlert("Error", "Las contraseñas no coinciden", "Ok");
                }
                else
                {
                    await DisplayAlert("Bienvenido", $"Hola {nameEntry.Text}!", "Ok");
                }
            }
        }
    }
}