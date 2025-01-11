using UnityEngine;

public class Move : MonoBehaviour
{
    [SerializeField] private float _xAxisSpeed;
    [SerializeField] private float _yAxisSpeed;
    [SerializeField] private float _zAxisSpeed;

    void Update()
    {
        transform.position += new Vector3(_xAxisSpeed, _yAxisSpeed, _zAxisSpeed) * Time.deltaTime;
    }
}
