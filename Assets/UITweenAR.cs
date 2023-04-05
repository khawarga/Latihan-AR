using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UITweenAR : MonoBehaviour
{
    [SerializeField] GameObject Backbutton, animationButton, resetButton;
    public CanvasGroup FadeInFadeOut;


    private void Start()
    {
        LeanTween.scale(Backbutton, new Vector3(1f, 1f, 1f), 1f).setEase(LeanTweenType.easeInOutElastic);
        LeanTween.scale(animationButton, new Vector3(1f, 1f, 1f), 1f).setEase(LeanTweenType.easeInOutElastic);
        LeanTween.scale(resetButton, new Vector3(1f, 1f, 1f), 1f).setEase(LeanTweenType.easeInOutElastic);
    }

    public void backButton()
    {
        SceneManager.LoadScene(0);
        SuaraAR.playSound("button");
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            SuaraAR.playSound("trivia");
            LeanTween.alphaCanvas(FadeInFadeOut, 1f, 2.2f).setOnComplete(keluar);
        }
    }
    private void keluar()
    {
        Application.Quit();
    }
}
