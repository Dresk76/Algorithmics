using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Serialization;

public class Player : MonoBehaviour
{
    public int health = 10;
    public CharacterController controller;
    public float moveSpeed = 2f;
    private Vector3 direction;
    //public AudioSource audioSource;
    //public AudioClip damageSound;


    private void Update()
    {
        direction = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        controller.Move(direction * (Time.deltaTime * moveSpeed));
    }

    public void TakeDamage(int damage)
    {
        //Actualización de los puntos de vida del jugador en función del daño
        health -= damage; // 8

        if (health > 0) // 8 > 0
        {
            //Reproduciendo el sonido de recibir daño
            //audioSource.PlayOneShot(damageSound);
            print("Reproducir sonido");
        }
        else
        {
            //Obtener el índice de la escena actual y reiniciarla
            int sceneIndex = SceneManager.GetActiveScene().buildIndex;
            SceneManager.LoadScene(sceneIndex);
        }

        print("Salud del jugador: " + health);
    }
}
