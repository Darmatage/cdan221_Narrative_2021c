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
				dialogue.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==3){
				ArtChar1.SetActive(true);
				ArtChar2.SetActive(false);
				ArtChar3.SetActive(false);
                Char1name.text = "Jazz";
                Char1speech.text = "Wow Eddy! I’d love to join the talent show, any idea what we could do?";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
				ArtChar2.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Eddy";
                Char2speech.text = "Hmm… I’m not sure, can’t you sing Jazz?";
        }
       else if (primeInt == 5){
                Char1name.text = "Jazz";
                Char1speech.text = "Yeah but not good enough to win!";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Eddy";
                Char2speech.text = "Oh I have an Idea!";
        }
       else if (primeInt ==7){
                Char1name.text = "Jazz";
                Char1speech.text = "Then tell me Eddy! What are you waiting for";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 8){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Eddy";
                Char2speech.text = "We can make a band! I’ll play the drums";
        }
		 else if (primeInt == 9){
                Char1name.text = "Jazz";
                Char1speech.text = "Won’t we need more people for that?";
                Char2name.text = "";
                Char2speech.text = "";
        }
		 else if (primeInt == 10){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Eddy";
                Char2speech.text = "Oh yeah, I guess you are right";
        }
		 else if (primeInt == 11){
                Char1name.text = "Jazz";
                Char1speech.text = "we only have five days! How are we supposed to find a group in time";
                Char2name.text = "";
                Char2speech.text = "";
        }
		 else if (primeInt == 12){
			 
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Eddy";
                Char2speech.text = "I know everyone in this school who plays an instrument, I might not be on the best terms with all of them but I believe in you Jazz. You can unite us all and take us to victory!";
				 // Turn off "Next" button, turn on "Choice" buttons
                nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
				
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
			Char2speech.text = "Go to the cafetorium";
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
			Char2speech.text = "I think Mr. Meep plays!… you might need to improve your history grade first.";
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