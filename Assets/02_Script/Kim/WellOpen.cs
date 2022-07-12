using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WellOpen : MonoBehaviour
{
    public bool well_possible;

    private void Awake()
    {
        well_possible = false;
    }

    void Update()
    {
        Collider2D collider = Physics2D.OverlapCircle(transform.position, 1, LayerMask.GetMask("Player"));
        if (collider != null)
        {
            well_possible = true;
        }
        else
        {
            well_possible = false;
        }
    }
}
