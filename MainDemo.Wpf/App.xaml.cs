﻿using System.Windows;
using System.Windows.Media;
using MaterialDesignThemes.Wpf;
using ShowMeTheXAML;

namespace MaterialDesignColors.WpfExample
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            //This is an alternate way to initialize MaterialDesignInXAML if you don't use the MaterialDesignResourceDictionary in App.xaml
            //Color primaryColor = SwatchHelper.Lookup[MaterialDesignColor.DeepPurple];
            //Color accentColor = SwatchHelper.Lookup[MaterialDesignColor.Lime];
            //ITheme theme = Theme.Create(new MaterialDesignLightTheme(), primaryColor, accentColor);
            //Resources.SetTheme(theme);

            //Illustration of setting culture info fully in WPF:
#if false
            Thread.CurrentThread.CurrentCulture = new CultureInfo("fr-FR");
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("fr-FR");
            FrameworkElement.LanguageProperty.OverrideMetadata(typeof(FrameworkElement), new FrameworkPropertyMetadata(
                        XmlLanguage.GetLanguage(CultureInfo.CurrentCulture.IetfLanguageTag)));
#endif

            XamlDisplay.Init();

            // test setup for Persian culture settings
#if false
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("fa-Ir");
            System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("fa-Ir");
            FrameworkElement.LanguageProperty.OverrideMetadata(typeof(FrameworkElement), new FrameworkPropertyMetadata(
                        System.Windows.Markup.XmlLanguage.GetLanguage(System.Globalization.CultureInfo.CurrentCulture.IetfLanguageTag)));
#endif						

            base.OnStartup(e);
        }
    }
}
