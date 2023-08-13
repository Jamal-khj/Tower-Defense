using UnityEngine;
//using Andrew.Script;)

public class WaypointFollower : MonoBehaviour
{
    public WayPointHolder waypoints;
    int index = 0;
    float dist;

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, waypoints.points[index], 5 * Time.deltaTime);
        dist = Vector2.Distance(transform.position, waypoints.points[index]);
        if (dist < 0.2f && index != waypoints.points.Length) index++;
    }
}
