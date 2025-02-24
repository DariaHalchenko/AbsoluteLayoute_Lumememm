using Microsoft.Maui.Controls;
using Microsoft.Maui.Layouts;

namespace AbsoluteLayoute_Lumememm;

public partial class LumememmPage : ContentPage
{
    Frame framering, framesuurRing, framepang, framesilmad, framesilmad2, framenina, framenuppu, framenuppu2, framenuppu3, framekasi1, framekasi2;
    AbsoluteLayout abs;
    Label lbl;
    Button btnPeidaNaita, btnrandomvarv, btnSula;
    Stepper stpositsioon, stSilma_liikumine;
    Slider slsuurus, slkalle;
    bool lumeinimese_seisundist = false;

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

        framekasi1 = new Frame
        {
            BackgroundColor = Color.FromArgb("#8B4513"), 
            HeightRequest = 5,
            WidthRequest = 50,
            CornerRadius = 5,
            VerticalOptions = LayoutOptions.Center,
            HorizontalOptions = LayoutOptions.Center,
        };

        framekasi2 = new Frame
        {
            BackgroundColor = Color.FromArgb("#8B4513"), 
            HeightRequest = 5,
            WidthRequest = 50,
            CornerRadius = 5,
            VerticalOptions = LayoutOptions.Center,
            HorizontalOptions = LayoutOptions.Center,
        };

        btnPeidaNaita = new Button
        {
            Text = "Peida",
            BackgroundColor = Color.FromArgb("#87CEFA"),
            TextColor = Color.FromArgb("#0000CD"),
            FontSize = 20, 
            FontAttributes = FontAttributes.Bold
        };
        btnPeidaNaita.Clicked += BtnPeidaNaita_Clicked;

        btnrandomvarv = new Button
        {
            Text = "Juhuslik värv",
            BackgroundColor = Color.FromArgb("#87CEFA"),
            TextColor = Color.FromArgb("#0000CD"),
            FontSize = 20, 
            FontAttributes = FontAttributes.Bold
        };
        btnrandomvarv.Clicked += Btnprandomvarv_Clicked;

        btnSula = new Button
        {
            Text = "Sulatada",
            BackgroundColor = Color.FromArgb("#87CEFA"),
            TextColor = Color.FromArgb("#0000CD"),
            FontSize = 20, 
            FontAttributes = FontAttributes.Bold
        };
        btnSula.Clicked += BtnSula_Clicked;

        lbl = new Label
        {
            Text = "Vali tegevus",
            FontSize = 20,
            HorizontalOptions = LayoutOptions.Center
        };
        stpositsioon = new Stepper
        {
            Minimum = -250,
            Maximum = 250,
            Increment = 5,
            Value = 0,
            HorizontalOptions = LayoutOptions.Center
        };
        stpositsioon.ValueChanged += StPositsioon_ValueChanged;

        stSilma_liikumine = new Stepper
        {
            Minimum = -15,
            Maximum = 15,
            Increment = 2,
            Value = 0,
            HorizontalOptions = LayoutOptions.Center
        };
        stSilma_liikumine.ValueChanged += StSilma_liikumine_ValueChanged;

        slsuurus = new Slider
        {
            Minimum = 0.5, 
            Maximum = 1.3,    
            Value = 1
        };
        slsuurus.ValueChanged += SlSuurus_ValueChanged;

        slkalle = new Slider
        {
            Minimum = -35, 
            Maximum = 35,    
            Value = 0
        };
        slkalle.ValueChanged += SlKalle_ValueChanged;

        abs = new AbsoluteLayout
        {
            Children = { framepang, framering, framesuurRing, framenina, framesilmad, framesilmad2, framenuppu, framenuppu2, framenuppu3, framekasi1, framekasi2 },
            BackgroundColor = Color.FromArgb("#E0FFFF")
        };

        lumeinimesepositsioon();

