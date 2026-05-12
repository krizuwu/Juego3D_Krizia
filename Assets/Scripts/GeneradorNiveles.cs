using UnityEngine;

public class GeneradorNiveles : MonoBehaviour
{
    public GameObject moldeTramo; // Tu Prefab
    public Transform jugador; 
    
    // Criterio de evaluación: Distancia configurable por el desarrollador
    public float distanciaEntreNiveles = 10f; 
    public int tramosEnPantalla = 5;

    private float posicionZActual = 0f;

    void Start()
    {
        // Generamos los primeros pedazos de calle al arrancar
        for (int i = 0; i < tramosEnPantalla; i++)
        {
            GenerarTramo();
        }
    }

    void Update()
    {
        // Si el jugador avanza y se acerca al final, generamos más pista
        if (jugador.position.z > (posicionZActual - (tramosEnPantalla * distanciaEntreNiveles)))
        {
            GenerarTramo();
        }
    }

    void GenerarTramo()
    {
        // Clonamos el molde en la posición Z que toca
        Instantiate(moldeTramo, new Vector3(0, 0, posicionZActual), Quaternion.identity);
        posicionZActual += distanciaEntreNiveles; // Sumamos la distancia configurable
    }
}