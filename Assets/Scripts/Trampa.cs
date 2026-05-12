using UnityEngine;
using UnityEngine.SceneManagement; // Necesario para reiniciar el nivel

public class Trampa : MonoBehaviour
{
    // Usamos OnCollisionEnter para detectar cuando choca físicamente
    void OnCollisionEnter(Collision choque)
    {
        if (choque.gameObject.name == "Jugador")
        {
            // ¡El bucle al perder! Recarga la escena actual desde cero
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}