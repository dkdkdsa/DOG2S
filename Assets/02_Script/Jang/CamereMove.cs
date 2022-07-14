using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;
public class CamereMove : MonoBehaviour
{
    public float speed;
    [SerializeField] Tilemap tilemap;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        tilemap.transform.position += Vector3.left * speed * Time.deltaTime;
        if (tilemap.transform.position.x <= -60)
        {
            tilemap.transform.position = new Vector3(0, 0, 0);
        }
    }
}
