using UnityEngine;

namespace M5L2
{
    public class Player : MonoBehaviour
    {
        public int points;


        void Start()
        {

        }

        void Update()
        {
            Move();
        }

        void Move()
        {
            if (Input.GetMouseButton(0))
            {
                Vector2 mousePos = Input.mousePosition;
                Vector2 realPos = Camera.main.ScreenToWorldPoint(mousePos);
                transform.position = realPos;
            }
        }
    }
}
