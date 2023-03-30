using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaneMovement : MonoBehaviour
{
    [SerializeField] float bpm;
    float ySpeed;
    // Start is called before the first frame update
    void Start()
    {
        ySpeed = -bpm/60f;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(0, ySpeed*Time.deltaTime,0);
    }
}
