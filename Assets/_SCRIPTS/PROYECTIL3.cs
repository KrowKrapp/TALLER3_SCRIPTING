using System.Collections;
using UnityEngine;

public class PROYECTIL3 : MonoBehaviour
{
    public GameObject explosionEffect;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Proyectil"))
            return;

        GameObject tmp = Instantiate(explosionEffect, transform.position, Quaternion.identity);
        DestroyParticles destroyParticles = tmp.GetComponent<DestroyParticles>();
        destroyParticles.ParticlesOn();
        gameObject.SetActive(false);
    }

}
