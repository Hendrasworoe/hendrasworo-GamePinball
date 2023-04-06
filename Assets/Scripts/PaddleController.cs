using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaddleController : MonoBehaviour
{
    public KeyCode input;
    // public float springPower;

    private float targetPressed;
    private float targetRelease;

    private HingeJoint hinge;

    private void Start()
    {
        hinge = GetComponent<HingeJoint>();

        targetPressed = hinge.limits.max;
        targetRelease = hinge.limits.min;
    }

    private void Update()
    {
        ReadInput();
        MovePaddle();
    }

    private void ReadInput()
    {
        JointSpring jointSpring = hinge.spring;

        if (Input.GetKey(input))
        {
            // jointSpring.spring = springPower;
            jointSpring.targetPosition = targetPressed;
        }
        else
        {
            // jointSpring.spring = 0;
            jointSpring.targetPosition = targetRelease;
        }

        hinge.spring = jointSpring;
    }

    private void MovePaddle()
    {
        // Move Paddle Here
    }
}
