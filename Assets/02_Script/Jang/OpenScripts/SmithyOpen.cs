using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmithyOpen : MonoBehaviour
{
    public bool smithy_possible;
    // Start is called before the first frame update
    void Start()
    {
        smithy_possible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Collider2D collider = Physics2D.OverlapBox(transform.position, new Vector2(3f, 1.9f), 0, LayerMask.GetMask("Player"));
        if (collider != null)
        {
            smithy_possible = true;
        }
        else
        {
            smithy_possible = false;
        }
    }
}
