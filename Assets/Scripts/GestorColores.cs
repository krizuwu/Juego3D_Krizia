using UnityEngine;

public class GestorColores : MonoBehaviour
{
    public Camera camaraPrincipal;
    public Material materialJugador;

    // Listas de colores que podrás configurar libremente en Unity
    public Color[] paletaFondo;
    public Color[] paletaJugador;

    void Start()
    {
        // Cambiar el color del fondo al azar
        if (camaraPrincipal != null && paletaFondo.Length > 0)
        {
            int colorAzar = Random.Range(0, paletaFondo.Length);
            camaraPrincipal.backgroundColor = paletaFondo[colorAzar];
        }

        // Cambiar el color de tu personaje al azar
        if (materialJugador != null && paletaJugador.Length > 0)
        {
            int colorAzar = Random.Range(0, paletaJugador.Length);
            materialJugador.color = paletaJugador[colorAzar];
        }
    }
}