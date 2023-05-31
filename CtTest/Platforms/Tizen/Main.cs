using Microsoft.Maui;
using Microsoft.Maui.Hosting;
using System;

namespace Community_Toolkit___Android_Button_Expander_Error
{
    internal class Program : MauiApplication
    {
        protected override MauiApp CreateMauiApp() => MauiProgram.CreateMauiApp();

        static void Main(string[] args)
        {
            var app = new Program();
            app.Run(args);
        }
    }
}