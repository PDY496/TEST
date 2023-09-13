using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scripts : MonoBehaviour
{
    [SerializeField]
    private GameObject go_carera;
    Vector3 rotation;

    private void Start()
    {
        rotation = this.transform.eulerAngles;
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.I))
        {
            this.transform.Translate(new Vector3(0, 0, 1) * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.S))
        {
            rotation = rotation + new Vector3(-90, 0, 0) * Time.deltaTime;
            this.transform.eulerAngles = rotation; 
            Debug.Log(transform.eulerAngles);

        }

        if (Input.GetKey(KeyCode.W))
        {
            this.transform.Rotate(new Vector3(90, 0, 0) * Time.deltaTime);

        }

        if (Input.GetKey(KeyCode.A))
        {
            rotation = rotation + new Vector3(-90, 0, 0) * Time.deltaTime;
            this.transform.rotation = Quaternion.Euler(rotation );

        }

        if (Input.GetKey(KeyCode.C))
        {
            this.transform.LookAt(go_carera.transform.position);
        }

        transform.RotateAround(go_carera.transform.position, Vector3.up, 100 * Time.deltaTime);
    }
}
