using UnityEngine;

public class SizeChanger : MonoBehaviour
{
    [SerializeField] private float _sizingSpeed;
    [SerializeField] private float _maxSize;

    private float inverter = -1f;
    private float minSize = 1f;

    void Update()
    {
        if (transform.localScale.x < minSize || transform.localScale.y < minSize || transform.localScale.z < minSize)
        {
            _sizingSpeed *= inverter;
        }
        else if (transform.localScale.x > _maxSize ||  transform.localScale.y > _maxSize || transform.localScale.z > _maxSize)
        {
            _sizingSpeed *= inverter;
        }

        transform.localScale += new Vector3(_sizingSpeed, _sizingSpeed, _sizingSpeed) * Time.deltaTime;
    }
}