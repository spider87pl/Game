using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Menu : MonoBehaviour
  
{
    public Texture GameLogo;
    public float buttonWidth = 300;
    public float buttonHeight = 60;

    private float buttonMargin = 20;
    public GUISkin skin;
    public GUIStyle disabledButton;

    void OnGUI()
    {
            GUI.skin = skin;
            GUI.DrawTexture(new Rect(0, 0, 800, 300), GameLogo);


        GUI.BeginGroup(new Rect(300, 300, buttonWidth, (buttonHeight + buttonMargin) * 3));

        if (GUI.Button(new Rect(0, 0, buttonWidth, buttonHeight), "New Game"))
        {
            Application.LoadLevel("SampleScene");
        }
        if (GUI.Button(new Rect(0, buttonHeight + buttonMargin, buttonWidth, buttonHeight), "Options"))
        {

        }
        if (GUI.Button(new Rect(0, (buttonHeight + buttonMargin) * 2, buttonWidth, buttonHeight), "Exit"))
        {
            Application.Quit();
        }

        GUI.EndGroup();

        
    }
    // Start is called before the first frame update
    void Start()
    {
        //responsywność grafiki
        buttonWidth = (buttonWidth * Screen.width) / 1920;
        buttonHeight = (buttonHeight * Screen.height) / 1080;
        buttonMargin = (buttonMargin * Screen.height) / 1080;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   
}
