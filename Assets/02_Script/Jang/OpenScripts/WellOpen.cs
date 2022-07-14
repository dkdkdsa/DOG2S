using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WellOpen : MonoBehaviour
{
    public bool welln_possible;
    // Start is called before the first frame update
    void Start()
    {
        welln_possible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Collider2D collider = Physics2D.OverlapCircle(transform.position, 0.3f, LayerMask.GetMask("Player"));
        if (collider != null)
        {
            welln_possible = true;
        }
        else
        {
            welln_possible = false;
        }
    }
}
