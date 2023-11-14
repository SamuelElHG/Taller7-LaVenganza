using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesManager : MonoBehaviour
{
    private int CanCount = 0;
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
        if (collision.gameObject.CompareTag("Lata"))
        {
            CanCount++;
            Destroy(collision.gameObject);
            Debug.Log(CanCount);

        }

        if (collision.gameObject.CompareTag("Obstacle"))
        {
            if (CanCount>0)
            {
                Destroy(collision.gameObject);
                CanCount--;
                Debug.Log(CanCount);

            }
            else
            {
                Debug.Log("Loco");
            }
        }

    }
}
