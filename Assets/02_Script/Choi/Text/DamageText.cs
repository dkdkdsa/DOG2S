using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageText : MonoBehaviour
{
    [SerializeField] private float upSpeed;
    [SerializeField] private Material material;
    [SerializeField] private TextMesh textMesh;
    [SerializeField] private Color color;

    void Start()
    {

        StartCoroutine(ColorSet());

    }
    void Update()
    {

        transform.Translate(Vector2.up * upSpeed * Time.deltaTime);

    }

    IEnumerator ColorSet()
    {

        yield return null;

        while (textMesh.color.a != 0)
        {

            color.a -= 0.02f;
            textMesh.color = color;
            yield return new WaitForSeconds(0.01f);

        }

        Destroy(gameObject);

    }

}
