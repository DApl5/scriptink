using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Going : MonoBehaviour
{
    public Vector3 newPosition = gameObject.transform.position;
    float speed = 1.55f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        newPosition.z += speed * Time.deltaTime;
        transform.position = newPosition;
    }
}
