using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShaderControl : MonoBehaviour
{
    [SerializeField] private float dissolveProgess = 0f;
    [SerializeField] private float dissolveSpeed = 1f;
    Material myMaterial;
    //Shader myShader;
    // Start is called before the first frame update
    void Start()
    {
        myMaterial = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        myMaterial.SetFloat("dissolveProgress", dissolveProgess);

        if (Input.GetKey(KeyCode.W) && dissolveProgess < 1)
        {
            dissolveProgess += dissolveSpeed * Time.deltaTime;
        }
        else if (Input.GetKey(KeyCode.S) && dissolveProgess > -1.1f)
        {
            dissolveProgess -= dissolveSpeed * Time.deltaTime;
        }
    }
}
