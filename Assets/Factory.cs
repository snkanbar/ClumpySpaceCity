using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Factory : MonoBehaviour
{
    public GameObject Prefab;

    public GameObject Target;

    public float MakeRate = 2.0f;

    private float _lastMake = 0;

    // Start is called before the first frame update
    private void Start()
    {
        GameObject go = Instantiate(Prefab, this.transform.position, Quaternion.identity);
        MobileUnit mu = go.GetComponent<MobileUnit>();
        mu.Target = Target;
    }

    // Update is called once per frame
    private void Update()
    {
        _lastMake += Time.deltaTime; //_lastMake = _lastMake + Time.deltaTime;
        if (_lastMake > MakeRate)
        {
            Debug.Log("Make");
            _lastMake = 0;

            GameObject go = Instantiate(Prefab, this.transform.position, Quaternion.identity);
            MobileUnit mu = go.GetComponent<MobileUnit>();
            mu.Target = Target;
        }
    }
}