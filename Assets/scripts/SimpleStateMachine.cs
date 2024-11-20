using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleStateMachine : MonoBehaviour
{
    public float speed = 0.001f;
    public float time = 10f;
    public float percentage;
    bool colorChange;

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
        colorChange = false;
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

        if (myMat.color != targetCol && colorChange)
        {
            percentage = RampFloat(time, 0, time, 0, 1);
            StartCoroutine(SetColor(targetCol, time));
        }

        // more regualr update code goes here, probably something that depends on what mode the script is in
    }

    public static float RampFloat(float value, float from1, float to1, float from2, float to2)
    {
        return (value - from1) / (to1 - from1) * (to2 - from2) + from2;
    }

    IEnumerator SetColor(Color c, float t)
    {
        while (t >= 0)
        {
            t -= speed;
            percentage = RampFloat(t, 0, t, 0, 1);
            myMat.color = Color.Lerp(myMat.color, c, 1 - t);
            yield return new WaitForSeconds(speed);
        }
        colorChange = false;
    }


}
