using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene4a : MonoBehaviour {
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
       //public AudioSource audioSource;
        private bool allowSpace = true;

void Start(){         // initial visibility settings
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
		
		// got Meep and K4t = primeInt 2-21
		// got just Meep = primeInt 25-45
		// got just K4t = primeInt 50-70 
		// got nobody = primeInt 75-96
		
		if ((gameHandlerObj.WhatIsMeep()== true )&&(gameHandlerObj.WhatIsK4t()== false )){
					primeInt = 24;
				}
		else if ((gameHandlerObj.WhatIsMeep()== false )&&(gameHandlerObj.WhatIsK4t()== true )){
					primeInt = 49;
				}
		else if ((gameHandlerObj.WhatIsMeep()== false )&&(gameHandlerObj.WhatIsK4t()== false )){
					primeInt = 74;
				}
		
   }

void FixedUpdate(){         // use spacebar as Next button
        if (allowSpace == true){
                if (Input.GetKeyDown("space")){
                       talking();
                }
        }
   }

public void talking(){         // main story function. Players hit next to progress to next int
        primeInt = primeInt + 1;
        if (primeInt == 1)
        {
            // AudioSource.Play();
        }
        else if (primeInt == 2)
        {
            ArtChar1.SetActive(false);
            ArtJazzExcited.SetActive(true);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(false);
            ArtMeepGuitar.SetActive(false);
            dialogue.SetActive(true);
            Char1name.text = "Jazz";
            Char1speech.text = "Hey! Are you ready to rock and roll??";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 3)
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
            Char2speech.text = "Heck yeah man!";

            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 4)
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
            Char4name.text = "Mr. Meep";
            Char4speech.text = "I’m not sure about this rocking and rolling you speak of, but I am surely excited to dust off my old guitar.";
        }
        else if (primeInt == 5)
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
            Char3speech.text = "I ate all the snacks Eddy brought already, so I’m ready to go!";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 6)
        {
            ArtChar1.SetActive(true);
            ArtJazzExcited.SetActive(false);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(false);
            ArtMeepGuitar.SetActive(false);
            Char1name.text = "Jazz";
            Char1speech.text = "Just let me get the mic all set up and then we can start.";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 7)
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
            Char2speech.text = "We should decide on a song to blast.";
        }
        else if (primeInt == 8)
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
        }
        else if (primeInt == 9)
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
            Char4name.text = "Mr. Meep";
            Char4speech.text = "Something smooth and nostalgic…";
        }
        else if (primeInt == 10)
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
            Char3speech.text = "Something that will knock the socks off the audience!";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 11)
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
            Char2speech.text = "Not to play too much off your name, Jazz, but how about something jazzy? We could do a modern rock interpretation on a jazz song!";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 12)
        {
            ArtChar1.SetActive(true);
            ArtJazzExcited.SetActive(false);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(false);
            ArtMeepGuitar.SetActive(false);
            Char1name.text = "Jazz";
            Char1speech.text = "That seems to tick all the boxes! K4t? Mr. Meep? What do you think?";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 13)
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
            Char3speech.text = "Ooooo! I love it.";
        }
        else if (primeInt == 14)
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
            Char4speech.text = "I could work with that.";
        }
        else if (primeInt == 15)
        {
            ArtChar1.SetActive(false);
            ArtJazzExcited.SetActive(true);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(false);
            ArtMeepGuitar.SetActive(false);
            Char1name.text = "Jazz";
            Char1speech.text = "Then let's do it!";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";

        }
        else if (primeInt == 16)
        {
            ArtChar1.SetActive(false);
            ArtJazzExcited.SetActive(false);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(false);
            ArtMeepGuitar.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "The group plays their song";
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
        else if (primeInt == 18)
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
        else if (primeInt == 19)
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
        else if (primeInt == 20)
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
            Char2speech.text = "I’m so glad. I was worried we wouldn’t be able to pull something off, but I think with the four of us, there's no way we could lose!!";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
            NextScene1Button.SetActive(false);
            nextButton.SetActive(true);

        }
        else if (primeInt == 21)
        {
            ArtChar1.SetActive(true);
            ArtJazzExcited.SetActive(false);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(false);
            ArtMeepGuitar.SetActive(false);
            Char1name.text = "Jazz";
            Char1speech.text = "Yeah Eddy!";
            Char2name.text = "";
            Char2speech.text = "";
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
            ArtChar1.SetActive(false);
            ArtJazzExcited.SetActive(true);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(false);
            ArtMeepGuitar.SetActive(false);
            dialogue.SetActive(true);
            Char1name.text = "Jazz";
            Char1speech.text = "Hey! Are you ready to rock and roll??";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 26)
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
            Char2speech.text = "Heck yeah man!";

        }
        else if (primeInt == 27)
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
            Char4name.text = "Mr. Meep";
            Char4speech.text = "I’m not sure about this rocking and rolling you speak of, but I am surely excited to dust off my old guitar.";
        }

        else if (primeInt == 28)
        {
            ArtChar1.SetActive(false);
            ArtJazzExcited.SetActive(false);
            ArtJazzSad.SetActive(true);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(false);
            ArtMeepGuitar.SetActive(false);
            Char1name.text = "Jazz";
            Char1speech.text = "It's too bad it didn't work out with K4t. She doesn't know what she's missing.";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 29)
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
            Char2speech.text = "Yeah, but we don't need her! We should decide on a song to blast.";
        }
        else if (primeInt == 30)
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
            Char2speech.text = "Not to play too much off your name, Jazz, but how about something jazzy? We could do a modern rock interpretation on a jazz song!";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 33)
        {
            ArtChar1.SetActive(true);
            ArtJazzExcited.SetActive(false);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(false);
            ArtMeepGuitar.SetActive(false);
            Char1name.text = "Jazz";
            Char1speech.text = "I like that! What do you think Mr. Meep?";
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
            Char4speech.text = "I could work with that.";
        }
        else if (primeInt == 35)
        {
            ArtChar1.SetActive(false);
            ArtJazzExcited.SetActive(true);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(false);
            ArtMeepGuitar.SetActive(false);
            Char1name.text = "Jazz";
            Char1speech.text = "Let's do it!";
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
            ArtMeepGuitar.SetActive(false);
            Char1name.text = "";
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
            ArtChar1.SetActive(true);
            ArtJazzExcited.SetActive(false);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(false);
            ArtMeepGuitar.SetActive(false);
            Char1name.text = "Jazz";
            Char1speech.text = "I’m so glad. I was worried we wouldn’t be able to pull something off, but I think the three of us still have a chance here!";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";

        }  else if (primeInt == 40)
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
            Char2speech.text = "Yeah!";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
			Choice1a.SetActive(true); // function Choice1aFunct()
            Choice1b.SetActive(true);
            NextScene1Button.SetActive(false);
            nextButton.SetActive(false);

        }

        // here are the primeInts for just K4t:

        else if (primeInt == 50)
        {
            ArtChar1.SetActive(false);
            ArtJazzExcited.SetActive(true);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(false);
            ArtMeepGuitar.SetActive(false);
			dialogue.SetActive(true);
            Char1name.text = "Jazz";
            Char1speech.text = "Hey! Are you ready to rock and roll??";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 51)
        {
            ArtChar1.SetActive(false);
            ArtJazzExcited.SetActive(true);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(true);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(false);
            ArtMeepGuitar.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Eddy";
            Char2speech.text = "Heck yeah man!";
        }
        else if (primeInt == 52)
        {
            ArtChar1.SetActive(false);
            ArtJazzExcited.SetActive(false);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(true);
            ArtChar4.SetActive(false);
            ArtMeepGuitar.SetActive(false);
            ArtChar3.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "K4t";
            Char3speech.text = "I ate all the snacks Eddy brought already, so I’m ready to go!";
            Char4name.text = "";
            Char4speech.text = "";

            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 53)
        {
            ArtChar1.SetActive(false);
            ArtJazzExcited.SetActive(false);
            ArtJazzSad.SetActive(true);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(false);
            ArtMeepGuitar.SetActive(false);
            Char1name.text = "Jazz";
            Char1speech.text = "Just let me get the mic all set up and then we can start. It's too bad Mr. Meep didn't join us.";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 54)
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
            Char2speech.text = "Who needs a grumpy old teacher anyway? We should decide on a song to blast.";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 55)
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
        }
        else if (primeInt == 56)
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
            Char3speech.text = "Something that will knock the socks off the audience!";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 57)
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
            Char2speech.text = "Not to play too much off your name, Jazz, but how about something jazzy? We could do a modern rock interpretation on a jazz song!";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 58)
        {
            ArtChar1.SetActive(false);
            ArtJazzExcited.SetActive(true);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(false);
            ArtMeepGuitar.SetActive(false);
            Char1name.text = "Jazz";
            Char1speech.text = "That's rad! What do you think K4t?";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 59)
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
            Char3speech.text = "Ooooo! I love it!";
        }
        else if (primeInt == 60)
        {
            ArtChar1.SetActive(false);
            ArtJazzExcited.SetActive(true);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(false);
            ArtMeepGuitar.SetActive(false);
            Char1name.text = "Jazz";
            Char1speech.text = "Then let's do it!";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";

        }
        else if (primeInt == 61)
        {
            ArtChar1.SetActive(false);
            ArtJazzExcited.SetActive(false);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(false);
            ArtMeepGuitar.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "The group plays their song";
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
        else if (primeInt == 63)
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
        else if (primeInt == 64)
        {
            ArtChar1.SetActive(true);
            ArtJazzExcited.SetActive(false);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(false);
            ArtMeepGuitar.SetActive(false);
            Char1name.text = "Jazz";
            Char1speech.text = "I’m so glad. I was worried we wouldn’t be able to pull something off, but I think the three of us still have a chance here!";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";       
        }
		
		  else if (primeInt == 65)
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
            Char2speech.text = "We Make a great team!";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";

        }
		  else if (primeInt == 66)
        {
            ArtChar1.SetActive(false);
            ArtJazzExcited.SetActive(true);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(false);
            ArtMeepGuitar.SetActive(false);
            Char1name.text = "Jazz";
            Char1speech.text = "Yeah Eddy!";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
			Choice1a.SetActive(true); //leads to chill rivals scenes
			Choice1b.SetActive(true); //leads to agrresive rivals scenes
            NextScene1Button.SetActive(false);
            nextButton.SetActive(false);

        }
        //here are the primeInts for nobody:

        else if (primeInt == 75)
        {
            ArtChar1.SetActive(false);
            ArtJazzExcited.SetActive(true);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(false);
            ArtMeepGuitar.SetActive(false);
            dialogue.SetActive(true);
            Char1name.text = "Jazz";
            Char1speech.text = "Hey! Are you ready to rock and roll??";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
        }
        else if (primeInt == 76)
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
            Char2speech.text = "Heck yeah man!";

            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 77)
        {
            ArtChar1.SetActive(false);
            ArtJazzExcited.SetActive(false);
            ArtJazzSad.SetActive(true);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(false);
            ArtMeepGuitar.SetActive(false);
            Char1name.text = "Jazz";
            Char1speech.text = "I'm sorry I couldn't get Mr. Meep or K4t to join us...";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 78)
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
            Char2speech.text = "I guess it's fine. We will show them we didn't need them anyways!";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 79)
        {
            ArtChar1.SetActive(true);
            ArtJazzExcited.SetActive(false);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(false);
            ArtMeepGuitar.SetActive(false);
            Char1name.text = "Jazz";
            Char1speech.text = "You're right!";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 80)
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
            Char2speech.text = "We should decide on a song to blast.";
        }
        else if (primeInt == 81)
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
        }
        else if (primeInt == 82)
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
            Char2speech.text = "Not to play too much off your name, Jazz, but how about something jazzy? We could do a modern rock interpretation on a jazz song!";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 83)
        {
            ArtChar1.SetActive(true);
            ArtJazzExcited.SetActive(false);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(false);
            ArtMeepGuitar.SetActive(false);
            Char1name.text = "Jazz";
            Char1speech.text = "Sure! We have nothing else to go on.";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 84)
        {
            ArtChar1.SetActive(false);
            ArtJazzExcited.SetActive(false);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(false);
            ArtMeepGuitar.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "The two play their song";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";

        }
        else if (primeInt == 85)
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
        else if (primeInt == 86)
        {
            ArtChar1.SetActive(true);
            ArtJazzExcited.SetActive(false);
            ArtJazzSad.SetActive(false);
            ArtChar2.SetActive(false);
            ArtChar3.SetActive(false);
            ArtChar4.SetActive(false);
            ArtMeepGuitar.SetActive(false);
            Char1name.text = "Jazz";
            Char1speech.text = "I’m so glad. I was worried we wouldn’t be able to pull something off since it's just the two of us.";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            Char4name.text = "";
            Char4speech.text = "";
			Choice1a.SetActive(true); //leads to chill rivals scenes
			Choice1b.SetActive(true); //leads to agrresive rivals scenes
            NextScene1Button.SetActive(false);
            nextButton.SetActive(false);

        }






        // ENCOUNTER AFTER CHOICE #1
       
        else if (primeInt == 100)
        {
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
	public void Choice1aFunct(){
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
			Char2speech.text = "sounds cool Jazz";
			primeInt = 99;
			Choice1a.SetActive(false);
			Choice1b.SetActive(false);
			nextButton.SetActive(true);
			allowSpace = true;
	}
	public void Choice1bFunct(){
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


	public void SceneChange2a(){
		   SceneManager.LoadScene("Scene5a");
	}
	public void SceneChange2b(){
			SceneManager.LoadScene("Scene5b");
	}
}