using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockGenerator : MonoBehaviour {

    public int numRocks;//how many rocks to generate
    public Vector3 fieldSize;//bounding box size for the rock field
    public GameObject rock;//the prefab that we will be using

    public Vector2 rockSize;//constraints for the randomized sizes of rocks
    public Vector2 rockVelocity;//contstraints for the randomized speeds of rocks
    public Vector2 rockangVelocity;//constraints for the randomized rotations of rocks

    private GameObject[] rocksHolder;//an array that holds all of the rocks

	void Start () {
        rocksHolder = new GameObject[numRocks];//assigns a gameobject array of the size "numRocks"

        for (int i= 0; i <= numRocks-1; i++)//itterates over the rock array and generates rocks with random locations, rotations, and movements.
        {
            GameObject freshRock = GameObject.Instantiate(rock, RandomVector3(fieldSize), Random.rotation);//instatiates rock with random position and rotation
            Rigidbody freshRockRB = freshRock.GetComponent<Rigidbody>();//assigns rocks Rigidbody to a variable so that we can randomize its angular and linear velocities

            freshRock.transform.localScale = RandomVelocity(rockSize);//Randomizes size USING THE VELOCITY RANDOMIZER CAUSE I AM LAZY
            freshRockRB.velocity = RandomVelocity(rockVelocity);//randomizes linear velocity
            freshRockRB.angularVelocity = RandomVelocity(rockangVelocity);//randomizes angular velocity

            freshRock.transform.parent = gameObject.transform;
            rocksHolder[i] = freshRock; //assigns generated rock to array

        }

	}

    Vector3 RandomVector3(Vector3 range) {
        //Takes a Vector3 which is used as the size of the rangebox, not a specific coord, and returns a random coord in that box. 0.0.0 is the center of the box.
        Vector3 randomVector3 = new Vector3(
            Random.Range(range.x / 2 * -1, range.x / 2),
            Random.Range(range.y / 2 * -1, range.y / 2),
            Random.Range(range.z / 2 * -1, range.z / 2)
            );
        return randomVector3;
    }

    Vector3 RandomVelocity(Vector2 range) {
        //Takes a Vector2 which is the min and max velocities and returns a random velocity in that range.
        Vector3 randomVector3 = new Vector3(
            Random.Range(range.x,range.y),
            Random.Range(range.x, range.y),
            Random.Range(range.x, range.y)
            );
        return randomVector3;
    }
}
