using UnityEngine;

public class PlayerFeetTrigger : MonoBehaviour
{
    public Player owner;
    float activePlatforms = 0;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Platform")
        {
            activePlatforms++;
            owner.SetGrounded(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Platform")
        {
            activePlatforms--;
            if (activePlatforms <= 0)
            {
                owner.SetGrounded(false);
            }
        }
    }

}
