using UnityEngine;
using UnityEngine.UI;

public class RecBlink : MonoBehaviour
{
    public Image image;
    public float speed = 1f; // vitesse du clignotement

    void Update()
    {
        float alpha = (Mathf.Sin(Time.time * speed * 3f) + 1f) * 0.5f;
        Color c = image.color;
        c.a = alpha;
        image.color = c;
    }
}
