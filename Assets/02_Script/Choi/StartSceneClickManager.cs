using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;
using UnityEngine.UI;

public class StartSceneClickManager : MonoBehaviour
{

    [SerializeField] private Image image;

    public void Click_Start()
    {

        image.DOFade(1, 0.3f).OnComplete(() =>
        {

            SceneManager.LoadScene("JangWheeseSong 1");

        });


    }

    public void Click_Quit()
    {

        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #endif

        Application.Quit();

    }

}
