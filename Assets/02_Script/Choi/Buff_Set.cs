using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buff_Set : MonoBehaviour
{

    public void Buff_Food(Food food)
    {

        PlayerPrefs.SetFloat("Buff_HP", food.buff_HP);
        PlayerPrefs.SetFloat("Buff_AttackPower", food.buff_AttackPower);

    }

    public void Buff_Alcohol(Alcohol alcohol)
    {

        PlayerPrefs.SetFloat("Buff_Defence", alcohol.buff_Defence);
        PlayerPrefs.SetFloat("Buff_Speed", alcohol.buff_Speed);

    }

}
