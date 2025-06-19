using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody playerRigidbody;
     public float Speed = 8f;
    

    private void Start()
    {
        playerRigidbody = gameObject.GetComponent<Rigidbody>();
      
      
    }

    private void Update()
    {
        //수평축과 수직축을 float형 변수에 저장
        float xInput = Input.GetAxis("Horizontal");
        float zInput = Input.GetAxis("Vertical");
        //playerRigidbody.AddForce(xInput * Speed, 0, zInput * Speed);

        //저장된 변수를 실제 속도로 변환
        //float xSpeed = xInput * Speed;
        //float zSpeed = zInput * Speed;
        float xSpeed = Mathf.FloorToInt( xInput *  Speed );
        float zSpeed = Mathf.FloorToInt( zInput * Speed );

        float xSpeed2 = xSpeed > 0 ? Speed : 0;
        float zSpeed2 = zSpeed > 0 ? Speed : 0;


        //Vector3로 변환
        Vector3 newVelocity = new Vector3(xSpeed, 0f, zSpeed);
        playerRigidbody.linearVelocity = newVelocity;

        Debug.Log("x축 입력" + xInput);
        Debug.Log("z축 입력" +  zInput);

        /*AddForce method
        //if (Input.GetKey(KeyCode.UpArrow) == true)
        //{
        //    playerRigidbody.AddForce(0f, 0f, Speed);
        //}

        //if (Input.GetKey(KeyCode.DownArrow) == true)
        //{
        //    playerRigidbody.AddForce(0f, 0f, -Speed);
        //}

        //if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    playerRigidbody.AddForce(Speed, 0f, 0f);
        //}

        //if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    playerRigidbody.AddForce(-Speed, 0f, 0f);
        //}
        */
    }
}
