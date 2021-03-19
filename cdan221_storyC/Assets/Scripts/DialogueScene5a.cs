using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene5a : MonoBehaviour
{
    public int primeInt = 1; // This integer drives game progress!
    public Text Char1name;
    public Text Char1speech;
    public Text Char2name;
    public Text Char2speech;
    public Text TimeText;
    // public Text Char3name;
    // public Text Char3speech;
    public GameObject dialogue;
    public GameObject ArtJazzTalking;
    public GameObject ArtJazzExcited;
    public GameObject ArtJazzSad;
    public GameObject ArtRivals;
    public GameObject ArtBG1;
    public GameObject Choice1a;
    public GameObject Choice1b;
	public GameObject Choice2a;
    public GameObject Choice2b;
    public GameObject NextScene1Button;
    public GameObject NextScene2Button;
    public GameObject nextButton;
    public GameHandler gameHandlerObj;
    public AudioSource audioSource;
    private bool allowSpace = true;

    void Start()
    {         // initial visibility settings
        dialogue.SetActive(false);
        ArtJazzTalking.SetActive(false);
        ArtJazzExcited.SetActive(false);
        ArtJazzSad.SetActive(false);
        ArtRivals.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
		Choice2a.SetActive(false);
        Choice2b.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
        nextButton.SetActive(true);
		
		// got nobody = primeInt 2-16		
		// got just K4t = primeInt 2-16
		// got just Meep = primeInt 2-16
		// got both = primeInt 20-34

		
		if ((gameHandlerObj.WhatIsMeep()== true )&&(gameHandlerObj.WhatIsK4t()== true )){
					primeInt = 19; //got both
				}
    }

    void Update()
    {         // use spacebar as Next button
        if (allowSpace == true)
        {
            if (Input.GetKeyDown("space"))
            {
                talking();
            }
        }
    }

    public void talking()
    {         // main story function. Players hit next to progress to next int
        primeInt = primeInt + 1;
        if (primeInt == 1)
        {
            // AudioSource.Play();
        }
        else if (primeInt == 2)
        {
            ArtJazzTalking.SetActive(false);
            ArtRivals.SetActive(true);
            dialogue.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Rivals";
            Char2speech.text = "Hey shrimp, how’s your last minute “band” coming along?";
        }
        else if (primeInt == 3)
        {
            ArtJazzTalking.SetActive(true);
            ArtRivals.SetActive(false);
            Char1name.text = "Jazz";
            Char1speech.text = "We are doing fine, thanks for asking.";
            Char2name.text = "";
            Char2speech.text = "";

        }
        else if (primeInt == 4)
        {
            ArtJazzTalking.SetActive(true);
            ArtRivals.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Rivals";
            Char2speech.text = "You really think you have what it takes to beat us at the talent show?";
        }
        else if (primeInt == 5)
        {
    
            Char1name.text = "Jazz";
            Char1speech.text = "Yeah, actually. I do. You guys don’t stand a chance.";
            Char2name.text = "";
            Char2speech.text = "";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 6)
        {
      
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Rivals";
            Char2speech.text = "Are you kidding me?? We’ve been together for a year and a half now. There’s no way you guys could get your act together that fast. What are you even playing?";
        }
        else if (primeInt == 7)
        {
            Char1name.text = "Jazz";
            Char1speech.text = "Why don't you mind your own business.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 8)
        {

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Rivals";
            Char2speech.text = "I bet it’s something stupid like twinkle twinkle little star!";
        }
        else if (primeInt == 9)
        {
            Char1name.text = "Jazz";
            Char1speech.text = "Whatever, I don't have time for you freaks.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 10)
        {
            ArtJazzTalking.SetActive(false);
            ArtRivals.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Rivals";
            Char2speech.text = "Hold on, I’m not done with you-";
        }
        else if (primeInt == 11)
        {
            ArtRivals.SetActive(true);
            ArtJazzTalking.SetActive(true);
            Char1name.text = "Jazz";
            Char1speech.text = "And what if I'm done with you?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 12)
        {
     
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Rivals";
            Char2speech.text = "I’m gonna knock your socks off if you interrupt me like that again, brat!";
        }
        else if (primeInt == 13)
        {
    
            Char1name.text = "Jazz";
            Char1speech.text = "I'm listening...";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 14)
        {

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Rivals";
            Char2speech.text = "I was about to tell you that I thi-";
        }
        else if (primeInt == 15)
        {
   
            Char1name.text = "Jazz";
            Char1speech.text = "Aaaaand I'm done listening. Bye!";
            Char2name.text = "";
            Char2speech.text = "";

        }
        else if (primeInt == 16)
        {
            ArtRivals.SetActive(true);
            ArtJazzTalking.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Rivals";
            Char2speech.text = "YOU LITTLE TWERP";
            Choice1a.SetActive(true); // function Choice1aFunct()
            Choice1b.SetActive(true); // function Choice1bFunct()

        }
		
		
		// if you have both members
		
		else if (primeInt == 20)
        {
            ArtJazzTalking.SetActive(false);
            ArtRivals.SetActive(true);
            dialogue.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Rivals";
            Char2speech.text = "Hey shrimp, how’s your last minute “band” coming along?";
        }
        else if (primeInt == 21)
        {
            ArtJazzTalking.SetActive(true);
            ArtRivals.SetActive(false);
            Char1name.text = "Jazz";
            Char1speech.text = "We are doing fine, thanks for asking.";
            Char2name.text = "";
            Char2speech.text = "";

        }
        else if (primeInt == 22)
        {
            ArtJazzTalking.SetActive(true);
            ArtRivals.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Rivals";
            Char2speech.text = "You really think you have what it takes to beat us at the talent show?";
        }
        else if (primeInt == 23)
        {
    
            Char1name.text = "Jazz";
            Char1speech.text = "Yeah, actually. I do. You guys don’t stand a chance.";
            Char2name.text = "";
            Char2speech.text = "";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 24)
        {
      
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Rivals";
            Char2speech.text = "Are you kidding me?? We’ve been together for a year and a half now. There’s no way you guys could get your act together that fast. What are you even playing?";
        }
        else if (primeInt == 25)
        {
            Char1name.text = "Jazz";
            Char1speech.text = "Why don't you mind your own business.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 26)
        {

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Rivals";
            Char2speech.text = "I bet it’s something stupid like twinkle twinkle little star!";
        }
        else if (primeInt == 27)
        {
            Char1name.text = "Jazz";
            Char1speech.text = "Whatever, I don't have time for you freaks.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 28)
        {
            ArtJazzTalking.SetActive(false);
            ArtRivals.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Rivals";
            Char2speech.text = "Hold on, I’m not done with you-";
        }
        else if (primeInt == 29)
        {
            ArtRivals.SetActive(true);
            ArtJazzTalking.SetActive(true);
            Char1name.text = "Jazz";
            Char1speech.text = "And what if I'm done with you?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 30)
        {
     
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Rivals";
            Char2speech.text = "I’m gonna knock your socks off if you interrupt me like that again, brat!";
        }
        else if (primeInt == 31)
        {
    
            Char1name.text = "Jazz";
            Char1speech.text = "I'm listening...";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 32)
        {

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Rivals";
            Char2speech.text = "I was about to tell you that I thi-";
        }
        else if (primeInt == 33)
        {
   
            Char1name.text = "Jazz";
            Char1speech.text = "Aaaaand I'm done listening. Bye!";
            Char2name.text = "";
            Char2speech.text = "";

        }
        else if (primeInt == 34)
        {
            ArtRivals.SetActive(true);
            ArtJazzTalking.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Rivals";
            Char2speech.text = "YOU LITTLE TWERP";
            Choice2a.SetActive(true); // function Choice2aFunct()
            Choice2b.SetActive(true); // function Choice2bFunct()

        }
    }

    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
    public void Choice1aFunct()
    {
        ArtJazzExcited.SetActive(false);
        ArtJazzTalking.SetActive(false);
        ArtRivals.SetActive(false);
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 99;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(false);
        allowSpace = true;
        NextScene1Button.SetActive(true);
    }
    public void Choice1bFunct()
    {
        ArtJazzExcited.SetActive(false);
        ArtJazzTalking.SetActive(true);
        ArtRivals.SetActive(false);
        Char1name.text = "Jazz";
        Char1speech.text = "It’s been fun, but I really don’t have time for neanderthals like you, and neither do my friends.";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 199;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(false);
        allowSpace = true;
        NextScene1Button.SetActive(true);
    }
	    public void Choice2aFunct()
    {
        ArtJazzExcited.SetActive(false);
        ArtJazzTalking.SetActive(false);
        ArtRivals.SetActive(false);
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 299;
        Choice2a.SetActive(false);
        Choice2b.SetActive(false);
        nextButton.SetActive(false);
        allowSpace = true;
        NextScene2Button.SetActive(true);
    }
    public void Choice2bFunct()
    {
        ArtJazzExcited.SetActive(false);
        ArtJazzTalking.SetActive(true);
        ArtRivals.SetActive(false);
        Char1name.text = "Jazz";
        Char1speech.text = "It’s been fun, but I really don’t have time for neanderthals like you, and neither do my friends.";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 399;
        Choice2a.SetActive(false);
        Choice2b.SetActive(false);
        nextButton.SetActive(false);
        allowSpace = true;
        NextScene2Button.SetActive(true);
    }
	
    public void SceneChange2a()
    {
        SceneManager.LoadScene("SceneLose");
    }
    public void SceneChange2b()
    {
        SceneManager.LoadScene("SceneWin");
    }
}

