using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaderAnimator : MonoBehaviour
{
    Material material;
    void Start()
    {
        material = GetComponent<MeshRenderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        material.SetFloat("T", Time.timeSinceLevelLoad);
    }
}
