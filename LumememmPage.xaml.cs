using Microsoft.Maui.Controls;
using Microsoft.Maui.Layouts;

namespace AbsoluteLayoute_Lumememm;

public partial class LumememmPage : ContentPage
{
	Frame framering, framesuurRing, framepang, framesilmad, framesilmad2, framenina, framenuppu, framenuppu2, framenuppu3;
    AbsoluteLayout abs;
    public LumememmPage(int k)
	{
        Title = "Lumememm";

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
            Children = { framepang, framering, framesuurRing, framenina, framesilmad, framesilmad2, framenuppu, framenuppu2, framenuppu3},
            BackgroundColor = Color.FromArgb("#E0FFFF")
        };
        AbsoluteLayout.SetLayoutBounds(framesuurRing, new Rect(100, 350, 180, 180));
        AbsoluteLayout.SetLayoutBounds(framering, new Rect(130, 260, 120, 120));
        AbsoluteLayout.SetLayoutBounds(framepang, new Rect(120, 230, 140, 40));
        AbsoluteLayout.SetLayoutBounds(framesilmad, new Rect(160, 300, 15, 15)); 
        AbsoluteLayout.SetLayoutBounds(framesilmad2, new Rect(210, 300, 15, 15)); 
        AbsoluteLayout.SetLayoutBounds(framenina, new Rect(185, 320, 15, 25));
        AbsoluteLayout.SetLayoutBounds(framenuppu, new Rect(185, 390, 20, 20));
        AbsoluteLayout.SetLayoutBounds(framenuppu2, new Rect(185, 430, 20, 20));
        AbsoluteLayout.SetLayoutBounds(framenuppu3, new Rect(185, 470, 20, 20));

        Content = abs;
    }
}