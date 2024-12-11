using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Statemachine : MonoBehaviour
{
    private Justice justiceScript;
    private bool stateComplete;
    Material myMat;
    Renderer myRend;
    public GameObject happyFace;
    public GameObject neutralFace;
    public GameObject angryFace;
    public int faceThing;

    private bool CRh_running;
    private bool CRn_running;
    private bool CRa_running;

    private void Start()
    {
        myRend = GetComponent<Renderer>();
        myMat = myRend.material;
        happyFace = GameObject.Find("Happy");
        neutralFace = GameObject.Find("Neutral");
        angryFace = GameObject.Find("Angry");
        faceThing = 0;   // 0 means neutral, -1 is angry, and 1 is happy

        happyFace.transform.localScale = Vector3.zero;
        neutralFace.transform.localScale = Vector3.one;
        angryFace.transform.localScale = Vector3.zero;

        CRh_running = false;
        CRn_running = false;
        CRa_running = false;
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
        switch (faceThing)
        {
            case 0:
                neutralFace.transform.localScale = Vector3.zero;
                happyFace.transform.localScale = Vector3.one;
                faceThing += 1;
                break;
            case -1:
                angryFace.transform.localScale = Vector3.zero;
                happyFace.transform.localScale = Vector3.one;
                faceThing += 2;
                break;
            case 1:
                break;
            default:
                Debug.Log("HOW DID YOU BREAK IT ALREADY");
                break;
        }
        StartCoroutine ("colorDelay1");
        stateComplete = true;
    }

    private void UpdateNEUTRAL()
    {
        print("OK!!!");
        myMat.color = Color.yellow;

        switch (faceThing)
        {
            case 1:
                happyFace.transform.localScale = Vector3.zero;
                neutralFace.transform.localScale = Vector3.one;
                faceThing -= 1;
                break;
            case -1:
                angryFace.transform.localScale = Vector3.zero;
                neutralFace.transform.localScale = Vector3.one;
                faceThing += 1;
                break;
            case 0:
                break;
            default:
                Debug.Log("HOW DID YOU BREAK IT ALREADY");
                break;
        }
        StartCoroutine(colorDelay0());
        stateComplete = true;
    }

    private void UpdateEVIL()
    {
        print("BAD!!!");
        myMat.color = Color.red;

        switch (faceThing)
        {
            case 0:
                neutralFace.transform.localScale = Vector3.zero;
                angryFace.transform.localScale = Vector3.one;
                faceThing -= 1;
                break;
            case 1:
                happyFace.transform.localScale = Vector3.zero;
                angryFace.transform.localScale = Vector3.one;
                faceThing -= 2;
                break;
            case -1:
                break;
            default:
                Debug.Log("HOW DID YOU BREAK IT ALREADY");
                break;
        }
        StartCoroutine("colorDelayN1");
        stateComplete = true;
    }

    IEnumerator colorDelay1()
    {
        CRh_running = true;
        yield return new WaitForSeconds(3);
        myMat.color = Color.white;
        happyFace.transform.localScale = Vector3.zero;
        neutralFace.transform.localScale = Vector3.one;
        faceThing -= 1;
        CRh_running = false;
    }

    IEnumerator colorDelay0()
    {
        yield return new WaitForSeconds(3);
        myMat.color = Color.white;
    }

    IEnumerator colorDelayN1()
    {
        yield return new WaitForSeconds(3);
        myMat.color = Color.white;
        angryFace.transform.localScale = Vector3.zero;
        neutralFace.transform.localScale = Vector3.one;
        faceThing += 1;
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
