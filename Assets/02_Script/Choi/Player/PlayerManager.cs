using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{

    [SerializeField] private Slider HPbar;
    [SerializeField] private TextMesh DamageEffect;

    void Awake()
    {

        HPbar.value = 100f;

    }

    public void TakeDamage(float damage)
    {

        HPbar.value -= damage;


        Instantiate(DamageEffect, transform.position, Quaternion.identity);

        DamageEffect.text = damage.ToString();
    }

}
