using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OgniskoObrazenia : MonoBehaviour
{
    public Gracz gracz;
    public Ognisko ognisko;
    public bool czyZadac;
    public int ileOdjacHP;
    public float timer7;
    void Start()
    {
        ileOdjacHP = 1;
    }

  
    void Update()
    {
        
    }
    void OnTriggerStay(Collider col)
    {
        czyZadac = true;
        if (col.tag == "Gracz" && czyZadac == true && ognisko.czyZapalone==true)
        {
            if (timer7 >= 0.1f)
            {
                timer7 = 0;
                gracz.HP -= ileOdjacHP;
            }
            else timer7 += (Time.deltaTime * 0.9f);
        }
    }
    private void OnTriggerExit(Collider col)
    {
        czyZadac = false;
    }
}
