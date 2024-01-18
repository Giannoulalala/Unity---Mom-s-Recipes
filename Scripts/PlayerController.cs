using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;
//using static UnityEditor.PlayerSettings;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f; // Η ταχύτητα κίνησης του παίκτη

    private Vector3 fingerPosition; // Η θέση του δαχτύλου του χρήστη

    //private var pos = Vector3;

    //

    /* public float moveSpeed = 5f;
     Rigidbody2D rb;
     Touch touch;
     Vector3 touchPosition, whereToMove;
     bool isMoving = false;
     float previousDistanceToTouchPos, currentDistanceToTouch;


    float xInput;
    Vector2 newPosition;
     public float xPositionlimit;*/

    //private float touchSensitivity;
    //bool itstouch;







    // Start is called before the first frame update
    void Start()
    {
        //rb = GetComponent<Rigidbody2D>();   

    }
    private void Update()
    {

        /*touchPosition = Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position.x, Input.GetTouch(0).position.y, 5);
        transform.position = new Vector3(touchPosition.x, touchPosition.y, touchPosition.z);*/


        if (Input.touchCount > 0) // Έλεγχος για αγγίγματα στην οθόνη
        {
            Touch touch = Input.GetTouch(0); // Παίρνουμε το πρώτο αγγίγμα

            if (touch.phase == TouchPhase.Moved) // Έλεγχος για κίνηση του αγγίγματος
            {
                fingerPosition = Camera.main.ScreenToWorldPoint(touch.position); // Μετατρέπουμε την οθόνη σε παγκόσμιες συντεταγμένες

                fingerPosition.z = 0f; // Επειδή χρησιμοποιούμε 2D, η z-θέση είναι πάντα 0
                fingerPosition.y = -3.58f;

                // Κινούμε τον παίκτη προς τη θέση του δαχτύλου με βάση την ταχύτητα
                transform.position = Vector3.MoveTowards(transform.position, fingerPosition, moveSpeed * Time.deltaTime);
            }
        }
    }

    // Update is called once per frame

    /*
        private void FixedUpdate()
        {
            if (isMoving)
            {
                currentDistanceToTouch = (touchPosition- transform.position).magnitude;
            }
            if (Input.touchCount > 0)
            {
                touch = Input.GetTouch(0);
                if (touch.phase == TouchPhase.Began)
                {
                    previousDistanceToTouchPos = 0;
                    currentDistanceToTouch = 0;
                    isMoving = true;
                    touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
                    touchPosition.y = -3.58f;
                    touchPosition.z = 0f;
                    whereToMove = (touchPosition - transform.position).normalized;
                    rb.velocity = new Vector2(whereToMove.x * moveSpeed, whereToMove.y * moveSpeed);
                }
            }

            if (currentDistanceToTouch > previousDistanceToTouchPos)
            {
                isMoving = false;
                rb.velocity = Vector2.zero;

            }
            if (isMoving)
            {
                previousDistanceToTouchPos = (touchPosition - transform.position).magnitude;

            }


        }*/




    // MovePlayer();
}
/*
    void MovePlayer()
    {
        if (itstouch== false)
        {
           // rb.MovePosition(newPosition);
            // Αν η συσκευή δεν είναι αφής, χρησιμοποιήστε τον κώδικα για τον έλεγχο με βάση τον άξονα Horizontal.
            xInput = Input.GetAxis("Horizontal");
            /*newPosition = transform.position;
            newPosition.x += xInput * moveSpeed;

            newPosition.x = Mathf.Clamp(newPosition.x, -xPositionlimit, xPositionlimit);
            //rb.MovePosition(newPosition);
            print("PC OK");
            newPosition = transform.position;
            newPosition.x += xInput * moveSpeed;

            newPosition.x = Mathf.Clamp(newPosition.x, -xPositionlimit, xPositionlimit);
            


        }
        else
        {
            //rb.MovePosition(newPosition);
            

      







    }
}
        */






/*
            // Αν η συσκευή είναι αφής, χρησιμοποιήστε τον κώδικα για τον έλεγχο με βάση την είσοδο αφής.
            if (Input.touchCount > 0)
            {


                print("PHONE OK");
                Touch touch = Input.GetTouch(0);
                Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
                touchPosition.z = 0f; // Φροντίστε να ορίσετε τον άξονα z στην επιθυμητή τιμή (στην ίδια επίπεδη επιφάνεια).
                
                
                
                // Μετακίνηση του παίκτη στη θέση της εισόδου αφής
                //rb.MovePosition(touchPosition);

                Touch touch = Input.GetTouch(0);
                Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
                touchPosition.y = transform.position.y; // Κρατάμε την τρέχουσα θέση του παίκτη στον άξονα Y
                touchPosition.z = transform.position.z; // Κρατάμε την τρέχουσα θέση του παίκτη στον άξονα Z 

                //Μετακίνηση του παίκτη στη νέα θέση της εισόδου αφής
                rb.MovePosition(touchPosition);

                newPosition = transform.position;
                newPosition.x += xInput * moveSpeed;

                newPosition.x = Mathf.Clamp(newPosition.x, -xPositionlimit, xPositionlimit);
                rb.MovePosition(touchPosition);

            }
            else
            {
                xInput = 0f;
                
            }*/
