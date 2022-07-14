using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    [SerializeField] GameObject player;
    [SerializeField] float damage;
    [SerializeField] float hp;
    [SerializeField] float speed;
    float angle;
    int patternControll;


    private void OnEnable()
    {
        StartCoroutine(Pattern());
    }
    private void Update()
    {
        if (player.transform.position.x < transform.position.x)
        {
            angle = 180;
        }
        else
        {
            angle = 0;
        }
    }
    IEnumerator Pattern()
    {
        while (true)
        {
            patternControll = Random.Range(0, 2);
            Debug.Log(patternControll);
            switch (patternControll)
            {
                case 0:
                    StartCoroutine(Fire());
                    break;
                case 1:
                    StartCoroutine(FireBall());
                    break;
                default:
                    break;
            }
            yield return new WaitUntil(() => patternControll == -1);
            yield return new WaitForSeconds(1);
        }
    }
    IEnumerator Fire()
    {
        Debug.Log("파이어볼 발사 작동");
        
        for (int i = 0; i < 3; i++)
        {
            GameObject fire = PoolingManager._Instance.PopObj("Fireball");
            fire.transform.position = new Vector3(transform.position.x, transform.position.y -0.6f);
            fire.transform.rotation = Quaternion.Euler(0, 0, angle);
            yield return new WaitForSeconds(0.3f);
        }
        yield return new WaitForSeconds(1);
        for (int i = 0; i < 5; i++)
        {
            GameObject fire = PoolingManager._Instance.PopObj("Fireball");
            fire.transform.position = new Vector3(transform.position.x, transform.position.y - 0.6f);
            fire.transform.rotation = Quaternion.Euler(0, 0, angle);
            yield return new WaitForSeconds(0.65f);
        }
        patternControll = -1;
    }

    IEnumerator FireBall()
    {
        for (int i = 0; i < 4; i++)
        {
            yield return new WaitForSeconds(0.7f);
            for (int j = 0; j < 9; j++)
            {
                GameObject fire = PoolingManager._Instance.PopObj("Fireball");
                fire.transform.position = new Vector3(Random.Range(-16, 28), -159);
                fire.transform.rotation = Quaternion.Euler(0, 0, -90);
            }
        }
        yield return new WaitForSeconds(0.8f);
        patternControll = -1;
    }
}
