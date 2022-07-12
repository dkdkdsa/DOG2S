using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alcohol3Manager : MonoBehaviour
{
    PlayerStat PS;
    public void OnClick()
    {
        PS.Player_speed += 5;
        PS.Player_defense += 100;
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
