using UnityEngine;
using UnityEngine.SceneManagement; //  para cambiar escenas

public class ControladorMenu : MonoBehaviour
{
    public void BotonJugar()
    {
        // Le decimos a Unity que cargue exactamente la escena 
        SceneManager.LoadScene("Nivel1"); 
    }
}