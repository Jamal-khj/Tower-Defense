using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaypointFollower : MonoBehaviour
{
    public WayPointHolder waypoints;
    int index = 0;
    float dist;

    void Start()
    {

    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, waypoints.points[index], 5 * Time.deltaTime);
        dist = Vector2.Distance(transform.position, waypoints.points[index]);
        if (dist < 0.2f && index != waypoints.points.Length) index++;
    }
}
