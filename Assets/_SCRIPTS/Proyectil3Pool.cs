using UnityEngine;

public class Proyectil3Pool : PoolParent
{
    public GameObject prefab3;

    protected override GameObject CreatePooledObject()
    {
        return Instantiate(prefab3);
    }
}
