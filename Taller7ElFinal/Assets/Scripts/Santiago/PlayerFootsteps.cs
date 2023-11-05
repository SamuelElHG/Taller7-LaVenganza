using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerFootsteps : MonoBehaviour
{
    public AudioSource walkAudioSource;
    public AudioSource runAudioSource;
    public AudioClip walkSound;
    public AudioClip runSound;
    private bool isRunning = false;

    private CharacterController characterController; // Agregar referencia al CharacterController

    private void Start()
    {
        characterController = GetComponent<CharacterController>(); // Obtener referencia al CharacterController
    }

    private void Update()
    {
        bool walking = Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.D);

        // Calcular la velocidad actual del personaje
        float playerSpeed = characterController.velocity.magnitude;

        if (walking)
        {
            if (isRunning)
            {
                runAudioSource.Stop();
                isRunning = false;
            }

            if (!walkAudioSource.isPlaying)
            {
                runAudioSource.Stop();
                walkAudioSource.clip = walkSound;
                walkAudioSource.pitch = 1.0f; // Velocidad normal al caminar
                walkAudioSource.Play();
            }
        }
        else if (playerSpeed > 0 && Input.GetKey(KeyCode.LeftShift))
        {
            if (!isRunning || !runAudioSource.isPlaying)
            {
                walkAudioSource.Stop(); // Detener el sonido de caminar
                runAudioSource.clip = runSound;
                runAudioSource.pitch = 1.5f; // Ajusta la velocidad al correr
                runAudioSource.Play();
                isRunning = true;
            }
        }
        else
        {
            walkAudioSource.Stop();
            runAudioSource.Stop();
            isRunning = false;
        }
    }
}
