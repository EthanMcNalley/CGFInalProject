using UnityEngine;

public class Shoot : MonoBehaviour
{
    public GameObject bullet;
    public GameObject wave_bullet;
    public GameObject ice_bullet;
    public GameObject plasma_bullet;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (SwitchBeams.beam_type == SwitchBeams.BeamType.POWER)
            {
                Instantiate(bullet, transform.position, transform.rotation);
            }

            else if (SwitchBeams.beam_type == SwitchBeams.BeamType.WAVE)
            {
                 Instantiate(wave_bullet, transform.position, transform.rotation);
            }

            else if (SwitchBeams.beam_type == SwitchBeams.BeamType.ICE)
            {
                 Instantiate(ice_bullet, transform.position, transform.rotation);
            }

            else if (SwitchBeams.beam_type == SwitchBeams.BeamType.PLASMA)
            {
                 Instantiate(plasma_bullet, transform.position, transform.rotation);
            }
        }
    }
}
