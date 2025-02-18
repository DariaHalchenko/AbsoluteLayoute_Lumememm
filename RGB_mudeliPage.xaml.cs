namespace AbsoluteLayoute_Lumememm;

public partial class RGB_mudeliPage : ContentPage
{
	Label lblpunane, lblroheline, lblsinine, header;
	Slider slpunane, slroheline, slsinine;
	Stepper stsuurus, stnurgas, stlabipaistvus;
	Button btn;
	AbsoluteLayout abs;
	Frame frame, framepunane, frameroheline, framesinine;

    public RGB_mudeliPage(int k)
	{
        Title = "RGB mudeli";
        header = new Label
        {
            Text = "RGB mudeli",
            FontSize = 24,
            HorizontalOptions = LayoutOptions.Center,
            TextColor = Color.FromRgb(0, 0, 0)
        };

        lblpunane = new Label
		{
			Text = "Punane: 0",
            TextColor = Color.FromRgb(0, 0, 0)
        };
		lblroheline = new Label
		{
			Text = "Roheline: 0",
            TextColor = Color.FromRgb(0, 0, 0)
        };
		lblsinine = new Label
		{
			Text = "Sinine: 0",
            TextColor = Color.FromRgb(0, 0, 0)
        };
		slpunane = new Slider
		{
			Minimum = 0,
			Maximum = 255,
            Value = 0
        };
        slroheline = new Slider
        {
            Minimum = 0,
            Maximum = 255,
            Value = 0
        };
        slsinine = new Slider
        {
            Minimum = 0,
            Maximum = 255,
            Value = 0
        };
        stsuurus = new Stepper
		{
			Minimum = 50,
			Maximum = 300,
			Increment = 10,
			Value = 100,
            HorizontalOptions = LayoutOptions.Center
		};
        stsuurus.ValueChanged += Stsuurus_ValueChanged;

        stnurgas = new Stepper
        {
            Minimum = 0,
            Maximum = 50,
            Increment = 1,
            Value = 10,
            HorizontalOptions = LayoutOptions.Center
        };
        stnurgas.ValueChanged += Stnurgas_ValueChanged;

        stlabipaistvus = new Stepper
        {
            Minimum = 0,
            Maximum = 1,
            Increment = 0.1,
            Value = 1,
            HorizontalOptions = LayoutOptions.Center
        };
        stlabipaistvus.ValueChanged += Stlabipaistvus_ValueChanged;

		btn = new Button
		{
			Text = "Juhuslik värv"
        };
        btn.Clicked += Btn_Clicked;

        frame = new Frame
        {
            BackgroundColor = Color.FromRgb(0, 0, 0),
            HeightRequest = 200,
            WidthRequest = 200,
            VerticalOptions = LayoutOptions.Center,
            HorizontalOptions = LayoutOptions.Center,
        };

        framepunane = new Frame
        {
            BackgroundColor = Color.FromRgb(255, 0, 0),
            HeightRequest = 100,
            WidthRequest = 100,
            VerticalOptions = LayoutOptions.Center,
            HorizontalOptions = LayoutOptions.Center,
        };

        frameroheline = new Frame
        {
            BackgroundColor = Color.FromRgb(0, 255, 0),
            HeightRequest = 100,
            WidthRequest = 100,
            VerticalOptions = LayoutOptions.Center,
            HorizontalOptions = LayoutOptions.Center,
        };

        framesinine = new Frame
        {
            BackgroundColor = Color.FromRgb(0, 0, 255),
            HeightRequest = 100,
            WidthRequest = 100,
            VerticalOptions = LayoutOptions.Center,
            HorizontalOptions = LayoutOptions.Center,
        };

        abs = new AbsoluteLayout { Children = { lblpunane, lblroheline, lblsinine, slpunane, slroheline, slsinine,
           btn, frame, framepunane, frameroheline, framesinine, stlabipaistvus, stnurgas, stsuurus, header} };

        AbsoluteLayout.SetLayoutBounds(header, new Rect(0, 10, 360, 40));
        AbsoluteLayout.SetLayoutBounds(frame, new Rect(10, 50, 340, 200));
        AbsoluteLayout.SetLayoutBounds(btn, new Rect(10, 270, 340, 40));

        AbsoluteLayout.SetLayoutBounds(framepunane, new Rect(10, 320, 100, 100));
        AbsoluteLayout.SetLayoutBounds(frameroheline, new Rect(130, 320, 100, 100));
        AbsoluteLayout.SetLayoutBounds(framesinine, new Rect(250, 320, 100, 100));

        AbsoluteLayout.SetLayoutBounds(lblpunane, new Rect(20, 430, 100, 30));
        AbsoluteLayout.SetLayoutBounds(lblroheline, new Rect(130, 430, 100, 30));
        AbsoluteLayout.SetLayoutBounds(lblsinine, new Rect(260, 430, 100, 30));

        AbsoluteLayout.SetLayoutBounds(slpunane, new Rect(20, 470, 330, 60));
        AbsoluteLayout.SetLayoutBounds(slroheline, new Rect(20, 500, 330, 60));
        AbsoluteLayout.SetLayoutBounds(slsinine, new Rect(20, 530, 330, 60));

        AbsoluteLayout.SetLayoutBounds(stlabipaistvus, new Rect(50, 580, 300, 40));
        AbsoluteLayout.SetLayoutBounds(stnurgas, new Rect(50, 620, 300, 40));
        AbsoluteLayout.SetLayoutBounds(stsuurus, new Rect(50, 660, 300, 40));

        Content = abs;

        slpunane.ValueChanged += Varv_ValueChanged;
        slroheline.ValueChanged += Varv_ValueChanged;
        slsinine.ValueChanged += Varv_ValueChanged;

    }

