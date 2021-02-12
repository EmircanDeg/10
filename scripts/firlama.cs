using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firlama : MonoBehaviour
{
    Rigidbody rb;
    public float guc;
    public int eslesme;
    GameObject kontol;
    public float xsinirlama;
    float zsinir;
    public GameObject[] cikacaklar;
    public int cikacaksayi;
    public GameObject fiskirmapatickle;
    public GameObject cikartici;
    public GameObject icindeki;
    public GameObject outline;
    void Start()
    {
        zsinir = transform.position.z;
        kontol = GameObject.Find("oyunkontrol");
        rb = gameObject.GetComponent<Rigidbody>();
        
    }

    
    void Update()
    {
        transform.position = new Vector3(xsinirlama, transform.position.y, zsinir);
    }
    private void OnMouseDown()
    {
        rb.velocity = Vector3.zero;
        //rb.AddForce(Random.Range(-200,200), Random.Range(0, 100), Random.Range(-200, 200));
        if (kontol.GetComponent<oyunkontrol>().obje1 == null) {  kontol.GetComponent<oyunkontrol>().obje1 = gameObject;Debug.Log("sayisi = " + eslesme);icindeki.GetComponent<kupiciscript>().animasyonoynat();outline.GetComponent<secimoutline>().degistir(); }
        else if (kontol.GetComponent<oyunkontrol>().obje2 == null) { if (Object.ReferenceEquals(gameObject, kontol.GetComponent<oyunkontrol>().obje1) == false) { kontol.GetComponent<oyunkontrol>().obje2 = gameObject; kontol.GetComponent<oyunkontrol>().kontrolet = true; } }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "bomba") {Destroy(gameObject); }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "bomba") {  Destroy(gameObject); }
    }
    public void cikartma() {olmeanimasyon(); Instantiate(cikacaklar[cikacaksayi-1], transform.position, transform.rotation); Destroy(gameObject); }
    public void yokolma() { Destroy(gameObject); cikartici.GetComponent<firlatma>().atma(); }
    public void yokolmaonustu() {olmeanimasyon(); Destroy(gameObject); }
    public void fiskirtma() { Instantiate(fiskirmapatickle, transform.position, transform.rotation); }
    public void olmeanimasyon() { icindeki.GetComponent<kupiciscript>().olmeanimasyon(); }
}
