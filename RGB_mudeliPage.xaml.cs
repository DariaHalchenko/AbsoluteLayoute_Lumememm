namespace AbsoluteLayoute_Lumememm;

public partial class RGB_mudeliPage : ContentPage
{
	Label lblpunane, lblroheline, lblsinine;
	Slider slpunane, slroheline, slsinine;
	Stepper stpunane, stroheline, stsinine;
	Button btn;
	AbsoluteLayout abs;
	Frame frame;
    BoxView boxView;

    public RGB_mudeliPage(int k)
	{
		lblpunane = new Label
		{
			BackgroundColor = Color.FromRgb(120, 144, 133),
			Text = "Punane: 0"
		};
		lblroheline = new Label
		{
			BackgroundColor = Color.FromRgb(120, 144, 133),
			Text = "Roheline: 0"
		};
		lblsinine = new Label
		{
			BackgroundColor = Color.FromRgb(120, 144, 133),
			Text = "Sinine: 0"
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
		stpunane = new Stepper
		{
			Minimum = 0,
			Maximum = 255,
			Increment = 1,
			Value = 0
		};
        stroheline = new Stepper
        {
            Minimum = 0,
            Maximum = 255,
            Increment = 1,
            Value = 0
        };
        stsinine = new Stepper
        {
            Minimum = 0,
            Maximum = 255,
            Increment = 1,
            Value = 0
        };
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
        abs = new AbsoluteLayout { Children = { lblpunane, lblroheline, lblsinine, slpunane, slroheline, slsinine,
           btn, frame } };
        AbsoluteLayout.SetLayoutBounds(lblpunane, new Rect(10, 20, 300, 30));
        AbsoluteLayout.SetLayoutBounds(lblroheline, new Rect(10, 60, 300, 30));
        AbsoluteLayout.SetLayoutBounds(lblsinine, new Rect(10, 100, 300, 30));

        AbsoluteLayout.SetLayoutBounds(slpunane, new Rect(10, 140, 300, 30));
        AbsoluteLayout.SetLayoutBounds(slroheline, new Rect(10, 180, 300, 30));
        AbsoluteLayout.SetLayoutBounds(slsinine, new Rect(10, 220, 300, 30));

        AbsoluteLayout.SetLayoutBounds(stpunane, new Rect(320, 140, 50, 30));
        AbsoluteLayout.SetLayoutBounds(stroheline, new Rect(320, 180, 50, 30));
        AbsoluteLayout.SetLayoutBounds(stsinine, new Rect(320, 220, 50, 30));

        AbsoluteLayout.SetLayoutBounds(btn, new Rect(10, 260, 360, 40));
        AbsoluteLayout.SetLayoutBounds(frame, new Rect(10, 310, 360, 220));

        Content = abs;

        slpunane.ValueChanged += Varv_ValueChanged;
        slroheline.ValueChanged += Varv_ValueChanged;
        slsinine.ValueChanged += Varv_ValueChanged;

        stpunane.ValueChanged += Varv_ValueChanged;
        stroheline.ValueChanged += Varv_ValueChanged;
        stsinine.ValueChanged += Varv_ValueChanged;
    }

    private void Varv_ValueChanged(object? sender, ValueChangedEventArgs e)
    {
        int punane = Convert.ToInt32(slpunane.Value);
        int roheline = Convert.ToInt32(slroheline.Value);
        int sinine = Convert.ToInt32(slsinine.Value);

        lblpunane.Text = $"Punane: {punane}";
        lblroheline.Text = $"Roheline: {roheline}";
        lblsinine.Text = $"Sinine: {sinine}";

        frame.BackgroundColor = Color.FromRgb(punane, roheline, sinine);
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

        stpunane.Value = rndpunane;
        stroheline.Value = rndroheline;
        stsinine.Value = rndsinine;

        frame.BackgroundColor = Color.FromRgb(rndpunane, rndsinine, rndroheline);

    }
}