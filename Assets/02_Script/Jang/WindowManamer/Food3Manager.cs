using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food3Manager : MonoBehaviour
{
    PlayerStat PS;
    public void OnClick()
    {
        PS.Player_hp += 150;
        PS.Player_power += 40;
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
