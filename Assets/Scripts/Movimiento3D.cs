using UnityEngine;
using System.Collections;

public class Movimiento3D : MonoBehaviour
{
    public float velocidad = 5f;
    private Rigidbody rb;
    private TrailRenderer estela;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        estela = GetComponent<TrailRenderer>(); 
    }

    void FixedUpdate()
    {
        float movX = Input.GetAxis("Horizontal");
        float movZ = Input.GetAxis("Vertical");

        Vector3 movimiento = new Vector3(movX * velocidad, rb.linearVelocity.y, movZ * velocidad);
        rb.linearVelocity = movimiento;
    }

    public void ActivarSuperVelocidad()
    {
        StartCoroutine(RutinaTurbo());
    }

    IEnumerator RutinaTurbo()
    {
        velocidad += 15f; 
        if(estela != null) estela.emitting = true;

        yield return new WaitForSeconds(3f);

        velocidad -= 15f;
        if(estela != null) estela.emitting = false;
    }
}