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

        if (PI.Money >= item.food.sell)
        {
            PI.Money -= item.food.sell;
        }
        else { }
    }

    public void Click_Alcohol() 
    {
        PlayerItem PI = FindObjectOfType<PlayerItem>();

        ItemMain item = GetComponent<ItemMain>();

        Buff_Set buff = FindObjectOfType<Buff_Set>();

        buff.Buff_Alcohol(item.alcohol);
        
        if (PI.Money >= item.alcohol.sell)
        {
            PI.Money -= item.alcohol.sell;
        }
        else { }

    }
    
}
