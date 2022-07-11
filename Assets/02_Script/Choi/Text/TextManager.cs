using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextManager : MonoBehaviour
{

    [SerializeField] private float delay;
    [SerializeField] private string[] line;
    [SerializeField] private Text text;

    private int count;
    private bool isWriteing;

    void Start()
    {

        text.text = null;

    }

    public void Click()
    {

        if(isWriteing == false && count < line.Length) StartCoroutine(WriteText());

    }

    IEnumerator WriteText()
    {
 
        text.text = null;

        isWriteing = true;

        char[] line_Char = line[count].ToCharArray();

        for(int i = 0; i < line_Char.Length; i++)
        {

            text.text += line_Char[i];

            //소리 재생

            yield return new WaitForSeconds(delay);


        }

        count++;
        isWriteing = false;

    }

}
