using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class Billboarding : MonoBehaviour
{
    [SerializeField] private GameObject theplayer;
    private void Start()
    {
        GameObject gameObject = new GameObject();
    }
    void Update()
    {
        //gameObject.transform.LookAt(Camera.main.transform.position, -Vector3.up);
        gameObject.transform.LookAt(theplayer.transform.position, Vector3.up);
    }
}
