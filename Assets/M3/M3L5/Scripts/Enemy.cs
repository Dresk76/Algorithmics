using UnityEngine;

namespace M3L5
{
    public class Enemy : MonoBehaviour
    {
        public float speed = 1.5f;
        public Transform target;
        public int playerDamage = 2;

        private void Update()
        {
            // Cambia la posición del personaje a una nueva en cada fotograma
            transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            
            // Gira al personaje cada fotograma para que mire al objetivo
            transform.LookAt(target.position);
        }
        
        private void OnTriggerEnter(Collider other)
        {
            // Guardar la referencia al player
            Player player = other.GetComponent<Player>();

            // Verificar si el objeto con el que colisiona tiene el componente Player
            if (player)
            {
                player.TakeDamage(playerDamage);
            }
        }
    }
}