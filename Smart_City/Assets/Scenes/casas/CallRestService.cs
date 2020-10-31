using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.Networking;
using System.Text;
using System;


public class CallRestService : MonoBehaviour
{

	// Use this for initialization
	void Start()
	{
		StartCoroutine(postUnityWebRequest());
		StartCoroutine(getUnityWebRequest());
	}

	IEnumerator postUnityWebRequest()
	{
		///<summary>
		/// Post using UnityWebRequest class
		/// </summary>
		var jsonString = "{\"Id\":3,\"Name\":\"Roy\"}";
		byte[] byteData = System.Text.Encoding.ASCII.GetBytes(jsonString.ToCharArray());

		UnityWebRequest unityWebRequest = new UnityWebRequest("https://localhost:44326/api/values", "POST");
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
		UnityWebRequest www = UnityWebRequest.Get("https://localhost:44326/api/values/3");
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
