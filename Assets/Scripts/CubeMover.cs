using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMover : MonoBehaviour
{

    [SerializeField] private Cube cube1;
    [SerializeField] private Cube cube2;
    [SerializeField] private Material cubeMat;
    [SerializeField] private float arrivalThresholdDistance = .05f;


    // Start is called before the first frame update
    private void Start()
    {
        cubeMat = GetComponentInChildren<Material>();
        StartCoroutine(SphereFollow(cube1));
        StartCoroutine(SphereFollow(cube2));
    }

    private IEnumerator SphereFollow(Cube cube)
    {
        //cube starts at first point
        cube.transform.position = cube.checkpoints[0].position;

        //Keep moving between the checkpoints
        while (true)
        {
            //increment to the next checkpoint
            cube.currentCheckpointIndex = (cube.currentCheckpointIndex + 1) % cube.checkpoints.Length;
            yield return StartCoroutine(MoveCubeToCheckpoint(cube));
        }
        //Wait until the sphere reaches the first checkpoint
        
        //Wait until the sphere reaches the second checpoint
       


        //loop movement between checkpoints

    }


    private IEnumerator MoveCubeToCheckpoint(Cube cube)
    {
        var checkpoint = cube.checkpoints[cube.currentCheckpointIndex];
        var speedPerSecond = cube.speed[cube.currentCheckpointIndex];
        //loop movement between checkpoints
        while (true)
        {
            //sphere will move at constant speed until it reaches the checkpoint
            Vector3 deltaPos = checkpoint.position - cube.transform.position; //calc the direction to the checkpoint
            var movementDir = deltaPos.normalized; //Normalize the direction to get a unit Vector
            cube.transform.Translate(movementDir * speedPerSecond * Time.deltaTime);
            yield return new WaitForEndOfFrame();

            //Once the sphere has reached the checkpoint
            var distanceToWaypoint = Vector3.Distance(cube.transform.position, checkpoint.position);
            if (distanceToWaypoint < arrivalThresholdDistance)
            {
                //snap the sphere to checkpoint
                cube.transform.position = checkpoint.position;
                cubeMat.color = cube.colors[cube.currentCheckpointIndex];
                Debug.Log("Arrived");
                break;
            }
        }
    }

}
