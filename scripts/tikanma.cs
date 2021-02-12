using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tikanma : MonoBehaviour
{
    public GameObject tikanmakontrol;
    void Start()
    {
        tikanmakontrol.GetComponent<tikanmakontrol>().i++;
        tikanmakontrol.GetComponent<tikanmakontrol>().tikanmalar[tikanmakontrol.GetComponent<tikanmakontrol>().i] = gameObject;
        

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
