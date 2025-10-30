using UnityEngine;

public class MouseCursor : MonoBehaviour
{
    public void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
