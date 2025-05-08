using UnityEngine;

public class Proyectil2Pool : PoolParent
{
    public GameObject prefab2;

    protected override GameObject CreatePooledObject()
    {
        return Instantiate(prefab2);
    }
}
