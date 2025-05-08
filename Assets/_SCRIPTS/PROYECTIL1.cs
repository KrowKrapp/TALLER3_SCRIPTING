using UnityEngine;

public class PROYECTIL1 : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Proyectil"))
        {
            return;
        }
        print(collision.gameObject.name);
        this.gameObject.SetActive(false);
    }
    
}
