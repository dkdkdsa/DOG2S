using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickManager : MonoBehaviour
{

    public void Click_Food()
    {

        ItemMain item = GetComponent<ItemMain>();

        Buff_Set buff = FindObjectOfType<Buff_Set>();

        buff.Buff_Food(item.food);

    }

    public void Click_Alcohol() 
    { 
    
        ItemMain item = GetComponent<ItemMain>();

        Buff_Set buff = FindObjectOfType<Buff_Set>();

        buff.Buff_Alcohol(item.alcohol);

    }
    
}
