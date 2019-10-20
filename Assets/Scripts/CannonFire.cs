using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonFire : MonoBehaviour
{
    public Rigidbody ball;
    public float speed;
    public float spread;
    public float angle;
    public float waitingTime;

    private float timer;
    private bool firing = false;
    [Range(0,21)] public int loaded;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (Input.GetKeyDown("space") && loaded > 0)
        {
            firing = true;
        }
        if (firing)
        {
            if (timer > waitingTime)
            {
                Fire();
                if (loaded < 1)
                    firing = false;
                timer = 0;
            }
        }
            

    }
    void Fire ()
    {
        Rigidbody shellInstance =
                        Instantiate(ball, transform.position, transform.rotation) as Rigidbody;
        shellInstance.transform.position = new Vector3(transform.position.x, transform.position.y + Random.Range(0,4), transform.position.z + Random.Range(-6, 6));
        shellInstance.transform.Rotate(Random.Range(-spread, -angle), Random.Range(-spread, spread), 0);
        shellInstance.velocity = speed * shellInstance.transform.forward;
        loaded--;
    }
}
