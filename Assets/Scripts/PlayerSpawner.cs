using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerSpawner : MonoBehaviour
{
    public GameObject ship;
    public float distance = 100;
    public Material blue;
    public Material red;
    public Material yellow;
    public Material green;
    private int numPlayers = Gamepad.all.Count;

    // Start is called before the first frame update
    void Awake()
    {
        Debug.Log(Gamepad.all.Count);
        //Shared
        //shareShip();
        //Seperate
        seperateShip();
    }
    void shareShip()
    {
        for (int i = 0; i < numPlayers; i++)
        {
            if (i == 0)
            {
                GameObject theship =
                Instantiate(ship, new Vector3(-distance - distance, 0.7f, -distance), Quaternion.identity) as GameObject;
                theship.GetComponentsInChildren<MeshRenderer>()[0].material = blue;
                theship.GetComponentsInChildren<MeshRenderer>()[1].material = blue;
                theship.GetComponentsInChildren<MeshRenderer>()[2].material = blue;
                theship.GetComponent<PlayerMovement>().gamepadNum = 1;
                theship.GetComponent<PlayerShooting>().gamepadNum = 2;
            }
            else if (i == 3)
            {
                GameObject theship =
                Instantiate(ship, new Vector3(distance + distance, 0.7f, distance), Quaternion.identity) as GameObject;
                theship.transform.Rotate(0, 180, 0);
                theship.GetComponentsInChildren<MeshRenderer>()[0].material = red;
                theship.GetComponentsInChildren<MeshRenderer>()[1].material = red;
                theship.GetComponentsInChildren<MeshRenderer>()[2].material = red;
                theship.GetComponent<PlayerMovement>().gamepadNum = 3;
                theship.GetComponent<PlayerShooting>().gamepadNum = 4;
            }
        }
    }
    void seperateShip()
    {
        for (int i = 0; i < numPlayers; i++)
        {
            if (i == 0)
            {
                GameObject theship =
                Instantiate(ship, new Vector3(-distance - distance, 0.7f, -distance), Quaternion.identity) as GameObject;
                theship.GetComponentsInChildren<MeshRenderer>()[0].material = blue;
                theship.GetComponentsInChildren<MeshRenderer>()[1].material = blue;
                theship.GetComponentsInChildren<MeshRenderer>()[2].material = blue;
                theship.GetComponent<PlayerMovement>().gamepadNum = 1;
                theship.GetComponent<PlayerShooting>().gamepadNum = 1;

            }

            else if (i == 1)
            {
                GameObject theship =
                Instantiate(ship, new Vector3(distance + distance, 0.7f, distance), Quaternion.identity) as GameObject;
                theship.transform.Rotate(0, 180, 0);
                theship.GetComponentsInChildren<MeshRenderer>()[0].material = red;
                theship.GetComponentsInChildren<MeshRenderer>()[1].material = red;
                theship.GetComponentsInChildren<MeshRenderer>()[2].material = red;
                theship.GetComponent<PlayerMovement>().gamepadNum = 2;
                theship.GetComponent<PlayerShooting>().gamepadNum = 2;
            }
            else if (i == 2)
            {
                GameObject theship =
                Instantiate(ship, new Vector3(-distance - distance, 0.7f, distance), Quaternion.identity) as GameObject;
                theship.GetComponentsInChildren<MeshRenderer>()[0].material = yellow;
                theship.GetComponentsInChildren<MeshRenderer>()[1].material = yellow;
                theship.GetComponentsInChildren<MeshRenderer>()[2].material = yellow;
                theship.GetComponent<PlayerMovement>().gamepadNum = 3;
                theship.GetComponent<PlayerShooting>().gamepadNum = 3;
            }
            else if (i == 3)
            {
                GameObject theship =
                Instantiate(ship, new Vector3(distance + distance, 0.7f, -distance), Quaternion.identity) as GameObject;
                theship.GetComponentsInChildren<MeshRenderer>()[0].material = green;
                theship.GetComponentsInChildren<MeshRenderer>()[1].material = green;
                theship.GetComponentsInChildren<MeshRenderer>()[2].material = green;
                theship.GetComponent<PlayerMovement>().gamepadNum = 4;
                theship.GetComponent<PlayerShooting>().gamepadNum = 4;
            }

        }
    }
}
