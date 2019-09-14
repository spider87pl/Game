using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Ekwipunek : MonoBehaviour
{
    public int szerokoscOkna;
    public int wysokoscOkna;
    public int szerokoscOkna2;
    public int wysokoscOkna2;
    public int liczbaSlotow;

    void Start()
    {
        liczbaSlotow = 10;
        szerokoscOkna2 = 60;
        wysokoscOkna2 = 60;

        szerokoscOkna = szerokoscOkna2 * liczbaSlotow + 20;
        wysokoscOkna = Screen.height - (Screen.height - 70);
               
    }

    void Update()
    {
        
    }

    void OnGUI()
    {
        GUI.Box(new Rect((Screen.width / 2) - szerokoscOkna / 2 , Screen.height * 2 - (Screen.height + 100), szerokoscOkna, wysokoscOkna), "");
        GUI.Box(new Rect((Screen.width / 2) - szerokoscOkna / 2 + 10, Screen.height * 2 - (Screen.height + 95), szerokoscOkna2, wysokoscOkna2), "Slot 1");
        GUI.Box(new Rect((Screen.width / 2) - szerokoscOkna / 2 + szerokoscOkna2 + 10, Screen.height * 2 - (Screen.height + 95), szerokoscOkna2, wysokoscOkna2), "Slot 2");
        GUI.Box(new Rect((Screen.width / 2) - szerokoscOkna / 2 + 2*szerokoscOkna2 + 10, Screen.height * 2 - (Screen.height + 95), szerokoscOkna2, wysokoscOkna2), "Slot 3");
        GUI.Box(new Rect((Screen.width / 2) - szerokoscOkna / 2 + 3*szerokoscOkna2 + 10, Screen.height * 2 - (Screen.height + 95), szerokoscOkna2, wysokoscOkna2), "Slot 4");
        GUI.Box(new Rect((Screen.width / 2) - szerokoscOkna / 2 + 4*szerokoscOkna2 + 10, Screen.height * 2 - (Screen.height + 95), szerokoscOkna2, wysokoscOkna2), "Slot 5");
        GUI.Box(new Rect((Screen.width / 2) - szerokoscOkna / 2 + 5*szerokoscOkna2 + 10, Screen.height * 2 - (Screen.height + 95), szerokoscOkna2, wysokoscOkna2), "Slot 6");
        GUI.Box(new Rect((Screen.width / 2) - szerokoscOkna / 2 + 6*szerokoscOkna2 + 10, Screen.height * 2 - (Screen.height + 95), szerokoscOkna2, wysokoscOkna2), "Slot 7");
        GUI.Box(new Rect((Screen.width / 2) - szerokoscOkna / 2 + 7*szerokoscOkna2 + 10, Screen.height * 2 - (Screen.height + 95), szerokoscOkna2, wysokoscOkna2), "Slot 8");
        GUI.Box(new Rect((Screen.width / 2) - szerokoscOkna / 2 + 8*szerokoscOkna2 + 10, Screen.height * 2 - (Screen.height + 95), szerokoscOkna2, wysokoscOkna2), "Slot 9");
        GUI.Box(new Rect((Screen.width / 2) - szerokoscOkna / 2 + 9*szerokoscOkna2 + 10, Screen.height * 2 - (Screen.height + 95), szerokoscOkna2, wysokoscOkna2), "Slot 10");

    }
}
