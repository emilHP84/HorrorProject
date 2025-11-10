using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BreakerQTE : MonoBehaviour
{
    [SerializeField] private List<QTEValue> points = new List<QTEValue>();
    [SerializeField] private float m_chronoSpeed;
    private float m_time;

    [Header("Test")]
    public GameObject m_go;
    public Transform m_goParent;

    public GameObject textChrono;


    private void Update()
    {
        m_time += m_chronoSpeed * Time.deltaTime;
        if (m_time >= 1) m_time = 0;
        textChrono.GetComponent<TextMeshProUGUI>().text = $"{m_time:F1}";
    }

    public void LaunchQTE(float numberOfReparation)
    {
        for (int i = 0; i < numberOfReparation; i++)
        {
            QTEValue v = new QTEValue();
            v.IsValidated = false;
            v.Value = Random.Range(0f, 1f);
            v.Visual = Instantiate(m_go, m_goParent);

            points.Add(v);

            v.Visual.GetComponent<TextMeshProUGUI>().text = $"{v.Value:F1}";
        }
    }


    public void PerformQTE(float numberOfReparation)
    {
        QTEValue qteValid = null;

        foreach (QTEValue qte in points)
        {
            if (!qte.IsValidated)
            {
                if (m_time <= qte.Value + 0.1f && m_time >= qte.Value - 0.1f)
                {

                    qteValid = qte;
                }
                else
                {
                    QTELoose();
                }
            }
        }

        qteValid.Visual.GetComponent<TextMeshProUGUI>().color = Color.green;

        // remove from list qte
        // check if list = null

        points.Remove(qteValid);

        if (points.Contains(null))
        {
            QTESuccess();
        }
    }

    public bool QTESuccess()
    {
        points.Clear();
        return true;

    }

    public bool QTELoose()
    {
        points.Clear();
        return true;
    }


}
