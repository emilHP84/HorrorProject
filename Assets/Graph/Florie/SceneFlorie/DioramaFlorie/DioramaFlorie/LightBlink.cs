using UnityEngine;
using System.Collections;

public class LightBlink : MonoBehaviour
{
    public Light spotLight;        // Ta lumière
    public float minDelay = 0.5f;  // Temps minimum entre clignotements
    public float maxDelay = 3f;    // Temps maximum entre clignotements
    public float blinkDuration = 0.1f; // Durée pendant laquelle la lumière s’allume

    void Start()
    {
        if (spotLight == null)
            spotLight = GetComponent<Light>();

        StartCoroutine(BlinkRoutine());
    }

    IEnumerator BlinkRoutine()
    {
        while (true)
        {
            // Attente aléatoire avant le prochain clignotement
            float wait = Random.Range(minDelay, maxDelay);
            yield return new WaitForSeconds(wait);

            // ON
            spotLight.enabled = true;
            yield return new WaitForSeconds(blinkDuration);

            // OFF
            spotLight.enabled = false;
        }
    }
}
