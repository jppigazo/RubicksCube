using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class rotateKeys : MonoBehaviour {
    
    public RubiksCubePrefab rubikscube;

    public leapHands leapHands;

    List<List<List<GameObject>>> cubePrefabMatrix;
    public float spacing = 1.05f;
    public float rotationSpeed = 40;
    int keyPressed = 0;

    // Use this for initialization
    void Start () {
        rubikscube = FindObjectOfType(typeof(RubiksCubePrefab)) as RubiksCubePrefab;
        leapHands = FindObjectOfType(typeof(leapHands)) as leapHands;
    }
	
	// Update is called once per frame
	void Update () {

       
        if (Input.GetKeyDown(KeyCode.Y))
        {
            keyPressed = 1;
            StartCoroutine(rotationCube(keyPressed));
        }
        else if (Input.GetKeyDown(KeyCode.U))
        {
            keyPressed = 2;
            StartCoroutine(rotationCube(keyPressed));
        }
        else if (Input.GetKeyDown(KeyCode.I))
        {
            keyPressed = 3;
            StartCoroutine(rotationCube(keyPressed));
        }
        else if (Input.GetKeyDown(KeyCode.P))
        {
            keyPressed = 4;
            StartCoroutine(rotationCube(keyPressed));
        }

        keyPressed = 0;

    }

    public IEnumerator rotationCube(int keyPressed)
    {

        // "i" will be last
        // "i" == clockwise = false
        // "R" == rotate Right face
        // "L" == rotate Left face
        // "U" == rotate Top face
        // "D" == rotate Bottom face
        // "F" == rotate Front face
        // "B" == rotate Back face
        // "X" == rotate cube on X
        // "Y" == rotate cube on Y
        // "Z" == rotate cube on Z

        string seq;
        float totalRotation = 0;
        bool clockwise = true;
        int dir = 1;
        if (clockwise)
            dir = -1;
        float delta = 0;
        switch (keyPressed)
        {
            case 1:
                seq = "R";
                GameObject.Find("RubiksCube").GetComponentInChildren<RubiksCubePrefab>().passPositionCube(seq);
                Debug.Log("Cube rotate Right face on clockwise");
                break;

            case 2:
                seq = "Ri";
                GameObject.Find("RubiksCube").GetComponentInChildren<RubiksCubePrefab>().passPositionCube(seq);
                Debug.Log("Cube rotate Right face on counterclockwise");
                break;

            case 3:
                seq = "L";
                GameObject.Find("RubiksCube").GetComponentInChildren<RubiksCubePrefab>().passPositionCube(seq);
                Debug.Log("Cube rotate Left face on clockwise");
                break;
            case 4:
                seq = "Li";
                GameObject.Find("RubiksCube").GetComponentInChildren<RubiksCubePrefab>().passPositionCube(seq);
                Debug.Log("Cube rotate Left face on counterclockwise");
                break;
        }

        yield return null;
    }


}