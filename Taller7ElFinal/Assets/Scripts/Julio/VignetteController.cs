using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class Vigg : MonoBehaviour
{
    [SerializeField] Volume vignetteVolume;
    [SerializeField] float vignetteValue;

    private void OnTriggerEnter(Collider GameObject)
    {
        if(GameObject.CompareTag("Player"))
        {
            vignetteVolume.weight = vignetteValue;
        }
    }
}
