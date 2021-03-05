using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;
using System.Text;
using System;
using System.Threading;
using System.Threading.Tasks;

public class CallRestCasas : MonoBehaviour
{
	public string WEB_URL = "";
	private int casa1;
	private int casa2;
	private int casa3;
	private int dia;
	private int noche;
	private int sisa;
	public static bool call;
	// Use this for initialization
	void Start()
	{
		call = false;
		StartCoroutine(postUnityWebRequest());
		//StartCoroutine(getUnityWebRequest());

	}

	void Update()
	{

		Debug.Log("La casa " + call);
        if (TemperaturaCasas.caso1 == true && TemperaturaCasas.caso2 == false)
        {
			noche = 1;
			dia = 0;
        }
		if(TemperaturaCasas.caso2== true && TemperaturaCasas.caso1 == false)
        {
			dia = 1;
			noche = 0;
        }
        else
        {
			dia = 0;
			noche = 0;
        }

        if (TemperaturaCasas.capo == false)
        {
			sisa = 1;
        }
		else if (TemperaturaCasas.capo == true)
        {
			sisa = 0;
        }

	}

	IEnumerator postUnityWebRequest()
	{

		while (call == false)
		{

			if (DropSlotCasas1.encasilla == true && DropSlotCasas2.encasilla==true && DropSlotCasas3.encasilla==true)
			{
				Debug.Log("ENTRE AL POST");
				casa1 = BotonesSYS.temp1;
				casa2 = BotonesSYS2.temp2;
				casa3 = BotonesSYS3.temp3;
				//por2 = SliderCasas.porc;
				///<summary>
				/// Post using UnityWebRequest class
				/// </summary>
				/// var jsonString = "{\"Id\":3,\"Name\":\"Roy\"}";
				var jsonString = "{\"nodo\":" + LoginScript.id.ToString() + ", \"casa1\":" + casa1.ToString() + 
					", \"casa2\":" + casa2.ToString() + ", \"casa3\":" + casa3.ToString() + " " +
					", \"diacasa\":" + dia.ToString() + ", \"nochecasa\":" + noche.ToString() + 
					", \"capo\":" + sisa.ToString() + " }";

				byte[] byteData = System.Text.Encoding.ASCII.GetBytes(jsonString.ToCharArray());

				UnityWebRequest unityWebRequest = new UnityWebRequest(WEB_URL, "POST");
				unityWebRequest.uploadHandler = new UploadHandlerRaw(byteData);
				unityWebRequest.SetRequestHeader("Content-Type", "application/json");

				if (unityWebRequest.isNetworkError || unityWebRequest.isHttpError)
				{
					Debug.Log(unityWebRequest.error);
				}
				else
				{
					yield return unityWebRequest.SendWebRequest();
					Debug.Log("Form upload complete! Status Code: " + unityWebRequest.responseCode + (int)Time.time);
					//yield return new WaitForSeconds(1);
				}
			}
			yield return new WaitForSeconds(3);

		}

	}

	IEnumerator getUnityWebRequest()
	{
		UnityWebRequest www = UnityWebRequest.Get("https://api.thingspeak.com/channels/1057026/fields/1");
		yield return www.SendWebRequest();

		if (www.isNetworkError || www.isHttpError)
		{
			Debug.Log(www.error);
		}
		else
		{
			Debug.Log(www.downloadHandler.text);
		}
	}
}
