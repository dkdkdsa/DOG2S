using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_AI : MonoBehaviour
{

    [SerializeField] private float speed;
    [SerializeField] private float damage;
    [SerializeField] private Vector2 size;

    private PlayerManager playerManager;
    private Animator animator;
    private SpriteRenderer spriteRenderer;
    private Rigidbody2D enemy_rigidbody;
    private Vector2 move;
    private Collider2D box;
    private Collider2D attackBox;

    void Awake()
    {

        playerManager = FindObjectOfType<PlayerManager>().GetComponent<PlayerManager>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        enemy_rigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {

        Move();

    }

    private void Move()
    {

        box = Physics2D.OverlapBox(transform.position, size, 0, LayerMask.GetMask("Player"));
        attackBox = Physics2D.OverlapBox(transform.position, new Vector2(2, 2), 0, LayerMask.GetMask("Player"));

        if (box)
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

            if (attackBox)
            {

                animator.SetBool("Walk", false);
                animator.SetTrigger("Attack");
                move = Vector2.zero;

            }

        }
        else
        {

            animator.SetBool("Walk", false);
            move = Vector2.zero;

        }


        enemy_rigidbody.velocity = move;


    }

    public void AttackEvent()
    {

        if(attackBox == true) playerManager.TakeDamage((int)Random.Range(damage, damage + 10f));

    }
}
