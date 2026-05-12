using UnityEngine;
using TMPro; // Necesario para los textos de la interfaz

public class GestorPuntos : MonoBehaviour
{
    public int score = 0;
    public int highScore = 0;
    
    public TextMeshProUGUI textoScore;
    public TextMeshProUGUI textoHighScore;

    void Start()
    {
        // 1. GUARDADO DE DATOS: Cargamos el HighScore desde la memoria del celular/compu
        highScore = PlayerPrefs.GetInt("HighScore", 0);
        ActualizarTextos();
    }

    public void SumarPunto(int cantidad)
    {
        score += cantidad;
        
        // 2. CURVA DE DIFICULTAD PROGRESIVA: 
        // Buscamos a tu jugador y le subimos la velocidad cada vez que anota
        Movimiento3D mov = Object.FindFirstObjectByType<Movimiento3D>();
        if(mov != null) {
            mov.velocidad += 0.5f; // ¡Se vuelve más rápida y difícil de controlar!
        }

        // 3. GUARDADO DE DATOS: Revisamos si rompimos el récord
        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("HighScore", highScore);
            PlayerPrefs.Save(); // Guardamos en la memoria
        }
        
        ActualizarTextos();
    }

    void ActualizarTextos()
    {
        textoScore.text = "Score: " + score;
        textoHighScore.text = "High Score: " + highScore;
    }
}
