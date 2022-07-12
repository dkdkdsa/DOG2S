using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Food1Manager : MonoBehaviour
{
    PlayerStat PS;
    public void OnClick()
    {
        PS.Player_hp += 10;
        PS.Player_power += 2;
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
