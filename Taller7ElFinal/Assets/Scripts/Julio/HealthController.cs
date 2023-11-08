using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class HealthController : MonoBehaviour
{
    [SerializeField] Volume healthVolume;
    public float Health = 0;

    public void GetHit()
    {
        Health++;
        ChangeWeighValue();
    }

    private void ChangeWeighValue()
    {
        healthVolume.weight = Health/5;
    }
}
