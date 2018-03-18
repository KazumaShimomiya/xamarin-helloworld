using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Forms;
using HelloWorld.ViewModels;

namespace HelloWorld.Views
{
    public partial class MyPage : ContentPage
    {
        public MyPage()
        {
            InitializeComponent();
            this.BindingContext = new MyPageViewModel();
        }
    }
}
