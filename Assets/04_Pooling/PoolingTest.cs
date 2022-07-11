using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolingTest : MonoBehaviour
{
    private void Update()
    {
        PoolingTestCode();
    }



    void PoolingTestCode()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log(1);
            GameObject testObj = PoolingManager._Instance.PopObj("TestObj");
        }
    }


}
