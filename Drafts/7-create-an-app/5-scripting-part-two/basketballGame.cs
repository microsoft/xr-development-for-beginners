using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class basketballGame : MonoBehaviour
{

    public Transform Ball;
    public Transform OverheadPos;
    public Transform Target;
    public Transform HoldPos;

    //Variables
    public float MoveSpeed = 5;
    //Our game will start with the ball in the character's hand, thus the assigned value is true.
    private bool BallInHands = true;
    private bool isBallFlying = false;
    private float T = 0;


    // Update is called once per frame
    void Update()
    {
        //Movement Section

        //Creating a direction vector based on the input axes.
        Vector3 direction = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        //Change the position transform by the direction vector times the defined movement speed and the time.
        transform.position += direction * MoveSpeed * Time.deltaTime;
        //Make the character look towards the vector's direction.
        transform.LookAt(transform.position + direction);

        //Shooting Section

        //First conditional, whether the ball is in the character hands.
        if (BallInHands)
        {
            //If it is, we will define the space key as the key to hold the ball over the character's head.
            if (Input.GetKey(KeyCode.Space))
            {
                //Once the space key is pressed, change the ball's position to the Overhead position.
                Ball.position = OverheadPos.position;
                //And make the character look at the target point (as if it is aiming)
                transform.LookAt(Target.parent.position);
            }

            //If the space key is not pressed, the ball is held at the HoldPos point.
            else
            {
                Ball.position = HoldPos.position;
            }
            //If the Space key is lifted
            if (Input.GetKeyUp(KeyCode.Space))
            {
                //For the ball to be shot, it must leave the character hands, so we make the boolean variable false.
                BallInHands = false;
                //To begin shooting, we change the boolean flying to true (as the ball starts flying from the hands)
                isBallFlying = true;
                //And restart the time (so that the new series of events can be easily written)
                T = 0;
            }
        }

        if (isBallFlying)
        {
            //Time variable is assigned a new value based on the time the event starts
            T += Time.deltaTime;
            //duration of travel
            float duration = 0.5f;
            //t01 variable will be used to create an arc, no need to worry about the details for now.
            float t01 = T / duration;

            Vector3 point_A = OverheadPos.position;
            Vector3 point_B = Target.position;
            //Lerp is the linear interpolation function, will result in a new vector that will represent the trajectory from A to B.
            Vector3 pos = Vector3.Lerp(point_A, point_B, t01);

            //Arc created using sine function
            Vector3 arc = Vector3.up * 5 * Mathf.Sin(t01 * 3.14f);
            //Moves the ball in an arc function 
            Ball.position = pos + arc;

            if (t01 >= 1)
            {
                isBallFlying = false;
                Ball.GetComponent<Rigidbody>().isKinematic = false;
            }
        }

    }

    //when the collision trigger happens, this method is executed.
    private void OnTriggerEnter(Collider other)
    {
        //Conditional: If the ball isn't flying or has not been picked up yet, pick up the ball and activate its Rigidbody component's kinematics.
        if (!BallInHands && !isBallFlying)
        {
            BallInHands = true;
            Ball.GetComponent<Rigidbody>().isKinematic = true;
        }
    }
}