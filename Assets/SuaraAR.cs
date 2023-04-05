using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SuaraAR : MonoBehaviour
{
    public static AudioClip button, trivia,helisfx;
    static AudioSource source;
    // Start is called before the first frame update
    void Start()
    {
        source = GetComponent<AudioSource>();

        button = Resources.Load<AudioClip>("playButton");
        trivia = Resources.Load<AudioClip>("trivia");
        helisfx = Resources.Load<AudioClip>("heli");
    }

    public static void playSound(string clip)
    {
        if (clip.Equals("trivia"))
        {
            source.PlayOneShot(trivia);
        }
        else if (clip.Equals("button"))
        {
            source.PlayOneShot(button);
        }
        else if (clip.Equals("heli"))
        {
            source.PlayOneShot(helisfx);
        }
    }
}
