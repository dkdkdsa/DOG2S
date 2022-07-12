using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class StatsManager : ScriptableObject
{
    float hp;
    float damage;
    float speed;
    float defense;
    float money;
    float time;
    int weapon;

    public float Hp { get { return hp; } set { hp = value; } }
    public float Damage { get { return damage; } set { damage = value; } }
    public float Defense { get { return defense; } set { defense = value; } }
    public float Speed { get { return speed; } set { speed = value; } }
    public float Money { get { return money; } set { money = value; } }
    public float Time { get { return time; } set { time = value; } }
    public int Weapon { get { return weapon; } set { weapon = value; } }
}
