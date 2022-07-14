using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_Manager : MonoBehaviour
{

    public UI_Move[] objects;

    public void Lode(string eventTag)
    {

        for(int i = 0; i < objects.Length; i++)
        {

            if(objects[i].EventTag == eventTag)
            {

                objects[i].Lode(false);

            }
            
        }

    }

    public void Stop(string eventTag)
    {

        for (int i = 0; i < objects.Length; i++)
        {

            if (objects[i].EventTag == eventTag)
            {

                objects[i].Kill();

            }

        }

    }

}
