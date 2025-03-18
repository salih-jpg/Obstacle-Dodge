using System.Threading;
using UnityEngine;
using UnityEngine.InputSystem;

public class Drop : MonoBehaviour
{
    [SerializeField] float timeToWait = 3f;
    MeshRenderer meshRenderer;
    new Rigidbody rigidbody;
    private void Start() {
        meshRenderer = GetComponent<MeshRenderer>();
        rigidbody = GetComponent<Rigidbody>();
        rigidbody.useGravity = false;
        rigidbody.isKinematic = true;
        meshRenderer.enabled = false;
    }
    
    public void Update  (){
       
       if(Time.time > timeToWait){
            meshRenderer.enabled = true;
            rigidbody.useGravity = true;
            rigidbody.isKinematic = false;
       }
    }
}
