using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene5b : MonoBehaviour
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
    //public AudioSource audioSource;
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
		
		// got nobody = primeInt 20-32	
		// got just K4t = primeInt 20-32
		// got just Meep = primeInt 20-32
		// got both = primeInt 2-14

		
		if ((gameHandlerObj.WhatIsMeep()== false )&&(gameHandlerObj.WhatIsK4t()== true )){
					primeInt = 19; //got k4t
				}
		else if ((gameHandlerObj.WhatIsMeep()== true )&&(gameHandlerObj.WhatIsK4t()== false )){
					primeInt = 19; //got meep
				}
		else if ((gameHandlerObj.WhatIsMeep()== false )&&(gameHandlerObj.WhatIsK4t()== false )){
					primeInt = 19; //got no one
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
            Char1speech.text = "You know what? We are actually doing really well.";
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
            Char1speech.text = "I’m not sure actually… but we’re going to do our best either way.";
            Char2name.text = "";
            Char2speech.text = "";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 6)
        {

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Rivals";
            Char2speech.text = "I guess I can’t knock you for that. I’m just surprised you could get your act together so quickly.";
        }
        else if (primeInt == 7)
        {
            Char1name.text = "Jazz";
            Char1speech.text = "Well, who knows what will happen on that stage.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 8)
        {

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Rivals";
            Char2speech.text = "Well we’ve been practicing together for years now, if you think you have what it takes to beat us, I can only wish you luck.";
        }
        else if (primeInt == 9)
        {
            Char1name.text = "Jazz";
            Char1speech.text = "Thanks I guess? We’re really just in it for the fun.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 10)
        {
         
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Rivals";
            Char2speech.text = "That’s good. As long as you don’t expect to win, you shouldn’t be disappointed.";
        }
        else if (primeInt == 11)
        {

            Char1name.text = "Jazz";
            Char1speech.text = "...alright.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 12)
        {

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Rivals";
            Char2speech.text = "Glad to know you won’t be a threat, kid.";
        }
        else if (primeInt == 13)
        {
            ArtJazzExcited.SetActive(true);
            ArtJazzTalking.SetActive(false);
            Char1name.text = "Jazz";
            Char1speech.text = "We’re still going to try our best! We could win you know!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 14)
        {
            ArtJazzExcited.SetActive(false);
            ArtJazzSad.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Rivals";
            Char2speech.text = "Ha, sure kid. You have a good day, now.";
            Choice1a.SetActive(true); // function Choice1aFunct()
            Choice1b.SetActive(true); // function Choice1bFunct()

        }
		
		// got meep/ket/no one
		
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
            Char1speech.text = "You know what? We are actually doing really well.";
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
            Char1speech.text = "I’m not sure actually… but we’re going to do our best either way.";
            Char2name.text = "";
            Char2speech.text = "";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 24)
        {

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Rivals";
            Char2speech.text = "I guess I can’t knock you for that. I’m just surprised you could get your act together so quickly.";
        }
        else if (primeInt == 25)
        {
            Char1name.text = "Jazz";
            Char1speech.text = "Well, who knows what will happen on that stage.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 26)
        {

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Rivals";
            Char2speech.text = "Well we’ve been practicing together for years now, if you think you have what it takes to beat us, I can only wish you luck.";
        }
        else if (primeInt == 27)
        {
            Char1name.text = "Jazz";
            Char1speech.text = "Thanks I guess? We’re really just in it for the fun.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 28)
        {
         
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Rivals";
            Char2speech.text = "That’s good. As long as you don’t expect to win, you shouldn’t be disappointed.";
        }
        else if (primeInt == 29)
        {

            Char1name.text = "Jazz";
            Char1speech.text = "...alright.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 30)
        {

            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Rivals";
            Char2speech.text = "Glad to know you won’t be a threat, kid.";
        }
        else if (primeInt == 31)
        {
            ArtJazzExcited.SetActive(true);
            ArtJazzTalking.SetActive(false);
            Char1name.text = "Jazz";
            Char1speech.text = "We’re still going to try our best! We could win you know!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 32)
        {
            ArtJazzExcited.SetActive(false);
            ArtJazzSad.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Rivals";
            Char2speech.text = "Ha, sure kid. You have a good day, now.";
            Choice2a.SetActive(true); // function Choice1aFunct()
            Choice2b.SetActive(true); // function Choice1bFunct()

        }
    }

    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
    public void Choice1aFunct()
    {
        ArtJazzTalking.SetActive(false);
        ArtJazzExcited.SetActive(false);
        ArtJazzSad.SetActive(true);
        ArtRivals.SetActive(true);
        Char1name.text = "Jazz";
        Char1speech.text = "*Sticks out tongue*";
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
        ArtJazzTalking.SetActive(false);
        ArtJazzSad.SetActive(true);
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "Jazz";
        Char2speech.text = "...";
        primeInt = 199;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(false);
        allowSpace = true;
        NextScene1Button.SetActive(true);
    }
	
	public void Choice2aFunct()
    {
        ArtJazzTalking.SetActive(false);
        ArtJazzExcited.SetActive(false);
        ArtJazzSad.SetActive(true);
        ArtRivals.SetActive(true);
        Char1name.text = "Jazz";
        Char1speech.text = "*Sticks out tongue*";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 399;
        Choice2a.SetActive(false);
        Choice2b.SetActive(false);
        nextButton.SetActive(false);
        allowSpace = true;
        NextScene2Button.SetActive(true);
    }
    public void Choice2bFunct()
    {
        ArtJazzExcited.SetActive(false);
        ArtJazzTalking.SetActive(false);
        ArtJazzSad.SetActive(true);
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "Jazz";
        Char2speech.text = "...";
        primeInt = 499;
        Choice2a.SetActive(false);
        Choice2b.SetActive(false);
        nextButton.SetActive(false);
        allowSpace = true;
        NextScene2Button.SetActive(true);
    }
    public void SceneChange2a()
    {
        SceneManager.LoadScene("SceneWin");
    }
    public void SceneChange2b()
    {
        SceneManager.LoadScene("SceneLose");
    }
}

// Turn off "Next" button, turn on "Choice" buttons
// nextButton.SetActive(false);
// allowSpace = false;
// Choice1a.SetActive(true); // function Choice1aFunct()
// Choice1b.SetActive(true); // function Choice1bFunct()


// nextButton.SetActive(false);
// allowSpace = false;
// NextScene1Button.SetActive(true);