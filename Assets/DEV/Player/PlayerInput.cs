using System;
using UnityEngine;

[Serializable]
public class PlayerInput : MonoBehaviour
{
    [Header("Mouvement")]
    [SerializeField] private KeyCode run = KeyCode.LeftShift;
    [SerializeField] private KeyCode interact = KeyCode.E;


    private float XMove;
    private float YMove;

    [Header("Camera")]
    private float XMouse;
    private float YMouse;

    private KeyCode currentKey;

    private void OnEnable()
    {
        
    }

    private void Awake()
    {

    }

    private void Start()
    {

    }

    private void Update()
    {
        YMove = Input.GetAxis("Horizontal");
        XMove = Input.GetAxis("Vertical");

        XMouse = Input.GetAxis("Mouse X");
        YMouse = Input.GetAxis("Mouse Y");

        if (Input.GetKey(run)) { }
    }

    private void OnDisable()
    {
        
    }

    private void OnDestroy()
    {
        
    }
}
