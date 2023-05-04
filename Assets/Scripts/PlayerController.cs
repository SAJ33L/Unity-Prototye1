using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //public variable for speed
    //public float speed = 5.0f;
    //public variable for turning speed
    //public float turnSpeed;
    //using a public variable to get horizontal-axis
    //public float horizontalInput;
    //using a public variable to get vertical-axis
    //public float forwardInput;

    //making all the inputs private
    private float speed = 20.0f;
    private float turnSpeed = 5.0f;
    private float horizontalInput;
    private float forwardInput;

    //Start is called before the first frame update
    void Start()
    {
        
    }

    //Update is called once per frame
    void Update()
    {
        //We'll move the vehicle forward
        //using simple transform.translate(x, y, z)
        //transform.Translate(0, 0, 1);
        //now using vector3.forward to move the vehicle at the change in frame persecond
        //transform.Translate(Vector3.forward * Time.deltaTime *speed);
        //now using vector3.forward to move the vehicle right or left
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed);

        //getting the horizontal axis from predefined horizontal keys in unity
        horizontalInput = Input.GetAxis("Horizontal");
        //now using vector3.right to move the vehicle right or left
        //transform.Translate(Vector3.right * Time.deltaTime * turnSpeed * horizontalInput);
        //using transform.rotated instead
        transform.Rotate(Vector3.up, turnSpeed * horizontalInput);
        //getting the horizontal axis from predefined vertical keys in unity
        forwardInput = Input.GetAxis("Vertical");
        //now using vector3.forward to move the vehicle forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);

    }
}
