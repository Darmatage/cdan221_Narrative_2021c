using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene4b : MonoBehaviour
{
    public int primeInt = 1; // This integer drives game progress!
    public Text Char1name;
    public Text Char1speech;
    public Text Char2name;
    public Text Char2speech;
    public Text Char3name;
    public Text Char3speech;
    public Text Char4name;
    public Text Char4speech;
    public GameObject dialogue;
    public GameObject ArtChar1;
    public GameObject ArtJazzExcited;
    public GameObject ArtJazzSad;
    public GameObject ArtChar2;
    public GameObject ArtChar3;
    public GameObject ArtChar4;
    public GameObject ArtMeepGuitar;
    public GameObject ArtBG1;
    public GameObject Choice1a;
    public GameObject Choice1b;
    public GameObject NextScene1Button;
    public GameObject NextScene2Button;
    public GameObject nextButton;
	public GameHandler gameHandlerObj;
    public AudioSource audioSource;
    private bool allowSpace = true;


    void Start()
    {         // initial visibility settings
        dialogue.SetActive(false);
        ArtChar1.SetActive(false);
        ArtJazzExcited.SetActive(false);
        ArtJazzSad.SetActive(false);
        ArtChar2.SetActive(false);
        ArtChar3.SetActive(false);
        ArtChar4.SetActive(false);
        ArtMeepGuitar.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
        nextButton.SetActive(true);
        // got Meep and K4t = primeInt 2-20
        // got just Meep = primeInt 25-45
        // got just K4t = primeInt 50-70 
        // got nobody = primeInt 75-95

        if ((gameHandlerObj.WhatIsMeep() == true) && (gameHandlerObj.WhatIsK4t() == false))
        {
            primeInt = 24;
        }
        else if ((gameHandlerObj.WhatIsMeep() == false) && (gameHandlerObj.WhatIsK4t() == true))
        {
            primeInt = 49;
        }
        else if ((gameHandlerObj.WhatIsMeep() == false) && (gameHandlerObj.WhatIsK4t() == false))
        {
            primeInt = 74;
        }

    
}

    void FixedUpdate()
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
            ArtChar1.SetActive(true);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(false);
            ArtMeepGuitar.SetActive(false);
            dialogue.SetActive(true);
            Char1name.text = "Jazz";
            Char1speech.text = "Hey! I'm sorry I'm the last one here...";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 3)
        {
            ArtChar1.SetActive(true);
            ArtChar2.SetActive(true);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Eddy";
            Char2speech.text = "No worries man, I came a bit early. I think I’m just excited to get started!";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 4)
        {
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(false);
            ArtMeepGuitar.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char4name.text = "Mr. Meep";
            Char4speech.text = "I hoped you’d have been here sooner, but I can’t say I’m upset. I haven’t used this guitar in years and it gave me time to dust the old boy off.";
        }
        else if (primeInt == 5)
        {
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(true);
            ArtChar4.SetActive(false);
            ArtMeepGuitar.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "K4t";
            Char3speech.text = "I don’t mind! It gave me plenty of time to feast on the snacks Eddy brought. Hurry and set up though, there’s nothing left to eat and I’m getting bored!!";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 6)
        {
            ArtChar1.SetActive(true);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(false);
            ArtMeepGuitar.SetActive(false);
            Char1name.text = "Jazz";
            Char1speech.text = "Just let me get the mic all set up and I think we’ll be ready to go.";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 7)
        {
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(true);
            ArtChar3.SetActive(true);
            ArtChar4.SetActive(false);
            ArtMeepGuitar.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Eddy";
            Char2speech.text = "We should start by picking what song we want to play.";
        }
        else if (primeInt == 8)
        {
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(true);
            ArtChar4.SetActive(false);
            ArtMeepGuitar.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "K4t";
            Char3speech.text = "Something that everyone likes!";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 9)
        {
            ArtChar1.SetActive(true);
            ArtJazzExcited.SetActive(false);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(false);
            ArtMeepGuitar.SetActive(false);
            Char1name.text = "Jazz";
            Char1speech.text = "Hmmm… what genre are we thinking?";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 10)
        {
            ArtChar1.SetActive(false);
            ArtJazzExcited.SetActive(false);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(false);
            ArtMeepGuitar.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "Mr. Meep";
            Char4speech.text = "Something smooth and nostalgic…";
        }
        else if (primeInt == 11)
        {
            ArtChar1.SetActive(false);
            ArtJazzExcited.SetActive(false);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(true);
            ArtChar4.SetActive(false);
            ArtMeepGuitar.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "K4t";
            Char3speech.text = "Something that has a lot of keyboard action!";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 12)
        {
            ArtChar1.SetActive(false);
            ArtJazzExcited.SetActive(false);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(true);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(false);
            ArtMeepGuitar.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Eddy";
            Char2speech.text = "Not to play too much off your name, Jazz, but how about something jazzy?";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 13)
        {
            ArtChar1.SetActive(true);
            ArtJazzExcited.SetActive(false);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(false);
            ArtMeepGuitar.SetActive(false);
            Char1name.text = "Jazz";
            Char1speech.text = "That seems to tick all the boxes!";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 14)
        {
            ArtChar1.SetActive(false);
            ArtJazzExcited.SetActive(false);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(true);
            ArtChar4.SetActive(false);
            ArtMeepGuitar.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "K4t";
            Char3speech.text = "Let's do it!";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 15)
        {
            ArtChar1.SetActive(false);
            ArtJazzExcited.SetActive(false);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(false);
            ArtMeepGuitar.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "Mr. Meep";
            Char4speech.text = "I'll be excited for that!";


        }
        else if (primeInt == 16)
        {
            ArtChar1.SetActive(false);
            ArtJazzExcited.SetActive(true);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(false);
            ArtMeepGuitar.SetActive(false);
            Char1name.text = "Jazz";
            Char1speech.text = "Alright!!";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 17)
        {
            ArtChar1.SetActive(false);
            ArtJazzExcited.SetActive(false);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(false);
            ArtMeepGuitar.SetActive(false);
            Char1name.text = "Jazz";
            Char1speech.text = "The group plays their song";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 18)
        {
            ArtChar1.SetActive(false);
            ArtJazzExcited.SetActive(false);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(true);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(false);
            ArtMeepGuitar.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Eddy";
            Char2speech.text = "Wow, that was fun! Not sure how we sounded, but the important part is that was a blast!";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 19)
        {
            ArtChar1.SetActive(false);
            ArtJazzExcited.SetActive(false);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(false);
            ArtMeepGuitar.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "Mr. Meep";
            Char4speech.text = "I’ve played with many bands in the past, and I have to say, we sounded pretty good. Looks like I still got it in me after all these years.";
        }

        else if (primeInt == 20)
        {
            ArtChar1.SetActive(false);
            ArtJazzExcited.SetActive(false);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(true);
            ArtChar4.SetActive(false);
            ArtMeepGuitar.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "K4t";
            Char3speech.text = "Yeah! That was awesome!";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 21)
        {
            ArtChar1.SetActive(false);
            ArtJazzExcited.SetActive(true);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(false);
            ArtMeepGuitar.SetActive(false);
            Char1name.text = "Jazz";
            Char1speech.text = "I’m so glad. I was worried we wouldn’t be able to pull something off, but I think we still have a chance here!";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";

        }
        else if (primeInt == 22)
        {
            ArtChar1.SetActive(false);
            ArtJazzExcited.SetActive(false);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(true);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(false);
            ArtMeepGuitar.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Eddy";
            Char2speech.text = "Yeah Jazz!";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
            Choice1a.SetActive(true);
            Choice1b.SetActive(true);
            NextScene1Button.SetActive(false);
            nextButton.SetActive(false);

        }




        // here are the primeInts for only Mr Meep:

        else if (primeInt == 25)
        {
            dialogue.SetActive(true);
            ArtChar1.SetActive(true);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(false);
            dialogue.SetActive(true);
            Char1name.text = "Jazz";
            Char1speech.text = "Hey! I'm sorry I'm the last one here...";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 26)
        {
            ArtChar1.SetActive(true);
            ArtChar2.SetActive(true);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(false);
            ArtMeepGuitar.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Eddy";
            Char2speech.text = "No worries man, I came a bit early. I think I’m just excited to get started!";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 27)
        {
            ArtChar1.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(false);
            ArtMeepGuitar.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char4name.text = "Mr. Meep";
            Char4speech.text = "I hoped you’d have been here sooner, but I can’t say I’m upset. I haven’t used this guitar in years and it gave me time to dust the old boy off.";
        }
        else if (primeInt == 28)
        {
            ArtChar1.SetActive(true);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(false);
            ArtMeepGuitar.SetActive(false);
            Char1name.text = "Jazz";
            Char1speech.text = "Just let me get the mic all set up and I think we’ll be ready to go. Too bad K4t couldn't join us.";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 29)
        {
            ArtChar1.SetActive(true);
            ArtChar2.SetActive(true);
            ArtChar3.SetActive(true);
            ArtChar4.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Eddy";
            Char2speech.text = "Mr. Meep told me earlier that it was probably for the best. We should start by picking what song we want to play.";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 30)
        {
            ArtChar1.SetActive(true);
            ArtJazzExcited.SetActive(false);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(false);
            Char1name.text = "Jazz";
            Char1speech.text = "Hmmm… what genre are we thinking?";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 31)
        {
            ArtChar1.SetActive(false);
            ArtJazzExcited.SetActive(false);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(false);
            ArtMeepGuitar.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "Mr. Meep";
            Char4speech.text = "Something smooth and nostalgic…";
        }
        else if (primeInt == 32)
        {
            ArtChar1.SetActive(false);
            ArtJazzExcited.SetActive(false);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(true);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(false);
            ArtMeepGuitar.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Eddy";
            Char2speech.text = "Not to play too much off your name, Jazz, but how about something jazzy?";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 33)
        {
            ArtChar1.SetActive(false);
            ArtJazzExcited.SetActive(true);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(false);
            ArtMeepGuitar.SetActive(false);
            Char1name.text = "Jazz";
            Char1speech.text = "That's great! What do you think Mr. Meep?";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 34)
        {
            ArtChar1.SetActive(false);
            ArtJazzExcited.SetActive(false);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(false);
            ArtMeepGuitar.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "Mr. Meep";
            Char4speech.text = "I'll be excited for that!";


        }
        else if (primeInt == 35)
        {
            ArtChar1.SetActive(false);
            ArtJazzExcited.SetActive(true);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            ArtMeepGuitar.SetActive(false);
            ArtChar4.SetActive(false);
            Char1name.text = "Jazz";
            Char1speech.text = "Alright!!";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 36)
        {
            ArtChar1.SetActive(false);
            ArtJazzExcited.SetActive(false);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(false);
            Char1name.text = "Jazz";
            Char1speech.text = "The group plays their song";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 37)
        {
            ArtChar1.SetActive(false);
            ArtJazzExcited.SetActive(false);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(true);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Eddy";
            Char2speech.text = "Wow, that was fun! Not sure how we sounded, but the important part is that was a blast!";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 38)
        {
            ArtChar1.SetActive(false);
            ArtJazzExcited.SetActive(false);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(false);
            ArtMeepGuitar.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "Mr. Meep";
            Char4speech.text = "I’ve played with many bands in the past, and I have to say, we sounded pretty good. Looks like I still got it in me after all these years.";
        }
        else if (primeInt == 39)
        {
            ArtChar1.SetActive(false);
            ArtJazzExcited.SetActive(true);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(false);
            ArtMeepGuitar.SetActive(false);
            Char1name.text = "Jazz";
            Char1speech.text = "I’m so glad. I was worried we wouldn’t be able to pull something off, but I think we still have a chance here!";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 40)
        {
            ArtChar1.SetActive(false);
            ArtJazzExcited.SetActive(false);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(true);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(false);
            ArtMeepGuitar.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Eddy";
            Char2speech.text = "Yeah Jazz!";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
            Choice1a.SetActive(true);
            Choice1b.SetActive(true);
            NextScene1Button.SetActive(false);
            nextButton.SetActive(false);

        }

        // here are the primeInts for only K4t:

        else if (primeInt == 50)
        {
            dialogue.SetActive(true);
            ArtChar1.SetActive(true);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(false);
            ArtMeepGuitar.SetActive(false);
            dialogue.SetActive(true);
            Char1name.text = "Jazz";
            Char1speech.text = "Hey! I'm sorry I'm the last one here...";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 51)
        {
            ArtChar1.SetActive(true);
            ArtChar2.SetActive(true);
            ArtChar3.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Eddy";
            Char2speech.text = "No worries man, I came a bit early. I think I’m just excited to get started!";

        }
    
        else if (primeInt == 52)
        {
            ArtChar1.SetActive(true);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "K4t";
            Char3speech.text = "I don’t mind! It gave me plenty of time to feast on the snacks Eddy brought. Hurry and set up though, there’s nothing left to eat and I’m getting bored!!";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 53)
        {
            ArtChar1.SetActive(true);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            Char1name.text = "Jazz";
            Char1speech.text = "Just let me get the mic all set up and I think we’ll be ready to go. Too bad Mr. Meep couldn't be here.";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 54)
        {
            ArtChar1.SetActive(true);
            ArtChar2.SetActive(true);
            ArtChar3.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Eddy";
            Char2speech.text = "Well, it's his loss! We should start by picking what song we want to play.";
        }
        else if (primeInt == 55)
        {
            ArtChar1.SetActive(true);
            ArtChar2.SetActive(true);
            ArtChar3.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "K4t";
            Char3speech.text = "Something that everyone likes!";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 56)
        {
            ArtChar1.SetActive(true);
            ArtJazzExcited.SetActive(false);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            Char1name.text = "Jazz";
            Char1speech.text = "Hmmm… what genre are we thinking?";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 57)
        {
            ArtChar1.SetActive(false);
            ArtJazzExcited.SetActive(false);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "K4t";
            Char3speech.text = "Something that has a lot of keyboard action!";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 58)
        {
            ArtChar1.SetActive(false);
            ArtJazzExcited.SetActive(false);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(true);
            ArtChar3.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Eddy";
            Char2speech.text = "Not to play too much off your name, Jazz, but how about something jazzy?";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 59)
        {
            ArtChar1.SetActive(true);
            ArtJazzExcited.SetActive(false);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            Char1name.text = "Jazz";
            Char1speech.text = "That would work! What do you think K4t?";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 60)
        {
            ArtChar1.SetActive(false);
            ArtJazzExcited.SetActive(false);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "K4t";
            Char3speech.text = "Let's do it!";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 61)
        {

            ArtChar1.SetActive(false);
            ArtJazzExcited.SetActive(true);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            Char1name.text = "Jazz";
            Char1speech.text = "Alright!!";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 62)
        {
            ArtChar1.SetActive(false);
            ArtJazzExcited.SetActive(false);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            Char1name.text = "Jazz";
            Char1speech.text = "The group plays their song";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 63)
        {
            ArtChar1.SetActive(false);
            ArtJazzExcited.SetActive(false);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(true);
            ArtChar3.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Eddy";
            Char2speech.text = "Wow, that was fun! Not sure how we sounded, but the important part is that was a blast!";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
        }

        else if (primeInt == 64)
        {
            ArtChar1.SetActive(false);
            ArtJazzExcited.SetActive(false);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "K4t";
            Char3speech.text = "Yeah! That was awesome!";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 65)
        {
            ArtChar1.SetActive(false);
            ArtJazzExcited.SetActive(true);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            Char1name.text = "Jazz";
            Char1speech.text = "I’m so glad. I was worried we wouldn’t be able to pull something off, but I think the three of us still have a chance here!";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";

        }
        else if (primeInt == 66)
        {
            ArtChar1.SetActive(false);
            ArtJazzExcited.SetActive(false);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(true);
            ArtChar3.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Eddy";
            Char2speech.text = "Yeah Jazz!";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
            Choice1a.SetActive(true);
            Choice1b.SetActive(true);
            NextScene1Button.SetActive(false);
            nextButton.SetActive(false);

        }

        // here are the primeInts for no one:

        else if (primeInt == 70)
        {
            dialogue.SetActive(true);
            ArtChar1.SetActive(true);
            ArtJazzExcited.SetActive(false);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
			ArtChar4.SetActive(false);
			ArtMeepGuitar.SetActive(false);
            Char1name.text = "Jazz";
            Char1speech.text = "Hey! I'm sorry I'm late...";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 71)
        {
            ArtChar1.SetActive(false);
            ArtJazzExcited.SetActive(false);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(true);
            ArtChar3.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Eddy";
            Char2speech.text = "No worries man, I came a bit early. I think I’m just excited to get started!";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 72)
        {
            ArtChar1.SetActive(false);
            ArtJazzExcited.SetActive(false);
            ArtJazzSad.SetActive(true);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            Char1name.text = "Jazz";
            Char1speech.text = "I'm sorry I couldn't get anyone else to join us...";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 73)
        {

            ArtChar1.SetActive(false);
            ArtJazzExcited.SetActive(false);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(true);
            ArtChar3.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "Eddy";
            Char3name.text = "That's okay. I'm sure we can figure something out with just the two of us!";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 74)
        {
            ArtChar1.SetActive(false);
            ArtJazzExcited.SetActive(false);
            ArtJazzSad.SetActive(true);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            Char1name.text = "Jazz";
            Char1speech.text = "I hope you're right.";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 75)
        {
            ArtChar1.SetActive(false);
            ArtJazzExcited.SetActive(false);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(true);
            ArtChar3.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Eddy";
            Char2speech.text = "We should start by picking what song we want to play.";
        }

        else if (primeInt == 76)
        {
            ArtChar1.SetActive(true);
            ArtJazzExcited.SetActive(false);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            Char1name.text = "Jazz";
            Char1speech.text = "Hmmm… what genre were you thinking?";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 77)
        {
            ArtChar1.SetActive(false);
            ArtJazzExcited.SetActive(false);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(true);
            ArtChar3.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Eddy";
            Char2speech.text = "Not to play too much off your name, but how about something jazzy?";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 78)
        {
            ArtChar1.SetActive(true);
            ArtJazzExcited.SetActive(false);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            Char1name.text = "Jazz";
            Char1speech.text = "Sure! That could work with just the two of us.";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 79)
        {
            ArtChar1.SetActive(false);
            ArtJazzExcited.SetActive(false);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(true);
            ArtChar3.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Eddy";
            Char2speech.text = "Let's get jammin'!";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 80)
        {
            ArtChar1.SetActive(false);
            ArtJazzExcited.SetActive(false);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            Char1name.text = "Jazz";
            Char1speech.text = "The two play their song";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 81)
        {
            ArtChar1.SetActive(false);
            ArtJazzExcited.SetActive(false);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(true);
            ArtChar3.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Eddy";
            Char2speech.text = "Wow, that was fun! Not sure how we sounded, but the important part is that was a blast!";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 82)
        {
            ArtChar1.SetActive(true);
            ArtJazzExcited.SetActive(false);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            Char1name.text = "Jazz";
            Char1speech.text = "I’m so glad. I was worried it wouldn't work with just the two of us, but I think we still have a chance here!";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";

        }
        else if (primeInt == 83)
        {
            ArtChar1.SetActive(false);
            ArtJazzExcited.SetActive(false);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(true);
            ArtChar3.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Eddy";
            Char2speech.text = "Yeah Jazz!";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
            Choice1a.SetActive(true);
            Choice1b.SetActive(true);
            NextScene1Button.SetActive(false);
            nextButton.SetActive(false);

        }





        // ENCOUNTER AFTER CHOICE #1
        else if (primeInt == 100)
        {
            ArtChar1.SetActive(false);
            ArtJazzExcited.SetActive(false);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(false);
            ArtMeepGuitar.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene2Button.SetActive(true);
        }

        else if (primeInt == 200)
        {
            ArtChar1.SetActive(false);
            ArtJazzExcited.SetActive(false);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(false);
            ArtMeepGuitar.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
        }
    }


    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
    public void Choice1aFunct()
    {
        ArtChar1.SetActive(false);
        ArtJazzExcited.SetActive(false);
        ArtJazzSad.SetActive(false);
        ArtChar2.SetActive(true);
        ArtChar3.SetActive(false);
        ArtChar4.SetActive(false);
        ArtMeepGuitar.SetActive(false);
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "Eddy";
        Char2speech.text = "Sounds cool, Jazz.";
        primeInt = 99;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
    public void Choice1bFunct()
    {
        ArtChar1.SetActive(false);
        ArtJazzExcited.SetActive(false);
        ArtJazzSad.SetActive(false);
        ArtChar2.SetActive(true);
        ArtChar3.SetActive(false);
        ArtChar4.SetActive(false);
        ArtMeepGuitar.SetActive(false);
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "Eddy";
        Char2speech.text = "Rock on!";
        primeInt = 199;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }


    public void SceneChange2a()
    {
        SceneManager.LoadScene("Scene5a");
    }
    public void SceneChange2b()
    {
        SceneManager.LoadScene("Scene5b");
    }
}