using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ICT13580101B
{
    public partial class MyPage2 : ContentPage
    {
        public MyPage2()
        {
            InitializeComponent();
            NextButton.Clicked += NextButton_Clicked;
            BackButton.Clicked += BackButton_Clicked;
        }

        void NextButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new MyPage3());
        }

        void BackButton_Clicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}
