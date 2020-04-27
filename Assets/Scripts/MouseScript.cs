using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseScript : MonoBehaviour
{
    // Start is called before the first frame update
    //Vector2 mouseLook;
    //Vector2 smoothV;
    //public float lookatspeed = 5.0f;
    //public float smoothing = 2.0f;

    //GameObject charactor;
    float speed = 5.0f ;
    public Transform target;

    void Start()
    {
        //charactor = this.transform.parent.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = Camera.main.transform.position;
        Vector3 target = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 1.0f));

        Vector3 direction = target-pos;

        //Quaternion rotation = Quaternion.LookRotation(direction, Vector3.up);
        //transform.rotation = rotation;
        Quaternion lookRotation = Quaternion.LookRotation(direction,Vector3.up);
        transform.rotation = Quaternion.RotateTowards(transform.rotation, lookRotation, Time.deltaTime * 10.0f);

        //var md = new Vector2(Input.GetAxisRaw("Mouse X"), Input.GetAxisRaw("Mouse Y"));

        //md = Vector2.Scale(md, new Vector2(lookatspeed * smoothing, lookatspeed * smoothing));
        //smoothV.x = Mathf.Lerp(smoothV.x, md.x, 1f / smoothing);
        //smoothV.y = Mathf.Lerp(smoothV.y, md.x, 1f / smoothing);
        //mouseLook += smoothV;

        //transform.localRotation = Quaternion.AngleAxis(-mouseLook.y, Vector3.right);
        //charactor.transform.localRotation = Quaternion.AngleAxis(mouseLook.x, charactor.transform.up);



    }
}
