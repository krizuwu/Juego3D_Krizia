using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement; 

public class GestorPuntos : MonoBehaviour
{
    public int score = 0;
    public int highScore = 0;
    
    public TextMeshProUGUI textoScore;
    public TextMeshProUGUI textoHighScore;

    [Header("Configuración de Nivel")]
    public string nombreSiguienteNivel = "Nivel2"; 
    public int puntosParaGanar = 5; 

    void Start()
    {
        highScore = PlayerPrefs.GetInt("HighScore", 0);
        ActualizarTextos();
    }

    public void SumarPunto(int cantidad)
    {
        score += cantidad;
        
        Movimiento3D mov = Object.FindFirstObjectByType<Movimiento3D>();
        if(mov != null) {
            mov.velocidad += 0.5f;
        }

        if (score > highScore)
        {
            highScore = score;
            PlayerPrefs.SetInt("HighScore", highScore);
            PlayerPrefs.Save();
        }
        
        ActualizarTextos();

        // REVISAR SI GANAMOS EL NIVEL
        if (score >= puntosParaGanar)
        {
            SceneManager.LoadScene(nombreSiguienteNivel);
        }
    }

    void ActualizarTextos()
    {
        textoScore.text = "Score: " + score;
        textoHighScore.text = "High Score: " + highScore;
    }
}