using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gracz : MonoBehaviour
{
    public double HP;
    public double maxHP;
    public double glod;
    public double woda;
    public double sen;

    public GUISkin skinHP;

    [HideInInspector]
    public double timer1;

    [HideInInspector]
    public double timer2;

    [HideInInspector]
    public double timer3;

    [HideInInspector]
    public double timer4;

    [HideInInspector]
    public double ileOdjac1;

    [HideInInspector]
    public double ileOdjac2;

    [HideInInspector]
    public double ileOdjac3;

    [HideInInspector]
    public double ileOdjac4;



    // Start is called before the first frame update
    void Start()
    {
        maxHP = 100;
        HP = maxHP;
        glod = 100;
        woda = 100;
        sen = 100;

        ileOdjac1 = 1;
        ileOdjac2 = 1;
        ileOdjac3 = 1;
        ileOdjac4 = 1;
    }

    // Update is called once per frame
    void Update()
    {
        if (HP <= 0)
        {
            HP = 0;
        }
        if (glod <= 0)
        {
            glod = 0;
        }
        if (woda <= 0)
        {
            woda = 0;
        }
        if (sen <= 0)
        {
            sen = 0;
        }
        // ustawianie maxHP maxGlod maxWoda maxSen - aby nie przekroczyc 100
        if (HP >= maxHP)
        {
            HP = maxHP;
        }
        if (glod >= 100)
        {
            glod = 100;
        }
        if (woda >= 100)
        {
            woda = 100;
        }
        if (sen >= 100)
        {
            sen = 100;
        }

        // odejmowanie HP poprzez glod

        if (timer1 >= 1)
        {
            timer1 = 0;
            glod -= ileOdjac1;
        }
        else timer1 += (Time.deltaTime * 0.9);

        // odejmowanie HP poprzez woda

        if (timer2 >= 1)
        {
            timer2 = 0;
            woda -= ileOdjac1;
        }
        else timer2 += (Time.deltaTime * 0.9);

        // odejmowanie HP poprzez sen

        if (timer3 >= 1)
        {
            timer3 = 0;
            sen -= ileOdjac1;
        }
        else timer3 += (Time.deltaTime * 0.9);

        // Dead

        if (HP <= 0)
        {
            Dead();
        }
        if (glod <= 25 || woda <= 25)
        {
            if (timer4 >= 3)
            {
                timer4 = 0;
                HP -= ileOdjac4;
            }
            else timer4 += (Time.deltaTime * 0.9);
        }
        if (HP < maxHP)
        {
            if (timer4 >= 3)
            {
                if (glod >= 75 && woda >= 75)
                {
                    timer4 = 0;
                    HP += ileOdjac1;
                }
            }
            else timer4 += (Time.deltaTime * 0.9);
        }


    }
    void OnGUI()
    {
        GUI.skin = skinHP;
        GUI.Box(new Rect(10, 10, 300, 50), "Zycie:" + HP);
        GUI.Box(new Rect(10, 65, 300, 50), "Glod:" + glod);
        GUI.Box(new Rect(10, 115, 300, 50), "Woda:" + woda);
        GUI.Box(new Rect(10, 165, 300, 50), "Sen:" + sen);


    }

    void Dead()
    {
        Destroy(gameObject);
    }
}
