using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shake : MonoBehaviour
{
    Vector3 zeee = new Vector3(0.05f, 0, 0);
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
        while (true)
        {
            yield return new WaitForSeconds(1f);
            for (int i = 0; i < 9; i++)
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
