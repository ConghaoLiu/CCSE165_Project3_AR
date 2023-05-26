using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball_Mass : MonoBehaviour
{
    public GameObject ball;
    float mass;
    public bool firstPress, secondPress;

    private void Start()
    {
        firstPress = false;
        secondPress = false;
    }

    public void Mass1()
    {
        if(firstPress == false && secondPress == false)
        {
            mass = 1f;
            firstPress = true;
        }
        else if(firstPress == true && secondPress == false)
        {
            mass = mass * 10f + 1f;
            secondPress = true;
        }

    }

    public void Mass2()
    {
        if (firstPress == false && secondPress == false)
        {
            mass = 2f;
            firstPress = true;
        }
        else if (firstPress == true && secondPress == false)
        {
            mass = mass * 10f + 2f;
            secondPress = true;
        }
    }

    public void Mass3()
    {
        if (firstPress == false && secondPress == false)
        {
            mass = 3f;
            firstPress = true;
        }
        else if (firstPress == true && secondPress == false)
        {
            mass = mass * 10f + 3f;
            secondPress = true;
        }
    }

    public void Mass4()
    {
        if (firstPress == false && secondPress == false)
        {
            mass = 4f;
            firstPress = true;
        }
        else if (firstPress == true && secondPress == false)
        {
            mass = mass * 10f + 4f;
            secondPress = true;
        }
    }

    public void Mass5()
    {
        if (firstPress == false && secondPress == false)
        {
            mass = 5f;
            firstPress = true;
        }
        else if (firstPress == true && secondPress == false)
        {
            mass = mass * 10f + 5f;
            secondPress = true;
        }
    }

    public void Mass6()
    {
        if (firstPress == false && secondPress == false)
        {
            mass = 6f;
            firstPress = true;
        }
        else if (firstPress == true && secondPress == false)
        {
            mass = mass * 10f + 6f;
            secondPress = true;
        }
    }

    public void Mass7()
    {
        if (firstPress == false && secondPress == false)
        {
            mass = 7f;
            firstPress = true;
        }
        else if (firstPress == true && secondPress == false)
        {
            mass = mass * 10f + 7f;
            secondPress = true;
        }
    }

    public void Mass8()
    {
        if (firstPress == false && secondPress == false)
        {
            mass = 8f;
            firstPress = true;
        }
        else if (firstPress == true && secondPress == false)
        {
            mass = mass * 10f + 8f;
            secondPress = true;
        }
    }

    public void Mass9()
    {
        if (firstPress == false && secondPress == false)
        {
            mass = 9f;
            firstPress = true;
        }
        else if (firstPress == true && secondPress == false)
        {
            mass = mass * 10f + 9f;
            secondPress = true;
        }
    }

    public void Mass0()
    {
        if (firstPress == false && secondPress == false)
        {
            mass = 0f;
            firstPress = true;
        }
        else if (firstPress == true && secondPress == false)
        {
            mass = mass * 10f;
            secondPress = true;
        }
    }

    public void Setballmass()
    {
        mass = mass * 0.453592f;
        ball.GetComponent<Rigidbody>().mass = mass;
        firstPress = false;
        secondPress = false;
        mass = 0.8f;
    }
}
