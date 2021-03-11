using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;


public class DialogueScene3d : MonoBehaviour{
        public int primeInt = 1; // This integer drives game progress!
        public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
        public Text Char3name;
        public Text Char3speech;
        public GameObject dialogue;
		public GameObject ArtJazzTalking;
		public GameObject ArtJazzExcited;
		public GameObject ArtJazzSad;
        public GameObject ArtKat;	
        public GameObject ArtKatFish;	
        public GameObject ArtKatChat;
        public GameObject ArtKatSad;
        public GameObject ArtKatWow;
		public GameObject ArtMeepAngery;
		public GameObject ArtMeepSad;
		public GameObject ArtMeepTalking;
        public GameObject ArtBG1;
        public GameObject Choice1a;
        public GameObject Choice1b;
		public GameObject Choice2a;
		public GameObject Choice2b;
        public GameObject NextScene1Button;
        public GameObject NextScene2Button;
        public GameObject nextButton;
       //public GameObject gameHandler;
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
		ArtMeepAngery.SetActive(false);
		ArtMeepSad.SetActive(false);
		ArtMeepTalking.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
		Choice2a.SetActive(false);
		Choice2b.SetActive(false);
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
			   ArtMeepTalking.SetActive(true);
                dialogue.SetActive(true);
                Char1name.text = "Jazz";
                Char1speech.text = "The cafetorium seems to be empty.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
        }
       else if (primeInt ==3){
                Char1name.text = "Jazz";
                Char1speech.text = "I think K4t is over there by the trash.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
                //gameHandler.AddPlayerStat(1);
        }
       else if (primeInt == 4){
			   ArtJazzSad.SetActive(false);
			   ArtMeepTalking.SetActive(false);
               ArtKat.SetActive(true);
			   ArtKatChat.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "K4t";
                Char2speech.text = "MMRRPPP . . . . . \n . . .";
				Char3name.text = "";
				Char3speech.text = "";
        }
       else if (primeInt == 5){
			   ArtMeepSad.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Mr.Meep";
                Char3speech.text = "OH! K4t what are you doing in the trash can?!";
        }	
       else if (primeInt == 6){
			   ArtJazzSad.SetActive(true);
                Char1name.text = "Jazz";
                Char1speech.text = "Uh, are you alright K4t?";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
        }
       else if (primeInt == 7){
			   ArtKatChat.SetActive(false);
			   ArtKatSad.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "K4t";
                Char2speech.text = "What’s the yelling about? I’m just looking for some snacks!";
				Char3name.text = "";
				Char3speech.text = "";
        }
       else if (primeInt == 8){
			   ArtMeepSad.SetActive(false);
			   ArtMeepTalking.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Mr.Meep";
				Char3speech.text = "Oh my, how repulsive. K4t, there are perfectly good snacks in the cafeteria line!";
        }
       else if (primeInt == 9){
			   ArtKatSad.SetActive(false);
			   ArtKatFish.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "K4t";
                Char2speech.text = "But these are free! *Holds up fish bone*";
				Char3name.text = "";
				Char3speech.text = "";
        }
		else if (primeInt == 10) {
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Mr.Meep";
				Char3speech.text = "Eugh!";
		}
        else if (primeInt == 11){
			   ArtJazzSad.SetActive(false);
			   ArtJazzTalking.SetActive(true);
                Char1name.text = "Jazz";
                Char1speech.text = "Uh, K4t we actually came to see if you would be interested in joining our band. . .";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
        else if (primeInt == 12){
			   ArtKatFish.SetActive(false);
			   ArtKatChat.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "K4t";
                Char2speech.text = "A band?";
				Char3name.text = "";
				Char3speech.text = "";
		}
        else if (primeInt == 13){
			   ArtJazzTalking.SetActive(false);
			   ArtJazzExcited.SetActive(true);
                Char1name.text = "Jazz";
                Char1speech.text = "Yeah, for the talent show!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 14){
			   ArtKatChat.SetActive(false);
			   ArtKatSad.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "K4t";
                Char2speech.text = "Oh, I’m not really interested in the talent show. The prize is just a dumb gift card.";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 15){
			   ArtMeepTalking.SetActive(false);
			   ArtMeepAngery.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Mr.Meep";
				Char3speech.text = "The faculty worked hard to pool money for that gift card!";
		}
		else if (primeInt == 16){
			   ArtJazzExcited.SetActive(false);
			   ArtJazzSad.SetActive(true);
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "K4t";
                Char2speech.text = "booooo!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 17){
				Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Mr.Meep";
				Char3speech.text = "Jazz, I think this is a lost cause! I’m not sure K4t would be a good fit anyways.";
				nextButton.SetActive(false);
                allowSpace = false;
                Choice1a.SetActive(true); // function Choice1aFunct()
                Choice1b.SetActive(true); // function Choice1bFunct()
		}

// ENCOUNTER AFTER CHOICE #1
       else if (primeInt == 100){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "K4t";
                Char2speech.text = "See ya around ^w^;;";
				Char3name.text = "";
				Char3speech.text = "";
        }
       else if (primeInt == 101){
			   ArtKat.SetActive(false);
                Char1name.text = "Jazz";
                Char1speech.text = "K4t left in a hurry . . .";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
			    nextButton.SetActive(false);
                allowSpace = false;
                NextScene1Button.SetActive(true);	
        }


       else if (primeInt == 200){
			   ArtJazzSad.SetActive(false);
			   ArtJazzExcited.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "K4t";
                Char2speech.text = "Ooooooo yes yes yes! I’ll come! But the snacks better be good!";
				Char3name.text = "";
				Char3speech.text = "";
        }
	   else if (primeInt == 201){
			   ArtKatWow.SetActive(false);
			   ArtMeepAngery.SetActive(false);
			   ArtMeepTalking.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";               
				Char3name.text = "Mr.Meep";
				Char3speech.text = "I’m not sure about this. . .";
        }
       else if (primeInt == 202){
                Char1name.text = "Jazz";
                Char1speech.text = "hmmm";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
                nextButton.SetActive(false);
                allowSpace = false;
                Choice2a.SetActive(true); // function Choice2aFunct()
                Choice2b.SetActive(true); // function Choice2bFunct()
        }
		
		
     }

// FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1,#2 and switch scenes)
        public void Choice1aFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "K4t";
                Char2speech.text = "Sorry bud I will have to decline your offer :'3";
				Char3name.text = "";
				Char3speech.text = "";
                primeInt = 99;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice1bFunct(){
			   ArtKatSad.SetActive(false);
			   ArtKatWow.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "K4t";
                Char2speech.text = "OHHHHHHhhhHHhHH yUUMM!!";
				Char3name.text = "";
				Char3speech.text = "";
                primeInt = 199;
                Choice1a.SetActive(false);
                Choice1b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
		        public void Choice2aFunct(){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Mr.Meep";
				Char3speech.text = "If you say so. . .";
                primeInt = 299;
				NextScene2Button.SetActive(true);
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void Choice2bFunct(){
			   ArtJazzExcited.SetActive(false);
			   ArtJazzSad.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "Mr.Meep";
				Char3speech.text = "We'll see about it.";
                primeInt = 399;
				NextScene1Button.SetActive(true);
                Choice2a.SetActive(false);
                Choice2b.SetActive(false);
                nextButton.SetActive(true);
                allowSpace = true;
        }
        public void SceneChange2a(){
               SceneManager.LoadScene("Scene4a");
        }
        public void SceneChange2b(){
                SceneManager.LoadScene("Scene4b");
        }
}

// Turn off "Next" button, turn on "Choice" buttons
                // nextButton.SetActive(false);
                // allowSpace = false;
                // Choice1a.SetActive(true); // function Choice1aFunct()
                // Choice1b.SetActive(true); // function Choice1bFunct()
				
