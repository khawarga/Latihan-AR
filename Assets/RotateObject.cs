using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObject : MonoBehaviour
{

    private Touch touch;
    private Quaternion rotationY;
    private float rotateSpeedModifier = 0.3f;
    public GameObject obj;
    private bool tanda;
    private BoxCollider rig;

    // Update is called once per frame
    void Update()
    {
        if(Input.touchCount > 0)
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hitinfo;

            if(Physics.Raycast(ray, out hitinfo))
            {
                rig = hitinfo.collider.GetComponent<BoxCollider>();
                if (rig != null && tanda == false)
                {
                    LeanTween.scale(obj, new Vector3(0.35875f, 0.35875f, 0.35875f), 1f).setEase(LeanTweenType.easeInOutElastic);
                    tanda = true;
                    SuaraAR.playSound("trivia");
                }
                else
                {
                    LeanTween.scale(obj, new Vector3(0f, 0f, 0f), 1f).setEase(LeanTweenType.easeInOutElastic);
                    tanda = false;
                    SuaraAR.playSound("trivia");
                }
            }

            touch = Input.GetTouch(0);

            if(touch.phase == TouchPhase.Moved)
            {
                rotationY = Quaternion.Euler(touch.deltaPosition.y * rotateSpeedModifier, -touch.deltaPosition.x * rotateSpeedModifier, 0f);

                transform.rotation = rotationY * transform.rotation;
            }
        }    
    }
}
