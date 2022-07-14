using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sex : MonoBehaviour
{

    [SerializeField] private GameObject[] sex;
    [SerializeField] private GameObject player;

    private void Awake()
    {
        player.transform.position = sex[PlayerPrefs.GetInt("LLL")].transform.position;
    }
}
