using Unity.VisualScripting;
using UnityEngine;

public class StupidEnemy : MonoBehaviour
{
    public float minX = 0;
    public float maxX = 4;

    public float speedX = 2;
    public Rigidbody2D body2D;

    float currentSpeed = 0;

    private void Start()
    {
        currentSpeed = speedX;
    }

    private void Update()
    {
        if (currentSpeed > 0 && transform.position.x > maxX)
        {
            currentSpeed = -speedX;
        }
        else if(currentSpeed < 0 && transform.position.x < minX)
        {
            currentSpeed = speedX;
        }
    }

    public void FixedUpdate()
    {   
        body2D.linearVelocityX = currentSpeed;
    }

    public void Die()
    {
        Destroy(gameObject);
    }

}
