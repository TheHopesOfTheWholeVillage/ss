﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DC01PlayBtn : MonoBehaviour {

    public GameObject MouseSS;
    
    void OnSelect()
    {

        GameObject.Find("AudioSource").GetComponent<AudioSource>().Play();
        MouseSS.GetComponent<FenJieManager>().PlayChaiDianChiAni();

    }
    
}
