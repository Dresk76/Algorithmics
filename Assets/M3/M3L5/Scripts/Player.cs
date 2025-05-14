using UnityEngine;
using UnityEngine.SceneManagement;

namespace M3L5
{
    public class Player : MonoBehaviour
    {
        public int health = 10;
        public GameObject fireballPrefab;
        public Transform attackPoint;
        public int coins;
        public AudioSource audioSource;
        public AudioClip damageSound;


        private void Update()
        {
            if (Input.GetMouseButtonDown(0))
            {
                Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
            }
        }

        public void TakeDamage(int damage)
        {
            //Actualizar los puntos de vida del jugador en función del daño
            health -= damage; // 8

            if (health > 0) // 8 > 0
            {
                //Reproducir el sonido de recibir daño
                audioSource.PlayOneShot(damageSound);
            }
            else
            {
                //Obtener el índice de la escena actual y reiniciarla
                int sceneIndex = SceneManager.GetActiveScene().buildIndex;
                SceneManager.LoadScene(sceneIndex);
            }

            print("Salud Actual del Jugador: " + health);
        }


        // Metodo para aumentar las monedas que tiene el player
        public void CollectCoins()
        {
            coins++;
        }
    }
}
