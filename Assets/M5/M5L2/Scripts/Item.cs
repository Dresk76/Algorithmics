using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace M5L2
{
    public class Item : MonoBehaviour
    {
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.tag == "Player")
            {
                Player player = collision.GetComponent<Player>();
                player.points++;
                Destroy(this.gameObject);

                Debug.Log("Entro en Item");
            }
        }
    }
}
