namespace kosci
{
    public partial class MainPage : ContentPage
    {
        public int suma_calkowita=0;
        public int suma = 0;
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Random rzut = new Random();
            int[] dice_value = new int[5];

            int wartosc_kostki = rzut.Next(1, 7);
            kosc1.Source = "kosc"+ wartosc_kostki + ".png";
            dice_value[0] = wartosc_kostki;

            wartosc_kostki = rzut.Next(1, 7);
            kosc2.Source = "kosc" + wartosc_kostki + ".png";
            dice_value[1] = wartosc_kostki;

            wartosc_kostki = rzut.Next(1, 7);
            kosc3.Source = "kosc" + wartosc_kostki + ".png";
            dice_value[2] = wartosc_kostki;

            wartosc_kostki = rzut.Next(1, 7);
            kosc4.Source = "kosc" + wartosc_kostki + ".png";
            dice_value[3] = wartosc_kostki;

            wartosc_kostki = rzut.Next(1, 7);
            kosc5.Source = "kosc" + wartosc_kostki + ".png";
            dice_value[4] = wartosc_kostki;

            int ile = 0;

            for (int z = 1; z <= 6; z++)
            {
                for (int j = 0; j < dice_value.Length; j++)
                {
                    if (dice_value[j] == z)
                    {
                        ile += 1;
                    }
                }
                if (ile > 1)
                {
                    suma += z * ile;
                }
                ile = 0;
            }
            suma_calkowita=suma_calkowita+suma;
            losowanie.Text = "Wynik tego losowania: "+suma;
            wynik.Text = "Wynik gry: " + suma_calkowita;
            suma = 0;
        }
        private void Reset(object sender, EventArgs e)
        {
            suma_calkowita = 0;
            kosc1.Source = "kosc0.png";
            kosc2.Source = "kosc0.png";
            kosc3.Source = "kosc0.png";
            kosc4.Source = "kosc0.png";
            kosc5.Source = "kosc0.png";
            losowanie.Text = "Wynik tego losowania: " + suma;
            wynik.Text = "Wynik gry: " + suma_calkowita;
        }
    }
}
