using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace IOSXamainUITest1
{
    public class AppInitializer
    {
        public static IApp StartApp(Platform platform)
        {


            return ConfigureApp.iOS.InstalledApp("com.PepsiCo.SalesHub2 - B.QA").StartApp();
        }
    }
}