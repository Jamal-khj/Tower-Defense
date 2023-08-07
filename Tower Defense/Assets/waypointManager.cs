using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class waypointManager : MonoBehaviour
{
    // create refference to the list of points
    public List<GameObject> pointObjects = new List<GameObject>();
    // a refernce to th point prefabs
    public WayPointHolder pointHolder;

    void Start()
    {
        pointHolder.points = new Vector2[pointObjects.Count];
        for (int i = 0; i < pointObjects.Count; i++)
        {
            pointHolder.points[i] = pointObjects[i].transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
