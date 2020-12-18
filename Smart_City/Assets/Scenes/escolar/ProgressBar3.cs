using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBar3 : MonoBehaviour
{
    private Slider slider;
    private float targetProgress = 40f;

    private void Awake()
    {
        slider = gameObject.GetComponent<Slider>();
    }

    // Start is called before the first frame update
    void Start()
    {
        Incremento(40f);

    }

    // Update is called once per frame
    void Update()
    {
        if (slider.value < targetProgress)
        {
            slider.value = ContadorBasura.tiempo3;
        }
        var fill = (slider as UnityEngine.UI.Slider).GetComponentsInChildren<UnityEngine.UI.Image>().FirstOrDefault(t => t.name == "Fill");
        if (ContadorBasura.tiempo3 < 15)
        {
            fill.color = Color.Lerp(Color.green, Color.green, 0.5f);
        }
        if (ContadorBasura.tiempo3 >= 15)
        {
            fill.color = Color.Lerp(Color.yellow, Color.yellow, 0.5f);
        }
        if (ContadorBasura.tiempo3 >= 26)
        {
            fill.color = Color.Lerp(Color.red, Color.red, 0.5f);
        }
    }

    public void Incremento(float newProgress)
    {
        targetProgress = slider.value + newProgress;
    }
}
