using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ICT13580101B
{
    public partial class MyPage3 : ContentPage
    {
        public MyPage3()
        {
            InitializeComponent();
            BackButton.Clicked += BackButton_Clicked;

        }

        void BackButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}
