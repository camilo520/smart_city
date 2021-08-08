using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class BotonesSYS : MonoBehaviour
{
    public static int temp1;
    public Text Ttemp;

    // Start is called before the first frame update
    void Start()
    {
        temp1 = Random.Range(10, 35);
        Ttemp.gameObject.GetComponent<Text>().text = Mathf.RoundToInt(temp1) + " °C";

    }

    public void sumar1()
    {
        temp1 += 1;
        Ttemp.gameObject.GetComponent<Text>().text = Mathf.RoundToInt(temp1) + " °C";
    }

    public void restar1()
    {
        temp1 -= 1;
        Ttemp.gameObject.GetComponent<Text>().text = Mathf.RoundToInt(temp1) + " °C";
    }

}
