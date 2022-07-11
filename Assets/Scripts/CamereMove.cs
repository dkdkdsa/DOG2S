using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamereMove : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.down * speed * Time.deltaTime;
        if (transform.position.y <= -45)
        {
            transform.position += new Vector3(0, 90, 0);
        }
    }
}
