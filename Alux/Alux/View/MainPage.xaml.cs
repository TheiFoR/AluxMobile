using Alux.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Alux
{
    public partial class MainPage: ContentPage
    {
        string selectedIconColor = "#31acec";
        string IconColor = "#808080";

        float selectedScale = 0.9f;
        uint lengthAnimation = 75;

        public MainPage()
        {
            InitializeComponent();

            onOrOffSettings.Pressed += panelButtonPress;
            onOrOffSettings.Released += panelButtonRelease;

            brightSettings.Pressed += panelButtonPress;
            brightSettings.Released += panelButtonRelease;

            effectSettings.Pressed += panelButtonPress;
            effectSettings.Released += panelButtonRelease;

            moreSettings.Pressed += panelButtonPress;
            moreSettings.Released += panelButtonRelease;
        }
        async void panelButtonPress(object sender, EventArgs args)
        {
            Element s = (sender as Button).Parent;
            await (s as Grid).ScaleTo(selectedScale, lengthAnimation);
        }
        async void panelButtonRelease(object sender, EventArgs args)
        {
            Element s = (sender as Button).Parent;
            await (s as Grid).ScaleTo(1, lengthAnimation);
        }
        void onOrOffLights(object sender, EventArgs args)
        {
            
        }
        void goToMainPage(object sender, EventArgs args)
        {
            homePage.TextColor = Color.FromHex(selectedIconColor);
            selectionPage.TextColor = Color.FromHex(IconColor);
            settingsPage.TextColor = Color.FromHex(IconColor);
        }
        void goToModeSelectionPage(object sender, EventArgs args)
        {
            homePage.TextColor = Color.FromHex(IconColor);
            selectionPage.TextColor = Color.FromHex(selectedIconColor);
            settingsPage.TextColor = Color.FromHex(IconColor);
        }
        void goToSettings(object sender, EventArgs args)
        {
            homePage.TextColor = Color.FromHex(IconColor);
            selectionPage.TextColor = Color.FromHex(IconColor);
            settingsPage.TextColor = Color.FromHex(selectedIconColor);
        }
    }
}
