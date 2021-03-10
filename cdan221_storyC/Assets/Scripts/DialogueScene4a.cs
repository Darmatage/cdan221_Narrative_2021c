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
		public GameObject ArtChar2;
		public GameObject ArtChar3;
		public GameObject ArtChar4;
        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
		public GameObject NextScene1Button;
        public GameObject NextScene2Button;
        public GameObject nextButton;
       //public GameObject gameHandler;
       //public AudioSource audioSource;
        private bool allowSpace = true;

void Start(){         // initial visibility settings
        dialogue.SetActive(false);
        ArtChar1.SetActive(false);
		ArtChar2.SetActive(false);
		ArtChar3.SetActive(false);
		ArtChar4.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
        nextButton.SetActive(true);
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
        if (primeInt == 1){
                // AudioSource.Play();
        }
        else if (primeInt == 2){
				ArtChar1.SetActive(true);
				ArtChar2.SetActive(false);
				ArtChar3.SetActive(false);
				ArtChar4.SetActive(false);
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
       else if (primeInt ==3){
				ArtChar1.SetActive(true);
				ArtChar2.SetActive(true);
				ArtChar3.SetActive(false);
				ArtChar4.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Eddy";
                Char2speech.text = "Heck yeah man!";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
				ArtChar2.SetActive(true);
				ArtChar3.SetActive(false);
				ArtChar4.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char4name.text = "Mr. Meep";
                Char4speech.text = "I’m not sure about this rocking and rolling you speak of, but I am surely excited to dust off my old guitar.";
        }
       else if (primeInt == 5){
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
       else if (primeInt == 6){
                Char1name.text = "Jazz";
                Char1speech.text = "Just let me get the mic all set up and then we can start.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
       else if (primeInt ==7){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Eddy";
                Char2speech.text = "We should decide on a song to blast.";
        }
       else if (primeInt == 8){
                Char1name.text = "Jazz";
                Char1speech.text = "Hmmm… what genre are we thinking?";
                Char2name.text = "";
                Char2speech.text = "";
        }
		 else if (primeInt == 9){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char4name.text = "Mr. Meep";
                Char4speech.text = "Something smooth and nostalgic…";
        }
		 else if (primeInt == 10){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "K4t";
                Char3speech.text = "Something that will knock the socks off the audience!";
				Char4name.text = "";
                Char4speech.text = "";
        }
		 else if (primeInt == 11){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Eddy";
                Char2speech.text = "Not to play too much off your name, Jazz, but how about something jazzy? We could do a modern rock interpretation on a jazz song!";
				Char3name.text = "";
                Char3speech.text = "";
        }
		 else if (primeInt == 12){
                Char1name.text = "Jazz";
                Char1speech.text = "That seems to tick all the boxes!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
        }
		 else if (primeInt == 13){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "K4t";
                Char3speech.text = "Ooooo! That’s a cool idea.";
        }
		 else if (primeInt == 14){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "Mr. Meep";
                Char4speech.text = "I could work with that.";
        }
		 else if (primeInt == 15){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
                Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
		 // else if (primeInt == 12){
			 
                // Char1name.text = "";
                // Char1speech.text = "";
                // Char2name.text = "Eddy";
                // Char2speech.text = "I know everyone in this school who plays an instrument, I might not be on the best terms with all of them but I believe in you Jazz. You can unite us all and take us to victory!";
				 // Turn off "Next" button, turn on "Choice" buttons
                // nextButton.SetActive(false);
                // allowSpace = false;
                // Choice1a.SetActive(true); // function Choice1aFunct()
                // Choice1b.SetActive(true); // function Choice1bFunct()
				
        }
	
// ENCOUNTER AFTER CHOICE #1
       else if (primeInt == 100){
                Char1name.text = "Jazz";
                Char1speech.text = "Okay!";
                Char2name.text = "";
                Char2speech.text = "";
        }
		else if (primeInt == 101){
				Char1name.text = "";
				Char1speech.text = "";
				Char2name.text = "";
				Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);						
		}
		
		else if (primeInt == 200){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
        }
	}
	// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
	public void Choice1aFunct(){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "Eddy";
			Char2speech.text = "";
			primeInt = 99;
			Choice1a.SetActive(false);
			Choice1b.SetActive(false);
			nextButton.SetActive(true);
			allowSpace = true;
	}
	public void Choice1bFunct(){
			Char1name.text = "";
			Char1speech.text = "";
			Char2name.text = "Eddy";
			Char2speech.text = "";
			primeInt = 199;
			Choice1a.SetActive(false);
			Choice1b.SetActive(false);
			nextButton.SetActive(true);
			allowSpace = true;
	}


	public void SceneChange2a(){
		   SceneManager.LoadScene("Scene2a");
	}
	public void SceneChange2b(){
			SceneManager.LoadScene("Scene2b");
	}
}