using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheel : MonoBehaviour
{

    [SerializeField] private Camera _camera;
    [SerializeField] private float speed;
    [SerializeField] private float move_Speed;

    private float value;

    private void Start()
    {
        
        _camera.transform.position = new Vector3(0, 0, -10);

    }

    // Update is called once per frame
    void Update()
    {

        value= Input.GetAxis("Mouse ScrollWheel") * speed;
        
        if(_camera.orthographicSize > 5 && value < 0)
        {

            _camera.orthographicSize = 5f;

        }
        else if(_camera.orthographicSize < 1)
        {

            _camera.orthographicSize = 1f;

        }
        else
        {

            _camera.orthographicSize -=  value;


        }


    }
}
