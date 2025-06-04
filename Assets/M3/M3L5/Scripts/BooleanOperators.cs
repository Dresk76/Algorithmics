using UnityEngine;

public class BooleanOperators : MonoBehaviour
{
    public bool thisJump = true;

    void Start()
    {
        if (thisJump == true)
        {
            print("¡El jugador está en el aire!");
        }
        else
        {
            print("¡El jugador está en el suelo!");
        }
    }
}
