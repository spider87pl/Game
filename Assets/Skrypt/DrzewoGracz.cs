using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrzewoGracz : MonoBehaviour
{
    public bool czyMamSiekiere = false;
    public bool czyUderzam = false;
    public bool czyMoznaUderzyc = true;
    public int czasUderzenia = 1;
    CharacterController controller; 
    // Start is called before the first frame update
    void Start()
    {
        czyMamSiekiere = true;
        controller = GameObject.FindGameObjectWithTag("Gracz").GetComponent < CharacterController >();
    }

    // Update is called once per frame
    void Update()
    {
        if(czyMamSiekiere == true && czyMoznaUderzyc == true)
        {
            if(Input.GetMouseButton(0))
            {
                Debug.Log("animacja");  //wstawic animacje
                //animation.Play("Atak");
                czyUderzam = true;
                czyMoznaUderzyc = false;
            }
        }
        if (czyMoznaUderzyc == false)
        {
            czasUderzenia = 0;
        }
        if(czasUderzenia <= 0 )
        {
            czasUderzenia = 1;
            czyMoznaUderzyc = true;
            czyUderzam = false;
        }
    }
}
