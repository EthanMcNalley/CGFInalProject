using System;
using System.Collections.Generic;
using UnityEngine;

public class SwitchBeams : MonoBehaviour
{
    public Animator animator;
    public MeshRenderer mesh_renderer;
    public Material new_material;
    public Material power_material;
    public Material wave_material;
    public Material ice_material;
    public Material plasma_material;
    public enum BeamType
    {
        POWER,
        WAVE,
        ICE,
        PLASMA
    }
    public static BeamType beam_type = BeamType.POWER;

    void Start()
    {
        beam_type = BeamType.POWER;
        new_material = power_material;
    }
    // Update is called once per frame
    void Update()
    {
        //Up Key
        if (Input.GetKeyDown(KeyCode.I))
        {
            beam_type = BeamType.POWER;
            new_material = power_material;
            animator.SetTrigger("BeamSwitch");
        }

        else if (Input.GetKeyDown(KeyCode.K))
        {
            beam_type = BeamType.WAVE;
            new_material = wave_material;
            animator.SetTrigger("BeamSwitch");
        }

        else if (Input.GetKeyDown(KeyCode.J))
        {
            beam_type = BeamType.ICE;
            new_material = ice_material;
            animator.SetTrigger("BeamSwitch");
        }

        else if (Input.GetKeyDown(KeyCode.L))
        {
            beam_type = BeamType.PLASMA;
            new_material = plasma_material;
            animator.SetTrigger("BeamSwitch");
        }
    }

    public void BeamSwitch()
    {
        Material[] materials = mesh_renderer.materials;

        materials[3] = new_material;
        materials[2] = new_material;

        mesh_renderer.materials = materials;
    }
}
