using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using CommunityToolkit.Maui.Alerts;
using CommunityToolkit.Maui.Layouts;

namespace CtTest.Pages;

public partial class MainPage : ContentPage
{

    public MainPage()
    {
        InitializeComponent();
        InitialisePage();
    }

    void InitialisePage()
    {
        Title = "Test page";
    }

    public void MaskCodes()
    {
    }

    public void UnmaskCodes()
    {
    }

    async void AddClicked(object? sender, EventArgs e)
    {
        var toast = Toast.Make("Add has been clicked");
        await toast.Show();
    }

    async void SettingsClicked(object? sender, EventArgs e)
    {
        var toast = Toast.Make("Settings has been clicked");
        await toast.Show();
    }

    private void PointerGestureRecognizer_PointerEntered(object sender, PointerEventArgs e)
    {
#if WINDOWS
        if (
            sender is Microsoft.Maui.Controls.VisualElement ff &&
            ff.Handler?.PlatformView is Microsoft.UI.Xaml.UIElement fr
        )
        {
            ChangeCursor(fr, Microsoft.UI.Input.InputSystemCursorShape.Hand);
        }
#elif MACCATALYST
         AppKit.NSCursor.PointingHandCursor.Set();
#endif

    }

#if WINDOWS
    public static void ChangeCursor(
        Microsoft.UI.Xaml.UIElement uiElement,
        Microsoft.UI.Input.InputSystemCursorShape cursor
    )
    {
        Type type = typeof(Microsoft.UI.Xaml.UIElement);
        type.InvokeMember(
            "ProtectedCursor",
            BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.SetProperty | BindingFlags.Instance,
            null,
            uiElement,
            new object[] { Microsoft.UI.Input.InputSystemCursor.Create(cursor) }
        );
    }
#endif
}
