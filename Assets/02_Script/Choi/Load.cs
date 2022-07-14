using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Load : MonoBehaviour
{

    private int core;
    public void Load_()
    {

        core = PlayerPrefs.GetInt("Earthcore");

        core += 3;
        PlayerPrefs.SetInt("Earthcore", core);

        StartCoroutine(e());

    }

    IEnumerator e()
    {
        Debug.Log(1);
        yield return new WaitForSeconds(1f);
        SceneManager.LoadScene("JangWheeseSong 1");

    }

}
