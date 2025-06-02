using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float velocity = 5f;

    void Update()
    {
        // Movimiento con teclas
        Move();
    }

    private void Move()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 moveDirection = new(horizontalInput, 0, verticalInput);
        moveDirection.Normalize();

        transform.Translate(Time.deltaTime * velocity * moveDirection);
    }

    private void Jump()
    {
        // Codigo para saltar
    }
}
