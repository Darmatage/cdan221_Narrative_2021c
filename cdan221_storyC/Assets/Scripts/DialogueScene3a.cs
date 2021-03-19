using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene3a : MonoBehaviour
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
    public GameObject ArtMeep;
    public GameObject ArtBG1;
    public GameObject Choice1a;
    public GameObject Choice1b;
    public GameObject Choice1c;
    public GameObject Choice2a;
    public GameObject Choice2b;
    public GameObject Choice3a;
    public GameObject Choice3b;
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
        ArtMeep.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        Choice1c.SetActive(false);
        Choice2a.SetActive(false);
        Choice2b.SetActive(false);
        Choice3a.SetActive(false);
        Choice3b.SetActive(false);
        NextScene1Button.SetActive(false);
        NextScene2Button.SetActive(false);
        nextButton.SetActive(true);
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
            ArtMeep.SetActive(true);
            dialogue.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Mr. Meep";
            Char2speech.text = "Hello class! Today we will be talking about the United States Constitution.";
        }
        else if (primeInt == 3)
        {
            ArtJazzSad.SetActive(true);
            ArtMeep.SetActive(false);
            Char1name.text = "Jazz";
            Char1speech.text = "Ugh… Perfect. This is the cherry on top to my recent failure with K4t.";
            Char2name.text = "";
            Char2speech.text = "";

        }
        else if (primeInt == 4)
        {
            ArtJazzSad.SetActive(false);
            ArtMeep.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Mr. Meep";
            Char2speech.text = "We have a lot to cover and only a little amount of time to do it!";
        }
        else if (primeInt == 5)
        {
            ArtJazzSad.SetActive(true);
            ArtMeep.SetActive(false);
            Char1name.text = "Jazz";
            Char1speech.text = "I hope I can stay awake through this.";
            Char2name.text = "";
            Char2speech.text = "";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 6)
        {
            ArtJazzSad.SetActive(false);
            ArtMeep.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Mr. Meep";
            Char2speech.text = "Let's get cracking!";
        }
        else if (primeInt == 7)
        {
            ArtJazzSad.SetActive(false);
            ArtMeep.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            TimeText.text = "Time passes";
        }
        else if (primeInt == 8)
        {
            ArtJazzSad.SetActive(true);
            ArtMeep.SetActive(false);
            Char1name.text = "Jazz";
            Char1speech.text = "Zzzzzzz...";
            Char2name.text = "";
            Char2speech.text = "";
            TimeText.text = "";
        }
        else if (primeInt == 9)
        {
            ArtJazzSad.SetActive(false);
            ArtMeep.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Mr. Meep";
            Char2speech.text = "And thus! History was born!!";
        }
        else if (primeInt == 10)
        {
            ArtJazzSad.SetActive(true);
            ArtMeep.SetActive(false);
            Char1name.text = "Jazz";
            Char1speech.text = "Oh crap... I fell asleep. Did I miss the whole class?";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 11)
        {
            ArtMeep.SetActive(true);
            ArtJazzSad.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Mr. Meep";
            Char2speech.text = "Stop packing up your things! I only have a couple more things to say!";
        }
        else if (primeInt == 12)
        {
            ArtMeep.SetActive(false);
            ArtJazzSad.SetActive(true);
            Char1name.text = "Jazz";
            Char1speech.text = "Classic Meep, keeping us later than class runs. Looks like everyone is leaving anyways.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 13)
        {
            ArtMeep.SetActive(true);
            ArtJazzSad.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Mr. Meep";
            Char2speech.text = "Disrespectful! All of you! Don't forget to read chapter six and seven tonight!";
        }
        else if (primeInt == 14)
        {
            ArtMeep.SetActive(false);
            ArtJazzTalking.SetActive(true);
            Char1name.text = "Jazz";
            Char1speech.text = "Now's my chance! I HAVE to succeed this time.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 15)
        {
            ArtMeep.SetActive(true);
            ArtJazzTalking.SetActive(true);
            Char1name.text = "Jazz";
            Char1speech.text = "Hey, Mr. Meep.";
            Char2name.text = "";
            Char2speech.text = "";

        }
        else if (primeInt == 16)
        {
            ArtMeep.SetActive(true);
            ArtJazzTalking.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Mr. Meep";
            Char2speech.text = "Oh, Hello Jazz. Did you have a question about the class?";

        }
        else if (primeInt == 17)
        {
            ArtMeep.SetActive(true);
            ArtJazzTalking.SetActive(true);
            Char1name.text = "Jazz";
            Char1speech.text = "Actually, I was kind of wondering about something else...";
            Char2name.text = "";
            Char2speech.text = "";

        }
        else if (primeInt == 18)
        {
            ArtMeep.SetActive(true);
            ArtJazzTalking.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Mr. Meep";
            Char2speech.text = "Oh? I saw you nodding off while I was teaching, you know. I was hoping you'd come ot apologize.";

        }
        else if (primeInt == 19)
        {
            ArtMeep.SetActive(true);
            ArtJazzTalking.SetActive(false);
            ArtJazzSad.SetActive(true);
            Char1name.text = "Jazz";
            Char1speech.text = "Oh no! I’m so sorry about that. I promise I was just resting my eyes. I was actually wondering if you would join me and Eddy’s band?";
            Char2name.text = "";
            Char2speech.text = "";

        }
        else if (primeInt == 20)
        {
            ArtMeep.SetActive(true);
            ArtJazzTalking.SetActive(false);
            ArtJazzSad.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Mr. Meep";
            Char2speech.text = "Band?";

        }
        else if (primeInt == 21)
        {
            ArtMeep.SetActive(true);
            ArtJazzTalking.SetActive(true);
            ArtJazzSad.SetActive(false);
            Char1name.text = "Jazz";
            Char1speech.text = "Yeah! For the school talent show. Is it true that you shred?";
            Char2name.text = "";
            Char2speech.text = "";

        }
        else if (primeInt == 22)
        {
            ArtMeep.SetActive(true);
            ArtJazzTalking.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Mr. Meep";
            Char2speech.text = "You mean play guitar? Well I used to... Actually had a pretty crazy band back in the day.";

        }
        else if (primeInt == 23)
        {
            ArtMeep.SetActive(true);
            ArtJazzTalking.SetActive(false);
            ArtJazzExcited.SetActive(true);
            Char1name.text = "Jazz";
            Char1speech.text = "PLEASE JOIN MY BAND";
            Char2name.text = "";
            Char2speech.text = "";

        }
        else if (primeInt == 24)
        {
            ArtMeep.SetActive(true);
            ArtJazzTalking.SetActive(true);
            ArtJazzExcited.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Mr. Meep";
            Char2speech.text = "Now hold on, can faculty even join?";

        }
        else if (primeInt == 25)
        {
            ArtMeep.SetActive(true);
            ArtJazzTalking.SetActive(true);
            Char1name.text = "Jazz";
            Char1speech.text = "Doesn't say you can't! Please Mr.Meep, without you we will have no one!";
            Char2name.text = "";
            Char2speech.text = "";

        }
        else if (primeInt == 26)
        {
            ArtMeep.SetActive(true);
            ArtJazzTalking.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Mr. Meep";
            Char2speech.text = "Fine. I guess it will be pretty fun haha, but only if you can answer this one question from class today.";

        }
        else if (primeInt == 27)
        {
            ArtMeep.SetActive(true);
            ArtJazzTalking.SetActive(false);
            ArtJazzSad.SetActive(true);
            Char1name.text = "Jazz";
            Char1speech.text = "Oh no...";
            Char2name.text = "";
            Char2speech.text = "";

        }
        else if (primeInt == 28)
        {
            ArtMeep.SetActive(true);
            ArtJazzTalking.SetActive(false);
            ArtJazzSad.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Mr. Meep";
            Char2speech.text = "When was the constitution written?";
            Choice1a.SetActive(true); // function Choice1aFunct()
            Choice1b.SetActive(true); // function Choice1bFunct()
            Choice1c.SetActive(true); // function Choice1cFunct()
            nextButton.SetActive(false);

        }
        // ENCOUNTER AFTER CHOICE #1
        else if (primeInt == 100)
        {
            ArtMeep.SetActive(true);
            ArtJazzExcited.SetActive(true);
            ArtJazzSad.SetActive(false);
            Char1name.text = "Jazz";
            Char1speech.text = "Awesome! Thanks Mr. Meep!";
            Char2name.text = "";
            Char2speech.text = "";
            nextButton.SetActive(true);
        }
        else if (primeInt == 101)
        {
            ArtMeep.SetActive(false);
            ArtJazzExcited.SetActive(false);
            ArtJazzTalking.SetActive(true);
            Char1name.text = "Jazz";
            Char1speech.text = "Wow that was a close one!";
            Char2name.text = "";
            Char2speech.text = "";
            NextScene1Button.SetActive(true);
            nextButton.SetActive(false);
        }

        else if (primeInt == 300)
        {

            ArtJazzExcited.SetActive(false);
            ArtJazzTalking.SetActive(false);
            ArtMeep.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Mr. Meep";
            Char2speech.text = "Oh my, that all seems like too much for me.";
            Choice1a.SetActive(false);
            Choice1b.SetActive(false);
            Choice1c.SetActive(false);
            nextButton.SetActive(false);
            Choice2a.SetActive(false);
            Choice2b.SetActive(false);
            Choice3a.SetActive(true);
            Choice3b.SetActive(true);
            allowSpace = true;

        }
        else if (primeInt == 400)
        {
            ArtJazzExcited.SetActive(false);
            ArtJazzTalking.SetActive(false);
            ArtMeep.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Mr. Meep";
            Char2speech.text = "Alright, I can work with that! I’m in.";
            Choice1a.SetActive(false);
            Choice1b.SetActive(false);
            Choice1c.SetActive(false);
            nextButton.SetActive(true);
            Choice2a.SetActive(false);
            Choice2b.SetActive(false);
            allowSpace = true;


        }
        else if (primeInt == 401)
        {
            ArtJazzExcited.SetActive(true);
            ArtJazzTalking.SetActive(false);
            ArtMeep.SetActive(false);
            Char1name.text = "Jazz";
            Char1speech.text = "Sweet! Practice is tomorrow after class in the band room!";
            Char2name.text = "";
            Char2speech.text = "";
            NextScene1Button.SetActive(true);
            nextButton.SetActive(false);


        }
        else if (primeInt == 500)
        {
            ArtJazzExcited.SetActive(false);
            ArtJazzTalking.SetActive(false);
            ArtMeep.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Mr. Meep";
            Char2speech.text = "I am insulted! Not everything has to be rowdy to be fun you know! Kids these days… I will not be joining your little hair band! Good luck to you.";
            NextScene2Button.SetActive(true);
            nextButton.SetActive(false);


        }
        else if (primeInt == 600)
        {
            ArtJazzExcited.SetActive(false);
            ArtJazzTalking.SetActive(false);
            ArtMeep.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Mr. Meep";
            Char2speech.text = "Well, alright, if you’re sure you won’t get too crazy. I’ll join your band!";
            NextScene1Button.SetActive(false);
            nextButton.SetActive(true);
            Choice3a.SetActive(false);
            Choice3b.SetActive(false);


        }
        else if (primeInt == 601)
        {
            ArtJazzExcited.SetActive(true);
            ArtJazzTalking.SetActive(false);
            ArtMeep.SetActive(false);
            Char1name.text = "Jazz";
            Char1speech.text = "Sweet! Practice is tomorrow after class in the band room!";
            Char2name.text = "";
            Char2speech.text = "";
            NextScene2Button.SetActive(true);
            nextButton.SetActive(false);
        }

        }

        // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
        public void Choice1cFunct()
    {
        ArtJazzExcited.SetActive(false);
        ArtJazzTalking.SetActive(false);
        ArtMeep.SetActive(true);
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "Mr. Meep";
        Char2speech.text = "Wonderful! Perhaps you were paying more attention than I thought. Before I agree to this, what kind of band are you planning on making?";
       	gameHandlerObj.UpdateMeep(true);
		primeInt = 99;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        Choice1c.SetActive(false);
        nextButton.SetActive(false);
        Choice2a.SetActive(true);
        Choice2b.SetActive(true);
        allowSpace = true;
    }
    public void Choice1bFunct()
    {
        ArtJazzExcited.SetActive(false);
        ArtJazzTalking.SetActive(false);
        ArtJazzSad.SetActive(true);
        ArtMeep.SetActive(true);
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "Mr. Meep";
        Char2speech.text = "I’m afraid that is incorrect. I will not be joining your band. Pay more attention to your studies!";
       	gameHandlerObj.UpdateMeep(false);
		primeInt = 199;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        Choice1c.SetActive(false);
        nextButton.SetActive(false);
        allowSpace = true;
        NextScene2Button.SetActive(true);
    }
    public void Choice1aFunct()
    {
        ArtJazzExcited.SetActive(false);
        ArtJazzTalking.SetActive(false);
        ArtJazzSad.SetActive(true);
        ArtMeep.SetActive(true);
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "Mr. Meep";
        Char2speech.text = "I’m afraid that is incorrect. I will not be joining your band. Pay more attention to your studies!";
      	gameHandlerObj.UpdateMeep(false);
		primeInt = 199;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        Choice1c.SetActive(false);
        nextButton.SetActive(false);
        allowSpace = true;
        NextScene2Button.SetActive(true);
    }
    public void Choice2aFunct()
    {
        ArtJazzExcited.SetActive(true);
        ArtJazzTalking.SetActive(false);
        ArtJazzSad.SetActive(false);
        ArtMeep.SetActive(false);
        Char1name.text = "Jazz";
        Char1speech.text = "Rock and Roll!!! Our band is gonna shred to the high heavens! The audience won’t know what hit them!!!";
        Char2name.text = "";
        Char2speech.text = "";
        gameHandlerObj.UpdateMeep(false);
		primeInt = 299;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        Choice1c.SetActive(false);
        nextButton.SetActive(true);
        Choice2a.SetActive(false);
        Choice2b.SetActive(false);
        allowSpace = true;




    }
    public void Choice2bFunct()
    {
        ArtJazzExcited.SetActive(false);
        ArtJazzSad.SetActive(false);
        ArtJazzTalking.SetActive(true);
        ArtMeep.SetActive(false);
        Char1name.text = "Jazz";
        Char1speech.text = "Hmm… We aren’t sure yet. Something relaxed and fun for all of us!";
        Char2name.text = "";
        Char2speech.text = "";
       	gameHandlerObj.UpdateMeep(true);
		primeInt = 399;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        Choice1c.SetActive(false);
        nextButton.SetActive(true);
        Choice2a.SetActive(false);
        Choice2b.SetActive(false);
        allowSpace = true;
    }
    public void Choice3aFunct()
    {
        ArtJazzExcited.SetActive(false);
        ArtJazzTalking.SetActive(true);
        ArtJazzSad.SetActive(false);
        ArtMeep.SetActive(false);
        Char1name.text = "Jazz";
        Char1speech.text = "Come on! I know those old feathers still have some fun left in them!";
        Char2name.text = "";
        Char2speech.text = "";
		gameHandlerObj.UpdateMeep(false);
        primeInt = 499;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        Choice1c.SetActive(false);
        nextButton.SetActive(true);
        Choice2a.SetActive(false);
        Choice2b.SetActive(false);
        Choice3a.SetActive(false);
        Choice3b.SetActive(false);
        allowSpace = true;
    }
    public void Choice3bFunct()
    {
        ArtJazzExcited.SetActive(false);
        ArtJazzTalking.SetActive(true);
        ArtJazzSad.SetActive(false);
        ArtMeep.SetActive(false);
        Char1name.text = "Jazz";
        Char1speech.text = "Well, maybe we can tone it down a bit for you, but we still wanna have fun!";
        Char2name.text = "";
        Char2speech.text = "";
        gameHandlerObj.UpdateMeep(true);
		primeInt = 599;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        Choice1c.SetActive(false);
        nextButton.SetActive(true);
        Choice2a.SetActive(false);
        Choice2b.SetActive(false);
        Choice3a.SetActive(false);
        Choice3b.SetActive(false);
        allowSpace = true;


    }
    public void SceneChange2a()
    {
        SceneManager.LoadScene("Scene4b");
    }
    public void SceneChange2b()
    {
        SceneManager.LoadScene("Scene4a");
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