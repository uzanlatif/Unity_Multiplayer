using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class PlayerController : MonoBehaviour
{
    public float speed;
    public Transform obj;

    PhotonView view;

    private void Start() {
        view = GetComponent<PhotonView>();
    }

    public void Update()
    {
        if(view.IsMine){
            float h = Input.GetAxis("Horizontal");
            float v = Input.GetAxis("Vertical");

            Vector3 tempVect = new Vector3(h, v, 0);
            tempVect = tempVect.normalized * speed * Time.deltaTime;

            obj.transform.position += tempVect;
        }
        
    }
}
