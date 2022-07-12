using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shake : MonoBehaviour
{
    public float shake;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Move());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator Move()
    {
        Vector3 zeee = new Vector3(0, shake, 0);
        while (true)
        {
            yield return new WaitForSeconds(0.5f);
            for (int i = 0; i < 3; i++)
            {
                transform.position += zeee;
                yield return new WaitForSeconds(0.03f);
                transform.position -= zeee;
                transform.position -= zeee;
                yield return new WaitForSeconds(0.03f);
                transform.position += zeee;
                yield return new WaitForSeconds(0.03f);
            }
        }
    }
}
