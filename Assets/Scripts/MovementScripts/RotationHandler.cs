using UnityEngine;
using System.Collections;

public class RotationHandler: MovementState {
    public Vector3 movementVector;
    public float speedSides;
    public Quaternion quack;
	// Use this for initialization
	void OnEnable () {

       movementVector=new Vector3(0,0,0);
}

// Update is called once per frame
   void Update () {
        SetRotation();
        MoveSides();
    }
    void SetRotation() {
        //this.transform.rotation = Camera.main.transform.rotation;
       // this.transform.rotation = Camera.main.transform.rotation;
    quack = new Quaternion(Camera.main.transform.rotation.x
    , this.transform.rotation.x
    , this.transform.rotation.z
    , this.transform.rotation.w);

    //
    }
    void MoveSides() {

        // movementVector.y = Camera.main.transform.rotation.x * speedSides *1 * Time.deltaTime;
        movementVector.x = Camera.main.transform.localRotation.z * speedSides*-1*Time.deltaTime;
    }
    void Move2CenterFromSides(int side) {

    }
    void OnTriggerEnter(Collider other) {
    }
}
