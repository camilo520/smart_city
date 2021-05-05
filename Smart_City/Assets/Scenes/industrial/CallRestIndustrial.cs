using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;
using System.Text;
using System;
using System.Threading;
using System.Threading.Tasks;
public class CallRestIndustrial : MonoBehaviour
{
	private string WEB_URL = "http://34.235.22.152:3000/industriales";
	private int tipoContaminante;
	private string valorContaminacion;
	public static bool call;
	// Use this for initialization
	void Start()
	{
		tipoContaminante = 0;
		call = false;
		StartCoroutine(postUnityWebRequest());
		//StartCoroutine(getUnityWebRequest());

	}

	void Update()
	{
		Debug.Log(WEB_URL);

		if (CasosIndustrial.caso1 == true)
        {
			tipoContaminante = 1;
        }
        if (CasosIndustrial.caso2 == true)
        {
			tipoContaminante = 2;
		}
        if (CasosIndustrial.caso3 == true)
        {
			tipoContaminante = 3;
		}


	}

	IEnumerator postUnityWebRequest()
	{

		while (call == false)
		{

			if (DropSlotIndustrial.encasilla == true)
			{
				Debug.Log("ENTRE AL POST");
				//por2 = SliderCasas.porc;
				///<summary>
				/// Post using UnityWebRequest class
				/// </summary>
				/// var jsonString = "{\"Id\":3,\"Name\":\"Roy\"}";
				var jsonString = "{\"nodo\":" + LoginScript.userID.ToString() + ", \"tipoc\":" + tipoContaminante +
					", \"contaminacion\":" + ContadorContaminacion.contaminacion.ToString() +  " }";

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
