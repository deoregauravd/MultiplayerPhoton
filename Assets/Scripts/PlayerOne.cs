using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using Photon.Realtime;

public class PlayerOne : MonoBehaviourPunCallbacks

{
    PhotonView view;
    float rotSpeed = 20;

    private void Start()
    {
        view = GetComponent<PhotonView>();
    }

    public void GetUsername()
    {
        PhotonNetwork.NickName = "PlayerOne";
        gameObject.SetActive(true);

    }
    private void OnMouseDrag()
    {
      if (view.IsMine)
        {
            float rotX = Input.GetAxis("Mouse X") * rotSpeed * Mathf.Deg2Rad;
            float rotY = Input.GetAxis("Mouse Y") * rotSpeed * Mathf.Deg2Rad;

            transform.RotateAround(Vector3.up, -rotX);
            transform.RotateAround(Vector3.right, -rotY);
        }
    }
}