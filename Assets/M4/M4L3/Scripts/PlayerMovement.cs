using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float runSpeed = 3f;
    public float rotationSpeed = 50f;
    public Animator animator;
    private float moveX;
    private float moveZ;

    void Update()
    {
        moveX = Input.GetAxis("Horizontal");
        moveZ = Input.GetAxis("Vertical");

        transform.Rotate(0, moveX * Time.deltaTime * rotationSpeed, 0); // X = 0 | Y = Nos movemos | Z = 0

        transform.Translate(0, 0, moveZ * Time.deltaTime * runSpeed); // X = 0 | Y = 0 | Z = Nos movemos

        animator.SetFloat("VelX", moveX);
        animator.SetFloat("VelZ", moveZ);
    }





    #region SEGUNDA PARTE
    //animator.SetFloat("VelX", moveX);
    //animator.SetFloat("VelZ", moveZ);
    #endregion
}
