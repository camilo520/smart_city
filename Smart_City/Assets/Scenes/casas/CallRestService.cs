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
	private Timer timer1;
	public string WEB_URL = "";
	private int por;
	// Use this for initialization
	void Start()
	{
		//StartCoroutine(postUnityWebRequest());
		StartCoroutine(getUnityWebRequest());
		
	}

	private void Update()
	{
		StartCoroutine(postUnityWebRequest());
	}


    IEnumerator postUnityWebRequest()
	{
		por=Slider.porc;
		///<summary>
		/// Post using UnityWebRequest class
		/// </summary>
		/// var jsonString = "{\"Id\":3,\"Name\":\"Roy\"}";
		var jsonString = "{\"field1\":" + por.ToString() + "}";
		byte[] byteData = System.Text.Encoding.ASCII.GetBytes(jsonString.ToCharArray());

		UnityWebRequest unityWebRequest = new UnityWebRequest(WEB_URL, "POST");
		unityWebRequest.uploadHandler = new UploadHandlerRaw(byteData);
		unityWebRequest.SetRequestHeader("Content-Type", "application/json");
		yield return unityWebRequest.SendWebRequest();

		if (unityWebRequest.isNetworkError || unityWebRequest.isHttpError)
		{
			Debug.Log(unityWebRequest.error);
		}
		else
		{
			Debug.Log("Form upload complete! Status Code: " + unityWebRequest.responseCode);
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
