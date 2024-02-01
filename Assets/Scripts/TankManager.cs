using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class TankManager : MonoBehaviour {
    // 値の初期化
    public class keyboards {
        public static KeyCode W = KeyCode.W;
        public static KeyCode A = KeyCode.A;
        public static KeyCode S = KeyCode.S;
        public static KeyCode D = KeyCode.D;
        public static KeyCode up = KeyCode.UpArrow;
        public static KeyCode down = KeyCode.DownArrow;
        public static KeyCode left = KeyCode.LeftArrow;
        public static KeyCode right = KeyCode.RightArrow;
    }

    private float bodyVertical = 0; // 縦
    private float bodyHorizontal = 0; // 横
    private float turretVertical = 0; // 縦
    private float turretHorizontal = 0; // 横

    void Start() {
        // ...
    }

    void Update() {
        // 左回転
        if (Input.GetKey(keyboards.A)) {
            this.transform.eulerAngles = new Vector3(
                this.transform.eulerAngles.x,
                this.transform.eulerAngles.y - 0.5F,
                this.transform.eulerAngles.z
            );
            
            // 現在の角度を取得し書き込む
            bodyHorizontal = this.transform.localEulerAngles.y; // 横の角度を取得し書き込む
        }

        // 右回転
        if (Input.GetKey(keyboards.D)) {
            this.transform.eulerAngles = new Vector3(
                this.transform.eulerAngles.x,
                this.transform.eulerAngles.y + 0.5F,
                this.transform.eulerAngles.z
            );
            
            // 現在の角度を取得し書き込む
            bodyHorizontal = this.transform.localEulerAngles.y; // 横の角度を取得し書き込む
        }

        // 移動処理 - 左右に回転した際の数値で正面方向を決定 "transform.forward" を使うと正面方向を取得できる
        if (Input.GetKey(keyboards.W)) {
            this.transform.position += new Vector3(
                this.transform.forward.x * 0.025F,
                0.0F,
                this.transform.forward.z * 0.025F
            );
        }
        if (Input.GetKey(keyboards.S)) {
            this.transform.position -= new Vector3(
                this.transform.forward.x * 0.025F,
                0.0F,
                this.transform.forward.z * 0.025F)
            ;
        }
    }
}
