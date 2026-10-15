using UnityEngine;
using UnityEngine.InputSystem;

public class StageMove : MonoBehaviour
{
    // プレイヤーの入力(WASD、矢印キー)が入力されたらStageを回転させる
    private InputAction _playerInput;

    // 回転させたい対象のオブジェクト
    [SerializeField]
    private GameObject _stage;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        _playerInput = InputSystem.actions.FindAction("Move");
    }

    // Update is called once per frame
    void Update()
    {

        // Stageを回転させる処理
        // 水平(horizontal)入力の取得
        float horizontalInput = _playerInput.ReadValue<Vector2>().x * 0.2f;
        // 垂直(vertical)入力の取得
        float verticalInput = _playerInput.ReadValue<Vector2>().y * 0.2f;

        // オブジェクトを回転させる
        // _stage.transform.Rotate(horizontalInput,*0.2f,0f,verticalInput*0.2f);
        // Vector2の入力をVector3に変換
        Vector3 rotation = new Vector3(horizontalInput,0f,verticalInput);

        // オイラー角に変換
        Quaternion tilt = Quaternion.Euler(rotation.x, 0f, rotation.z);

        // 変換した値をRigidbodyに渡す
        _stage.GetComponent<Rigidbody>().MoveRotation(_stage.GetComponent<Rigidbody>().transform.rotation * tilt);
    }
}
