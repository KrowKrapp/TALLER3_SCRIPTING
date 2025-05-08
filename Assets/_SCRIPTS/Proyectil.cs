using UnityEngine;

public class Proyectil : MonoBehaviour
{
    public Vector3 PuntoA;
    public Vector3 PuntoB;
    public float Velocidad;
    public float lifetime = 7f;

    Rigidbody rb;
    void OnEnable()
    {
        CancelInvoke();
        Invoke("DisableSelf", lifetime);
    }

    void DisableSelf()
    {
        gameObject.SetActive(false);
    }
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    

    void Update()
    {
      rb.AddForce((PuntoB - PuntoA).normalized * Velocidad, ForceMode.Force);

    }
}
