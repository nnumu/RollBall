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
        _stage.transform.Rotate(horizontalInput, 0f, verticalInput);
    }
}
