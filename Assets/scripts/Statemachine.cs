using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statemachine : MonoBehaviour
{
    public GameObject ENTITY;
    private Justice justiceScript;
    bool stateComplete;
    Material myMat;
    Renderer myRend;
    public GameObject happyFace;
    public GameObject neutralFace;
    public GameObject angryFace;

    private void Start()
    {
        myRend = GetComponent<Renderer>();
        myMat = myRend.material;
        happyFace = GameObject.Find("Happy");
        neutralFace = GameObject.Find("Neutral");
        angryFace = GameObject.Find("Angry");
    }

    public enum MOOD
    {
        GOOD,
        NEUTRAL,
        EVIL
    }

    public MOOD bruh;

    public void UpdateState(MOOD m)
    {
        bruh = m;
        switch (bruh)
        {
            case MOOD.GOOD:
                UpdateGOOD();// some random code lol
                break;

            case MOOD.NEUTRAL:
                UpdateNEUTRAL();// more random code lol
                break;

            case MOOD.EVIL:
                UpdateEVIL();// even more random code lol
                break;
        }
    }

    private void UpdateGOOD()
    {
        print("GOOD!!!");
        myMat.color = Color.green;
        stateComplete = true;
    }

    private void UpdateNEUTRAL()
    {
        print("OK!!!");
        myMat.color = Color.yellow;
        stateComplete = true;
    }

    private void UpdateEVIL()
    {
        print("BAD!!!");
        myMat.color = Color.red;
        stateComplete = true;
    }

    

    //private void Update()
    //{
    //    if (stateComplete)
    //    {
    //        SelectState();
    //    }
    //    UpdateState();
    //}

    //private void SelectState()
    //{
    //    stateComplete = false;
    //}

}
