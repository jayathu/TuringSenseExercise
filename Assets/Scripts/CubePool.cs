using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubePool : MonoBehaviour {

    public static System.Action GenerateCube;
    public GameObject cubePrefab;
    [HideInInspector]
    public List<Transform> transforms;

    List<GameObject> cubes;
    int poolAmount = 10;
                 
	// Use this for initialization
	void Start () {

        cubes = new List<GameObject>();
        for (int i = 0; i < poolAmount; i++)
        {
            GameObject cube = (GameObject)Instantiate(cubePrefab);
            cube.transform.parent = transform;
            cube.SetActive(false);
            cubes.Add(cube);
        }
        GenerateCube += ShowNextCube;
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void ShowNextCube()
    {
        Debug.Log("Generated A cube at " + Time.time);
        for (int i = 0; i < cubes.Count; i++)
        {
            if (!cubes[i].activeInHierarchy)
            {
                cubes[i].transform.position = transforms[i].position;
                cubes[i].GetComponent<Deactivate>().CallInvoke();
                cubes[i].SetActive(true);
                break;
            }
        }
    }
}
