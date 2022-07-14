using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerInput_new : MonoBehaviour
{
    DungeonOpen DO;
    SmithyOpen SO;
    TownOpen TO;
    RestaurantOpen RO;
    WellOpen WO;
    FactoryOpen FO;

    [SerializeField] private AudioSource source;


    // Start is called before the first frame update
    void Start()
    {
        DO = FindObjectOfType<DungeonOpen>();
        SO = FindObjectOfType<SmithyOpen>();
        TO = FindObjectOfType<TownOpen>();
        RO = FindObjectOfType<RestaurantOpen>();
        WO = FindObjectOfType<WellOpen>();
        FO = FindObjectOfType<FactoryOpen>();
    }

    // Update is called once per frame
    void Update()
    {
        if (DO.dungeon_possible == true && Input.GetKeyDown(KeyCode.E))
        {
            PlayerPrefs.SetInt("LLL", 1);
            SceneManager.LoadScene("TowerSide_ChoiDaeWon");
        }
        if (SO.smithy_possible == true && Input.GetKeyDown(KeyCode.E))
        {
            PlayerPrefs.SetInt("LLL", 2);
            SceneManager.LoadScene("Smithy");
        }
        if (TO.town_possible == true && Input.GetKeyDown(KeyCode.E))
        {
            PlayerPrefs.SetInt("LLL", 3);
            SceneManager.LoadScene("Town");
        }
        if (RO.restaurant_possible == true && Input.GetKeyDown(KeyCode.E))
        {
            PlayerPrefs.SetInt("LLL", 4);
            SceneManager.LoadScene("Pestaurant");
        }
    }
}
