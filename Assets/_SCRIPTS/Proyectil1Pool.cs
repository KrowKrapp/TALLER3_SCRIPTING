using UnityEngine;

public class Proyectil1Pool : PoolParent
{
    public GameObject prefab1;

    protected override GameObject CreatePooledObject()
    {
        return Instantiate(prefab1);
    }
}
