using UnityEngine;

public class CharacterAnim : MonoBehaviour
{
    public Animator animator;
    int isWalkingHash, isRunningHash; // Se pueden declarar varias variables del mismo tipo en una sola línea

    void Start()
    {
        // Convierte el nombre del parámetro en un número para que el juego funcione más rápido
        isWalkingHash = Animator.StringToHash("isWalking");
        isRunningHash = Animator.StringToHash("isRunning");
    }

    void Update()
    {
        // Revisa si los parámetros de caminar o correr están activados en el sistema de animaciones
        bool isRunning = animator.GetBool(isRunningHash);
        bool isWalking = animator.GetBool(isWalkingHash);

        // Revisa si el jugador está presionando la tecla W (caminar hacia adelante) o Shift (para correr)
        bool forwardPressed = Input.GetKey(KeyCode.W);
        bool runPressed = Input.GetKey(KeyCode.LeftShift);

        // Activa la animación de caminar si se presiona W y el personaje no estaba caminando
        if (!isWalking && forwardPressed)
        {
            animator.SetBool("isWalking", true);
        }

        // Apaga la animación de caminar si se deja de presionar W
        if (isWalking && !forwardPressed)
        {
            animator.SetBool("isWalking", false);
        }

        // Activa la animación de correr si se presiona W y Shift al mismo tiempo, y el personaje no estaba corriendo
        if (!isRunning && forwardPressed && runPressed)
        {
            animator.SetBool("isRunning", true);
        }

        // Apaga la animación de correr si se deja de presionar W o Shift
        if (isRunning && (!forwardPressed || !runPressed))
        {
            animator.SetBool("isRunning", false);
        }
    }
}
