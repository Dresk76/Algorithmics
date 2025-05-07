using UnityEngine;

public class Methods : MonoBehaviour
{
    private void Start()
    {
        Greet(); // Llamar el metodo void
        print("Tengo: " + GetGoldCoins() + " monedas"); // Llamar el metodo void con return
        AddPoints("Ganaste", 5); // Llamar el metodo con parametros
    }

    #region Ejemplo de un metodo
    private void Greet()
    {
        print("¡Hola, soy un valiente caballero!"); 
    }
    #endregion

    #region Ejemplo de un metodo con return
    private int GetGoldCoins()
    {
        int coins = 10;
        return coins;
    }
    #endregion

    #region Ejemplo de un metodo con parametros
    private void AddPoints(string winText, int pointsEarned)
    {
        int totalPoints = 5;
        totalPoints += pointsEarned;
        print(winText + " " + pointsEarned + " puntos! Ahora tienes: " + totalPoints);
    }
    #endregion
}
