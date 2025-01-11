using UnityEngine;

public class Move_v2 : MonoBehaviour
{
    [SerializeField] private float _xAxisSpeed;
    [SerializeField] private float _yAxisSpeed;
    [SerializeField] private float _zAxisSpeed;

    void Update()
    {
        transform.position += transform.forward * _zAxisSpeed * Time.deltaTime;
        transform.position += transform.up * _yAxisSpeed * Time.deltaTime;
        transform.position += transform.right * _xAxisSpeed * Time.deltaTime;
    }
}
