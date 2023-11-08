using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MilkScript : MonoBehaviour
{
    public GameObject milk;

    private void OnTriggerEnter(Collider GameObject)
    {
        if(GameObject.CompareTag("Player"))
        {
            milk.SetActive(false);
        }
    }
}
