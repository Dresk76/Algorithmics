using UnityEngine;

public class ConditionalIf : MonoBehaviour
{
    public bool isRaining; // false
    public int health = 15;
    public int coinsPlayer = 12;


    private void Start()
    {
        //CheckRainfall();
        TakeDamage();
    }


    #region If

    private void CheckRainfall()
    {
        if (isRaining == true)
        {
            print("Esta lloviendo");
        }

        // if (isRaining)
        // {
        //     print("Esta lloviendo");
        // }

        if (isRaining == false)
        {
            print("No esta lloviendo");
        }

        // if (!isRaining)
        // {
        //     print("No esta lloviendo");
        // }
    }

    #endregion

    #region If-Else

    private void TakeDamage()
    {
        if (health >= 13) // 15 >= 13
        {
            print("Reducir numero de vidas.");
        }
        else
        {

        }
    }

    #endregion



    private void Test()
    {
        
    }
}
