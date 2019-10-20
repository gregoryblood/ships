using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    public GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 40; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                for (int k = 0; k < 1; k++)
                {
                    Instantiate(cube, new Vector3(transform.position.x+k,
                                    transform.position.y + j, transform.position.z + i), transform.rotation);
                }
                
            }
        }
    }

}
