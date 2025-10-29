using UnityEngine;

public class CameraComponent : MonoBehaviour
{
    float m_yRot;
    float m_xRot;

    private void Start()
    {
        m_yRot = 0;
        m_xRot = 0;
    }

    public void RotateCamera(Vector2 rot, float LimitedAxe)
    {
        m_yRot += rot.x;
        m_xRot -= rot.y;

        m_xRot = Mathf.Clamp( m_xRot, -LimitedAxe, LimitedAxe); ;

        transform.localRotation = Quaternion.Euler(m_xRot,m_yRot,0) ;
    }
}
