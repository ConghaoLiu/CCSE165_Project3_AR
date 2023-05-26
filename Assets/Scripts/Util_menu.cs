using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QCHT.Interactions.Distal.ControlBox;

public class Util_menu : MonoBehaviour
{
    public Lunch_pad pad;
    public GameObject ball;
    public GameObject rails;
    public Bowing_pins_manager pin_list;
    public GameObject pin_parent;
    public GameObject bowling;
    public List<Vector3> pin_positions;
    public List<Quaternion> pin_rotations;
    private Vector3 initialPos_ball;

    // Start is called before the first frame update

    public void ResetBall()
    {
        ball.transform.position = initialPos_ball;
        ball.GetComponent<Rigidbody>().velocity = Vector3.zero;
        ball.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        ball.GetComponent<Rigidbody>().mass = 0.8f;
        pad.xs = 0;
        pad.ys = 0;
        pad.zs = 0;
        pad.speed = 0;

        int child_count = 10;
        for (int i = 0; i < child_count; i++)
        {
            pin_parent.gameObject.transform.GetChild(i).rotation = pin_rotations[i];
            pin_parent.gameObject.transform.GetChild(i).position = pin_positions[i];
            pin_parent.gameObject.transform.GetChild(i).GetComponent<Rigidbody>().velocity = Vector3.zero;
            pin_parent.gameObject.transform.GetChild(i).GetComponent<Rigidbody>().angularVelocity = Vector3.zero;


        }
    }

    public void Game()
    {
        initialPos_ball = ball.transform.position;
        ball.gameObject.AddComponent<Rigidbody>();
        ball.gameObject.transform.GetComponent<Rigidbody>().mass = 0.8f;
        ball.gameObject.transform.GetComponent<Rigidbody>().useGravity = true;
        ball.GetComponent<Rigidbody>().velocity = Vector3.zero;
        ball.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        int child_count = 10;
        for (int i = 0; i < child_count; i++)
        {
            Transform child_transform = pin_parent.gameObject.transform.GetChild(i);
            child_transform.gameObject.AddComponent<Rigidbody>();
            pin_parent.gameObject.transform.GetChild(i).GetComponent<Rigidbody>().mass = 0.2f;
            pin_parent.gameObject.transform.GetChild(i).GetComponent<Rigidbody>().useGravity = true;

            Vector3 itpos = pin_parent.gameObject.transform.GetChild(i).position;
            pin_positions.Add(itpos);

            Quaternion itrot = pin_parent.gameObject.transform.GetChild(i).rotation;
            pin_rotations.Add(itrot);
        }

        bowling.GetComponent<QCHTControlBox>().enabled = false;
    }

    public void ToggleOn()
    {
        rails.SetActive(true);
    }

    public void ToggleOff()
    {
        rails.SetActive(false);
    }

    public void ChangeMass()
    {

    }
}
