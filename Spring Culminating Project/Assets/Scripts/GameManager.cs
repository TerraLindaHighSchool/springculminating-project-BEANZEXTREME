using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    private float secondsCount;
    public TextMeshProUGUI timePassesSlowly;
    public PlayerController vroomies;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        secondsCount += Time.deltaTime;
        timePassesSlowly.text = "Time Wasted: " + secondsCount;
        Debug.Log(vroomies.distanceTraveled);
    }
}
