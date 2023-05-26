using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bowing_pins_manager : MonoBehaviour
{
    public List<Vector3> pin_positions;
    public List<Quaternion> pin_rotations;
    public GameObject parent_pin;
    // Start is called before the first frame update
    void Start()
    {
        int child_count = 10;

        for(int i = 0; i < child_count; i++)
        {
            Vector3 itpos = parent_pin.gameObject.transform.GetChild(i).position;
            pin_positions.Add(itpos);

            Quaternion itrot = parent_pin.gameObject.transform.GetChild(i).rotation;
            pin_rotations.Add(itrot);
        }
    }


}
