using UnityEngine;

public class ConditionalIf : MonoBehaviour
{
    public string semaforo;
    public bool tareaTerminada;


    private void Start()
    {
        CheckTrafficLight();
        //CheckGame();
    }


    #region If

    private void CheckTrafficLight()
    {
        if (semaforo == "rojo")
        {
            print("¡El carro para!");
        }

        if (semaforo == "verde")
        {
            print("¡El carro avanza!");
        }
    }

    #endregion

    #region If-Else

    private void CheckGame()
    {
        if (tareaTerminada == true)
        {
            print("¡Puedes jugar!");
        }
        else
        {
            print("¡No puedes jugar!");
        }
    }

    #endregion
}
