using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ventanaEmergente : MonoBehaviour
{
    public GameObject panel;

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
}
