using UnityEngine;
using System.Collections;

public class fire11 : MonoBehaviour {

    public int dousen=0;
    //int length=0;
    //float length =transform.localScale.y;

        // Use this for initialization;
    void Start () {



    }

    // Update is called once per frame
    void Update () {
        if (dousen == 1) {
            transform.localScale += new Vector3 (0, -0.15f * Time.deltaTime, 0);
        }
        if (dousen == 0) {
            transform.localScale = transform.localScale;
        }
        //transform.localScale += new Vector3(0, -0.15f*Time.deltaTime, 0);



    }

    public void StartFire(){
        dousen = 1;

    }
    public void Safe(){
        dousen = 0;
    }
}
