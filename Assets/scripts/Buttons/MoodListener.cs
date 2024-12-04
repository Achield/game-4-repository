using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoodListener : MonoBehaviour
{
    public Statemachine myMachine;
    public Statemachine.MOOD targetMood;

    public void Awake()
    {
        myMachine = FindObjectOfType<Statemachine>();
    }

    //public void OnMouseDownAsButton()
    //{
    //    Debug.Log("JUSTICE!!!");
    //}

    public void Interact()
    {
        Debug.Log("PROFESSIONAL!");
        myMachine.UpdateState(targetMood);
    }
}
