using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using DG.Tweening;

public class MapMove : MonoBehaviour
{

    [SerializeField] private Camera main_camera;
    [SerializeField] private GameObject stageBox;
    [SerializeField] private Text text;
    [SerializeField] private UI_Move move;

    private Stage[] target;
    private int count;
    private bool isMoveing;

    void Awake()
    {
        
        target = stageBox.GetComponentsInChildren<Stage>();

    }

    void Update()
    {

        MoveMap();

        text.text = $"STAGE : {count + 1}";

    }

    private void MoveMap()
    {


        if (Input.GetKeyDown(KeyCode.W) && isMoveing == false)
        {

            if(count == 0)
            {

                //SceneManager.LoadScene("Name");
                Debug.Log(1);
            }
            else
            {

                 --count;
                 StartCoroutine(Delay());

            }

        }
        else if (Input.GetKeyDown(KeyCode.S) && isMoveing == false)
        {

            if(count != target.Length)
            {

                ++count;
                StartCoroutine(Delay());

           }

        }
            
        
       

        Vector3 pos = new Vector3(target[count].transform.position.x, target[count].transform.position.y, -10);

        transform.position = Vector3.Lerp(transform.position, pos, Time.deltaTime * 5f);

    }

    IEnumerator Delay()
    {
        isMoveing = true; ;
        yield return new WaitForSeconds(1f);
        isMoveing = false;

    }

    public void Click()
    {

        PlayerPrefs.SetInt("Stage", count);

        move.Lode(true);

    }

}
