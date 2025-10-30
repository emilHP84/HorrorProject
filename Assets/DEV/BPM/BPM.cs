using System;
using TMPro;
using UnityEngine;

public class BPM : MonoBehaviour
{
    public PlayerController playerController;

    [SerializeField] private BPMStatut e_bpmStatut;

    [SerializeField] private GameObject m_bpmPanel;

    [SerializeField]private float m_bpmCompter;
    [SerializeField]private float m_bpmCardiacEffect = 0;
    private float m_bpmCardiacMultiply;

    private bool m_isrunning;
    private bool m_isStatic;
    private bool m_onTheLight;
    private bool m_seeEntity;

    private void OnEnable()
    {
        playerController.OnNoMouveEventHandler += OnNoMouve;
        playerController.OnRunningEventHandler += OnRunning;
        playerController.OnMouvingEventHandler += OnMouving;
    }
    void Start()
    {
        m_bpmCompter = 80;
    }

    void Update()
    {
        m_bpmCompter += (m_bpmCardiacEffect * m_bpmCardiacMultiply) * Time.deltaTime;

        DefineBPMStatut();
        switch (e_bpmStatut)
        {
            case BPMStatut.stable:
                m_bpmCardiacMultiply = 1.0f;
                break;

            case BPMStatut.warning:
                m_bpmCardiacMultiply = 1.5f;
                break;

            case BPMStatut.critical:
                m_bpmCardiacMultiply = 3.0f;
                break;
        }
        CalculCardiacEffect();

        m_bpmPanel.GetComponent<TextMeshProUGUI>().text = $"{m_bpmCompter:F1}"  + " : " + e_bpmStatut;
    }

    private void DefineBPMStatut()
    {
        if (m_bpmCompter > 80 && m_bpmCompter < 100)
        {
            e_bpmStatut = BPMStatut.stable;
        }
        if (m_bpmCompter > 60 && m_bpmCompter < 80 || m_bpmCompter > 100 && m_bpmCompter < 140)
        {
            e_bpmStatut = BPMStatut.warning;
        }
        if (m_bpmCompter >= 40 && m_bpmCompter < 60 || m_bpmCompter > 140 && m_bpmCompter < 180)
        {
            e_bpmStatut = BPMStatut.critical;
        }
    }

    private void CalculCardiacEffect()
    {
        if (m_isrunning) m_bpmCardiacEffect = 3f;
        else if (m_isStatic) m_bpmCardiacEffect = -3f;
        else if(!m_isrunning && !m_isStatic) m_bpmCardiacEffect = 0;
    }


    void OnRunning(object sender, EventArgs e)
    {
        m_isrunning = true;
        m_isStatic = false;
    }
    void OnNoMouve(object sender, EventArgs e)
    {
        m_isStatic = true;
        m_isrunning = false;
    }
    void OnMouving(object sender, EventArgs e)
    {
        m_isStatic = false;
        m_isrunning = false;
    }

    private void OnDisable()
    {
        playerController.OnNoMouveEventHandler -= OnNoMouve;
        playerController.OnRunningEventHandler -= OnRunning;
        playerController.OnMouvingEventHandler -= OnMouving;
    }
}
