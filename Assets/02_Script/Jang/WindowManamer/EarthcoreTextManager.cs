using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EarthcoreTextManager : MonoBehaviour
{
    ShopManager SM;
    public Text Text;
    // Start is called before the first frame update
    void Start()
    {
        SM = FindObjectOfType<ShopManager>();
    }

    // Update is called once per frame
    void Update()
    {
        Text.text = "어스코어 개수 : " + SM.TowerEarthcore;
    }
}
