using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destructable : MonoBehaviour
{
    public GameObject destroyedVersion;
  

    public void Destroy()
    {
        Instantiate(destroyedVersion, transform.position, transform.rotation);
      

        Destroy(gameObject);
    }
}
