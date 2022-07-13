using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickManager : MonoBehaviour
{
    public void Click_Food()
    {
        PlayerItem PI = FindObjectOfType<PlayerItem>();
        
        ItemMain item = GetComponent<ItemMain>(); 

        Buff_Set buff = FindObjectOfType<Buff_Set>();

        buff.Buff_Food(item.food);

        PI.Money -= item.food.sell;
    }

    public void Click_Alcohol() 
    {
        PlayerItem PI = FindObjectOfType<PlayerItem>();

        ItemMain item = GetComponent<ItemMain>();

        Buff_Set buff = FindObjectOfType<Buff_Set>();

        buff.Buff_Alcohol(item.alcohol);

        PI.Money -= item.alcohol.sell;

    }
    
}
