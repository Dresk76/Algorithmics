using UnityEngine;

namespace M3L7
{
    public class Player : MonoBehaviour
    {
        public float velocity = 5f;
        public Color normalColor;
        public Color specialColor;
        private MeshRenderer meshRenderer;

        void Start()
        {
            meshRenderer = GetComponent<MeshRenderer>();
            meshRenderer.material.color = normalColor;
        }
        
        void Update()
        {
            // Movimiento con teclas
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");

            Vector3 moveDirection = new(horizontalInput, 0, verticalInput);
            moveDirection.Normalize();

            transform.Translate(Time.deltaTime * velocity * moveDirection);
            
            // Cambiar color al presionar ESPACIO
            if (Input.GetKeyDown(KeyCode.Space))
            {
                meshRenderer.material.color = specialColor;
            }
            
            // Volver al color normal al soltar ESPACIO
            if (Input.GetKeyUp(KeyCode.Space))
            {
                meshRenderer.material.color = normalColor;
            }
        }
    }
}
