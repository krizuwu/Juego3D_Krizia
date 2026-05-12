using UnityEngine;

public class Punto3D : MonoBehaviour
{
    // Usamos OnTriggerEnter igual que en 2D, pero sin el "2D" al final de la palabra
    void OnTriggerEnter(Collider choque)
    {
        if (choque.gameObject.name == "Jugador")
        {
            GestorPuntos gestor = Object.FindFirstObjectByType<GestorPuntos>();
            if (gestor != null)
            {
                gestor.SumarPunto(1);
            }
            Destroy(gameObject); // El cubo desaparece al tocarlo
        }
    }
}
