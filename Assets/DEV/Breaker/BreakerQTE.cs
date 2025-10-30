using System.Collections.Generic;
using UnityEngine;


public class BreakerQTE : MonoBehaviour
{
    [SerializeField] private Dictionary<int, float> points = new Dictionary<int, float>();
    [SerializeField] private float m_chronoSpeed;
    private float m_time;

    private bool m_qteResult = false;


    [Header("Test")]
    public List<GameObject> gameObjectsList = new List<GameObject>();
    public GameObject m_go;
    public Transform m_goParent;

    public GameObject textChrono;


    private void Update()
    {
        m_time += m_chronoSpeed * Time.deltaTime;
        if(m_time >= 1) m_time = 0;

        Debug.Log(gameObject.name +" "+ m_qteResult);
        Debug.Log(gameObject.name +" "+ points.Count);



        //textChrono.GetComponent<TextMeshProUGUI>().text = $"{m_time:F1}";
    }
    
    public void LaunchQTE(float numberOfReparation, float percentOfReparation)
    {
        for (int i = 0; i < numberOfReparation; i++)
        {
            points.Add(i, Random.value);
            m_qteResult = false;



            GameObject go = Instantiate(m_go,m_goParent);
            gameObjectsList.Add(go);
            //go.GetComponent<TextMeshProUGUI>().text = $"{points[i]:F1}";



            Debug.Log(points.Values);
        }
    }

    public void PerformQTE()
    {
        for (int i = 0; i < points.Count; i++)
        {
            if (m_time <= points[i] + 0.1f && m_time >= points[i] - 0.1f)
            {
                points.Remove(i);
                gameObjectsList.Remove(gameObjectsList[i]);
            }
            else
            {
                m_qteResult = false;
                Debug.Log("G RATE LE QTE PTN");
            }
        }
        CheckQTE();
    }

    private void CheckQTE()
    {
        if (points.Count == 0)
        {
            m_qteResult = true;
        }
    }

    public bool QTEResult()
    {

        return m_qteResult;
    }
}
