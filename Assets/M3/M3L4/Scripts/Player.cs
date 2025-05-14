using UnityEngine;

namespace M3L4
{
    public class Player : MonoBehaviour
    {
        public int health = 10;
        public GameObject fireballPrefab;
        public Transform attackPoint;
        public int coins;


        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
            }
        }

        public void TakeDamage(int damage)
        {
            //Actualización de los puntos de vida del jugador
            health -= damage; // 8

            print("Salud Actual del Jugador: " + health);
        }


        // Metodo para aumentar las monedas que tiene el player
        public void CollectCoins()
        {
            coins++;
        }
    }
}
