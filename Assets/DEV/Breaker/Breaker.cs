using UnityEngine;

[RequireComponent(typeof(BreakerQTE))]
public class Breaker : MonoBehaviour, IInteractable
{
    private BreakerQTE m_qte => GetComponent<BreakerQTE>();

    [Header("Breaker")]
    [SerializeField][Range(0,100)]private float m_durability = 100f;
    [SerializeField] private float m_passiveDamage = 0.1f;
    [SerializeField] private GameObject m_lightSpot;

    [Header("à La Réparation")]
    [SerializeField] private GameObject m_reparationPanel;
    [SerializeField][Range(1,5)] private int m_numberOfReparation;
    [SerializeField][Range(50,100)] private float m_percentOfReparation;
    private bool m_onReparation;

    [SerializeField] private Transform reparationPos;

    [Header("à L'interaction")]
    [SerializeField] private GameObject m_interactPanel;

    private void OnEnable()
    {

    }

    private void Awake()
    {
        m_interactPanel.SetActive(false);
        m_onReparation = false;
        m_reparationPanel.SetActive(false);
    }

    private void Start()
    {

    }

    private void Update()
    {
        if(m_qte.QTEResult() == true && m_onReparation)
        {
            m_durability += m_percentOfReparation;
            Debug.Log("G REUSSI");

            m_reparationPanel.SetActive(false);
            m_onReparation = false;
        }

        if (m_durability >= 50) m_lightSpot.SetActive(true);
        else m_lightSpot.SetActive(false);
    }

    public void Interact(KeyCode i)
    {
        if(i == KeyCode.E)
        {
            m_reparationPanel.SetActive(true);
            m_onReparation = true;
            m_interactPanel.SetActive(false);

            m_numberOfReparation = Random.Range(1, 5);
            m_percentOfReparation = Random.Range(50, 100);

            m_qte.LaunchQTE(m_numberOfReparation, m_percentOfReparation);
        }

        if(i == KeyCode.Space) 
        { 
            m_qte.PerformQTE();
        }

    }

    public void ShowInteractOnContat(bool value)
    {
        if (!m_onReparation)
        {
            m_interactPanel.SetActive(value);
        }
    }

    private void OnDisable()
    {
        
    }
}
