using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueSceneWin : MonoBehaviour {
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
        public GameObject ArtJazzMic;
		public GameObject ArtJazzExcited;
		public GameObject ArtChar2;
		public GameObject ArtK4t;
		public GameObject ArtK4tChat;
		public GameObject ArtChar4;
        public GameObject ArtBG1;
		public GameObject ArtBG2;
		public GameObject ArtBGWhite;
        public GameObject nextButton;
		public GameObject replayButton;
		public GameObject quitButton;
        public GameHandler gameHandlerObj;
       //public AudioSource audioSource;
        private bool allowSpace = true;

void Start(){         // initial visibility settings
        dialogue.SetActive(false);
        ArtJazzExcited.SetActive(false);
		ArtJazzMic.SetActive(false);
		ArtChar2.SetActive(false);
		ArtK4t.SetActive(false);
		ArtK4tChat.SetActive(false);
		ArtChar4.SetActive(false);
        ArtBG1.SetActive(true);
		ArtBG2.SetActive(false);
		ArtBGWhite.SetActive(false);
        nextButton.SetActive(true);
		replayButton.SetActive(false);
		quitButton.SetActive(false);
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
				ArtJazzExcited.SetActive(true);
				ArtChar2.SetActive(true);
				ArtK4t.SetActive(true);
				ArtChar4.SetActive(true);
				dialogue.SetActive(true);
                Char1name.text = "Jazz";
                Char1speech.text = "Today is the Talent Show. . .";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
        }
		else if (primeInt == 3){
                Char1name.text = "Jazz";
                Char1speech.text = "I'm so excited for this moment!!";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
		}
		else if (primeInt == 4){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Eddy";
                Char2speech.text = "Me too!! I'm so glad we were able to recruit K4t and Mr.Meep!!";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
		}
		else if (primeInt == 5){
				ArtK4t.SetActive(false);
				ArtK4tChat.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "K4t";
                Char3speech.text = "I had a blast! The snacks were very yummy!!";
                Char4name.text = "";
                Char4speech.text = "";
		}
		else if (primeInt == 6){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "Mr.Meep";
                Char4speech.text = "Let's create some great memories together!!";
		}
		else if (primeInt == 7){
				ArtJazzExcited.SetActive(false);
				ArtJazzMic.SetActive(true);
                Char1name.text = "Jazz";
                Char1speech.text = "Oh look it's the queue for us to get on!! Let's go!!!";
                Char2name.text = "";
                Char2speech.text = "";
                Char3name.text = "";
                Char3speech.text = "";
                Char4name.text = "";
                Char4speech.text = "";
		}
		else if (primeInt == 8){
				ArtBG1.SetActive(false);
				ArtBGWhite.SetActive(true);
				dialogue.SetActive(false);
		}
		else if (primeInt == 9){
				dialogue.SetActive(true);
				Char1name.text = "Jazz";
                Char1speech.text = "WE WON FIRST PLACE!!";
		}
		else if (primeInt == 10){
				dialogue.SetActive(false);
				ArtBGWhite.SetActive(false);
				ArtBG2.SetActive(true);
				nextButton.SetActive(false);
				allowSpace = false;
				replayButton.SetActive(true);
				quitButton.SetActive(true);
		}
	}
}