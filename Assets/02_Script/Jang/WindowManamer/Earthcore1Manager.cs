using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Earthcore1Manager : MonoBehaviour
{
    PlayerItem PI;
    public void OnClick()
    {
        PI.Earthcore -= 1;
        PlayerPrefs.SetFloat("TowerEarthcore", 0);
    }
    // Start is called before the first frame update
    void Start()
    {
        PI = FindObjectOfType<PlayerItem>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
