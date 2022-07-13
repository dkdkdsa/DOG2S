using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextManager : MonoBehaviour
{
    [SerializeField] private Image mainImage;
    [SerializeField] private Sprite[] images;
    [SerializeField] private float delay;
    [SerializeField] private string[] line;
    [SerializeField] private Text text;

    private int count;
    private bool isWriteing;

    void Start()
    {

        text.text = null;
        mainImage.sprite = null;

    }

    public void Click()
    {

        if(isWriteing == false && count < line.Length) StartCoroutine(WriteText());
        else SceneManager.LoadScene("Start");

    }

    public void Skip()
    {

        SceneManager.LoadScene("Start");

    }

    IEnumerator WriteText()
    {
 
        text.text = null;

        isWriteing = true;

        char[] line_Char = line[count].ToCharArray();

       mainImage.sprite = images[count];

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
