using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueSceneLose : MonoBehaviour {
        public int primeInt = 1; // This integer drives game progress!
        public Text placementWin;
		public Text Char1name;
        public Text Char1speech;
        public Text Char2name;
        public Text Char2speech;
        public Text Char3name;
        public Text Char3speech;
        public Text Char4name;
        public Text Char4speech;
		public GameObject placement;
		public GameObject bandInventory;
        public GameObject dialogue;
        public GameObject ArtJazzMic;
		public GameObject ArtJazzExcited;
		public GameObject ArtJazzSad;
		public GameObject ArtEddy;
		public GameObject ArtEddyTalk;
		public GameObject ArtK4t;
		public GameObject ArtK4tChat;
		public GameObject ArtChar4;
        public GameObject ArtBG1;
		public GameObject ArtBGWhite;
        public GameObject nextButton;
		public GameObject replayButton;
		public GameObject quitButton;
        public GameHandler gameHandlerObj;
       //public AudioSource audioSource;
        private bool allowSpace = true;

void Start(){         // initial visibility settings
        dialogue.SetActive(false);
		placement.SetActive(false);
		bandInventory.SetActive(false);
        ArtJazzExcited.SetActive(false);
		ArtJazzMic.SetActive(false);
		ArtJazzSad.SetActive(false);
		ArtEddy.SetActive(false);
		ArtEddyTalk.SetActive(false);
		ArtK4t.SetActive(false);
		ArtK4tChat.SetActive(false);
		ArtChar4.SetActive(false);
        ArtBG1.SetActive(true);
		ArtBGWhite.SetActive(false);
        nextButton.SetActive(true);
		replayButton.SetActive(false);
		quitButton.SetActive(false);
		
		// got nobody = primeInt 2-10		
		// got just K4t = primeInt 12-20
		// got just Meep = primeInt  22-30

		
		if ((gameHandlerObj.WhatIsMeep()== false )&&(gameHandlerObj.WhatIsK4t()== true )){
					primeInt = 11; //got k4t
				}
		else if ((gameHandlerObj.WhatIsMeep()== true )&&(gameHandlerObj.WhatIsK4t()== false )){
					primeInt = 21; //got meep
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
        if (primeInt == 1){
                // AudioSource.Play();
        }
        else if (primeInt == 2){
				ArtJazzSad.SetActive(true);
				ArtEddy.SetActive(true);
				dialogue.SetActive(true);
				bandInventory.SetActive(true);
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
                Char1speech.text = "I'm so nervous about this performance.";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 4){
				ArtEddy.SetActive(false);
				ArtEddyTalk.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Eddy";
                Char2speech.text = "Me too!! It's just the two of us.";
		}
		else if (primeInt == 5){
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Eddy";
                Char2speech.text = "Our recruitment plan did not go according to plan but here we are anyway.";
		}
		else if (primeInt == 6){
				ArtEddy.SetActive(true);
				ArtEddyTalk.SetActive(false);
                Char1name.text = "Jazz";
                Char1speech.text = "That's in the past now. . .";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 7){
				ArtEddy.SetActive(true);
				ArtEddyTalk.SetActive(false);
				ArtJazzExcited.SetActive(true);
				ArtJazzSad.SetActive(false);
                Char1name.text = "Jazz";
                Char1speech.text = "I believe in us! Now let's play our heart out!";
                Char2name.text = "";
                Char2speech.text = "";
		}
		else if (primeInt == 8){
				ArtJazzExcited.SetActive(false);
				ArtJazzMic.SetActive(true);
				ArtEddy.SetActive(false);
				ArtEddyTalk.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Eddy";
                Char2speech.text = "You're right. . . There's our queue to get on!";
		}
		else if (primeInt == 9){
				ArtBG1.SetActive(false);
				ArtBGWhite.SetActive(true);
				dialogue.SetActive(false);
				bandInventory.SetActive(false);
		}
		else if (primeInt == 10){
				ArtBG1.SetActive(true);
				placement.SetActive(true);
				placementWin.text = "YOU WON 3ND PLACE!!";
				nextButton.SetActive(false);
				allowSpace = false;
				replayButton.SetActive(true);
				quitButton.SetActive(true);
		}
		
// primtInt for k4t

        else if (primeInt == 12){
				placementWin.text = "";
				ArtJazzSad.SetActive(true);
				ArtEddy.SetActive(true);
				ArtK4t.SetActive(true);
				dialogue.SetActive(true);
				bandInventory.SetActive(true);
                Char1name.text = "Jazz";
                Char1speech.text = "Today is the Talent Show. . .";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
				Char4name.text = "";
                Char4speech.text = "";
        }
		else if (primeInt == 13){
                Char1name.text = "Jazz";
                Char1speech.text = "I'm so nervous about this performance.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 14){
				ArtEddy.SetActive(false);
				ArtEddyTalk.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Eddy";
                Char2speech.text = "Me too!!";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 15){
				ArtEddy.SetActive(true);
				ArtEddyTalk.SetActive(false);
				ArtK4t.SetActive(false);
				ArtK4tChat.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "K4t";
				Char3speech.text = "I did not think we would make it this far. . . I ony joined for the snacks.";
		}
		else if (primeInt == 16){
				ArtK4t.SetActive(true);
				ArtK4tChat.SetActive(false);
				ArtJazzExcited.SetActive(true);
				ArtJazzSad.SetActive(false);
                Char1name.text = "Jazz";
                Char1speech.text = "C'mon K4t we are going to crush this talet show!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 17){
				ArtJazzExcited.SetActive(true);
				ArtJazzSad.SetActive(false);
                Char1name.text = "Jazz";
                Char1speech.text = "I believe in us! Now let's play our heart out!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
		}
		else if (primeInt == 18){
				ArtJazzExcited.SetActive(false);
				ArtJazzMic.SetActive(true);
				ArtK4t.SetActive(false);
				ArtK4tChat.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "K4t";
				Char3speech.text = "You're right. . . There's our queue to get on!";
		}
		else if (primeInt == 19){
				ArtBG1.SetActive(false);
				ArtBGWhite.SetActive(true);
				dialogue.SetActive(false);
				bandInventory.SetActive(false);
		}
		else if (primeInt == 20){
				ArtBG1.SetActive(true);
				placement.SetActive(true);
				placementWin.text = "YOU WON 2ND PLACE!!";
				nextButton.SetActive(false);
				allowSpace = false;
				replayButton.SetActive(true);
				quitButton.SetActive(true);
		}

// primInt for meep

		else if (primeInt == 22){
				placementWin.text = "";
				ArtJazzSad.SetActive(true);
				ArtEddy.SetActive(true);
				ArtChar4.SetActive(true);
				bandInventory.SetActive(true);
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
		else if (primeInt == 23){
                Char1name.text = "Jazz";
                Char1speech.text = "I'm so nervous about this performance.";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
			    Char4name.text = "";
			    Char4speech.text = "";
		}
		else if (primeInt == 24){
				ArtEddy.SetActive(false);
				ArtEddyTalk.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "Eddy";
                Char2speech.text = "Me too!!";
				Char3name.text = "";
				Char3speech.text = "";
			    Char4name.text = "";
			    Char4speech.text = "";
		}
		else if (primeInt == 25){
				ArtEddy.SetActive(true);
				ArtEddyTalk.SetActive(false);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
			    Char3name.text = "";
			    Char3speech.text = "";
			    Char4name.text = "Mr.Meep";
				Char4speech.text = "You two did fantastic at practice I have no doubt that our performance will be amazing!";
		}
		else if (primeInt == 26){
				ArtJazzExcited.SetActive(true);
				ArtJazzSad.SetActive(false);
                Char1name.text = "Jazz";
                Char1speech.text = "Thank you Mr.Meep!!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
				Char4name.text = "";
				Char4speech.text = "";
		}
		else if (primeInt == 27){
				ArtEddy.SetActive(true);
				ArtEddyTalk.SetActive(false);
				ArtJazzExcited.SetActive(true);
				ArtJazzSad.SetActive(false);
                Char1name.text = "Jazz";
                Char1speech.text = "I believe in us! Now let's play our heart out!";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
				Char4name.text = "";
				Char4speech.text = "";
		}
		else if (primeInt == 28){
				ArtJazzExcited.SetActive(false);
				ArtJazzMic.SetActive(true);
                Char1name.text = "";
                Char1speech.text = "";
                Char2name.text = "";
                Char2speech.text = "";
				Char3name.text = "";
				Char3speech.text = "";
				Char4name.text = "Mr.Meep";
				Char4speech.text = "You're right. . . There's our queue to get on!";
		}
		else if (primeInt == 29){
				ArtBG1.SetActive(false);
				ArtBGWhite.SetActive(true);
				dialogue.SetActive(false);
				bandInventory.SetActive(false);
		}
		else if (primeInt == 30){
				ArtBG1.SetActive(true);
				placement.SetActive(true);
				placementWin.text = "YOU WON 2ND PLACE!!";
				nextButton.SetActive(false);
				allowSpace = false;
				replayButton.SetActive(true);
				quitButton.SetActive(true);
		}

	}
}