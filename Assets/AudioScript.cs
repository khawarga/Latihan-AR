using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{

    public static AudioClip BGM1,BGM2,Title, playButton, playButtonClicked;
    static AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        Title = Resources.Load<AudioClip>("Title");
        playButton = Resources.Load<AudioClip>("playButton");
        playButtonClicked = Resources.Load<AudioClip>("playButtonClicked");

        source = GetComponent<AudioSource>();
    }
    
    public static void playSound(string clip)
    {
        if (clip.Equals("Title"))
        {
            source.PlayOneShot(Title);
        }
        else if (clip.Equals("playButton"))
        {
            source.PlayOneShot(playButton);
        }
        else if (clip.Equals("playButtonClicked"))
        {
            source.PlayOneShot(playButtonClicked);
        }
    }
}
