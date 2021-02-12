using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firlatma : MonoBehaviour
{
    public GameObject[] firlayanlar;
   
    int secici;
    
    
    
    void Start()
    {
        cokluatma();
            
    }

    // Update is called once per frame
    void Update()
    {
        
        secici = Random.Range(0, firlayanlar.Length);
        
        
    }
    public void atma() 
    {
        float i;
        i = Random.Range(0, 0.5f);
        Invoke("esasatma", i);
        
    }
    public void esasatma() { secici = Random.Range(0, firlayanlar.Length); Instantiate(firlayanlar[secici], transform.position, firlayanlar[secici].transform.rotation); }
    void cokluatma() { Invoke("atma", 0.0f); Invoke("atma", 0.25f); Invoke("atma", 0.50f); Invoke("atma", 0.75f); Invoke("atma", 1f); }
}
    