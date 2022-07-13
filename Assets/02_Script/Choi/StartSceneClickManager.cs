using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartSceneClickManager : MonoBehaviour
{
    
    public void Click_Start()
    {

        SceneManager.LoadScene("JangWheeseSong 1");

    }

    public void Click_Quit()
    {

        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif

        Application.Quit();

    }

}
