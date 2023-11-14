using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.SceneManagement;

public class LevelFinish : MonoBehaviour
{
    [SerializeField] private int sceneNumber;
    [SerializeField] private Light theLight;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        theLight.intensity = 1000f;
        StartCoroutine(waiChange());

    }
    IEnumerator waiChange()
    {
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(sceneNumber);
    }
}
