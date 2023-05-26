using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Lunch_pad : MonoBehaviour
{
    public GameObject ball;
    public Vector3 initialPos_ball;
    public int speed;
    public TMP_Text xtext, ytext, ztext;
    public int xs, ys, zs;
    public TMP_Text speed_text;

    // Start is called before the first frame update
    void Start()
    {
        initialPos_ball = ball.transform.position;
    }

    // Update is called once per fram
    void Update()
    {
        xtext.text = xs.ToString();
        ytext.text = ys.ToString();
        ztext.text = zs.ToString();
        speed_text.text = speed.ToString();
        
    }

    // This is the function to shoot the ball
    public void Ballshoot()
    {
        Debug.Log("Ballshoot");
        ball.GetComponent<Rigidbody>().AddForce(new Vector3(xs * speed, ys * speed, zs * speed), ForceMode.Impulse);

    }

    public void IncSpeed()
    {
        speed += 1;
    }

    public void DecSpeed()
    {
        speed -= 1;
    }

    public void IncRotate(int axis)
    {
        switch (axis)
        {
            case 0:
                xs += 1;
                break;
            case 1:
                ys += 1;
                break;
            case 2:
                zs += 1;
                break;
        }
    }

    public void DecRotate(int axis)
    {
        switch (axis)
        {
            case 0:
                xs -= 1;
                break;
            case 1:
                ys -= 1;
                break;
            case 2:
                zs -= 1;
                break;
        }
    }
}
