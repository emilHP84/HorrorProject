using UnityEngine;

public class ChangeCamera : MonoBehaviour
{
    [SerializeField] private Camera[] cameras;     // Liste des caméras
    public int currentIndex = 0; // Caméra active

    void Start()
    {
        // Désactiver toutes les caméras sauf la première
        for (int i = 0; i < cameras.Length; i++)
        {
            cameras[i].gameObject.SetActive(i == currentIndex);
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E)) // touche pour changer
        {
            // Désactiver la caméra actuelle
            cameras[currentIndex].gameObject.SetActive(false);

            // Passer à la suivante
            currentIndex = (currentIndex + 1) % cameras.Length;

            // Activer la nouvelle caméra
            cameras[currentIndex].gameObject.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            Debug.Log("Camera preview");

            cameras[currentIndex].gameObject.SetActive(false);

            if (currentIndex == 0) 
            {
                currentIndex = cameras.Length - 1;
            }
            else
            {
                currentIndex--;
            }

            cameras[currentIndex].gameObject.SetActive(true);
        }
    }
}
