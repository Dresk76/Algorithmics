using UnityEngine;

namespace M3L4
{
    public class Coin : MonoBehaviour
    {
        void OnTriggerEnter(Collider other)
        {
            // Guardar la referencia al player
            Player player = other.GetComponent<Player>();

            // Llama al método que suma una moneda al jugador
            player.CollectCoins();

            // Destruye este objeto de moneda
            Destroy(gameObject);
        }
    }
}