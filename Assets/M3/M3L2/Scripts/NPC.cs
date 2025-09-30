using UnityEngine;

public class NPC : MonoBehaviour
{
    // Salud de los NPC
    int health = 5;

    // Nivel de los NPC
    int level = 10;

    // Velocidad de los NPC
    public float velocity = 1.2f;


    void Start()
    {
        // Al inicio de la partida, se actualiza la salud del NPC
        health = level;

        // Enviar el valor de salud a la consola para verificar que el cálculo es correcto.
        print("Salud del NPC actualizada: " + health);
    }

    void Update()
    {
        // Crear un Vector3 para almacenar la nueva posición
        Vector3 newPosition = transform.position;

        // Modificar la posición en el eje Z según la velocidad y el tiempo entre fotogramas
        newPosition.z += velocity * Time.deltaTime;

        // Actualizar la posición del NPC
        transform.position = newPosition;
    }
}
