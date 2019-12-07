using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyModel : MonoBehaviour
{
    public float destroyTimer;

    // Update is called once per frame
    void Update()
    {
        Destroy(this.gameObject, Time.deltaTime * destroyTimer);
    }
}
