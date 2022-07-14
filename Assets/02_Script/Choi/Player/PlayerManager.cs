using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{

    [SerializeField] private Slider HPbar;
    [SerializeField] private TextMesh DamageEffect;
    [SerializeField] private PlayerMove player;
    [SerializeField] private Rigidbody2D _rigidbody2D;

    private Animator animator;

    void Awake()
    {

        animator = GetComponent<Animator>();

    }

    private void Update()
    {

        if (Physics2D.OverlapBox(transform.position, new Vector2(0.5f, 0.7f), 0, LayerMask.GetMask("Trap")) && player.IsDie == false)
        {

            _rigidbody2D.velocity = Vector2.zero;
            player.IsDie = true;
            PlayerPrefs.SetFloat("Buff_HP", 0);
            PlayerPrefs.SetFloat("Buff_Defence", 0);
            PlayerPrefs.SetFloat("Buff_AttackPower", 0);
            PlayerPrefs.SetFloat("Buff_Speed", 0);
            animator.SetTrigger("Die");

        }

    }

    public void TakeDamage(float damage)
    {

        HPbar.value -= damage - player.Buff_Defance;
        Instantiate(DamageEffect, transform.position, Quaternion.identity);
        DamageEffect.text = damage.ToString();

        if(HPbar.value <= 0)
        {
            _rigidbody2D.velocity = Vector2.zero;
            player.IsDie = true;
            PlayerPrefs.SetFloat("Buff_HP", 0);
            PlayerPrefs.SetFloat("Buff_Defence", 0);
            PlayerPrefs.SetFloat("Buff_AttackPower", 0);
            PlayerPrefs.SetFloat("Buff_Speed", 0);
            animator.SetTrigger("Die");

        }
        else
        {

            if(player.IsSkill == false && player.IsAttack == false) animator.SetTrigger("Hurt");

        }

    }

    public void DieEvent()
    {

        StartCoroutine(Die());

    }

    IEnumerator Die()
    {

        yield return new WaitForSeconds(1f);

        SceneManager.LoadScene("JangWheeseSong 1");

    }

}
