using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        //this.transform.position.Set(this.transform.position.x, 0, this.transform.position.z);
        this.gameObject.transform.GetChild(2).gameObject.SetActive(true);
        
    }
}
