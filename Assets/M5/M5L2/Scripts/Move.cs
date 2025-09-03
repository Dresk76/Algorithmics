using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace M5L2
{
    public class Move : MonoBehaviour
    {
        public float speed = 2f;


        void Start()
        {
            Destroy(gameObject, 5f);
        }

        void Update()
        {
            transform.position = (Vector2)transform.position + speed * Time.deltaTime * Vector2.down;
        }
    }
}
