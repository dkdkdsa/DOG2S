using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PubOpen : MonoBehaviour
{
    public bool pub_possible;
    // Start is called before the first frame update
    void Start()
    {
        pub_possible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Collider2D collider = Physics2D.OverlapCircle(transform.position, 1f, LayerMask.GetMask("Player"));
        if (collider != null)
        {
            pub_possible = true;
        }
        else
        {
            pub_possible = false;
        }
    }
}
