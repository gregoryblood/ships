using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class PlayerHealth : MonoBehaviour
{
    public int health = 60;
    public SimpleHealthBar healthbar;
    public GameObject explosion;
    public AudioSource blastSound;
    public GameObject plank;

    private Material colorShip;

    // Start is called before the first frame update
    void Start()
    {
        colorShip = GetComponentInChildren<MeshRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag("Water"))
        {
            
            health--;
            healthbar.UpdateBar(health, 60);
            GameObject debree = Instantiate(plank, transform.position, Quaternion.Euler(0,0,0)) as GameObject;
            debree.GetComponent<Rigidbody>().velocity = new Vector3(Random.Range(-10, 10), Random.Range(5, 25), Random.Range(-10, 10));
            debree.GetComponent<Rigidbody>().AddTorque(transform.up * Random.Range(-500,500));
            debree.GetComponent<Rigidbody>().AddTorque(transform.right * Random.Range(-500, 500));
            debree.GetComponent<Rigidbody>().AddTorque(transform.forward * Random.Range(-500, 500));
            debree.GetComponent<MeshRenderer>().material = colorShip;
            blastSound.Play();

            if (health < 1)
            {
                Destroy(gameObject);
                GameObject blast = 
                    Instantiate(explosion, transform.position, Quaternion.identity) as GameObject;
                blast.transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(20, 20, 20), 20f * Time.deltaTime);
                Destroy(blast, 0.5f);

            }
        }
    }
}
