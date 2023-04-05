using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationScript : MonoBehaviour
{
    private Animator anim;
    private int tanda = 0;
    private Vector3 obj1;
    private Quaternion obj2;

    private void Start()
    {
        obj1 = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
        obj2 = Quaternion.Euler(gameObject.transform.rotation.x, gameObject.transform.rotation.y, gameObject.transform.rotation.z);
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if(tanda == 1)
        {
            tanda = 0;
            AnimationPlay();
            SuaraAR.playSound("button");
        }
        else if(tanda == 2)
        {
            tanda = 0;
            ResetButton();
            SuaraAR.playSound("button");
        }
    }

    private void AnimationPlay()
    {
        anim.SetTrigger("Terbang");
        SuaraAR.playSound("heli");
    }

    private void ResetButton()
    {
        gameObject.transform.position = obj1;
        gameObject.transform.rotation = obj2;
        gameObject.transform.localScale = new Vector3(0.02f, 0.02f, 0.02f);
    }

    public void AnimationButtonClicked()
    {
        tanda = 1;
    }

    public void ResetButtonClicked()
    {
        tanda = 2;
    }
}
