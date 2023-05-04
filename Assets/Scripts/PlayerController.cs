using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5.0f;
    public float turnspeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // We'll move the vehicle forward

        // using simple transform.translate(x, y, z)
        //transform.Translate(0, 0, 1);

        // now using vector3.forward
        transform.Translate(Vector3.forward * Time.deltaTime *speed);
        transform.Translate(Vector3.right * Time.deltaTime * turnspeed);
    }
}
