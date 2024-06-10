namespace Practica04Cubo;

public partial class Entero : ContentPage
{
	public Entero()
	{
		InitializeComponent();
	}
    private void OnSquareClicked(object sender, EventArgs e)
    {
        try
        {
            int number = int.Parse(NumberEntry.Text);

            if (number < 0)
            {
                Resultado.Text = "Por favor, ingrese un número entero positivo.";
            }
            else
            {
                int square = number * number;
                Resultado.Text = $"El cuadrado de {number} es {square}.";
            }
        }
        catch (FormatException)
        {
            Resultado.Text = "Por favor, ingrese un número válido.";
        }
    }
    private void OnCubeClicked(object sender, EventArgs e)
    {
        try
        {
            int number = int.Parse(NumberEntry.Text);

            if (number < 0)
            {
                Resultado.Text = "Por favor, ingrese un número entero positivo.";
            }
            else
            {
                int cube = number * number * number;
                Resultado.Text = $"El cubo de {number} es {cube}.";
            }
        }
        catch (FormatException)
        {
            Resultado.Text = "Por favor, ingrese un número válido.";
        }
    }

}