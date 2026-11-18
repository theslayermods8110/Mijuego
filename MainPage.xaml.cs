namespace Mijuego;

public partial class MainPage : ContentPage
{
    int puntos = 0;

    public MainPage()
    {
        InitializeComponent();
    }

    private void OnJugarClicked(object sender, EventArgs e)
    {
        puntos++;
        PuntosLabel.Text = $"Puntos: {puntos}";

        int nivel = (puntos / 10) + 1;
        NivelLabel.Text = $"Nivel: {nivel}";

        if (puntos == 10)
            JugarBtn.Text = "¡VAS BIEN!";
        else if (puntos == 20)
            JugarBtn.Text = "¡ERES UNA BESTIA!";
        else if (puntos == 50)
            JugarBtn.Text = "¡IMPARABLE!";
    }

    private void OnReiniciarClicked(object sender, EventArgs e)
    {
        puntos = 0;
        PuntosLabel.Text = "Puntos: 0";
        NivelLabel.Text = "Nivel: 1";
        JugarBtn.Text = "¡TOCAME!";
    }
}
