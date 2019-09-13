using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ognisko : MonoBehaviour
{

    public bool czyZapalic;
    public bool czyMozna;
    public bool czyZapalone;
    public bool czyPokazac;
    public ParticleSystem partikle1;
    public ParticleSystem partikle2;
    public AudioSource dzwiek;
    public Light swiatlo;

    // Start is called before the first frame update
    void Start()
    {
        partikle1.enableEmission = false;
        partikle2.enableEmission = false;
        swiatlo.enabled = false;
        czyMozna = true;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider col)
    {
         if(col.tag == "Gracz")
        {
            if (czyZapalic == true && Input.GetKeyDown(KeyCode.E))
            {
                partikle1.enableEmission = true;
                partikle2.enableEmission = true;
                dzwiek.Play();
                swiatlo.enabled = true;
                czyZapalone = true;
                czyMozna = false;
                czyZapalic = false;

            }
        }
    }

    private void OnGUI()
    {
        if (czyZapalic == true )
        {
            GUI.Box(new Rect((Screen.width / 2) - 100, (Screen.height * 2) - Screen.height - 150, 200, 50, " Nacisnij E aby zapalic ognisko"));
        }
    }
}
