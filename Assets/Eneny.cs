using UnityEngine;

public class Eneny : MonoBehaviour
{
    public Animator animator;
    public int health = 10;
    public GameObject death_burst;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            animator.SetTrigger("Damage");
            health -= 1;

            if (health < 1)
            {
                Instantiate(death_burst, new Vector3(transform.position.x, transform.position.y + 2, transform.position.z), Quaternion.identity);
                Destroy(gameObject);
            }
        }
    }
}
