using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Justice : MonoBehaviour
{
    public bool CLICKED;

    public void Start()
    {
        CLICKED = false;
    }
    public void OnMouseDownAsButton()
    {
        Debug.Log("JUSTICE!!!");
    }

    public void Interact()
    {
        Debug.Log("JUSTICE!");
        //state = MOOD.GOOD;
        //bool CLICKED = true;
    }

}
