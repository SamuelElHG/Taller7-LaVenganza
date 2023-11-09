using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXContro : MonoBehaviour
{
    [SerializeField] AudioClip theClip;
    [SerializeField] AudioSource theSource;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            theSource.PlayOneShot(theClip, 1);
        }
    }
}
