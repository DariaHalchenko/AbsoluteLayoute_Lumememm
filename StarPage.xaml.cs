namespace AbsoluteLayoute_Lumememm;

public partial class StarPage : ContentPage
{
    public List<ContentPage> lehed = new List<ContentPage>() { new DateTimePage(1), new StepperSliderPage(1), new RGB_mudeliPage(1), new LumememmPage(1)};
    public List<string> tekstid = new List<string> { "Tee lahti DateTimePage", "Tee lahti StepperSliderPage", "Tee lahti RGB_mudeli", "Tee lahti LumememmPage" };

    ScrollView sv;
    VerticalStackLayout vsl;

    public StarPage()
    {
        Title = "Avaleht";
        vsl = new VerticalStackLayout { BackgroundColor = Color.FromArgb("#9370DB") };

        for (int i = 0; i < tekstid.Count; i++)
        {
            Button nupp = new Button
            {
                Text = tekstid[i],
                BackgroundColor = Color.FromArgb("#BA55D3"),
                TextColor = Color.FromArgb("#800080"),
                BorderWidth = 10,
                ZIndex = i,
                FontFamily = "Luckyfield 400",
                FontSize = 25
            };
            vsl.Add(nupp);
            nupp.Clicked += Lehte_avamine;
        }

     
        sv = new ScrollView { Content = vsl };
        Content = sv;
    }

    private async void Lehte_avamine(object? sender, EventArgs e)
    {
        Button btn = (Button)sender;
        await Navigation.PushAsync(lehed[btn.ZIndex]);
    }

    private async void Tagasi_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new MainPage());
    }
}
