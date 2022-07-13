using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerItem : MonoBehaviour
{
    public float Money;
    public float Earthcore;
    // Start is called before the first frame update
    void Start()
    {
        Money = PlayerPrefs.GetFloat("Money", 0);
        Earthcore = PlayerPrefs.GetFloat("Earthcore", 0);
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetFloat("Money", Money);
        PlayerPrefs.SetFloat("Earthcore", Earthcore);
    }
}
