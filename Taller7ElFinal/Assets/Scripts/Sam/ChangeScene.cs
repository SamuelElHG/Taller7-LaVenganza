using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    [SerializeField] private int targetScene;

    public void MoveToScene()
    {
        SceneManager.LoadScene(targetScene);
    }
}
