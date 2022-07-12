using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcOpen : MonoBehaviour
{
    public bool npc_possible;
    // Start is called before the first frame update
    void Start()
    {
        npc_possible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Collider2D collider = Physics2D.OverlapCircle(transform.position, 1, LayerMask.GetMask("Player"));
        if (collider != null)
        {
            npc_possible = true;
        }
        else
        {
            npc_possible = false;
        }
    }
}
