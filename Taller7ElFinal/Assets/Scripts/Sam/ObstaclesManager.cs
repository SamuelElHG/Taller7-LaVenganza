using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesManager : MonoBehaviour
{
    private int CanCount = 0;
    public AudioClip lataSound;
    public AudioClip obstacleSound;
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Lata"))
        {
            CanCount++;
            Destroy(collision.gameObject);
            Debug.Log(CanCount);
            if (lataSound != null)
            {
                audioSource.PlayOneShot(lataSound);
            }
        }

        if (collision.gameObject.CompareTag("Obstacle"))
        {
            if (CanCount>0)
            {
                Destroy(collision.gameObject);
                CanCount--;
                Debug.Log(CanCount);
                if (obstacleSound != null)
                {
                    audioSource.PlayOneShot(obstacleSound);
                }
            }
            else
            {
                Debug.Log("Loco");
            }
        }

    }
}
