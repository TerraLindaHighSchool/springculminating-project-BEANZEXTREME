using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    // Private Variables
    public float speed = 5.0f;
    private float turnSpeed = 25.0f;
    private float horizontalInput;
    private float forwardInput;

    //time stuff
    private float secondsCount;
    private int minuteCount;
    private int hourCount;

    public int health = 100;

    public TextMeshProUGUI distance;

    public SpawnManager fightMe;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // This is where we get player input
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");

        // We move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // We turn the vehicle
        transform.Rotate(Vector3.up * Time.deltaTime * turnSpeed * horizontalInput);

        //off the interweb
        UpdateTimerUI();

        //neyeyeroeorer
        InitiateZoomies();

        //yeah um the is too fast for physics so lol
        Locked();

        //distance and its related functions/tasks
        DistanceOperations();
        //Debug.Log(distanceTraveled);
        distance.text = "how far gone " + distanceTraveled;
    }

    //call this on update off interweb
    public void UpdateTimerUI()
    {
        //set timer UI
        secondsCount += Time.deltaTime;
        // timerText.text = hourCount + "h:" + minuteCount + "m:" + (int)secondsCount + "s";
        if (secondsCount >= 60)
        {
            minuteCount++;
            secondsCount = 0;
        }
        else if (minuteCount >= 60)
        {
            hourCount++;
            minuteCount = 0;
        }
    }

    //"The Speed!"
    public void InitiateZoomies()
    {
        //in testing find some better maths later
        speed += secondsCount / 5;
        //for example make 5 the difficulty level or something
    }


    //you can hide but you cant run
    public void Locked()
    {
        //follow this format
        
        if(transform.position.x < -10)
        {
            transform.position = new Vector3(-10, transform.position.y, transform.position.z);
        }
        
    }


    //test
    private Vector3 lastPosition;
    public float distanceTraveled;

    public float DistanceOperations()
    {
        distanceTraveled += Vector3.Distance(transform.position, lastPosition);
        lastPosition = transform.position;
        return distanceTraveled;
        //distance.text = "how far gone " + distanceTraveled;
    }
}
