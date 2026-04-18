using UnityEngine;

public class TimelineTrigger : MonoBehaviour
{
    public GameObject timeline;
    public Transform player_pos;
    public GameObject player;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            timeline.SetActive(true);
            player.transform.position = player_pos.position;
            player.transform.rotation = player_pos.rotation;
            gameObject.SetActive(false);
        }
    }
}
