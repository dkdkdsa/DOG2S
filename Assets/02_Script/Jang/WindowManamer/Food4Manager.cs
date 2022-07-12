using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food4Manager : MonoBehaviour
{
    PlayerStat PS;
    public void OnClick()
    {
        PS.Player_hp += 200;
        PS.Player_power += 60;
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
