using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BE_CardFaceUser : MonoBehaviour
{
    [SerializeField]
    private Transform target;

    // Update is called once per frame
    void Update()
    {
        LookAt();   
    }

    public void LookAt()
    {

        transform.LookAt(target);
    }
}
