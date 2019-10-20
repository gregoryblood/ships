using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UI;
using TMPro;

public class PlayerShooting : MonoBehaviour
{
    public int playerNum;
    public Transform cannonLeft;
    public Transform cannonRight;
    public Rigidbody cannonBall;
    public float ballSpeed;
    public int loadMax = 60;
    [Range(0, 60)] public int loaded;
    public AudioSource cannonSound;

    public float angle;
    public float spread;
    public TextMeshProUGUI numLoaded;
    public Image[] images;
    public int gamepadNum;
    public float deadzone = 0.6f;
    //public bool rightSide = false;



    PlayerControls controls;

    private int loadLevel = 1;
    private int bonusShots = 0;
    // Start is called before the first frame update
    void Awake()
    {     
        //controls = new PlayerControls();
        //controls.Shooting.ShootLeft.performed += ctx => FireLeft();
        //controls.Shooting.ShootRight.performed += ctx => FireRight();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        numLoaded.SetText(loaded.ToString());
        LoadShot();
        if (Gamepad.all[gamepadNum - 1].rightTrigger.wasPressedThisFrame)
            FireRight();
        else if (Gamepad.all[gamepadNum - 1].leftTrigger.wasPressedThisFrame)
            FireLeft();
    }
    
    void LoadShot()
    {
        if (Gamepad.all[gamepadNum - 1].rightStick.ReadValue().x <= -deadzone && loadLevel == 1 && loaded < loadMax)
        {
            loadLevel++;
            images[0].enabled = false;
            images[1].enabled = true;
        }
        else if (Gamepad.all[gamepadNum - 1].rightStick.ReadValue().y >= deadzone && loadLevel == 2 && loaded < loadMax)
        {
            loadLevel++;
            images[1].enabled = false;
            images[2].enabled = true;
        }
        else if (Gamepad.all[gamepadNum - 1].rightStick.ReadValue().x >= deadzone && loadLevel == 3 && loaded < loadMax)
        {
            loadLevel++;
            images[2].enabled = false;
            images[3].enabled = true;

        }
        else if (Gamepad.all[gamepadNum - 1].rightStick.ReadValue().y <= -deadzone && loadLevel == 4 && loaded < loadMax)
        {
            images[3].enabled = false;
            images[0].enabled = true;
            loadLevel = 1;
            if (loaded < loadMax)
            {
                //how much to load
                loaded += 2 + bonusShots;
                bonusShots += 1;
                if (loaded >= loadMax)
                {
                    loaded = loadMax;
                    images[0].enabled = false;
                }
            }
            

        }
        else
        {
            /*Wrong Input
            if ((Gamepad.all[gamepadNum - 1].rightStick.ReadValue().x <= -0.8f && loadLevel != 1 ||
                Gamepad.all[gamepadNum - 1].rightStick.ReadValue().y <= -0.8f && loadLevel != 2 ||
                Gamepad.all[gamepadNum - 1].rightStick.ReadValue().x >= 0.8f && loadLevel != 3 ||
                Gamepad.all[gamepadNum - 1].rightStick.ReadValue().y >= 0.8f && loadLevel != 4) &&
                loaded < loadMax)
            {
                loadLevel = 1;
                images[0].enabled = true;
                images[1].enabled = false;
                images[2].enabled = false;
                images[3].enabled = false;
            }
            */
            //Need to load
            if (loaded < loadMax && loadLevel == 1)
                images[0].enabled = true;
        }
        //CAN ADD ANOTHER BUTTON TO STOP CIRCLE SPAMMING
    }
    void FireRight()
    {
        bonusShots = 0;
        for (int i = -4; i <= 4; i+=2)
        {
            for (int j = 0; j <= 4; j += 2)
            {
                if (loaded > 0)
                {

                    Rigidbody shellInstance =
                        Instantiate(cannonBall, cannonRight.position, cannonRight.rotation) as Rigidbody;
                    if ((transform.rotation.eulerAngles.y >= 45 && transform.rotation.eulerAngles.y <= 135) || (transform.rotation.eulerAngles.y >= 225 && transform.rotation.eulerAngles.y <= 315))
                    {
                        shellInstance.transform.position = new Vector3(cannonRight.position.x + i, cannonRight.position.y + j, cannonRight.position.z);
                    }
                    else
                        shellInstance.transform.position = new Vector3(cannonRight.position.x, cannonRight.position.y + j, cannonRight.position.z + i);

                    shellInstance.transform.Rotate(Random.Range(-spread/2, -angle), Random.Range(-spread, spread), 0);
                    shellInstance.velocity = ballSpeed * shellInstance.transform.forward;
                    cannonSound.Play();
                    loaded--;
                    loadLevel = 1;
                    images[0].enabled = true;
                    images[1].enabled = false;
                    images[2].enabled = false;
                    images[3].enabled = false;
                }
                
            }
        }
        
    }
    void FireLeft()
    {
        bonusShots = 0;
        for (int i = -4; i <= 4; i += 2)
        {
            for (int j = 0; j <= 4; j += 2)
            {
                if (loaded > 0)
                {
                    Rigidbody shellInstance =
                        Instantiate(cannonBall, cannonLeft.position, cannonLeft.rotation) as Rigidbody;
                    if ((transform.rotation.eulerAngles.y >= 45 && transform.rotation.eulerAngles.y <= 135) || (transform.rotation.eulerAngles.y >= 225 && transform.rotation.eulerAngles.y <= 315))
                        shellInstance.transform.position = new Vector3(cannonLeft.position.x + i, cannonLeft.position.y + j, cannonLeft.position.z);
                    else
                        shellInstance.transform.position = new Vector3(cannonLeft.position.x, cannonLeft.position.y + j, cannonLeft.position.z + i);
                    shellInstance.transform.Rotate(Random.Range(-spread/2, -angle), Random.Range(-spread, spread), 0);
                    shellInstance.velocity = ballSpeed * shellInstance.transform.forward;
                    cannonSound.Play();
                    loaded--;
                    loadLevel = 1;
                    images[0].enabled = true;
                    images[1].enabled = false;
                    images[2].enabled = false;
                    images[3].enabled = false;
                }

            }
        }
    }
    private void OnEnable()
    {
        //controls.Shooting.Enable();
    }
    private void OnDisable()
    {
        //controls.Shooting.Disable();
    }


}
