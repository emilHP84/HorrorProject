using UnityEngine;
using System;

[RequireComponent(typeof(MoveComponent))]

public class PlayerController : MonoBehaviour
{
    [Header("Mouvement")]
    private MoveComponent m_moving => GetComponent<MoveComponent>();

    public event EventHandler<EventArgs> OnRunningEventHandler;
    public event EventHandler<EventArgs> OnNoMouveEventHandler;
    public event EventHandler<EventArgs> OnMouvingEventHandler;

    [SerializeField] private float speed;
    [SerializeField] private float runSpeed;

    private Vector3 m_direction;

    private float m_actualSpeed;
    private float XMove;
    private float YMove;

    [Header("Camera")]
    [SerializeField] private Camera m_cam;
    [SerializeField] private float m_mouseSensibility;

    private Vector3 m_rotation;

    private float XMouse;
    private float YMouse;

    [Header("Interaction")]
    RaycastHit currentHit;
    bool m_hasInteract;


    private void Start()
    {
        m_actualSpeed = speed;
    }

    public void Update()
    {
        // MOUVEMENT ET CAMERA
        YMove = Input.GetAxis("Horizontal");
        XMove = Input.GetAxis("Vertical");

        XMouse = Input.GetAxis("Mouse X") * m_mouseSensibility * Time.deltaTime;
        YMouse = Input.GetAxis("Mouse Y") * m_mouseSensibility * Time.deltaTime;

        m_actualSpeed = Input.GetKey(KeyCode.LeftShift) ? runSpeed : speed;

        if (Input.GetKey(KeyCode.LeftShift))
        {
            OnRunningEventHandler?.Invoke(this, new System.EventArgs());
        }
        else if (YMove <= 0.1f && XMove <=0.1f)
        {
            OnNoMouveEventHandler?.Invoke(this, new System.EventArgs());
        }
        else if(YMove > 0.1f || XMove > 0.1f)
        {
            OnMouvingEventHandler?.Invoke(this, new System.EventArgs());

        }

        SetRotation();


        // INTERACTION
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        if (Physics.Raycast(ray, out RaycastHit hit, 3) && hit.transform.GetComponent<Breaker>())
        {
            currentHit = hit;
            currentHit.transform.GetComponent<IInteractable>().ShowInteractOnContact(true);

            if (Input.GetKey(KeyCode.E) && !m_hasInteract)
            {
                hit.transform.GetComponent<IInteractable>().Interact(KeyCode.E);
                m_hasInteract = true;
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                
                hit.transform.GetComponent<IInteractable>().Interact(KeyCode.Space);
            }
        }
        else
        {
            if (currentHit.transform != null) currentHit.transform.GetComponent<IInteractable>().ShowInteractOnContact(false);
            m_hasInteract = false;
        }

    }

    private void SetRotation()
    {
        Vector3 camForward = m_cam.transform.forward;
        Vector3 camRight = m_cam.transform.right;

        camForward.y = 0;
        camRight.y = 0;

        m_direction = (camForward * XMove) + (camRight * YMove);
    }

    void FixedUpdate()
    {
        m_moving.Moving(m_direction, m_actualSpeed, m_rotation);
    }

    void LateUpdate()
    {
        m_cam.GetComponent<CameraComponent>().RotateCamera(new Vector3(XMouse, YMouse, 0),90);
    }
}
