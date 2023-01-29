using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lever: MonoBehaviour
{
    public float maxIntensity = 2;
    public HingeJoint hinge;
    public Light[] lamps;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float hingeMin = hinge.limits.min;
        float hingeMax = hinge.limits.max;
        int current = (int)hinge.angle;
        JointSpring spring = hinge.spring;

        float OldRange = (hingeMax - hingeMin);
        float NewRange = (maxIntensity - 0);
        float intensity = (((current - hingeMin) * NewRange) / OldRange) + 0;

        if (current > 40)
        {
            spring.targetPosition = 50;
            hinge.spring = spring;

        } else if (current < -40)
        {
            spring.targetPosition = -50;
            hinge.spring = spring;
        }

        foreach (Light lamp in lamps)
        {
            lamp.intensity = intensity;
        }
    }
}
