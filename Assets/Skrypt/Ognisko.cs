using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ognisko : MonoBehaviour
{

    public bool czyPokazac;
    public bool czyMozna;
    public bool czyZapalone;
    public bool czyZapalic;
    public ParticleSystem partikle1;
    public ParticleSystem partikle2;
    public AudioSource dzwiek;
    public Light swiatlo;
    public float timer6;

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
        if (czyMozna == false)
            czyZapalic = false;

        if (timer6 >= 60)
        {
            timer6 = 0;
            partikle1.enableEmission = false;
            partikle2.enableEmission = false;
            dzwiek.Stop();
            swiatlo.enabled = false;
            czyZapalone = false;
            czyMozna = true;
            czyZapalic = true;
            czyPokazac = false;
        }
        else if (czyZapalone == true)
        {
            timer6 += (Time.deltaTime * 0.9f);
        }


    }
    private void OnTriggerStay(Collider col)
    {
         if(col.tag == "Gracz")
        {
            if (czyZapalone == true)
                czyPokazac = true;
            czyZapalic = true;
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

            if (czyZapalone == true && Input.GetKeyDown(KeyCode.F))
            {
                timer6 = 0;
                partikle1.enableEmission = false;
                partikle2.enableEmission = false;
                dzwiek.Stop();
                swiatlo.enabled = false;
                czyZapalone = false;
                czyMozna = true;
                czyZapalic = true;
                czyPokazac = false;
            }
        }
    }

    private void OnGUI()
    {
        if (czyZapalic == true )
        {
            GUI.Box(new Rect((Screen.width / 2) - 100, (Screen.height * 2) - Screen.height - 150, 200, 50), " Nacisnij E aby zapalic ognisko");
        }

        if (czyPokazac == true)
        {
            GUI.Box(new Rect((Screen.width / 2) - 100, (Screen.height * 2) - Screen.height - 150, 200, 50), " Nacisnij F aby zgasic ognisko");
        }
    }

    void OnTriggerExit(Collider col)
    {
        czyZapalic = false;
        czyPokazac = false;
    }
}
