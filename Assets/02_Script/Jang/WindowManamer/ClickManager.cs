using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickManager : MonoBehaviour
{
    void Awake()
    {
        text.gameObject.SetActive(false);
    }
    public Text text;
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
        else 
        {
            StartCoroutine(Warmming());
        }
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
        else 
        {
            StartCoroutine(Warmming());
        }

    }
    IEnumerator Warmming()
    {
        text.gameObject.SetActive(true);
        yield return new WaitForSeconds(0.7f);
        text.gameObject.SetActive(false);
    }
}
