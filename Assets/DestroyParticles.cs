using System.Collections;
using UnityEngine;

public class DestroyParticles : MonoBehaviour
{
    public ParticleSystem explosionEffect;
    public void ParticlesOn()
    {
        explosionEffect = GetComponent<ParticleSystem>();
        transform.parent = null;
        explosionEffect.Play();
        StartCoroutine(DestroyAfter(explosionEffect.main.duration));
    }
    private IEnumerator DestroyAfter(float delay)
    {
        yield return new WaitForSeconds(delay);
        Destroy(explosionEffect.gameObject);
    }
}
