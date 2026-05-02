using UnityEngine;

public class Movimiento3D : MonoBehaviour
{
    public float velocidad = 5f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float movX = Input.GetAxis("Horizontal");
        float movZ = Input.GetAxis("Vertical");

        // Movimiento en X y Z. La Y se queda con la gravedad del Rigidbody
        Vector3 movimiento = new Vector3(movX * velocidad, rb.linearVelocity.y, movZ * velocidad);
        rb.linearVelocity = movimiento;
    }
}