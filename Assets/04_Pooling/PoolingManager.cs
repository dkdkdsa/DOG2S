using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolingManager : MonoBehaviour
{
    public static PoolingManager _Instance = null;
    [SerializeField] List<PoolingData> _poolingData = new List<PoolingData>();

    private void Awake()
    {
        if (_Instance == null)
            _Instance = this;

        InitialPooling();
    }
    /// <summary>
    /// Ǯ�� �� ������Ʈ�� �̸� ����
    /// </summary>
    private void InitialPooling()
    {
        for (int i = 0; i < _poolingData.Count; i++)
        {
            for (int j = 0; j < _poolingData[i]._poolingMaxCount; j++)
            {
                GameObject poolObj = Instantiate(_poolingData[i]._poolObj);
                poolObj.GetComponent<PooledObj>().Name = _poolingData[i]._poolObj.name;
                poolObj.SetActive(false);
                _poolingData[i]._poolingList.Add(poolObj);
            }
        }
    }
    /// <summary>
    /// Ǯ�� �� ���� �ҷ����� �Լ�
    /// </summary>
    /// <param name="objName"></param>
    /// <returns></returns>
    public GameObject PopObj(string objName)
    {
        //��ȯ �� �� ��
        GameObject returnObj = null;
        //_poolingData�� ����Ʈ�̹Ƿ� �� ����Ʈ�� ����ŭ �ݺ�
        foreach (PoolingData poolingData in _poolingData)
        {
            //�޾ƿ� �̸��̶� poolingData�� �̸��� ���ٸ�
            if (poolingData._poolName == objName)
            {
                //���� ����Ʈ�� ���� �� ����ִٸ�
                if (poolingData._poolingList.Count <= 0)
                {
                    //���� ���� �� ����Ʈ�� ����
                    returnObj = Instantiate(poolingData._poolObj);
                    returnObj.GetComponent<PooledObj>().Name = poolingData._poolName;
                }
                else
                {
                    returnObj = poolingData._poolingList[0];
                    poolingData._poolingList.RemoveAt(0);
                }

                returnObj.SetActive(true);

                //��ȯ
                return returnObj;
            }
        }
        return null;
    }
    /// <summary>
    /// ������Ʈ ��Ȱ��ȭ
    /// </summary>
    /// <param name="objName"></param>
    /// <param name="obj"></param>
    public void PushObj(string objName, GameObject obj)
    {
        foreach (PoolingData poolingData in _poolingData)
        {
            //�޾ƿ� �̸��̶� poolingData�� �̸��� ���ٸ�
            if (poolingData._poolName == objName)
            {
                obj.SetActive(false);
                poolingData._poolingList.Add(obj);
                return;
            }
        }

    }
}
[System.Serializable]
public class PoolingData
{
    [Header("Ǯ�� ������")]

    [Tooltip("Ǯ�� �� ������Ʈ�� ������ ����Ʈ")]
    public List<GameObject> _poolingList = new List<GameObject>();
    [Tooltip("Ǯ�� �� ��ü")]
    public GameObject _poolObj;
    [Tooltip("Ǯ�� �� ������Ʈ�� �̸�")]
    public string _poolName = string.Empty;
    [Tooltip("Ǯ���� �󸶳� �Ұ���")]
    public int _poolingMaxCount;
}
