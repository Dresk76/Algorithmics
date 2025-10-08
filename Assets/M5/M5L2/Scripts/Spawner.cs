using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefab;
    public Transform borderRight;
    public Transform borderLeft;
    public float spawnInterval = 1f;
    public float spawnTimer;
    private List<GameObject> objs = new();


    void Update()
    {
        spawnTimer -= Time.deltaTime;

        if (spawnTimer <= 0)
        {
            Spawn();
        }
    }

    void Spawn()
    {
        float randomX = Random.Range(borderLeft.position.x, borderRight.position.x);

        Vector2 newPosition = transform.position;
        newPosition.x = randomX;

        GameObject obj = Instantiate(prefab, newPosition, Quaternion.identity);
        objs.Add(obj);

        spawnTimer = spawnInterval;
    }

    public void Restart()
    {
        // Destruir todos los objetos instanciados
        foreach (GameObject obj in objs)
        {
            if (obj != null)
                Destroy(obj);
        }

        // Vaciar la lista
        objs.Clear();

        // Reiniciar el temporizador
        spawnTimer = spawnInterval;
    }
}
