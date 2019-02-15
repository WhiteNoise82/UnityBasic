using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    Vector3 rotation;
    // Start is called before the first frame update
    void Start()
    {
        rotation = this.transform.eulerAngles;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            //this.transform.position = this.transform.position + new Vector3(0, 0, 1) * Time.deltaTime;
            this.transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            //this.transform.position = this.transform.position + new Vector3(0, 0, 1) * Time.deltaTime;
            this.transform.Translate(new Vector3(0, 0, -1) * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            //this.transform.position = this.transform.position + new Vector3(0, 0, 1) * Time.deltaTime;
            this.transform.Translate(new Vector3(-1, 0, 0) * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            //this.transform.position = this.transform.position + new Vector3(0, 0, 1) * Time.deltaTime;
            this.transform.Translate(new Vector3(1, 0, 0) * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.UpArrow))
        {
            //rotation += new Vector3(90, 0, 0) * Time.deltaTime;
            //this.transform.eulerAngles = rotation;

            //this.transform.Rotate(new Vector3(90, 0, 0) * Time.deltaTime);

            rotation += new Vector3(90, 0, 0) * Time.deltaTime;
            this.transform.rotation = Quaternion.Euler(rotation);

            //Debug.Log(transform.eulerAngles);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            //rotation += new Vector3(90, 0, 0) * Time.deltaTime;
            //this.transform.eulerAngles = rotation;

            //this.transform.Rotate(new Vector3(-90, 0, 0) * Time.deltaTime);

            rotation += new Vector3(-90, 0, 0) * Time.deltaTime;
            this.transform.rotation = Quaternion.Euler(rotation);

            //Debug.Log(transform.eulerAngles);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            //rotation += new Vector3(90, 0, 0) * Time.deltaTime;
            //this.transform.eulerAngles = rotation;

            //this.transform.Rotate(new Vector3(0, -90, 0) * Time.deltaTime);

            rotation += new Vector3(0, -90, 0) * Time.deltaTime;
            this.transform.rotation = Quaternion.Euler(rotation);

            //Debug.Log(transform.eulerAngles);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            //rotation += new Vector3(90, 0, 0) * Time.deltaTime;
            //this.transform.eulerAngles = rotation;

            //this.transform.Rotate(new Vector3(0, 90, 0) * Time.deltaTime);

            rotation += new Vector3(0, 90, 0) * Time.deltaTime;
            this.transform.rotation = Quaternion.Euler(rotation);

            //Debug.Log(transform.eulerAngles);
        }
    }
}
