using UnityEngine;

public class Punto3D : MonoBehaviour
{
    void OnTriggerEnter(Collider choque)
    {
        if (choque.gameObject.name == "Jugador") // Verifica que sea exactamente el Jugador
        {
            GestorPuntos gestor = Object.FindFirstObjectByType<GestorPuntos>(); // Busca tu contador de puntos
            if (gestor != null)
            {
                gestor.SumarPunto(1); // Manda a sumar el punto a la UI
            }
            Destroy(gameObject); // Desaparece el cubo al tocarlo
        }
    }
}