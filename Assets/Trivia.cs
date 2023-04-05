using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trivia : MonoBehaviour
{

    public GameObject obj;

    private void OnMouseDown()
    {
        obj.SetActive(true);
    }
}
