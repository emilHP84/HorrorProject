using UnityEngine;

[RequireComponent (typeof(Rigidbody))]
public class MoveComponent : MonoBehaviour
{
    private Rigidbody m_rb => GetComponent<Rigidbody>();

    public void Moving(Vector3 pos, float speed, Vector3 rot)
    {
        Vector3 direction = transform.position + pos * speed * Time.deltaTime;
        Quaternion rotation = Quaternion.Euler(0, rot.y, 0);
        transform.position = direction;
        transform.rotation = rotation;
    }
}
