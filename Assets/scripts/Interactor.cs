using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Interactor : MonoBehaviour
{
    public float clickCoolDown = 3.5f;
    private float lastUsedTime;

    bool canClick;

    public Transform InteractorSource;
    public float InteractRange;

    // Start is called before the first frame update
    void Start()
    {
        //canClick = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && Time.time > lastUsedTime + clickCoolDown)
        {
            Ray r = new Ray(InteractorSource.position, InteractorSource.forward);
            Debug.Log("Successfully clicked");
            if (Physics.Raycast(r, out RaycastHit hitInfo, InteractRange))
            {
                if (hitInfo.collider.gameObject.TryGetComponent(out MoodListener listen))
                {
                    listen.Interact();
                }
            }
            lastUsedTime = Time.time;
            canClick = false;
        }
        //else
        //{
        //    clickCoolDown -= Time.deltaTime;
        //    if (clickCoolDown <= 0)
        //    {
        //        canClick = true;
        //    }
        //}
    }
}





//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;


//public class Interactor : MonoBehaviour
//{
//    float clickDelay = 2f;
//    bool canClick;


//    public Transform InteractorSource;
//    public float InteractRange;

//    // Start is called before the first frame update
//    void Start()
//    {
//        bool canClick = true;
//    }

//    // Update is called once per frame
//    void Update()
//    {
//        if (Input.GetKeyDown(KeyCode.Mouse0) && canClick == true)
//        {
//            Ray r = new Ray(InteractorSource.position, InteractorSource.forward);
//            canClick = false;
//        }
//        if (Physics.Raycast(r, out RaycastHit hitInfo, InteractRange))
//        {
//            if (hitInfo.collider.gameObject.TryGetComponent(out MoodListener listen))
//            {
//                listen.Interact();
//            }
//        }
//    }

//}
//}

////The interval you want your player to be able to fire.
//var FireRate : float = 1.0;

////The actual time the player will be able to fire.
//private var NextFire : float;

//function Update()
//{
//    //If the player is pressing fire AND The current time is > than when I want them to fire
//    if (Input.GetButton("Fire1") && Time.time > NextFire)
//    {
//        //If the player fired, reset the NextFire time to a new point in the future.
//        NextFire = Time.time + FireRate;


//        //Weapon firing logic goes here.


//        Debug.Log("Firing once every 1s");
//    }


//}