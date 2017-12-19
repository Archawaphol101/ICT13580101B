using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ICT13580101B
{
    public partial class NavPage3 : ContentPage
    {
        public NavPage3()

        {
            InitializeComponent();
            BackButton.Clicked += BackButton_Clicked;
            Backtorootbutton.Clicked += Backtorootbutton_Clicked;
        }

        void BackButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PopAsync();
        }

        void Backtorootbutton_Clicked(object sender, EventArgs e)
        {
            Navigation.PopToRootAsync();
        }
    }
}
