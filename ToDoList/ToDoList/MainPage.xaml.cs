using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ToDoList
{
   
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_OnClicked(object sender, EventArgs e)
        {
            bool isEmailBlank = string.IsNullOrEmpty(userName.Text);
            bool isPasswordBlank = string.IsNullOrEmpty(password.Text);


            if (isEmailBlank || isPasswordBlank)
            {
                DisplayAlert("LoginError", "Email or Password is missing", "ok");
            }

            else
            {
                Navigation.PushAsync(new LandingPage());
            }
        }
    }
}
