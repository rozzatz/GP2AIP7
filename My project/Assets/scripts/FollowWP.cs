using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowWP : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] waypoints; 
    int CurrentWP = 0;


    public float speed = 10.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(this.transform.position, waypoints[CurrentWP].transform.position) < 3)
            CurrentWP++;

        if (CurrentWP >= waypoints.Length)
            { CurrentWP = 0; }

        this.transform.LookAt (waypoints[CurrentWP].transform);
        this.transform.Translate(0, 0, speed * Time.deltaTime);
    }
}
