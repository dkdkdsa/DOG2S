using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStat : MonoBehaviour
{
    public float Player_power;
    public float Player_hp;
    public float Player_speed;
    public float Player_defense;
    // Start is called before the first frame update
    void Start()
    {
        Player_power = PlayerPrefs.GetFloat("power", 0);
        Player_hp = PlayerPrefs.GetFloat("hp", 0);
        Player_speed = PlayerPrefs.GetFloat("speed", 0);
        Player_defense = PlayerPrefs.GetFloat("damage", 0);
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetFloat("power", Player_power);
        PlayerPrefs.SetFloat("hp", Player_hp);
        PlayerPrefs.SetFloat("speed", Player_speed);
        PlayerPrefs.SetFloat("damage", Player_defense);
    }
}
