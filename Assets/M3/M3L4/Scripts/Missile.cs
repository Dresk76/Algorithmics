using UnityEngine;

namespace M3L4
{
    public class Missile : MonoBehaviour
    {
        public float speed = 3.5f;
        private Transform enemy;


        void Start()
        {
            // Busca el primer objeto con la etiqueta "Enemy" y obtiene su Transform
            enemy = GameObject.FindWithTag("Enemy").GetComponent<Transform>();

            // Destruye este objeto de juego después de 3 segundos
            Destroy(gameObject, 3f);
        }

        void Update()
        {
            // Calcula la dirección hacia el enemigo y la normaliza
            Vector3 direction = (enemy.position - transform.position).normalized;

            // Mueve el misil hacia el enemigo en cada frame
            transform.position += speed * Time.deltaTime * direction;
        }

        // other: contiene información sobre el objeto con el que colisionamos
        void OnTriggerEnter(Collider other)
        {
            // Guardar la referencia al enemigo
            Enemy enemy = other.GetComponent<Enemy>();

            // Verificar si el objeto con el que colisiona tiene el componente Enemy
            if (enemy)
            {
                // Destruye el objeto enemigo
                Destroy(enemy.gameObject);

                // Destruye este misil (gameObject referencia al GameObject actual)
                Destroy(gameObject);
            }
        }
    }
}
