using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleStateMachine : MonoBehaviour
{
    // here is an enumerable, this will track the color of the object's material
    public enum stateMode
    {
        RED,
        GREEN,
        BLUE,
        WHITE,
        BLACK,
        MAGENTA
    }

    public stateMode myMode;
    Renderer myRend;
    Material myMat;

    // Start is called before the first frame update
    void Start()
    {
        myRend = GetComponent<Renderer>();
        myMat = myRend.material;
    }

    // Update is called once per frame
    void Update()
    {
        // to determine what code to run based off the current state of our myMode variable
        // we're going to use a switch statement

        switch (myMode)   // for ecah potential state or mode, declare a "case" and then write any relevant code for that mode
        {
            case stateMode.RED:
                myMat.color = Color.red;
                break;  // at the end of each case, put a break to end it

            case stateMode.GREEN:
                myMat.color = Color.green;
                break;

            case stateMode.BLUE:
                myMat.color = Color.blue;
                break;

            case stateMode.BLACK:
                myMat.color = Color.black;
                break;

            case stateMode.WHITE:
                myMat.color = Color.white;
                break;

            case stateMode.MAGENTA:
                myMat.color = Color.magenta;
                break;
        }



        // more regualr update code goes here, probably something that depends on what mode the script is in


    }
}
