using System.Collections.Generic;
using UnityEngine;

public abstract class PoolParent : MonoBehaviour
{
    public static PoolParent SharedInstance;
    public List<GameObject> pooledObjects;
    public int amountToPool;

    void Awake()
    {
        SharedInstance = this;
    }

    void Start()
    {
        pooledObjects = new List<GameObject>();
        for (int i = 0; i < amountToPool; i++)
        {
            GameObject obj = CreatePooledObject();
            obj.SetActive(false);
            pooledObjects.Add(obj);
        }
    }

    protected abstract GameObject CreatePooledObject();
    public GameObject GetPooledObject()
    {
        foreach (var obj in pooledObjects)
        {
            if (!obj.activeInHierarchy)
                return obj;
        }
        return null;
    }
}
