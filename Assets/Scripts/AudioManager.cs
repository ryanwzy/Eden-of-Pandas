using System;
using System.Collections;
using UnityEngine.Audio;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioManager : MonoBehaviour {


    public Sound[] sounds;
    public static AudioManager instance;

    private string lastScene;
    private string currentScene;


    public void FadeOut(string name, float FadeSpeed)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);

        float startVolume = s.source.volume;

        if(s.source.volume > 0)
        {
            s.source.volume -= FadeSpeed;
        }

    }


    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }

        DontDestroyOnLoad(gameObject);

        foreach(Sound s in sounds)
        {
            s.source = gameObject.AddComponent<AudioSource>();
            s.source.clip = s.clip;
            s.source.playOnAwake = s.PlayOnAwake;
            s.source.volume = s.volume;
            s.source.pitch = s.pitch;
            s.source.loop = s.loop;
        }
    }


    void Update () {

        // Checking which scene is loaded (for handling music)

        currentScene = SceneManager.GetActiveScene().name;

        if (currentScene != lastScene)
        {
            lastScene = currentScene;
            ChangeSong();
        }

    }
    // Changing the song when loading a specific level
    void ChangeSong()
    {
        if(lastScene == "Scene1"){
            Play("Scene1");
            }
        if (lastScene == "Scene2")
        {
            Stop("Scene1");
            Play("Scene2");
        }
        if (lastScene == "Scene3")
        {
            Play("cave-ambient");
            Stop("Scene2");
        }
        if(lastScene == "Scene4")
        {
            Stop("cave-ambient");
            Play("Scene4");
        }
        if (lastScene == "Credits")
        {
            Debug.Log("fade!");
            Stop("Scene4");
        }
    }

 

    public void Play(string name)
    {
      
        Sound s = Array.Find(sounds, sound => sound.name == name);
        if (!s.source.isPlaying)
        {
            s.source.PlayOneShot(s.source.clip);

        }
        else if (s.source.isPlaying)
        {
            return;
        }
    }

    public void Stop(string name)
    {
        Sound s = Array.Find(sounds, sound => sound.name == name);
        s.source.Stop();
    }
}
