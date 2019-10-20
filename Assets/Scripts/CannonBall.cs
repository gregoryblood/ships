using UnityEngine;

public class CannonBall : MonoBehaviour
{
    public float lifespan = 5f;
    public GameObject explosion;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, lifespan);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Boat"))
        {
            GameObject blast = Instantiate(explosion, transform.position, Quaternion.identity) as GameObject;
            blast.transform.localScale = Vector3.Lerp(transform.localScale, new Vector3(5, 5, 5), 20f * Time.deltaTime);
            Destroy(blast, 0.5f);
            Destroy(gameObject);
        }
        

    }
}
