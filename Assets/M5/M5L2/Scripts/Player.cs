using UnityEngine;

namespace M5L2
{
    public class Player : MonoBehaviour
    {
        public int points;

        #region Pag 77
        public Projectile projectilePrefab;
        #endregion

        #region Pag 79
        public float shootInterval = 0.5f;
        public float shootTimer;
        #endregion

        #region Pag 86
        public Transform shootPoint;
        #endregion

        void Update()
        {
            Move();
            Shoot();
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

        #region Pag 77
        // void Shoot()
        // {
        //     Instantiate(projectilePrefab, transform.position, Quaternion.identity);
        // }
        #endregion

        #region Pag 79
        // void Shoot()
        // {
        //     shootTimer -= Time.deltaTime;

        //     if (shootTimer <= 0)
        //     {
        //         Instantiate(projectilePrefab, transform.position, Quaternion.identity);

        //         shootTimer = shootInterval;
        //     }
        // }
        #endregion
        
        #region Pag 86
        void Shoot()
        {
            shootTimer -= Time.deltaTime;

            if (shootTimer <= 0)
            {
                Instantiate(projectilePrefab, shootPoint.position, Quaternion.identity);

                shootTimer = shootInterval;
            }
        }
        # endregion
    }
}
