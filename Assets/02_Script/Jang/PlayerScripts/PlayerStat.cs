using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStat : MonoBehaviour
{
    public float Player_power;
    public float Player_hp;
    public float Player_speed;
    public float Player_damage;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetFloat("power", Player_power);
        PlayerPrefs.SetFloat("hp", Player_hp);
        PlayerPrefs.SetFloat("speed", Player_speed);
        PlayerPrefs.SetFloat("damage", Player_damage);
    }
}
