using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public Transform target;
    public int playerDamage = 2;

    private void Update()
    {
        // Cambia la posición del personaje a una nueva en cada fotograma
        transform.position = Vector3.MoveTowards(
            transform.position, 
                   target.position, speed * Time.deltaTime);
        
        // Gira al personaje cada fotograma para que mire al objetivo
        transform.LookAt(target.position);
    }
    
    private void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<Player>();
        player.TakeDamage(playerDamage);
    }
}
