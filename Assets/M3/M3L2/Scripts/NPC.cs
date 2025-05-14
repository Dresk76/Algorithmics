using UnityEngine;

public class NPC : MonoBehaviour
{
    // Salud de los NPC
    int health = 5;

    // Nivel de los NPC
    int level = 5;

    // Velocidad de los NPC
    float velocity = 2.5f;


    // Start is called before the first frame update
    void Start()
    {
        // Al inicio de la partida, se actualiza la salud del NPC
        health = level;

        // Enviar el valor de salud a la consola para verificar que el cálculo es correcto.
        print("Salud del NPC actualizada: " + health);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
