using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NpcOpen2 : MonoBehaviour
{
    public bool npc2_possible;
    // Start is called before the first frame update
    void Start()
    {
        npc2_possible = false;
    }

    // Update is called once per frame
    void Update()
    {
        Collider2D collider = Physics2D.OverlapCircle(transform.position, 1.5f, LayerMask.GetMask("Player"));
        if (collider != null)
        {
            npc2_possible = true;
        }
        else
        {
            npc2_possible = false;
        }
    }
}
