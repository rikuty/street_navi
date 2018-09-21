using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MazePlayerController : MonoBehaviour {

    bool isMoving = false;

    Context context;

	// Use this for initialization
	void Start () {
		
	}

    public void Init(Context context)
    {
        this.context = context;
    }

    // Update is called once per frame
    void Update () {
        if (context == null) return;

        //// Up方向
        //Debug.Log(OVRInput.Get(OVRInput.Button.Up));

        //// Down方向
        //Debug.Log(OVRInput.Get(OVRInput.Button.Down));

        //// Left方向
        //Debug.Log(OVRInput.Get(OVRInput.Button.Left));

        //// Right方向
        //Debug.Log(OVRInput.Get(OVRInput.Button.Right));

        if (this.isMoving == true) return;

        if(OVRInput.Get(OVRInput.Button.Up)){
            this.isMoving = true;
            iTween.MoveTo(this.gameObject,this.context.GetNextPoint(),0.5f);
            StartCoroutine(this.Wait());
       }else if(OVRInput.Get(OVRInput.Button.Down)){
            
        }else if(OVRInput.Get(OVRInput.Button.Left)){
            this.isMoving = true;
            iTween.RotateAdd(this.gameObject, new Vector3(0, -90, 0), 0.5f);
            this.context.SetTurnPoint(-1);
            StartCoroutine(this.Wait());
        }else if(OVRInput.Get(OVRInput.Button.Right)){
            this.isMoving = true;
            iTween.RotateAdd(this.gameObject, new Vector3(0, 90, 0), 0.5f);
            this.context.SetTurnPoint(1);
            StartCoroutine(this.Wait());
        }


        if (Input.GetKeyDown(KeyCode.W))
        {
            this.isMoving = true;
            //this.transform.localPosition = this.context.GetNextPoint();
            iTween.MoveTo(this.gameObject, this.context.GetNextPoint(), 0.5f);
            StartCoroutine(this.Wait());
        }
        else if (Input.GetKeyDown(KeyCode.X))
        {

        }
        else if (Input.GetKeyDown(KeyCode.A)){

            this.isMoving = true;
            //this.transform.Rotate(new Vector3(0, -90, 0));
            iTween.RotateAdd(this.gameObject, new Vector3(0, -90, 0), 1f);
            this.context.SetTurnPoint(-1);
            StartCoroutine(this.Wait());
       }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            this.isMoving = true;
            //this.transform.Rotate(new Vector3(0, 90, 0));
            iTween.RotateAdd(this.gameObject, new Vector3(0, 90, 0), 1f);
            this.context.SetTurnPoint(1);
            StartCoroutine(this.Wait());

        }
	}

    IEnumerator Wait(){
        yield return new WaitForSeconds (0.5f);
        this.isMoving = false;
    }
}
