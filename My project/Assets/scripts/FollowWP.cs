using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowWP : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] waypoints; 
    int CurrentWP = 0;


    public float speed = 10.0f;
    public float rotSpeed = 10.0f;

    GameObject tracker;
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

        //this.transform.LookAt (waypoints[CurrentWP].transform);

        Quaternion lookatWP = Quaternion.LookRotation(waypoints[CurrentWP].transform.position - this.transform.position);

        this.transform.rotation = Quaternion.Slerp(transform.rotation, lookatWP,rotSpeed * Time.deltaTime);

        this.transform.Translate(0, 0, speed * Time.deltaTime);
    }
}