    // Muuda kõigi ristkülikute läbipaistvust
    private void Stlabipaistvus_ValueChanged(object? sender, ValueChangedEventArgs e)
    {
        float labipaistvus = (float)stlabipaistvus.Value;  

        frame.BackgroundColor = frame.BackgroundColor.WithAlpha(labipaistvus);
        framepunane.BackgroundColor = framepunane.BackgroundColor.WithAlpha(labipaistvus);
        frameroheline.BackgroundColor = frameroheline.BackgroundColor.WithAlpha(labipaistvus);
        framesinine.BackgroundColor = framesinine.BackgroundColor.WithAlpha(labipaistvus);
    }

    // Muuda kõigi ristkülikute nurkade ümardamist
    private void Stnurgas_ValueChanged(object? sender, ValueChangedEventArgs e)
    {
        float kraadi = (float)stnurgas.Value;  

        frame.CornerRadius = kraadi;
        framepunane.CornerRadius = kraadi;
        frameroheline.CornerRadius = kraadi;
        framesinine.CornerRadius = kraadi;
    }

    // Kõikide ristkülikute laiuse ja kõrguse muutmine
    private void Stsuurus_ValueChanged(object? sender, ValueChangedEventArgs e)
    {
        double newsuurus = stsuurus.Value;

        frame.WidthRequest = newsuurus;
        frame.HeightRequest = newsuurus;
        framepunane.WidthRequest = newsuurus;
        framepunane.HeightRequest = newsuurus;
        frameroheline.WidthRequest = newsuurus;
        frameroheline.HeightRequest = newsuurus;
        framesinine.WidthRequest = newsuurus;
        framesinine.HeightRequest = newsuurus;
    }


    private void Varv_ValueChanged(object? sender, ValueChangedEventArgs e)
    {
        int punane = Convert.ToInt32(slpunane.Value);
        int roheline = Convert.ToInt32(slroheline.Value);
        int sinine = Convert.ToInt32(slsinine.Value);

        lblpunane.Text = $"Punane: {punane}";
        lblroheline.Text = $"Roheline: {roheline}";
        lblsinine.Text = $"Sinine: {sinine}";

        framepunane.BackgroundColor = Color.FromRgb(punane, 0, 0);
        frameroheline.BackgroundColor = Color.FromRgb(0, roheline, 0);
        framesinine.BackgroundColor = Color.FromRgb(0, 0, sinine);

        frame.BackgroundColor = Color.FromRgb(punane, roheline, sinine);
        header.TextColor = Color.FromRgb(punane, roheline, sinine);
        lblpunane.TextColor = Color.FromRgb(punane, roheline, sinine);
        lblroheline.TextColor = Color.FromRgb(punane, roheline, sinine);
        lblsinine.TextColor = Color.FromRgb(punane, roheline, sinine);
    }

    private async void Btn_Clicked(object? sender, EventArgs e)
    {
        Random rnd = new Random();
        int rndpunane = rnd.Next(0, 256);
        int rndroheline = rnd.Next(0, 256);
        int rndsinine = rnd.Next(0, 256);

        slpunane.Value = rndpunane;
        slroheline.Value = rndroheline;
        slsinine.Value = rndsinine;

        frame.BackgroundColor = Color.FromRgb(rndpunane, rndsinine, rndroheline);

    }
}