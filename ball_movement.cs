using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // private variables
    private float speed = 10.0f;
    private float turnSpeed = 30.0f;
    private float horizontalInput;
    private float forwardInput;
    private List<transform> _segements;

    public transform _segementPrefab;
    // Start is called before the first frame update
    void Start()
    {
        _segements = new List<transform>();
        _segements.Add(this.transform);
    }

    // Update is called once per frame
    void Update()
    {
        //Moving from the last segment to player for fluid motion
        for (int i = _segements.count - 1; i > 0; i--){
            _segements[i].position = _segements[i-1].position;
        }
        // using unity's in-built input controls for movement instead of specifying keys induvidually
        horizontalInput = Input.GetAxis("Horizontal");
        forwardInput = Input.GetAxis("Vertical");
        // we move the spheres forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // we rotate the spheres to turn
        transform.Rotate(Vector3.up* Time.deltaTime * turnSpeed * horizontalInput);
    }
    void Grow()
    {
        //Adding new segments to player when going through power-ups
        Instantiate(this._segementPrefab);
        segment.position = _segements[_segements.count - 1].position;
        _segements.Add(segment);

    }
}
