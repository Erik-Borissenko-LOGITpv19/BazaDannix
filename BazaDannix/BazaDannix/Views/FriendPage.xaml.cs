﻿using BazaDannix.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BazaDannix.Views
{
        [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FriendPage : ContentPage
    {
        public FriendViewModel ViewModel { get; private set; }
        public FriendPage(FriendViewModel vm)
        {
            InitializeComponent();
            ViewModel = vm;
            this.BindingContext = ViewModel;
        }
    }
}