using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PlayerMove : MonoBehaviour
{

    [SerializeField] private float speed;
    [SerializeField] private float JumpPower;
    [SerializeField] private float attackPower;
    [SerializeField] private float offset;
    [SerializeField] private float dashSpeed;
    [SerializeField] private Vector2 attackBoxSize;
    [SerializeField] private JumpBox jumpBox;
    [SerializeField] private Camera cam;
    [SerializeField] private SpriteRenderer spriteRenderer;
    [SerializeField] private GameObject skillEffect;
    [SerializeField] private Gravity gravity;

    private Animator animator;
    private Rigidbody2D player_rigidbody;
    private bool isSkill;
    private bool moving;
    private bool dashCool;
    private bool isDash;
    private bool isAttack;
    private bool attackCool;
    private float dashPos;
    private float rotate_Value;
    private float knockBackPos;
    public float KnockBackPos => knockBackPos;

    void Awake()
    {
     
        animator = GetComponent<Animator>();
        player_rigidbody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {

        Jump();
        Attack();
        Skill();

        float moveX = Input.GetAxisRaw("Horizontal");

        Dash();

        offset = moveX switch
        {

            -1 => -1,
            1 => 1,
            0 => offset,
            _ => offset,

        };

        knockBackPos = moveX switch
        {

            -1 => -2f,
            1 => 2f,
            0 => knockBackPos,
            _ => knockBackPos,

        };

        spriteRenderer.flipX = moveX switch
        {


            -1 => true,
            1 => false,
            0 => spriteRenderer.flipX,
            _ => spriteRenderer.flipX,

        };

        rotate_Value = moveX switch
        {

            -1 => 180,
            1 => 0,
            0 => rotate_Value,
            _ => rotate_Value,

        };

        dashPos = moveX switch
        {

            -1 => -1,
            1 => 1,
            0 => dashPos,
            _ => dashPos,

        };

    }

    void FixedUpdate()
    {

        if(isAttack == false && isDash == false) Move();

    }

    private void Move()
    {

        float moveX = Input.GetAxis("Horizontal");
        float inputRaw = Input.GetAxisRaw("Horizontal");

        if (inputRaw != 0) moving = true;
        else moving = false;

       animator.SetBool("Walk", moving);

        float slowSpeed = moving ? 1.0f : 0.5f;

        player_rigidbody.velocity = new Vector2(moveX * speed * slowSpeed, player_rigidbody.velocity.y);
        

    }

    private void Dash()
    {

        if(Input.GetKeyDown(KeyCode.LeftShift) && dashCool == false && isAttack == false)
        {
            dashCool = true;
            player_rigidbody.velocity = Vector2.zero;
            player_rigidbody.AddForce(new Vector2(dashPos, 0) * dashSpeed, ForceMode2D.Impulse);
            player_rigidbody.gravityScale = 0;
            gravity.enabled = false;
            animator.SetTrigger("Dash");
            isDash = true;
           
        }

    }

    private void Jump()
    {

        if (jumpBox.IsGround() && Input.GetKeyDown(KeyCode.Space))
        {

            player_rigidbody.AddForce(Vector2.up * JumpPower, ForceMode2D.Impulse);

        }

    }

    private void Attack()
    {

        if (Input.GetMouseButtonDown(0) && isAttack == false && isDash ==false && attackCool == false)
        {

            animator.SetTrigger("Attack");
            isAttack = true;
            attackCool = true;

        }

    }

    private void Skill()
    {

        if (Input.GetMouseButtonDown(1) && isAttack == false && isSkill == false)
        {

            animator.SetTrigger("Skill");

            isSkill = true;

        }

    }

    

    public void Attack_Event()
    {

        Collider2D[] attack = Physics2D.OverlapBoxAll(new Vector2(transform.position.x + offset, transform.position.y), attackBoxSize, 0, LayerMask.GetMask("Enemy"));

        if(attack != null)
        {

            foreach(var item in attack)
            {

                Enemy_AI enemy = item.GetComponent<Enemy_AI>();

                if(enemy.IsDie == false)
                {

                    enemy.TakeDamage((int)Random.Range(attackPower, attackPower + 9), 0);

                }

            }

        }

    }
    
    public void SkillDelay()
    {

        StartCoroutine(Delay());

    }
    public void AttackDelayEvent()
    {

        StartCoroutine(AttackDelay());
        isAttack = false;

    }

    public void DashEnd()
    {

        isDash = false;
        player_rigidbody.gravityScale = 1;
        player_rigidbody.velocity = Vector2.zero;
        gravity.enabled = true;
        StartCoroutine(DashDelay());

    }

    public void SkillEffect()
    {

        Instantiate(skillEffect, transform.position, Quaternion.Euler(0, rotate_Value, 0));

    }

    IEnumerator Delay()
    {

        yield return new WaitForSeconds(1f);

        isSkill = false;

    }

    IEnumerator DashDelay()
    {

        yield return new WaitForSeconds(1.5f);

        dashCool = false;

    }

    IEnumerator AttackDelay()
    {

        yield return new WaitForSeconds(1f);
        attackCool = false;

    }

}
