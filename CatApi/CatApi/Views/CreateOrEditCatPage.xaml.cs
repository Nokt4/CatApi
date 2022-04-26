using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CatApi.Model;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CatApi.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CreateOrEditCatPage : ContentPage
    {
        bool IsNewItem;
        public CreateOrEditCatPage(bool isNew = false)
        {
            InitializeComponent();
            IsNewItem = isNew;
        }
        private async void SaveButton_Clicked(object sender, EventArgs e)
        {
            var catItem = (CatItemModel)BindingContext;
            await App.CatManager.SaveItemAsync(catItem, IsNewItem);
            await Navigation.PopAsync();
        }
        private async void DeleteButton_Clicked(object sender, EventArgs e)
        {
            var catItem = (CatItemModel)BindingContext;
            await App.CatManager.DeleteCatAsync(catItem);
            await Navigation.PopAsync();
        }
    }
}