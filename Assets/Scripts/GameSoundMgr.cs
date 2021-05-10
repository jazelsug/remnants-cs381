using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

public class GameSoundMgr : MonoBehaviour
{
    public GameObject GametimePanel;
    public GameObject PausePanel;
    public GameObject ConfirmQuitPanel;
    public GameObject GameOverPanel;

    public AudioSource gametimeMusic;
    public AudioSource pausedMusic;
    public AudioSource endLevelMusic;

    private bool gametimeMusicStarted = false;
    private bool pausedMusicStarted = false;
    private bool endLevelMusicStarted = false;

    public CarAudio carSounds;

    // Start is called before the first frame update
    void Start()
    {
        pausedMusic.Stop();
        endLevelMusic.Stop();
        pausedMusicStarted = false;
        endLevelMusicStarted = false;
        gametimeMusic.Play();
        gametimeMusicStarted = true;
    }

    // Update is called once per frame
    void Update()
    {
        //user pauses
        if (PausePanel.activeSelf && !pausedMusicStarted)
        {
            carSounds.StopSound();

            gametimeMusic.Pause();
            pausedMusic.Play();
            pausedMusicStarted = true;
        }

        //pausedMusic continues to play when...
        //user hits quit - given confirm screen, or
        //user returns to pause screen from confirm screen

        //user unpauses
        if(!PausePanel.activeSelf && !ConfirmQuitPanel.activeSelf && pausedMusicStarted)
        {
            pausedMusic.Pause();
            gametimeMusic.UnPause();
            pausedMusicStarted = false; //for pausing again after pausing and unpausing once

            carSounds.StartSound();
        }

        //reach the end of level
        if (GameOverPanel.activeSelf && !endLevelMusicStarted)
        {
            carSounds.StopSound();

            gametimeMusic.Stop();
            endLevelMusic.Play();
            endLevelMusicStarted = true;
        }
    }
}
