using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class ChangeSceneVideoPlayerEnd : MonoBehaviour
{
    [SerializeField] VideoPlayer player;
    [SerializeField] string scene;

    private void Start()
    {
        player = GetComponent<VideoPlayer>();
        player.loopPointReached += OnVideoFinished;
    }

    private void OnVideoFinished(VideoPlayer vp)
    {
        Application.Quit();
    }
}
