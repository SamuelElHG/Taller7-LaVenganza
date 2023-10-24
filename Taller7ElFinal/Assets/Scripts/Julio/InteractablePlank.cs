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

    internal float GetValue()
    {
        return plankCount;
    }

    void Update()
    {
        // Verifica si el bot�n "F" ha sido presionado.
        if (Input.GetKeyDown(KeyCode.F))
        {
            // Realiza un raycast desde la posici�n del jugador en la direcci�n hacia adelante.
            Ray ray = new Ray(transform.position, transform.forward);
            RaycastHit hit;
            // Realiza el raycast y verifica si ha golpeado algo dentro del rango de interacci�n.
            if (Physics.Raycast(ray, out hit, interactionRange))
            {
                if(hit.collider.CompareTag("Interactable"))
                {
                    if (plankCount == 0)
                    {
                        Destroy(interactable0);
                        plankCount++;
                        changeTextPlank.UpdateText(plankCount.ToString());
                    }
                    else if (plankCount == 1)
                    {
                        Destroy(interactable1);
                        plankCount++;
                        changeTextPlank.UpdateText(plankCount.ToString());
                    }
                    else if (plankCount == 2)
                    {
                        Destroy(interactable2);
                        plankCount++;
                        changeTextPlank.UpdateText(plankCount.ToString());
                    }
                    else if (plankCount == 3)
                    {
                        Destroy(interactable3);
                        plankCount++;
                        changeTextPlank.UpdateText(plankCount.ToString());
                    }
                }
                if(hit.collider.CompareTag("DestroyableObs"))
                {
                    if (plankCount == 1)
                    {
                        Destroy(destroyableObs0);
                        Plank0.SetActive(true);
                    }
                    if (plankCount == 2)
                    {
                        Destroy(destroyableObs1);
                        Plank1.SetActive(true);
                    }
                    if (plankCount == 3)
                    {
                        Destroy(destroyableObs2);
                        Plank2.SetActive(true);
                    }
                    if (plankCount == 4)
                    {
                        Destroy(destroyableObs3);
                        Plank3.SetActive(true);
                    }
                }
            }
        }
    }
}

