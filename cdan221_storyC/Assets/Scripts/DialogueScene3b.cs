using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class DialogueScene3b : MonoBehaviour
{
    public int primeInt = 1; // This integer drives game progress!
    public Text Char1name;
    public Text Char1speech;
    public Text Char2name;
    public Text Char2speech;
    public Text Char3name;
    public Text Char3speech;
    // public Text Char3name;
    // public Text Char3speech;
    public GameObject dialogue;
    public GameObject ArtJazzTalking;
    public GameObject ArtJazzExcited;
    public GameObject ArtJazzSad;
    public GameObject ArtMeep;
    public GameObject ArtK4t;
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

    void Start()
    {         // initial visibility settings
        dialogue.SetActive(false);
        ArtJazzTalking.SetActive(false);
        ArtJazzExcited.SetActive(false);
        ArtJazzSad.SetActive(false);
        ArtMeep.SetActive(false);
        ArtK4t.SetActive(false);
        ArtBG1.SetActive(true);
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        Choice2a.SetActive(false);
        Choice2b.SetActive(false);
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
            ArtJazzTalking.SetActive(true);
            ArtMeep.SetActive(false);
            ArtK4t.SetActive(true);
            dialogue.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "K4t";
            Char3speech.text = "It looks like Mr. Meep is still teaching his class.";
        }
        else if (primeInt == 3)
        {
            ArtJazzTalking.SetActive(false);
            ArtJazzSad.SetActive(true);
            ArtMeep.SetActive(false);
            ArtK4t.SetActive(true);
            Char1name.text = "Jazz";
            Char1speech.text = "Nuts. Second period was supposed to be over five minutes ago!";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";

        }
        else if (primeInt == 4)
        {
            ArtJazzSad.SetActive(true);
            ArtMeep.SetActive(false);
            ArtK4t.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "K4t";
            Char3speech.text = "Mr. Meep is notorious for holding his class late.";
        }
        else if (primeInt == 5)
        {
            ArtJazzSad.SetActive(true);
            ArtMeep.SetActive(false);
            ArtK4t.SetActive(true);
            Char1name.text = "Jazz";
            Char1speech.text = "Oh! Look everyone’s starting to leave!";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "";
            Char3speech.text = "";
            //gameHandler.AddPlayerStat(1);
        }
        else if (primeInt == 6)
        {
            ArtJazzSad.SetActive(false);
            ArtMeep.SetActive(true);
            ArtK4t.SetActive(false);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Mr. Meep";
            Char2speech.text = "I wasn’t finished yet! Don’t forget to read chapter twelve!!!! Sigh.";
        }
        else if (primeInt == 7)
        {
            ArtJazzTalking.SetActive(true);
            ArtMeep.SetActive(false);
            ArtK4t.SetActive(true);
            Char1name.text = "Jazz";
            Char1speech.text = "Uh, excuse me, Mr. Meep?";
            Char2name.text = "";
            Char2speech.text = "";
            
        }
        else if (primeInt == 8)
        {
            ArtJazzTalking.SetActive(true);
            ArtMeep.SetActive(true);
            ArtK4t.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Mr. Meep";
            Char2speech.text = "Oh, hello children.";
            
        }
        else if (primeInt == 9)
        {
            ArtJazzTalking.SetActive(true);
            ArtMeep.SetActive(true);
            ArtK4t.SetActive(true);
            Char1name.text = "Jazz";
            Char1speech.text = "Do you have a minute to talk? We wanted to ask you something.";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 10)
        {
            ArtJazzTalking.SetActive(true);
            ArtMeep.SetActive(true);
            ArtK4t.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Mr. Meep";
            Char2speech.text = "Sure! Ask away.";
        }
        else if (primeInt == 11)
        {
            ArtJazzTalking.SetActive(true);
            ArtMeep.SetActive(true);
            ArtK4t.SetActive(true);
            Char1name.text = "Jazz";
            Char1speech.text = "You know about the school talent show right? Well me, Eddy, and K4t are starting a band, and we wanted to know if you would join us!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 12)
        {
            ArtJazzTalking.SetActive(true);
            ArtMeep.SetActive(true);
            ArtK4t.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Char3name.text = "K4t";
            Char3speech.text = "We heard you play the guitar!!";
        }
        else if (primeInt == 13)
        {
            ArtJazzTalking.SetActive(true);
            ArtMeep.SetActive(true);
            ArtK4t.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Mr. Meep";
            Char2speech.text = "Oh my… I haven’t played my guitar in ages. Is faculty even allowed in the talent show?";
            Char3name.text = "";
            Char3speech.text = "";
        }
        else if (primeInt == 14)
        {
            ArtJazzTalking.SetActive(true);
            ArtMeep.SetActive(true);
            ArtK4t.SetActive(true);
            Char1name.text = "Jazz";
            Char1speech.text = "They didn’t say that you can’t! Please Mr. Meep, we really need you!";
            Char2name.text = "";
            Char2speech.text = "";
        }
        else if (primeInt == 15)
        {
            ArtJazzTalking.SetActive(true);
            ArtMeep.SetActive(true);
            ArtK4t.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Mr. Meep";
            Char2speech.text = "Well hold on now, just what kind of band are you planning on being?";
            Choice1a.SetActive(true); // function Choice1aFunct()
            Choice1b.SetActive(true); // function Choice1bFunct()
        }
        
       
       
           
        // ENCOUNTER AFTER CHOICE #1

        else if (primeInt == 100)
        {
            ArtJazzTalking.SetActive(false);
            ArtJazzExcited.SetActive(true);
            ArtMeep.SetActive(true);
            ArtK4t.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Mr. Meep";
            Char2speech.text = "Oh my, that all seems like too much for me.";

        }
        else if (primeInt == 101)
        {
            ArtJazzSad.SetActive(true);
            ArtJazzExcited.SetActive(false);
            ArtMeep.SetActive(true);
            ArtK4t.SetActive(true);
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "";
            Char2speech.text = "";
            Choice2a.SetActive(true); // function Choice2aFunct()
            Choice2b.SetActive(true); // function Choice2bFunct()
        }
       

        else if (primeInt == 200)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Mr. Meep";
            Char2speech.text = "Alright, I can work with that! I’m in.";
        }
        else if (primeInt == 201)
        {
            Char1name.text = "Jazz";
            Char1speech.text = "Sweet! Practice is after class in the band room!";
            Char2name.text = "";
            Char2speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene2Button.SetActive(true);

        }
        else if (primeInt == 300)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Mr. Meep";
            Char2speech.text = "I am insulted! Not everything has to be rowdy to be fun you know! Kids these days… I will not be joining your little hair band! Good luck to you.";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
        }
        else if (primeInt == 400)
        {
            Char1name.text = "";
            Char1speech.text = "";
            Char2name.text = "Mr. Meep";
            Char2speech.text = "Well, alright, if you’re sure you won’t get too crazy. I’ll join your band!";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene1Button.SetActive(true);
        }
        else if (primeInt == 401)
        {
            ArtJazzExcited.SetActive(true);
            ArtJazzTalking.SetActive(false);
            ArtJazzSad.SetActive(false);
            ArtMeep.SetActive(true);
            ArtK4t.SetActive(true);
            Char1name.text = "Jazz";
            Char1speech.text = "Sweet! Practice is after class in the band room!";
            Char2name.text = "";
            Char2speech.text = "";
            nextButton.SetActive(false);
            allowSpace = false;
            NextScene2Button.SetActive(true);

        }

    }

    // FUNCTIONS FOR BUTTONS TO ACCESS (Choice #1 and switch scenes)
    public void Choice1aFunct()
    {
        ArtJazzTalking.SetActive(false);
        ArtJazzExcited.SetActive(true);
        ArtMeep.SetActive(true);
        ArtK4t.SetActive(true);
        Char1name.text = "Jazz";
        Char1speech.text = "Rock and Roll!!! Our band is gonna shred to the high heavens! The audience won’t know what hit them!!!";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 99;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
    }
    public void Choice1bFunct()
    {
        ArtJazzExcited.SetActive(false);
        ArtJazzTalking.SetActive(false);
        ArtJazzSad.SetActive(true);
        ArtMeep.SetActive(true);
        Char1name.text = "Jazz";
        Char1speech.text = "Hmm… We aren’t sure yet. Something relaxed and fun for all of us!";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 199;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(false);
        allowSpace = true;
        nextButton.SetActive(true);
        Choice1a.SetActive(false); // function Choice1aFunct()
        Choice1b.SetActive(false); // function Choice1bFunct()
    }
    public void Choice2aFunct()
    {
        ArtJazzExcited.SetActive(false);
        ArtJazzTalking.SetActive(true);
        ArtJazzSad.SetActive(false);
        ArtMeep.SetActive(true);
        ArtK4t.SetActive(true);
        Char1name.text = "";
        Char1speech.text = "";
        Char2name.text = "Jazz";
        Char2speech.text = "Come on! I know those old feathers still have some fun left in them!";
        primeInt = 299;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
        NextScene2Button.SetActive(false);
        Choice2a.SetActive(false); // function Choice2aFunct()
        Choice2b.SetActive(false);
    }
    public void Choice2bFunct()
    {
        ArtJazzExcited.SetActive(false);
        ArtJazzTalking.SetActive(true);
        ArtJazzSad.SetActive(false);
        ArtMeep.SetActive(true);
        ArtK4t.SetActive(true);
        Char1name.text = "Jazz";
        Char1speech.text = "Well, maybe we can tone it down a bit for you, but we still wanna have fun!";
        Char2name.text = "";
        Char2speech.text = "";
        primeInt = 399;
        Choice1a.SetActive(false);
        Choice1b.SetActive(false);
        nextButton.SetActive(true);
        allowSpace = true;
        NextScene2Button.SetActive(false);
        Choice2a.SetActive(false); // function Choice2aFunct()
        Choice2b.SetActive(false);
    }
    public void SceneChange2a()
    {
        SceneManager.LoadScene("Scene4a");
    }
    public void SceneChange2b()
    {
        SceneManager.LoadScene("Scene4b");
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
