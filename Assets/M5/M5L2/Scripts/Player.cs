using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace M5L2
{
    public class Player : MonoBehaviour
    {
        public int points;
        public UIManager uiManager;
        public Projectile projectilePrefab;
        public Transform shootPoint;
        public float shootInterval = 0.5f;
        public float shootTimer;
        public float moveTime = 1.5f;
        private Vector3 startPos;
        private Vector3 targetPos;
        private float elapsedTime;
        private Spawner[] spawners;


        void Start()
        {
            startPos = transform.position;
            targetPos = new Vector3(startPos.x, startPos.y + 1f, startPos.z);
        }

        void Update()
        {
            Move();
            Shoot();
        }

        void Move()
        {
            if (elapsedTime < moveTime)
            {
                elapsedTime += Time.deltaTime;
                transform.position = Vector3.Lerp(startPos, targetPos, elapsedTime / moveTime);
            }

            if (Input.GetMouseButton(0))
            {
                Vector2 mousePos = Input.mousePosition;
                Vector2 realPos = Camera.main.ScreenToWorldPoint(mousePos);
                transform.position = realPos;
            }
        }

        void Shoot()
        {
            shootTimer -= Time.deltaTime;

            if (shootTimer <= 0)
            {
                Instantiate(projectilePrefab, shootPoint.position, Quaternion.identity);

                shootTimer = shootInterval;
            }
        }

        public void Dead()
        {
            uiManager.Restart();
            transform.position = startPos;

            foreach (var item in spawners)
            {
                item.Restart();
            }
        }
    }
}
