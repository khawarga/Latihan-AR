using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UITween : MonoBehaviour
{
    [SerializeField] GameObject Background, Title, Playbutton;
    public CanvasGroup FadeInFadeOut;

    // Start is called before the first frame update
    void Start()
    {
        LeanTween.alphaCanvas(FadeInFadeOut, 0f, 3f).setOnComplete(TitleGo);
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            SuaraAR.playSound("playButtonClicked");
            LeanTween.alphaCanvas(FadeInFadeOut, 1f, 2.2f).setOnComplete(keluar);
        }
    }

    private void TitleGo()
    {
        AudioScript.playSound("Title");
        LeanTween.moveLocalY(Title, 622, 2.3f).setOnComplete(playButton);
    }

    private void playButton()
    {
        AudioScript.playSound("playButton");
        LeanTween.scale(Playbutton, new Vector3(1f, 1f, 1f), 1f).setEase(LeanTweenType.easeInOutElastic);
    }

    public void buttonCliked()
    {
        LeanTween.scale(Playbutton, new Vector3(0f, 0f, 0f), 1f).setEase(LeanTweenType.easeInOutElastic);
        AudioScript.playSound("playButtonClicked");
        LeanTween.alphaCanvas(FadeInFadeOut, 1f, 2.2f).setOnComplete(ChangeScene);
        
    }

    private void keluar()
    {
        Application.Quit();
    }

    private void ChangeScene()
    {
        SceneManager.LoadScene(1);
    }
}
