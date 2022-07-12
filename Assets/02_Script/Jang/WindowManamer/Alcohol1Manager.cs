using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Alcohol1Manager : MonoBehaviour
{
    PlayerStat PS;
    public void OnClick()
    {
        PS.Player_speed += 2;
        PS.Player_defense -= 5;
    }
    // Start is called before the first frame update
    void Start()
    {
        PS = FindObjectOfType<PlayerStat>();   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
