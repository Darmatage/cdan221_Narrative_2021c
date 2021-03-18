﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;
using UnityEngine.UI;

public class GameHandler : MonoBehaviour{

        public static int playerStat;
	    public static bool gotK4t = false;
        public static bool gotMeep = false;
		public GameObject youGotK4t;
		public GameObject youGotMeep;		
		
		
        //public GameObject textGameObject;
		public static bool GameisPaused = false;
        public GameObject pauseMenuUI;
        public AudioMixer mixer;
        public static float volumeLevel = 1.0f;
        private Slider sliderVolumeCtrl;
		
        //void Start () { UpdateScore (); }

    
        void Awake(){
                SetLevel (volumeLevel);
                GameObject sliderTemp = GameObject.FindWithTag("PauseMenuSlider");
                if (sliderTemp != null){
                        sliderVolumeCtrl = sliderTemp.GetComponent<Slider>();
                        sliderVolumeCtrl.value = volumeLevel;
                }
        }

        void Start(){
                pauseMenuUI.SetActive(false);
				UpdateK4t(gotK4t);
				UpdateMeep(gotMeep);
        }

        void Update(){
                if (Input.GetKeyDown(KeyCode.Escape)){
                        if (GameisPaused){
                                Resume();
                        }
                        else{
                                Pause();
                        }
                }
        }
				
			public void UpdateK4t(bool isK4t){
				gotK4t = isK4t;
				if (isK4t == true){
				youGotK4t.SetActive(true);}
				else{youGotK4t.SetActive(false);}
			}	
			
			public void UpdateMeep(bool isMeep){
				gotMeep = isMeep;
				if (isMeep == true){
				youGotMeep.SetActive(true);}
				else{youGotMeep.SetActive(false);}
			}
				
				
			public bool WhatIsK4t(){
				return gotK4t;
				
			}	
			
			public bool WhatIsMeep(){
				return gotMeep;
				
			}				
			
        void Pause(){
                pauseMenuUI.SetActive(true);
                Time.timeScale = 0f;
                GameisPaused = true;
        }

        public void Resume(){
                pauseMenuUI.SetActive(false);
                Time.timeScale = 1f;
                GameisPaused = false;
        }

        public void RestartGame(){
                Time.timeScale = 1f;
				gotK4t = false;
				gotMeep = false;
                //restart the game:
                //SceneManager.LoadScene (SceneManager.GetActiveScene().buildIndex);
SceneManager.LoadScene ("MainMenu");
        }


        public void SetLevel (float sliderValue){
                mixer.SetFloat("MusicVolume", Mathf.Log10 (sliderValue) * 20);
                volumeLevel = sliderValue;
        }


        public void AddPlayerStat(int amount){
                playerStat += amount;
                Debug.Log("Current Player Stat = " + playerStat);
        //      UpdateScore ();
        }

        //void UpdateScore () {
        //        Text scoreTemp = textGameObject.GetComponent<Text>();
        //        scoreTemp.text = "Score: " + score; }

        public void StartGame(){
                SceneManager.LoadScene("Scene1a");
        }

        public void QuitGame(){
                #if UNITY_EDITOR
                UnityEditor.EditorApplication.isPlaying = false;
                #else
                Application.Quit();
                #endif
		}
}