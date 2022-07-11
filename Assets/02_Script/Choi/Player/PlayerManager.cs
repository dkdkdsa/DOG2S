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

        DamageEffect.text = damage.ToString();

        Instantiate(DamageEffect, transform.position, Quaternion.identity);

    }

}
