using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene2a : MonoBehaviour {
        public int primeInt = 1; // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
        // public Text Char3name;
        // public Text Char3speech;
        public GameObject dialogue;
		public GameObject ArtJazzTalking;
		public GameObject ArtJazzExcited;
		public GameObject ArtJazzSad;
        public GameObject ArtKat;	
        public GameObject ArtKatFish;	
        public GameObject ArtKatChat;
        public GameObject ArtKatSad;
        public GameObject ArtKatWow;			
        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
		public GameObject Choice1c;
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
        public GameObject nextButton;
        public GameHandler gameHandlerObj;
       //public AudioSource audioSource;
        private bool allowSpace = true;

void Start(){         // initial visibility settings
        dialogue.SetActive(false);
 		ArtJazzTalking.SetActive(false); 
		ArtJazzExcited.SetActive(false);
		ArtJazzSad.SetActive(false);
        ArtKat.SetActive(false);
        ArtKatFish.SetActive(false);
        ArtKatChat.SetActive(false);
        ArtKatSad.SetActive(false);
        ArtKatWow.SetActive(false);		
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
		Choice1c.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
        nextButton.SetActive(true);
   }

void Update(){         // use spacebar as Next button
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
               ArtJazzSad.SetActive(true);
               ArtKat.SetActive(false);
                dialogue.SetActive(true);
                Char1name.text = "Jazz";
                Char1speech.text = "The cafetorium seems to be empty.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt ==3){
                Char1name.text = "Jazz";
                Char1speech.text = "I think K4t is over there by the trash.";
                Char2name.text = "";
                Char2speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
			   ArtJazzSad.SetActive(false);
               ArtKat.SetActive(true);
			   ArtKatChat.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "K4t";
                Char2speech.text = "MMRRPPP . . . . . \n . . .";
        }
       else if (primeInt == 5){
			   ArtKatChat.SetActive(false);
			   ArtKatFish.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "K4t";
                Char2speech.text = "aHA!! a fish bone!";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 6){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "K4t";
                Char2speech.text = "w0WoW! such rare treasure!!";
        }
       else if (primeInt ==7){
			   ArtJazzTalking.SetActive(true);
			   ArtKatFish.SetActive(true);
                Char1name.text = "Jazz";
                Char1speech.text = "Hey K4t, Sorry to interrupt your lil scavenger hunt.";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 8){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "K4t";
                Char2speech.text = "hmm??";
        }
		else if (primeInt == 9) {
                Char1name.text = "Jazz";
                Char1speech.text = "I have a favor to ask if you don’t mind?";
                Char2name.text = "";
                Char2speech.text = "";
		}
        else if (primeInt == 10){
			   ArtKatFish.SetActive(false);
			   ArtKatChat.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "K4t";
                Char2speech.text = "This better be important!";
		}
        else if (primeInt == 11){
			   ArtKatChat.SetActive(false);
			   ArtKat.SetActive(true);
		       ArtJazzTalking.SetActive(false);
			   ArtJazzExcited.SetActive(true);
                Char1name.text = "Jazz";
                Char1speech.text = "We would like to recruit you to be our keyboardist for the talent show!";
                Char2name.text = "";
                Char2speech.text = "";
		}
        else if (primeInt == 12){
			   ArtKatSad.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "K4t";
                Char2speech.text = "Wellllllll I’m not really interested in the gift card.";
		}
		else if (primeInt == 13){
				Char1name.text = "Jazz";
                Char1speech.text = "We will provide snacks for practice!";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 14){
			   ArtKatSad.SetActive(false);
			   ArtKatChat.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "K4t";
                Char2speech.text = "oOho?!";
		}
				else if (primeInt == 15){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "K4t";
                Char2speech.text = "What kind of snacks?";
				nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
				Choice1c.SetActive(true); // function Choice1cFunct()
		}

// ENCOUNTER AFTER CHOICE #1
       else if (primeInt == 100){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "K4t";
                Char2speech.text = "How did you know those were my favorite?!! ^q^";
        }
       else if (primeInt == 101){
                Char1name.text = "Jazz";
                Char1speech.text = "Lucky guess.";
                Char2name.text = "";
                Char2speech.text = "";     
        }
       else if (primeInt == 102){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "K4t";
                Char2speech.text = "Luck is on your side then! I will see you and those chips and chocolate at practice!";     
        }
       else if (primeInt == 103){
		   	   ArtJazzExcited.SetActive(true);
			   ArtJazzTalking.SetActive(false);
                Char1name.text = "Jazz";
                Char1speech.text = "We need one more member! Would you be willing to help me see if Mr. Meep would want to join our band?";
                Char2name.text = "";
                Char2speech.text = "";     
        }
       else if (primeInt == 104){
			   ArtKatWow.SetActive(false);
			   ArtKatChat.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "K4t";
                Char2speech.text = "Hmmm… Oh sure, why not!"; 
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);				
        }


       else if (primeInt == 200){
                Char1name.text = "Jazz";
                Char1speech.text = "Aww that's too bad, our band was going to be awesome.";
                Char2name.text = "";
                Char2speech.text = "";               
        }
       else if (primeInt == 201){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "K4t";
                Char2speech.text = "I just don't think it will be worth my time.";
        }
       else if (primeInt == 202){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "K4t";
                Char2speech.text = "See ya around ^w^;;";
        }
       else if (primeInt == 203){
			   ArtKat.SetActive(false);
                Char1name.text = "Jazz";
                Char1speech.text = "K4t left in a hurry . . .";
                Char2name.text = "";
                Char2speech.text = "";
        }
       else if (primeInt == 204){
                Char1name.text = "Jazz";
                Char1speech.text = "Time to head out . . .";
                Char2name.text = "";
                Char2speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                NextScene2Button.SetActive(true);
        }
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1aFunct(){
			   ArtJazzExcited.SetActive(false);
			   ArtJazzTalking.SetActive(true);
			   ArtKatWow.SetActive(true);
			   ArtKatChat.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "K4t";
                Char2speech.text = "OHHHHHHhhhHHhHH YUUMM YUM !!";
                primeInt = 99;
				gameHandlerObj.UpdateK4t(true);
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
				Choice1c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
			   ArtJazzExcited.SetActive(false);
			   ArtJazzSad.SetActive(true);
			   ArtKatChat.SetActive(false);
			   ArtKatSad.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "K4t";
                Char2speech.text = "Sorry bud but I will have to decline your offer :’3";
                primeInt = 199;
				gameHandlerObj.UpdateK4t(false);
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
				Choice1c.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void SceneChange2a(){
               SceneManager.LoadScene("Scene3b");
        }
        public void SceneChange2b(){
                SceneManager.LoadScene("Scene3a");
        }
}

// Turn off "Next" button, turn on "Choice" buttons
                // nextButton.SetActive(false);
                // allowSpace = false;
                // Choice1a.SetActive(true); // function Choice1aFunct()
                // Choice1b.SetActive(true); // function Choice1bFunct()
				
