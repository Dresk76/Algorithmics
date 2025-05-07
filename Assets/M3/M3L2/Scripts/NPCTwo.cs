using UnityEngine;

public class NPCTwo : MonoBehaviour
{
    public float velocity = 1.2f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
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
