using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;
using System.Text;
using System;
using System.Threading;
using System.Threading.Tasks;
public class CallRestEjecutivo : MonoBehaviour
{
	public string WEB_URL = "";
	private int espacio1;
	private int espacio2;
	private int espacio3;
	private int espacio4;
	private int espacio5;
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

		if (BotonEspacio1.disponible == true)
		{
			espacio1 = 1;
		}
		else if (BotonEspacio1.disponible == false)
		{
			espacio1 = 0;
		}

		if (BotonEspacio2.disponible == true)
		{
			espacio2 = 1;
		}
		else if (BotonEspacio2.disponible == false)
		{
			espacio2 = 0;
		}

		if (BotonEspacio3.disponible == true)
		{
			espacio3 = 1;
		}
		else if (BotonEspacio3.disponible == false)
		{
			espacio3 = 0;
		}

		if (BotonEspacio4.disponible == true)
		{
			espacio4 = 1;
		}
		else if (BotonEspacio4.disponible == false)
		{
			espacio4 = 0;
		}

		if (BotonEspacio5.disponible == true)
		{
			espacio5 = 1;
		}
		else if (BotonEspacio5.disponible == false)
		{
			espacio5 = 0;
		}

	}

	IEnumerator postUnityWebRequest()
	{

		while (call == false)
		{

			if (DropSlotEjecutivo1.encasilla == true && DropSlotEjecutivo2.encasilla == true && DropSlotEjecutivo3.encasilla == true && DropSlotEjecutivo4.encasilla == true && DropSlotEjecutivo5.encasilla == true)
			{
				Debug.Log("ENTRE AL POST");
				//por2 = SliderCasas.porc;
				///<summary>
				/// Post using UnityWebRequest class
				/// </summary>
				/// var jsonString = "{\"Id\":3,\"Name\":\"Roy\"}";
				var jsonString = "{\"nodo\":6, \"p1\":" + espacio1.ToString() +
					", \"p2\":" + espacio2.ToString() + ", \"p3\":" + espacio3.ToString() + " " +
					", \"p4\":" + espacio4.ToString() + ", \"p5\":" + espacio5.ToString() + " }";

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
