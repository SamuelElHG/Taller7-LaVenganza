using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using UnityEngine.UI;

public class InteractablePlank : MonoBehaviour
{
    public ChangeTextPlank changeTextPlank;

    public float interactionRange;
    public GameObject interactable0;
    public GameObject destroyableObs0;
    public GameObject Plank0;
    public GameObject interactable1;
    public GameObject destroyableObs1;
    public GameObject Plank1;
    public GameObject interactable2;
    public GameObject destroyableObs2;
    public GameObject Plank2;
    public GameObject interactable3;
    public GameObject destroyableObs3;
    public GameObject Plank3;
    public int plankCount = 0;

    [SerializeField] AudioSource soundInteractable0;
    [SerializeField] AudioSource soundInteractable1;
    [SerializeField] AudioSource soundInteractable2;
    [SerializeField] AudioSource soundInteractable3;

    [SerializeField] AudioSource soundDestroyable0;
    [SerializeField] AudioSource soundDestroyable1;
    [SerializeField] AudioSource soundDestroyable2;
    [SerializeField] AudioSource soundDestroyable3;

    bool soundPlayedInteractable0 = false;
    bool soundPlayedInteractable1 = false;
    bool soundPlayedInteractable2 = false;
    bool soundPlayedInteractable3 = false;

    bool soundPlayedDestroyable0 = false;
    bool soundPlayedDestroyable1 = false;
    bool soundPlayedDestroyable2 = false;
    bool soundPlayedDestroyable3 = false;


    internal float GetValue()
    { 
        return plankCount;
    }

    void Update()
    {
        // Verifica si el botón "F" ha sido presionado.
        if (Input.GetKeyDown(KeyCode.F))
        {
            // Realiza un raycast desde la posición del jugador en la dirección hacia adelante.
            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit hit;
            // Realiza el raycast y verifica si ha golpeado algo dentro del rango de interacción.
            if (Physics.Raycast(ray, out hit, interactionRange))
            {
                if(hit.collider.CompareTag("Interactable"))
                {
                    if (plankCount == 0)
                    {
                        Destroy(interactable0);
                        plankCount++;
                        changeTextPlank.UpdateText(plankCount.ToString());
                        if(soundPlayedInteractable0 == false)
                        {
                            soundInteractable0.Play();
                        }
                        if(soundInteractable0 == true)
                        {
                            Debug.Log(soundPlayedInteractable0);
                        }
                    }
                    else if (plankCount == 1)
                    {
                        Destroy(interactable1);
                        plankCount++;
                        changeTextPlank.UpdateText(plankCount.ToString());
                        if (soundPlayedInteractable1 == false)
                        {
                            soundInteractable1.Play();
                        }
                        if (soundInteractable1 == true)
                        {
                            Debug.Log(soundPlayedInteractable1);
                        }
                    }
                    else if (plankCount == 2)
                    {
                        Destroy(interactable2);
                        plankCount++;
                        changeTextPlank.UpdateText(plankCount.ToString());
                        if (soundPlayedInteractable2 == false)
                        {
                            soundInteractable2.Play();
                        }
                        if (soundInteractable2 == true)
                        {
                            Debug.Log(soundPlayedInteractable2);
                        }
                    }
                    else if (plankCount == 3)
                    {
                        Destroy(interactable3);
                        plankCount++;
                        changeTextPlank.UpdateText(plankCount.ToString());
                        if (soundPlayedInteractable3 == false)
                        {
                            soundInteractable3.Play();
                        }
                        if (soundInteractable3 == true)
                        {
                            Debug.Log(soundPlayedInteractable3);
                        }
                    }
                }
                if(hit.collider.CompareTag("DestroyableObs"))
                {
                    if (plankCount == 1)
                    {
                        Destroy(destroyableObs0);
                        Plank0.SetActive(true);
                        if (soundPlayedDestroyable0 == false)
                        {
                            soundDestroyable0.Play();
                        }
                        if (soundPlayedDestroyable0 == true)
                        {
                            Debug.Log(soundPlayedDestroyable0);
                        }
                    }
                    if (plankCount == 2)
                    {
                        Destroy(destroyableObs1);
                        Plank1.SetActive(true);
                        if (soundPlayedDestroyable1 == false)
                        {
                            soundDestroyable1.Play();
                        }
                        if (soundPlayedDestroyable1 == true)
                        {
                            Debug.Log(soundPlayedDestroyable1);
                        }
                    }
                    if (plankCount == 3)
                    {
                        Destroy(destroyableObs2);
                        Plank2.SetActive(true);
                        if (soundPlayedDestroyable2 == false)
                        {
                            soundDestroyable2.Play();
                        }
                        if (soundPlayedDestroyable2 == true)
                        {
                            Debug.Log(soundPlayedDestroyable2);
                        }
                    }
                    if (plankCount == 4)
                    {
                        Destroy(destroyableObs3);
                        Plank3.SetActive(true);
                        if (soundPlayedDestroyable3 == false)
                        {
                            soundDestroyable3.Play();
                        }
                        if (soundPlayedDestroyable3 == true)
                        {
                            Debug.Log(soundPlayedDestroyable3);
                        }
                    }
                }
            }
        }
    }
}

