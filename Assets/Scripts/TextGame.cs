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
    public GameObject LevelChoices;
    

    // Start is called before the first frame update
    void Start()
    {
        HPvalue = 10;
        Sanityvalue = 10;
        startofstory = "Hello??";
    }

    // Update is called once per frame
    void Update()
    {
        HPValue.text = HPvalue.ToString();
        SanityValue.text = Sanityvalue.ToString();
        Storytext.text = startofstory.ToString();
    }

    public void Hello()
    {
        Sanityvalue += 1;
        startofstory = "Heyyy";
        LevelChoices.SetActive(false);
    }
    public void Help()
    {
        HPvalue -= 2;
        startofstory = "Your scream is terrible...";
        LevelChoices.SetActive(false);
    }
    public void Silent()
    {
        Sanityvalue -= 1;
        startofstory = "Uh, hello??";
        LevelChoices.SetActive(false);
    }
}
