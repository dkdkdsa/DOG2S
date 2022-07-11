using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{

    [SerializeField] private float speed;
    [SerializeField] private float JumpPower;
    [SerializeField] private JumpBox jumpBox;

    private Rigidbody2D player_rigidbody;
    private bool moving;

    void Awake()
    {
        
        player_rigidbody = GetComponent<Rigidbody2D>();

    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Jump();

    }

    void FixedUpdate()
    {

        Move();

    }

    private void Move()
    {

        float moveX = Input.GetAxis("Horizontal");

        if (moveX != 0) moving = true;
        else moving = false;

        float slowSpeed = moving ? 1.0f : 0.5f;

        player_rigidbody.velocity = new Vector2(moveX * speed * slowSpeed, player_rigidbody.velocity.y);
        

    }

    private void Jump()
    {

        if (jumpBox.IsGround() && Input.GetKeyDown(KeyCode.Space))
        {

            player_rigidbody.AddForce(Vector2.up * JumpPower, ForceMode2D.Impulse);

        }

    }

}
