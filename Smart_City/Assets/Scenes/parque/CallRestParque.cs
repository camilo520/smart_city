using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;
using System.Text;
using System;
using System.Threading;
using System.Threading.Tasks;

public class CallRestParque : MonoBehaviour
{
	public string WEB_URL = "";
	public static bool call;
	void Start()
	{
		call = false;
		StartCoroutine(postUnityWebRequest());
		//StartCoroutine(getUnityWebRequest());

	}

	void Update()
	{

		

	}

	IEnumerator postUnityWebRequest()
	{

		while (call == false)
		{

			if (DropSlotParque.encasilla == true && DropSlotParque2.encasilla == true)
			{
				Debug.Log("ENTRE AL POST");
				//por2 = SliderCasas.porc;
				///<summary>
				/// Post using UnityWebRequest class
				/// </summary>
				/// var jsonString = "{\"Id\":3,\"Name\":\"Roy\"}";
				var jsonString = "{\"nodo\":" + LoginScript.userID.ToString() + ", \"suelo1\":" + ContadorHumedad.tiempo.ToString() +
									", \"suelo2\":" + ContadorHumedad.tiempo2.ToString() 
									+ ", \"reg1\":" + ContadorHumedad.reg1.ToString() +
									", \"reg2\":" + ContadorHumedad.reg2.ToString() + " }";

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
