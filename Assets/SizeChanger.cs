using UnityEngine;

public class SizeChanger : MonoBehaviour
{
    [SerializeField] private float _sizingSpeed;
    [SerializeField] private float _maxSize;

    private float _inverter = -1f;
    private float _minSize = 1f;

    private void Update()
    {
        if (transform.localScale.x < _minSize || transform.localScale.y < _minSize || transform.localScale.z < _minSize ||
            transform.localScale.x > _maxSize || transform.localScale.y > _maxSize || transform.localScale.z > _maxSize)
        {
            _sizingSpeed *= _inverter;
        }

        transform.localScale += new Vector3(_sizingSpeed, _sizingSpeed, _sizingSpeed) * Time.deltaTime;
    }
}