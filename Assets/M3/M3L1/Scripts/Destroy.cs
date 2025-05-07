using UnityEngine;

public class Destroy : MonoBehaviour
{
    // Destruir un objeto al iniciar el juego
    private void Start()
    {
        Destroy(gameObject);
        print("Objeto destruido!");
    }
}
