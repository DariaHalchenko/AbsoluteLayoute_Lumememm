using Microsoft.Maui.Controls;

namespace AbsoluteLayoute_Lumememm;

public partial class LumememmPage : ContentPage
{
	Frame framering, framesuurRing, framepang, framesilmad, framesilmad2, framenina, framenuppu, framenuppu2, framenuppu3;
	Label header;
    AbsoluteLayout abs;
    public LumememmPage(int k)
	{
        Title = "Lumememm";
        header = new Label
        {
            Text = "Lumememm",
            FontSize = 24,
            HorizontalOptions = LayoutOptions.Center,
            TextColor = Color.FromRgb(0, 0, 0)
        };

        framepang = new Frame
        {
            BackgroundColor = Color.FromArgb("#8B4513"),
            HeightRequest = 50,
            WidthRequest = 50,
            VerticalOptions = LayoutOptions.Center,
            HorizontalOptions = LayoutOptions.Center,
        };
        framering = new Frame
        {
            BackgroundColor = Color.FromArgb("#F5FFFA"),
            HeightRequest = 100,
            WidthRequest = 100,
            CornerRadius = 50,
            VerticalOptions = LayoutOptions.Center,
            HorizontalOptions = LayoutOptions.Center,
        };
        framesuurRing = new Frame
        {
            BackgroundColor = Color.FromArgb("#F5FFFA"),
            HeightRequest = 150,
            WidthRequest = 150,
            CornerRadius = 75,
            VerticalOptions = LayoutOptions.Center,
            HorizontalOptions = LayoutOptions.Center,
        };
        framesilmad = new Frame
        {
            BackgroundColor = Color.FromArgb("#000000"),
            HeightRequest = 10,
            WidthRequest = 10,
            CornerRadius = 50,
            VerticalOptions = LayoutOptions.Center,
            HorizontalOptions = LayoutOptions.Center,
        };
        framesilmad2 = new Frame
        {
            BackgroundColor = Color.FromArgb("#000000"),
            HeightRequest = 10,
            WidthRequest = 10,
            CornerRadius = 50,
            VerticalOptions = LayoutOptions.Center,
            HorizontalOptions = LayoutOptions.Center,
        };
        framenina = new Frame
        {
            BackgroundColor = Color.FromArgb("#FF8C00"),
            HeightRequest = 20,
            WidthRequest = 10,
            CornerRadius = 5,
            VerticalOptions = LayoutOptions.Center,
            HorizontalOptions = LayoutOptions.Center,
        };
        //
        framenuppu = new Frame
        {
            BackgroundColor = Color.FromArgb("#000000"),
            HeightRequest = 20,
            WidthRequest = 10,
            CornerRadius = 30,
            VerticalOptions = LayoutOptions.Center,
            HorizontalOptions = LayoutOptions.Center,
        };
        framenuppu2 = new Frame
        {
            BackgroundColor = Color.FromArgb("#000000"),
            HeightRequest = 20,
            WidthRequest = 10,
            CornerRadius = 30,
            VerticalOptions = LayoutOptions.Center,
            HorizontalOptions = LayoutOptions.Center,
        };
        framenuppu3 = new Frame
        {
            BackgroundColor = Color.FromArgb("#000000"),
            HeightRequest = 20,
            WidthRequest = 10,
            CornerRadius = 30,
            VerticalOptions = LayoutOptions.Center,
            HorizontalOptions = LayoutOptions.Center,
        };

        abs = new AbsoluteLayout
        {
            Children = { framepang, framering, framesuurRing, framenina, framesilmad, framesilmad2 ,header, framenuppu, framenuppu2, framenuppu3},
            BackgroundColor = Color.FromArgb("#E0FFFF")
        };

        AbsoluteLayout.SetLayoutBounds(header, new Rect(0, 10, 360, 40));

        AbsoluteLayout.SetLayoutBounds(framepang, new Rect(155, 50, 50, 30));
        AbsoluteLayout.SetLayoutBounds(framering, new Rect(135, 80, 100, 100));
        AbsoluteLayout.SetLayoutBounds(framesuurRing, new Rect(120, 170, 150, 150));
        AbsoluteLayout.SetLayoutBounds(framenina, new Rect(170, 140, 10, 20));
        AbsoluteLayout.SetLayoutBounds(framesilmad, new Rect(155, 120, 5, 5));
        AbsoluteLayout.SetLayoutBounds(framesilmad2, new Rect(180, 120, 5, 5));

        AbsoluteLayout.SetLayoutBounds(framenuppu, new Rect(170, 140, 10, 20));
        AbsoluteLayout.SetLayoutBounds(framenuppu2, new Rect(155, 120, 5, 5));
        AbsoluteLayout.SetLayoutBounds(framenuppu3, new Rect(180, 120, 5, 5));

        Content = abs;
    }
}