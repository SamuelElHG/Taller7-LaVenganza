using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger1 : MonoBehaviour
{
    [SerializeField] ShopIntroScene shop;

    private void OnTriggerEnter(Collider GameObject)
    {
        if(GameObject.CompareTag("Player"))
        {
            shop.Trigger1();
        }
    }
}
