using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopManager : MonoBehaviour
{
    public float TowerEarthcore;
    // Start is called before the first frame update
    void Start()
    {
        TowerEarthcore = PlayerPrefs.GetFloat("TowerEarthcore", 0);
    }

    // Update is called once per frame
    void Update()
    {
        PlayerPrefs.SetFloat("TowerEarthcore", TowerEarthcore);
    }
}
