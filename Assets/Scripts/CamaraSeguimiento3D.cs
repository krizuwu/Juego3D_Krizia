using UnityEngine;

public class CamaraSeguimiento3D : MonoBehaviour
{
    public Transform objetivo; 
    private Vector3 offset;    //  la distancia 

    void Start()
    {
        // Calculamos la distancia
        if (objetivo != null)
        {
            offset = transform.position - objetivo.position;
        }
    }

    void LateUpdate()
    {
        if (objetivo != null)
        {
            // La cámara sigue a la esfera en X y Y, pero dejamos su propia Z intacta
            transform.position = new Vector3(
                objetivo.position.x + offset.x, 
                objetivo.position.y + offset.y, 
                transform.position.z 
            );
        }
    }
}