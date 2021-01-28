using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BotonesSYS3 : MonoBehaviour
{
    public static int temp3;
    public Text Ttemp;

    // Start is called before the first frame update
    void Start()
    {
        temp3 = Random.Range(10, 35);
        Ttemp.gameObject.GetComponent<Text>().text = Mathf.RoundToInt(temp3) + " °C";

    }

    // Update is called once per frame
    void Update()
    {

    }


    public void sumar1()
    {
        temp3 += 1;
        Ttemp.gameObject.GetComponent<Text>().text = Mathf.RoundToInt(temp3) + " °C";
    }

    public void restar1()
    {
        temp3 -= 1;
        Ttemp.gameObject.GetComponent<Text>().text = Mathf.RoundToInt(temp3) + " °C";
    }
}
