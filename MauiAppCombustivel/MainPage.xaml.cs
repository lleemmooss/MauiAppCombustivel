namespace MauiAppCombustivel
{
    public partial class MainPage : ContentPage
    {
        

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            try
            {
                double etanol = Convert.ToDouble(txt_etanol.Text);
                double gasolina = Convert.ToDouble(txt_gasolina.Text);
                string msg = "";
                if (etanol < 0.7 * gasolina) 
                {
                    msg = "O etanol está compensando";
                }
                else 
                {
                    msg = "A gasolina está compensando";
                }
                DisplayAlert("Calculado", msg, "Fechar");
            }
            catch (Exception ex) 
            {
                DisplayAlert("Ops!", ex.Message, "Fechar");
            }

        }
    }

}
