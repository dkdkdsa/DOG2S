using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Enemy_AI : MonoBehaviour
{

    [SerializeField] private float speed;
    [SerializeField] private float damage;
    [SerializeField] private float HP;
    [SerializeField] private TextMesh damageEffect;
    [SerializeField] private Vector2 size;
    [SerializeField] private Camera main_Camera;

    private bool isDie;
    private PlayerMove playerMove;
    private bool isKnockBack;
    private PlayerManager playerManager;
    private Animator animator;
    private SpriteRenderer spriteRenderer;
    private Rigidbody2D enemy_rigidbody;
    private Vector2 move;
    private Collider2D box;
    private Collider2D attackBox;

    public bool IsDie => isDie;

    void Awake()
    {

        playerMove = FindObjectOfType<PlayerMove>().GetComponent<PlayerMove>();
        playerManager = FindObjectOfType<PlayerManager>().GetComponent<PlayerManager>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        enemy_rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

    }

    void Update()
    {

        if(isKnockBack == false && isDie == false) Move();

    }

    private void Move()
    {

        box = Physics2D.OverlapBox(transform.position, size, 0, LayerMask.GetMask("Player"));
        attackBox = Physics2D.OverlapBox(transform.position, new Vector2(2, 2), 0, LayerMask.GetMask("Player"));

        if (box && playerMove.IsDie == false)
        {

            if(transform.position.x > box.transform.position.x)
            {

                spriteRenderer.flipX = false;
                animator.SetBool("Walk", true);
                move = new Vector2(-1 * speed, enemy_rigidbody.velocity.y);
                

            }
            else if(transform.position.x < box.transform.position.x)
            {

                spriteRenderer.flipX = true;
                animator.SetBool("Walk", true);
                move = new Vector2(1 * speed, enemy_rigidbody.velocity.y);

            }

            if (attackBox )
            {

                animator.SetBool("Walk", false);
                animator.SetTrigger("Attack");
                move = new Vector2(0, enemy_rigidbody.velocity.y);

            }

        }
        else
        {

            animator.SetBool("Walk", false);
            move = new Vector2(0, enemy_rigidbody.velocity.y);

        }


        enemy_rigidbody.velocity = move;


    }

    public void TakeDamage(float damage, float knockBackPos)
    {
        HP -= damage;

        damageEffect.text = $"{damage}";
        Instantiate(damageEffect, transform.position, Quaternion.identity);

        if(HP > 0)
        {
            if(isKnockBack == false)
            {

                transform.position = new Vector2(transform.position.x + knockBackPos, transform.position.y + 0.5f);
                StartCoroutine(KnockCoolTime());
                StartCoroutine(GracityCoolTime());

            }


        }
        else if(HP <= 0)
        {

            Die(knockBackPos);

        }



    }

    private void Die(float knockBackPos)
    {

        isDie = true;
        main_Camera.transform.DOShakePosition(0.3f, new Vector3(0.5f, 0, 0), 20, 0);
        animator.SetTrigger("Die");
        enemy_rigidbody.velocity = Vector2.zero;
        enemy_rigidbody.gravityScale = 1;
        enemy_rigidbody.AddForce(new Vector2(knockBackPos * 2, 3f) * 1, ForceMode2D.Impulse);
        StartCoroutine(Disappear());

    }

    public void AttackEvent()
    {

        if(attackBox == true) playerManager.TakeDamage((int)Random.Range(damage, damage + 10f));

    }

    IEnumerator GracityCoolTime()
    {

        yield return new WaitForSeconds(0.1f);


    }
    IEnumerator KnockCoolTime()
    {
        isKnockBack = true;
        yield return new WaitForSeconds(1f);
        isKnockBack = false;
    }

    IEnumerator Disappear()
    {

        yield return new WaitForSeconds(3f);

        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();

        Color color = spriteRenderer.color;

        for (float i = 0; i < 10; i++)
        {

            color.a = 0.5f;
            spriteRenderer.color = color;
            yield return new WaitForSeconds(0.1f);
            color.a = 1;
            spriteRenderer.color = color;
            yield return new WaitForSeconds(0.1f);

        }

        Destroy(gameObject);

    }

}
