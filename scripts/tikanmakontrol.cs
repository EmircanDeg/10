using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class tikanmakontrol : MonoBehaviour
{
    public int i = 0;
    public GameObject[] tikanmalar;
    public GameObject[] cikaricilar;
    float x;

    void Start()
    {

    }


    public void tikanmakaldirici()
    {
        Debug.Log("BASİLDİ");
        if (i >1) 
        {
            if (x < -1f) { cikaricilar[0].GetComponent<firlatma>().atma(); }
            if (x > -1f && x < 1) { cikaricilar[1].GetComponent<firlatma>().atma(); }
            if (x > 1f && x < 2) { cikaricilar[2].GetComponent<firlatma>().atma(); }
            if (x  > 2f && x < 3) { cikaricilar[3].GetComponent<firlatma>().atma(); }
            if (x > 3f) { cikaricilar[4].GetComponent<firlatma>().atma(); }
            Destroy(tikanmalar[i]);
            i--; 
        }
    }

    public void home() { SceneManager.LoadScene("home"); }
    void Update()
    {
        x = tikanmalar[i].transform.position.x;
        //Debug.Log(i);
    }
}
