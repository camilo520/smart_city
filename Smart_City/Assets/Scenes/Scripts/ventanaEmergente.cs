using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ventanaEmergente : MonoBehaviour
{
    public GameObject panel;
    public GameObject panel2;
    public GameObject panel3;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void openPanel()
    {
        if(panel != null)
        {
            panel.SetActive(true);
        }
    }

    public void closePanel()
    {
        if(panel != null)
        {
            panel.SetActive(false);
        }
    }

    public void openPanel2()
    {
        if (panel2 != null)
        {
            panel2.SetActive(true);
        }
    }

    public void closePanel2()
    {
        if (panel2 != null)
        {
            panel2.SetActive(false);
        }
    }

    public void openPanel3()
    {
        if (panel3 != null)
        {
            panel3.SetActive(true);
        }
    }

    public void closePanel3()
    {
        if (panel3 != null)
        {
            panel3.SetActive(false);
        }
    }
}