        Content = new VerticalStackLayout
        {
            Children =
            {
                abs, 
                new VerticalStackLayout
                {
                    Children = { lbl, btnPeidaNaita, btnrandomvarv, btnSula, stpositsioon, slsuurus, stSilma_liikumine, slkalle },
                    Padding = 10,
                    VerticalOptions = LayoutOptions.End
                }
            }
        };
    }

    private void lumeinimesepositsioon()
    {
        AbsoluteLayout.SetLayoutBounds(framesuurRing, new Rect(100, 200, 180, 180));
        AbsoluteLayout.SetLayoutBounds(framering, new Rect(130, 110, 120, 120));
        AbsoluteLayout.SetLayoutBounds(framepang, new Rect(120, 80, 140, 40));
        AbsoluteLayout.SetLayoutBounds(framesilmad, new Rect(160, 140, 15, 15));
        AbsoluteLayout.SetLayoutBounds(framesilmad2, new Rect(210, 140, 15, 15));
        AbsoluteLayout.SetLayoutBounds(framenina, new Rect(185, 160, 15, 25));
        AbsoluteLayout.SetLayoutBounds(framenuppu, new Rect(185, 230, 20, 20));
        AbsoluteLayout.SetLayoutBounds(framenuppu2, new Rect(185, 270, 20, 20));
        AbsoluteLayout.SetLayoutBounds(framenuppu3, new Rect(185, 310, 20, 20));
        AbsoluteLayout.SetLayoutBounds(framekasi1, new Rect(100, 250, 50, 5)); 
        AbsoluteLayout.SetLayoutBounds(framekasi2, new Rect(230, 250, 50, 5));
    }

    //„Sulata“ lumeinimene
    private async void BtnSula_Clicked(object? sender, EventArgs e)
    {
        bool vastus = await DisplayAlert("Lumememm tegevus", 
            lumeinimese_seisundist ? "Kas tahad lumememme taastada?" : "Kas tahad lumememme sulatada?", 
            "Jah", "Ei");

        if (vastus)
        {
            if (lumeinimese_seisundist)
            {
                TaastaLumememm();
                btnSula.Text = "Sulatada";
            }
            else
            {
                await SulataLumememm();
                btnSula.Text = "Taastada";
            }
            lumeinimese_seisundist = !lumeinimese_seisundist;
        }
    }



    //Sulav lumeinimene
    private async Task SulataLumememm()
    {
        for (int i = 0; i < 5; i++)
        {
            framering.Scale -= 0.2;
            framesuurRing.Scale -= 0.2;
            framepang.Scale -= 0.2;
            framesilmad.Scale -= 0.2;
            framesilmad2.Scale -= 0.2;
            framenina.Scale -= 0.2;
            framenuppu.Scale -= 0.2;
            framenuppu2.Scale -= 0.2;
            framenuppu3.Scale -= 0.2;
            framekasi1.Scale -= 0.2;
            framekasi2.Scale -= 0.2;

            await Task.Run(() => Thread.Sleep(500));
        }
        lbl.Text = "Lumememm sulas!"; 
    }

    //Lumeinimese tagasitulek
    private void TaastaLumememm()
    {
        framering.Scale = 1;
        framesuurRing.Scale = 1;
        framepang.Scale = 1;
        framesilmad.Scale = 1;
        framesilmad2.Scale = 1;
        framenina.Scale = 1;
        framenuppu.Scale = 1;
        framenuppu2.Scale = 1;
        framenuppu3.Scale = 1;
        framekasi1.Scale = 1;
        framekasi2.Scale = 1;

        lbl.Text = "Lumememm taastatud!"; 
    }

    //Värvi juhusliku värviga
    private async void Btnprandomvarv_Clicked(object? sender, EventArgs e)
    {
        Random rnd = new Random();
        bool vastus = await DisplayAlert("Värvi muutus", "Kas tahad värvi muuta?", "Jah", "Ei");
        if (vastus)
        {
            framering.BackgroundColor = Color.FromRgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            framesuurRing.BackgroundColor = Color.FromRgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            framepang.BackgroundColor = Color.FromRgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            framesilmad.BackgroundColor = Color.FromRgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            framesilmad2.BackgroundColor = Color.FromRgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            framenina.BackgroundColor = Color.FromRgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            framenuppu.BackgroundColor = Color.FromRgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            framenuppu2.BackgroundColor = Color.FromRgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            framenuppu3.BackgroundColor = Color.FromRgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            framekasi1.BackgroundColor = Color.FromRgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));
            framekasi2.BackgroundColor = Color.FromRgb(rnd.Next(256), rnd.Next(256), rnd.Next(256));

            lbl.Text = "Värv muudetud!";
        }
        else
        {
            lbl.Text = "Värv jäi samaks!";
        }
    }

    //Peida lumeinimene ja näita lumeinimest
    private async void BtnPeidaNaita_Clicked(object? sender, EventArgs e)
    {
        bool vastus = await DisplayAlert("Lumememm tegevus", 
            abs.IsVisible ? "Kas tahad lumememme peita?" : "Kas tahad lumememme näidata?", "Jah", "Ei");

        if (vastus)
        {
            if (abs.IsVisible)
            {
                abs.IsVisible = false;
                btnPeidaNaita.Text = "Näita"; 
                lbl.Text = "Lumememm peidetud!";
            }
            else
            {
                abs.IsVisible = true;
                btnPeidaNaita.Text = "Peida"; 
                lbl.Text = "Lumememm nähtav!";
            }
        }
    }

    //Liiguta lumeinimene
    private void StPositsioon_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        double newX = e.NewValue;

        AbsoluteLayout.SetLayoutBounds(framesuurRing, new Rect(newX + 100, 200, 180, 180));
        AbsoluteLayout.SetLayoutBounds(framering, new Rect(newX + 130, 110, 120, 120));
        AbsoluteLayout.SetLayoutBounds(framepang, new Rect(newX + 120, 80, 140, 40));
        AbsoluteLayout.SetLayoutBounds(framesilmad, new Rect(newX + 160, 140, 15, 15));
        AbsoluteLayout.SetLayoutBounds(framesilmad2, new Rect(newX + 210, 140, 15, 15));
        AbsoluteLayout.SetLayoutBounds(framenina, new Rect(newX + 185, 160, 15, 25));
        AbsoluteLayout.SetLayoutBounds(framenuppu, new Rect(newX + 185, 230, 20, 20));
        AbsoluteLayout.SetLayoutBounds(framenuppu2, new Rect(newX + 185, 270, 20, 20));
        AbsoluteLayout.SetLayoutBounds(framenuppu3, new Rect(newX + 185, 310, 20, 20));
        AbsoluteLayout.SetLayoutBounds(framekasi1, new Rect(newX + 100, 250, 50, 5));
        AbsoluteLayout.SetLayoutBounds(framekasi2, new Rect(newX + 230, 250, 50, 5));
        
        lbl.Text = $"Lumeinimese positsioon: {newX}";
    } 
    //Lumeinimese suurus muutub
    private void SlSuurus_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        double suurus = e.NewValue;

        framering.Scale = suurus;
        framesuurRing.Scale = suurus;
        framepang.Scale = suurus;
        framesilmad.Scale = suurus;
        framesilmad2.Scale = suurus;
        framenina.Scale = suurus;
        framenuppu.Scale = suurus;
        framenuppu2.Scale = suurus;
        framenuppu3.Scale = suurus;
        framekasi1.Scale = suurus;
        framekasi2.Scale = suurus;
        
        lbl.Text = $"Lumeinimese suurus: {suurus:F1}";
    }
    //Silma liikumine
    private void StSilma_liikumine_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        AbsoluteLayout.SetLayoutBounds(framesilmad, new Rect(160 + e.NewValue, 140, 15, 15));
        AbsoluteLayout.SetLayoutBounds(framesilmad2, new Rect(210 + e.NewValue, 140, 15, 15));
    } 

    //Käe kallutamine
    private void SlKalle_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        double kalle = e.NewValue;

        framekasi1.Rotation = kalle; 
        framekasi2.Rotation = kalle; 

        lbl.Text = $"Käe kaldenurk: {kalle:F1}°";
    }
}
