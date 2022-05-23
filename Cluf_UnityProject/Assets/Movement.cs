using UnityEngine;

public class Movement : MonoBehaviour
{
    public Vector2 startVelocity = Vector3.zero;
    public float gain = 1f;
    public float period = 1f;

    private Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Start()
    {
        rb.velocity = startVelocity;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        float accel;

        accel = CalculateAcceleration();
        
        rb.AddForce(rb.mass * accel * Vector2.up);
    }

    float CalculateAcceleration()
    {
        float acceleration = 0f;

        //-------YOUR CODE GOES HERE-------
        //Examples:
        //acceleration = gain;
        //acceleration = gain * Mathf.Sin(Time.time / period * Mathf.PI * 2f);
        //acceleration = gain * Mathf.Sign( Mathf.Sin(Time.time / period * Mathf.PI * 2f) );

        acceleration = gain;

        //-------END OF YOUR CODE-------

        return acceleration;
    }
}
