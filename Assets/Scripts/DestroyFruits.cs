using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyFruits : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < -5f)
        {
            Destroy(this.gameObject);
        }
    }
}
