using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PooledObj : MonoBehaviour
{
    string _name;
    public string Name { set { _name = value; } }

    public void Push()
    {
        PoolingManager._Instance.PushObj(_name, this.gameObject);
    }
}
