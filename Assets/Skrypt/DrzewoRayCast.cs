using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrzewoRayCast : MonoBehaviour
{

    public int odleglosc = 4;
    private Drzewo drzewo2;
    private DrzewoGracz animacja;

    // Start is called before the first frame update
   /* void Start()
    {
        
    }
    */
    // Update is called once per frame
    void Update()
    {
        RaycastHit hit;
        Vector3 fwd = transform.TransformDirection(Vector3.forward);
        if(Physics.Raycast(transform.position, fwd, out hit, odleglosc))
        {
            if (hit.collider.gameObject.tag=="Choinka")
            {
                Debug.Log("drzewo przed nami");
                drzewo2 = GameObject.Find(hit.collider.gameObject.name).GetComponent<Drzewo>();
                animacja = GameObject.Find("axe").GetComponent<DrzewoGracz>();

                if(Input.GetButtonDown("Fire1") && animacja.czyMoznaUderzyc == true)
                {
                    drzewo2.treeHP -= 1; 
                }
            }
        }
    }
}
