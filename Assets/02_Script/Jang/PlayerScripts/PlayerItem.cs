using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerItem : MonoBehaviour
{
    public int Money;
    public int Earthcore;
    // Start is called before the first frame update
    void Awake()
    {
        Money = PlayerPrefs.GetInt("Money");
        Earthcore = PlayerPrefs.GetInt("Earthcore");
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetInt("Money", Money);
        PlayerPrefs.SetInt("Earthcore", Earthcore);
    }
}
