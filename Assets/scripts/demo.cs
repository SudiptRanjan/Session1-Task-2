using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Traj : MonoBehaviour
{
    public float speed;
    public Transform target;
    public float arcHeight;
    public Transform _startPosition;
    float _stepScale;
    float _progress;
    //float _stepSize;
    // Start is called before the first frame update
    void Start()
    {
        //_startPosition = transform.position;
        float distance =Vector3.Distance(_startPosition.position,target.position);
        _stepScale = speed / distance;
    }

    // Update is called once per frame
    void Update()
    {
        _progress = Mathf.Min(_progress + Time.deltaTime * _stepScale, 1.0f);
        float parabola = 1.0f - 4.0f * (_progress - 0.5f) * (_progress - 0.5f);
        Vector3 nextPos = Vector3.Lerp(_startPosition.position, target.position, _progress);
        nextPos.y += parabola * arcHeight;
        transform.LookAt(nextPos, transform.forward);
        //if (_progress == 1.0f)
        //    Arrived();

    }

    //private void Arrived()
    //{
    //    throw new NotImplementedException();
    //}
}
