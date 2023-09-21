using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForceMove : MonoBehaviour
{

    Rigidbody2D myBody;

    float armPower = 200f;

    SoundManager mySoundManager;

    // Start is called before the first frame update
    void Start()
    {
        myBody = GetComponent<Rigidbody2D>();
        mySoundManager = GetComponent<SoundManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {


            myBody.AddForce(transform.up * armPower, ForceMode2D.Impulse);
            mySoundManager.myAudioSource.PlayOneShot(mySoundManager.song);
        }
    }
}
