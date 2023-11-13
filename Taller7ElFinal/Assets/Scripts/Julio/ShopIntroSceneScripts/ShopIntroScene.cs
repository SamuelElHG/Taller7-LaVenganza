using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShopIntroScene : MonoBehaviour
{
    [SerializeField] AudioSource flashingAudio;
    bool soundHasNotPlayed = true;

    [SerializeField] Light directionalLight;
    [SerializeField] GameObject Frame1;
    [SerializeField] GameObject Frame2;
    [SerializeField] GameObject Frame3;

    bool timerOn0 = false;
    [SerializeField] float timeLeft0;

    bool timerOn1 = false;
    [SerializeField] float timeLeft1;

    [SerializeField] string sceneName;

    public void Trigger1()
    {
        Frame1.SetActive(true);
        Frame2.SetActive(false);
        Frame3.SetActive(false);
    }
    public void Trigger2()
    {
        Frame1.SetActive(false);
        Frame2.SetActive(true);
        Frame3.SetActive(false);
    }
    public void Trigger3()
    {
        Frame1.SetActive(false);
        Frame2.SetActive(false);
        Frame3.SetActive(true);
    }
    public void lightActivation()
    {
        timerOn0 = true;
    }
    private void Update()
    {
        if(timerOn0)
        {
            if(timeLeft0 > 0)
            {
                timeLeft0 -= Time.deltaTime;
            }
            else
            {
                Debug.Log("TIME");
                timeLeft0 = 0;
                timerOn0 = false;
                timerOn1 = true;
            }
        }
        if(timerOn1)
        {
            if(timeLeft1 > 0)
            { 
                timeLeft1 -= Time.deltaTime;
                directionalLight.intensity++;
                if(soundHasNotPlayed)
                {
                    flashingAudio.Play();
                    soundHasNotPlayed = false;
                }
            }
            else
            {
                Debug.Log("ChangeScene");
                timeLeft1 = 0;
                timerOn1 = false;
                SceneManager.LoadScene(sceneName);
            }
        }
    }
}
