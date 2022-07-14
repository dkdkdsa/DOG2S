using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowBuff : MonoBehaviour
{

    [SerializeField] private Image alcohol;
    [SerializeField] private Image food;
    [SerializeField] private Sprite[] food_sprites;
    [SerializeField] private Sprite[] alcohol_sprite;

    private int food_Count, alcohol_Count;

    public void Show()
    {

        food_Count = PlayerPrefs.GetInt("Food_Count");
        alcohol_Count = PlayerPrefs.GetInt("Alcohol_Count");
        
        if(food_Count != 0)
        {

            food.gameObject.SetActive(true);
            food.sprite = food_sprites[food_Count];

        }

        if(alcohol_Count != 0)
        {

            alcohol.gameObject.SetActive(true);
            alcohol.sprite = alcohol_sprite[alcohol_Count];

        }

    }

}
