using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerManager : MonoBehaviour
{

    [SerializeField] private Slider HPbar;
    [SerializeField] private TextMesh DamageEffect;
    [SerializeField] private PlayerMove player;

    private Animator animator;

    void Awake()
    {

        animator = GetComponent<Animator>();
        HPbar.value = 100f;

    }

    public void TakeDamage(float damage)
    {

        HPbar.value -= Mathf.Abs(damage - player.Buff_Hp - player.Buff_Defance);
        Instantiate(DamageEffect, transform.position, Quaternion.identity);
        DamageEffect.text = damage.ToString();

        if(HPbar.value <= 0)
        {

            player.IsDie = true;
            animator.SetTrigger("Die");

        }
        else
        {

            animator.SetTrigger("Hurt");

        }

    }

}
