using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TestPooling();
        }
    }
    void TestPooling()
    {
        Debug.Log(1);
        GameObject testObj = PoolingManager._Instance.PopObj("1");
        Debug.Log(testObj);
        testObj.transform.position = transform.position;
    }



}
