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
    PubOpen PO;
    // Start is called before the first frame update
    void Start()
    {
        DO = FindObjectOfType<DungeonOpen>();
        SO = FindObjectOfType<SmithyOpen>();
        TO = FindObjectOfType<TownOpen>();
        RO = FindObjectOfType<RestaurantOpen>();
        PO = FindObjectOfType<PubOpen>();
    }

    // Update is called once per frame
    void Update()
    {
        if (DO.dungeon_possible == true && Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene("TowerSide_ChoiDaeWon");
        }
        if (SO.smithy_possible == true && Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene("Smithy");
        }
        if (TO.town_possible == true && Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene("Town");
        }
        if (RO.restaurant_possible == true && Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene("Pestaurant");
        }
        if (PO.pub_possible == true && Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene("Pub");
        }
    }
}
