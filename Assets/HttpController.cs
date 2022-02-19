﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;

public class HttpController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(HttpConnect());
    }

    IEnumerator HttpConnect() {
        string url = "https://joytas.net/php/hello.php";
        UnityWebRequest uwr = UnityWebRequest.Get(url);
        yield return uwr.SendWebRequest();
        if(uwr.isHttpError || uwr.isNetworkError) {
            Debug.Log(uwr.error);
        } else {
            Debug.Log(uwr.downloadHandler.text);
        }
    }
}
