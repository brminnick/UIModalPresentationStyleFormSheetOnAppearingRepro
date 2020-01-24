using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;

namespace OnAppearingRepro
{
    public class App : Xamarin.Forms.Application
    {
        public App() => MainPage = new Xamarin.Forms.NavigationPage(new ButtonPage());

        class ButtonPage : ContentPage
        {
            public ButtonPage()
            {
                var pageButton = new Button
                {
                    Text = "Push Page"
                };
                pageButton.Clicked += HandlPageButtonClicked;

                var modalPageFullScreenButton = new Button
                {
                    Text = "Push Modal Full Screen Sheet Page"
                };
                modalPageFullScreenButton.Clicked += HandleModalFullScreenPageButtonClicked;

                var modalPageFormSheetButton = new Button
                {
                    Text = "Push Modal Form Sheet Page"
                };
                modalPageFormSheetButton.Clicked += HandleModalFormSheetPageButtonClicked;

                Content = new StackLayout
                {
                    Children =
                    {
                        pageButton,
                        modalPageFullScreenButton,
                        modalPageFormSheetButton,
                    }
                };
            }

            protected override async void OnAppearing()
            {
                base.OnAppearing();

                await DisplayAlert("OnAppearing Fired", "", "OK");
            }

            async void HandlPageButtonClicked(object sender, EventArgs e) =>
                await Navigation.PushAsync(new LabelPage(false));

            async void HandleModalFullScreenPageButtonClicked(object sender, EventArgs e) =>
                await Navigation.PushModalAsync(new Xamarin.Forms.NavigationPage(new LabelPage(false)));

            async void HandleModalFormSheetPageButtonClicked(object sender, EventArgs e) =>
                await Navigation.PushModalAsync(new LabelPage(true));

        }

        class LabelPage : ContentPage
        {
            public LabelPage(bool isFormSheet)
            {
                if (isFormSheet)
                    On<iOS>().SetModalPresentationStyle(UIModalPresentationStyle.FormSheet);

                var backButton = new ToolbarItem
                {
                    Text = "Back"
                };
                backButton.Clicked += HandleBackButtonClicked;

                ToolbarItems.Add(backButton);

                Content = new Label
                {
                    HorizontalOptions = LayoutOptions.Center,
                    VerticalOptions = LayoutOptions.Center,
                    HorizontalTextAlignment = TextAlignment.Center,
                    VerticalTextAlignment = TextAlignment.Center,
                    Text = "Dismiss This Page to Confirm OnAppearing Fires on Previous Page"
                };
            }

            async void HandleBackButtonClicked(object sender, EventArgs e) =>
                await Navigation.PopModalAsync();

            //Work around for known UIModalPresentationStyle.FormSheet Issue:https://github.com/xamarin/Xamarin.Forms/issues/7878#issuecomment-544195130
            protected override async void OnDisappearing()
            {
                base.OnDisappearing();

                if (Navigation.ModalStack.Any())
                    await Navigation.PopModalAsync();
            }
        }
    }
}
