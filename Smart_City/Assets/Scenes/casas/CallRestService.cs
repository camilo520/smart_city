using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;
using System.Text;
using System;
using System.Threading;
using System.Threading.Tasks;

public class CallRestService : MonoBehaviour
{
	private string WEB_URL = "http://34.235.22.152:3000/aptos";
	private int porcentaje;
	public static bool call;
	void Start()
	{
		call = false;
		StartCoroutine(postUnityWebRequest());
	
	}


	IEnumerator postUnityWebRequest()
	{
		
		while (call==false)
		{

			if (DropSlotApartamentos1.encasilla == true)
			{
				porcentaje = SliderCasas1.porc;
				var jsonString = "{\"nodo\":" + LoginScript.userID.ToString() + ", \"ruido\":" + porcentaje.ToString() +"}";
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
