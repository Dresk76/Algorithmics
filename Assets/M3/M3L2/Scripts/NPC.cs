using UnityEngine;

public class NPC : MonoBehaviour
{
    // Salud de los NPC
    int health = 5;

    // Nivel de los NPC
    int level = 5;


    void Start()
    {
        // Al inicio de la partida, se actualiza la salud del NPC
        health = level;

        // Enviar el valor de salud a la consola para verificar que el cálculo es correcto.
        print("Salud del NPC actualizada: " + health);
    }
}
