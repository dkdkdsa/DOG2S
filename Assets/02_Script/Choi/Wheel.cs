using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheel : MonoBehaviour
{

    [SerializeField] private Camera _camera;
    [SerializeField] private float speed;
    [SerializeField] private float move_Speed;
    [SerializeField] private AudioSource _source;
    [SerializeField] private AudioSource source;
    [SerializeField] private AudioSource audioSource;

    private float value;

    private void Start()
    {
        
        //_camera.transform.position = new Vector3(0, 0, -10);

    }

    // Update is called once per frame
    void Update()
    {

        value= Input.GetAxis("Mouse ScrollWheel") * speed;
        
        if(_camera.orthographicSize >= 12 && value < 0)
        {

            _camera.orthographicSize = 12f;

        }
        else if(_camera.orthographicSize <= 0.5f && value >= 0)
        {

            _camera.orthographicSize = 0.5f;

        }
        else
        {

            _camera.orthographicSize -=  value;
            _source.volume -= value/10;
            audioSource.volume -= value/10;
            source.volume += value/10;

        }

        

    }
}
