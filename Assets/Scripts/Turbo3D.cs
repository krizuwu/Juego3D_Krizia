using UnityEngine;

public class Turbo3D : MonoBehaviour
{
    void OnTriggerEnter(Collider choque)
    {
        if (choque.gameObject.name == "Jugador")
        {
            Movimiento3D mov = choque.gameObject.GetComponent<Movimiento3D>();
            if (mov != null)
            {
                mov.ActivarSuperVelocidad(); // Dispara el evento
            }
            Destroy(gameObject); // El turbo desaparece al tocarlo
        }
    }
}