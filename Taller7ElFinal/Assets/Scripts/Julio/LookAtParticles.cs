using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtParticles : MonoBehaviour
{
    public Transform playerBoii;

    void Update()
    {
        transform.LookAt(playerBoii);
    }
}
