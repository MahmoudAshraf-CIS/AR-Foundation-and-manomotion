using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MySceneManagment : MonoBehaviour
{
    public int sceneCount = 33;
    public int sceneIndex;
    public Text txt;

    private void Awake()
    {
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        txt.text = SceneManager.GetActiveScene().name;
    }

    public void next()
    {
        SceneManager.LoadScene((sceneIndex + 1) % sceneCount, LoadSceneMode.Single);
    }
}
