using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotonesSYS2 : MonoBehaviour
{
    public static int temp2;
    public Text Ttemp;

    // Start is called before the first frame update
    void Start()
    {
        temp2 = Random.Range(10, 35);
        Ttemp.gameObject.GetComponent<Text>().text = Mathf.RoundToInt(temp2) + " °C";

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void sumar1()
    {
        temp2 += 1;
        Ttemp.gameObject.GetComponent<Text>().text = Mathf.RoundToInt(temp2) + " °C";
    }

    public void restar1()
    {
        temp2 -= 1;
        Ttemp.gameObject.GetComponent<Text>().text = Mathf.RoundToInt(temp2) + " °C";
    }

}
