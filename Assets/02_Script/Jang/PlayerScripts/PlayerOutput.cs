using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerOutput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Collider2D collider2D = Physics2D.OverlapBox(transform.position, new Vector2(1,1), 0, LayerMask.GetMask("Player"));
        if (collider2D != null)
        {
            SceneManager.LoadScene("JangWheeseSong 1");
        }
    }
}
