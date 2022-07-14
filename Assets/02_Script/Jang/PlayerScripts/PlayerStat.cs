using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStat : MonoBehaviour
{

    private float damage;

    public void SetDamage(float set_damage)
    {

        damage = set_damage;

        PlayerPrefs.SetFloat("Damage", damage);

    }

}
