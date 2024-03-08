using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlaySong : MonoBehaviour
{
    [SerializeField] AudioSource sceneMusic;

    public void PlaySound(float vol, AudioClip myClip)     //adjust preferred volume of particular clip in "vol" 
    {
        sceneMusic.clip = myClip;
        sceneMusic.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (!sceneMusic.isPlaying)
        {
            SceneManager.LoadScene("MainMenu");
            Debug.Log("Audio file ended.");
        }
    }
}
