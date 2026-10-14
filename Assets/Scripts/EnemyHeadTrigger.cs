using UnityEngine;

public class EnemyHeadTrigger : MonoBehaviour
{
    public StupidEnemy owner;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            owner.Die();
        }
    }

}
