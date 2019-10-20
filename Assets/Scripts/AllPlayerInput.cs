using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class AllPlayerInput : MonoBehaviour
{
    public float slowMotion = 0.3f;
    public float timer;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(Time.time + " || " + timer);
        //Reset->Pause Menu
        if (Gamepad.all[0].startButton.wasPressedThisFrame)
        {
            if (Time.time < timer + 0.5f)
            {
                Application.Quit();
            }
            else
            {

                timer = Time.time;
                InvokeRepeating("loadScene", 0.6f, 2f);


            }
            
            
            
        }
        if (Input.GetKeyDown("0"))
        {
            Time.timeScale = slowMotion;
            //Time.fixedDeltaTime = slowMotion * 0.2f;
        }
        if (Input.GetKeyUp("0"))
        {
            Time.timeScale = 1;
            //Time.fixedDeltaTime = 0.2f;
        }
        
    }
    void loadScene()
    {
        SceneManager.LoadScene(0);
    }

}
