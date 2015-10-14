using UnityEngine;
using System.Collections;

public class DownLoadAssets : MonoBehaviour
{
	delegate void DidFinishedDowned (Object obj);
	delegate void DidFailedDowned (string error);
	// Use this for initialization
//	string assetUrl = "file:///" + Application.dataPath + "/PackedAssets/PackedAssets";
//	void OnGUI ()
//	{
//		if (GUILayout.Button ("下载资源")) {
//
//
//		}
//	}

	void DownloadAsset (string url, int version, DidFinishedDowned finished, DidFailedDowned faild)
	{
//		StartCoroutine (url, version, finished, faild);
	}
	

	IEnumerator RequestAsset (string url, int version, DidFinishedDowned finished, DidFailedDowned faild)
	{
		WWW www = WWW.LoadFromCacheOrDownload (url, version);
//		while(!www.isDone)
//		{
//			yield return 0;
//		}
		if (www.error != null) {
			faild (www.error);
			yield break;
		}
		yield return www;
		finished (www.assetBundle);
	}






}
