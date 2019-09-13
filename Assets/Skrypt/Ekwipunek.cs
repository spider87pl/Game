using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Ekwipunek : MonoBehaviour
{
    public int szerokoscOkna;
    public int wysokoscOkna;
    
    void Start()
    {
        szerokoscOkna = 60;
        wysokoscOkna = 60;

        
    }

    void Update()
    {
        
    }

    void OnGUI()
    {
        GUI.Box(new Rect((Screen.width / 2) - szerokoscOkna / 2 + 10, Screen.height * 2 - (wysokoscOkna + 95), szerokoscOkna, wysokoscOkna), "");

    }
}
