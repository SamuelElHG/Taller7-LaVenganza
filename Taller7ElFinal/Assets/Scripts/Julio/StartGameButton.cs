using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGameButton : MonoBehaviour
{
    public string sceneToLoad;
    public void StartGameFunction()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
