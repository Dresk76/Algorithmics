using UnityEngine;

public class Methods : MonoBehaviour
{
    private void Start()
    {
        // 1. Método void sin parámetros:
        Saludar();

        // 2. Método con return:
        print("Tengo: " + SumarMonedas(3, 5) + " monedas");

        // 3. Método void con parámetros:
        ElegirColor("Rojo");

        // SUPER IMPORTANTE: Los argumentos se deben ingresar en el mismo orden que se solicitan
    }

    #region Metodo con void
    // Imagina un botón en un juego: lo presionas y algo mágico pasa, 
    // pero no le das datos ni esperas respuesta.
    private void Saludar()
    {
        print("¡Hola, soy un valiente caballero!");
    }
    #endregion

    #region Metodo con return
    // Imagina que los métodos con return son como máquinas expendedoras:
    // Les das algo (parámetros).
    // Hacen algo (código).
    // Te devuelven algo (resultado).
    private int SumarMonedas(int a, int b)
    {
        return a + b; // ¡Te devuelve la suma!
    }
    #endregion

    #region Metodo con parametros
    // Imagina que los métodos con parametros son como un pincel mágico: 
    // le dices que color usar y pinta exactamente como le indicaste
    private void ElegirColor(string color)
    {
        print("¡Has elegido el color " + color);
    }
    #endregion
}
