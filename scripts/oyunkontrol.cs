using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class oyunkontrol : MonoBehaviour
{
    public GameObject animeci;
    public GameObject obje1;
    public GameObject obje2;
    public bool kontrolet = false;
    public int goster;
    public GameObject tikanmafekti;
    public GameObject tikanma;
    public GameObject skorcu;
    public int skor = 0;
    //public AudioSource pop;
    void Start()
    {
        skorcu.GetComponent<TextMesh>().text = skor.ToString();
    }

   

    // Update is called once per frame
    void Update()
    {


        

        


        if (kontrolet == true)
         {
           if (obje1.GetComponent<firlama>().eslesme + obje2.GetComponent<firlama>().eslesme<10) 
            {
                skor = skor + obje1.GetComponent<firlama>().eslesme + obje2.GetComponent<firlama>().eslesme;
                obje1.GetComponent<firlama>().fiskirtma();
                obje2.GetComponent<firlama>().cikacaksayi = obje1.GetComponent<firlama>().eslesme + obje2.GetComponent<firlama>().eslesme;
                obje2.GetComponent<firlama>().cikartma();
                obje1.GetComponent<firlama>().yokolma();
                skorcu.GetComponent<TextMesh>().text = skor.ToString();


            }

           if(obje1.GetComponent<firlama>().eslesme + obje2.GetComponent<firlama>().eslesme == 10) 
            {
                obje1.GetComponent<firlama>().fiskirtma(); obje2.GetComponent<firlama>().fiskirtma(); 
                obje1.GetComponent<firlama>().yokolma(); obje2.GetComponent<firlama>().yokolma(); skor = skor + 10;
                skorcu.GetComponent<TextMesh>().text = skor.ToString();
            }

           if (obje1.GetComponent<firlama>().eslesme + obje2.GetComponent<firlama>().eslesme > 10) 
            { 
                obje2.GetComponent<firlama>().yokolmaonustu(); 
                obje1.GetComponent<firlama>().yokolma(); 
                Instantiate(tikanma, obje2.transform.position, obje2.transform.rotation);
                
                Instantiate(tikanmafekti, obje1.transform.position, obje1.transform.rotation);
            }

           if (obje1.GetComponent<firlama>().eslesme != obje2.GetComponent<firlama>().eslesme) 
            {
                obje1 = obje2; obje2 = null; kontrolet = false; ; 
            }
         }
             
    }
}


