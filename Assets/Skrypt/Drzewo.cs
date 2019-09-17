using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drzewo : MonoBehaviour
{
    public int treeHP = 5;
    public Transform klody;
    public GameObject drzewo;
    public Rigidbody rb;
    

    // Start is called before the first frame update
    void Start()
    {
        drzewo = this.gameObject;
        rb.isKinematic = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(treeHP <=0)
        {
            rb.isKinematic = false;
            TreeDestroy();
        }
    }
    void TreeDestroy()
    {
        Destroy(drzewo);
        Vector3 pozycja = new Vector3(Random.Range(-1.0f, 1.0f), 0, Random.Range(-1.0f, 1.0f));
        Instantiate(klody, drzewo.transform.position + new Vector3(0, 0, 0) + pozycja, Quaternion.identity);
        Instantiate(klody, drzewo.transform.position + new Vector3(2, 2, 2) + pozycja, Quaternion.identity);
        Instantiate(klody, drzewo.transform.position + new Vector3(4, 4, 4) + pozycja, Quaternion.identity);
    }

}
