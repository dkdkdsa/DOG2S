using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DateDelete : MonoBehaviour
{
    PlayerStat PS;
    // Start is called before the first frame update
    void Start()
    {
        PS = FindObjectOfType<PlayerStat>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            PS.Player_hp = 0;
            PS.Player_power = 0;
            PS.Player_speed = 0;
            PS.Player_defense = 0;
            PlayerPrefs.DeleteAll();
            gameObject.GetComponent<DateDelete>().enabled = false;
        }
    }
}
