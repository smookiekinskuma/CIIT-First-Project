using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextGame : MonoBehaviour
{
    //Declare a variable int
    public int HPvalue, Sanityvalue;
    //Declare a variable TextMeshpro
    public TextMeshProUGUI HPValue, SanityValue, Storytext;
    //Declare a variable string
    public string startofstory;
    //Declare Game Object
    public GameObject LevelChoices, MainMenu, Scene1, HPText, SanityText, Scene2_Help, Scene2_Hello, Scene2_Silent;
    

    // Start is called before the first frame update
    void Start()
    {
        HPvalue = 10;
        Sanityvalue = 10;
        startofstory = "Fine, it's Candles";
    }

    // Update is called once per frame
    void Update()
    {
        HPValue.text = HPvalue.ToString();
        SanityValue.text = Sanityvalue.ToString();
        Storytext.text = startofstory.ToString();
    }

    //Scene 1
    public void Hello()
    {
        Sanityvalue += 1;
        startofstory = "Heyyy";
        LevelChoices.SetActive(false);
        Scene2_Hello.SetActive(true);
    }
    public void Help()
    {
        HPvalue -= 2;
        startofstory = "Your scream is terrible...";
        LevelChoices.SetActive(false);
        Scene2_Help.SetActive(true);
    }
    public void Silent()
    {
        Sanityvalue -= 1;
        startofstory = "Uh, hello??";
        LevelChoices.SetActive(false);
        Scene2_Silent.SetActive(true);
    }

    //Scene2_Help

    public void Who()
    {
        Sanityvalue += 1;
        startofstory = "I like ya! (You live to see the next day)";
        Scene2_Silent.SetActive(false);
    }

    public void Sorry()
    {
        Sanityvalue -= 1;
        startofstory = "Oh, sorry :( (You live to see the next day)";
    }


    //Start and Exit Buttons!!!

    public void ExitButton()
    {
        Application.Quit();
    }

    public void StartButton()
    {
        MainMenu.SetActive(false);
        startofstory = "Hello?";
        HPText.SetActive(true);
        SanityText.SetActive(true);
        Scene1.SetActive(true);
    }
}
