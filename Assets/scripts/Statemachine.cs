using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statemachine : MonoBehaviour
{
    bool stateComplete;
    Material myMat;

    private void Start()
    {
        myMat = GetComponent<Material>();
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
