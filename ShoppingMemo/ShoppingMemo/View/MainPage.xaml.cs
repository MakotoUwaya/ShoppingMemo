using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using ShoppingMemo.ViewModel;

namespace ShoppingMemo.View
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();   
                    
        }

        private void PopupButton_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("タイトル", "メッセージ", "OK");
        }
    }
}
