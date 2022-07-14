using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkillMove : MonoBehaviour
{

    [SerializeField] private float speed;
    [SerializeField] private GameObject explosionEffect;

    private PlayerMove playerMove;
    private SpriteRenderer spriteRenderer;
    private bool isCol;

    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        playerMove = FindObjectOfType<PlayerMove>();
        Invoke("Destroy", 3f);
    }
    void Destroy()
    {
        Destroy(gameObject);
    }
    float knockBackPos;
    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime);

        float pos = transform.rotation.y switch
        {

            0 => 2,
            180 => -2,
            _ => -2,

        };

        Collider2D col = Physics2D.OverlapBox(transform.position, new Vector2(1, 1), 0, LayerMask.GetMask("Enemy"));
        if (col != null && isCol == false)
        {
            Enemy_AI enemy = col.gameObject.GetComponent<Enemy_AI>();

            if (enemy.IsDie == false)
            {
                isCol = true;
                enemy.TakeDamage((int)Random.Range((playerMove.AttackPower + playerMove.Buff_AttackPower + playerMove.WaponAttackPower) * 2, (playerMove.AttackPower + playerMove.Buff_AttackPower + playerMove.WaponAttackPower) * 2.5f), pos);
                Instantiate(explosionEffect, transform.position, Quaternion.identity);
                spriteRenderer.enabled = false;
                StartCoroutine(_Destroy());

            }
        }
    }

    IEnumerator _Destroy()
    {

        yield return new WaitForSeconds(1f);
        Destroy(gameObject);

    }

}
