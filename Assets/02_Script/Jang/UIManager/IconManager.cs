using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IconManager : MonoBehaviour
{
    public GameObject SmithyIcon;
    public GameObject RestaurantIcon;
    public GameObject TownIcon;
    public GameObject DungeonIcon;
    public bool icon_on;
    // Start is called before the first frame update
    void Start()
    {
        icon_on = false;
        SmithyIcon.SetActive(false);
        RestaurantIcon.SetActive(false);
        TownIcon.SetActive(false);
        DungeonIcon.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (icon_on == false && Input.GetKeyDown(KeyCode.M))
        {
            Debug.Log("icon_on");
            icon_on = true;
            SmithyIcon.SetActive(true);
            RestaurantIcon.SetActive(true);
            TownIcon.SetActive(true);
            DungeonIcon.SetActive(true);
        }
        else if(icon_on == true && Input.GetKeyDown(KeyCode.M))
        {
            Debug.Log("icon_off");
            icon_on = false;
            SmithyIcon.SetActive(false);
            RestaurantIcon.SetActive(false);
            TownIcon.SetActive(false);
            DungeonIcon.SetActive(false);
        }
    }
}
