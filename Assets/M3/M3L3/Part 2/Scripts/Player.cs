using UnityEngine;

public class Player : MonoBehaviour
{
    private void Update()
    {
        float movX = Input.GetAxis("Horizontal") * 5f * Time.deltaTime; // Movimiento horizontal
        float movZ = Input.GetAxis("Vertical") * 5f * Time.deltaTime;   // Movimiento vertical
        transform.Translate(movX, 0, movZ); // Aplica el movimiento
    }
}
