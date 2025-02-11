namespace AbsoluteLayoute_Lumememm;

public partial class StarPage : ContentPage
{
    public List<ContentPage> lehed = new List<ContentPage>() { new DateTimePage(1), new StepperSliderPage(1) };
    public List<string> tekstid = new List<string> { "Tee lahti DateTimePage", "Tee lahti StepperSliderPage" };

    ScrollView sv;
    VerticalStackLayout vsl;

    public StarPage()
    {
        Title = "Avaleht";
        vsl = new VerticalStackLayout { BackgroundColor = Color.FromArgb("#FFC0CB") };

        // Добавление кнопок для оставшихся страниц
        for (int i = 0; i < tekstid.Count; i++)
        {
            Button nupp = new Button
            {
                Text = tekstid[i],
                BackgroundColor = Color.FromArgb("#EE82EE"),
                TextColor = Color.FromArgb("#FF00FF"),
                BorderWidth = 10,
                ZIndex = i,
                FontFamily = "Luckymoon 400",
                FontSize = 30
            };
            vsl.Add(nupp);
            nupp.Clicked += Lehte_avamine;
        }

        // Скроллинг для вертикального стека
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
