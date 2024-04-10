namespace TipTime
{
    public partial class MainPage : ContentPage
    {
        int count = 0;

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnBtn15_Clicked(object sender, EventArgs e)
        {
            TipPercentOut.Text = "15%";
            TipSlider.Value = 15;
        }

        private void OnBtn30_Clicked(object sender, EventArgs e)
        {
            TipPercentOut.Text = "30%";
            TipSlider.Value = 30;
        }

        private void OnRoundUp_Clicked(object sender, EventArgs e)
        {
            double valorRefeicao = Convert.ToDouble(ValueEntry.Text);
            double valorSlider = Convert.ToDouble(TipSlider.Value);
            double valorGorjeta = valorRefeicao * (valorSlider / 100);
            valorGorjeta = Math.Ceiling(valorGorjeta);
            double sliderValueOut = Math.Ceiling(valorSlider);
            double totalRefeicao = valorRefeicao + valorGorjeta;

            TipOut.Text = "$" + valorGorjeta.ToString();
            TotalOut.Text = "$" + totalRefeicao.ToString();
            TipSlider.Value = sliderValueOut;

        }

        private void OnRoundDown_Clicked(object sender, EventArgs e)
        {
            double valorRefeicao = Convert.ToDouble(ValueEntry.Text);
            double valorSlider = Convert.ToDouble(TipSlider.Value);
            double valorGorjeta = valorRefeicao * (valorSlider / 100);
            valorGorjeta = Math.Floor(valorGorjeta);
            double sliderValueOut = Math.Floor(valorSlider);
            double totalRefeicao = valorRefeicao + valorGorjeta;

            TipOut.Text = "$" + valorGorjeta.ToString();
            TotalOut.Text = "$" + totalRefeicao.ToString();
            TipSlider.Value = sliderValueOut;
        }

        private void OnTipSlider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            double sliderValue = TipSlider.Value;
            string sliderValueOut = sliderValue.ToString() + "%";
            double porcentagemOut = Math.Round(sliderValue, 2);
            TipPercentOut.Text = porcentagemOut.ToString() + "%";

            double valorRefeicao = Convert.ToDouble(ValueEntry.Text);
            double valorGorjeta = valorRefeicao * (sliderValue / 100);
            valorGorjeta = Double.Round(valorGorjeta);
            double totalRefeicao = valorRefeicao + valorGorjeta;

            TipOut.Text = "$" + valorGorjeta.ToString();
            TotalOut.Text = "$" + totalRefeicao.ToString();


        }
    }

}

