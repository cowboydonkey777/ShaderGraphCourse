using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DissolveTrigger : MonoBehaviour
{
    public SkinnedMeshRenderer mr;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            mr.material.SetFloat("Vector1_075ef254fe25404b9524abc469c4e99a", Time.time);
        }
    }
}
