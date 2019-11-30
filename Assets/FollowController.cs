using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowController : MonoBehaviour
{

    public GameObject gameobject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position=gameobject.transform.position;
        transform.rotation=gameobject.transform.rotation;
    }
}
