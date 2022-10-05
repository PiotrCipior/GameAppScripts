using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SPlayerMovement : MonoBehaviour {

	public SCharacterController2D controller;
	public Animator animator;

	public float runSpeed = 40f;

	float horizontalMove = 0f;
	bool jump = false;
	private Rigidbody2D m_Rigidbody2D;
	private int i = 1;
	private Vector3 startscale = new Vector3(0.4f, 0.4f, 0.0f);
	private Vector3 scaleChange;
	private Vector3 positionChange = new Vector3(0.0f, 1.0f, 0.0f);

	//private static bool m_CanGrowSmall2;
	//private static bool m_CanGrowMedium2;

	void Start ()
	{
		//m_Rigidbody2D.transform.localScale += startscale;
	}

	private void Awake()
	{
		m_Rigidbody2D = GetComponent<Rigidbody2D>();
	}

	// Update is called once per frame
	void Update () 
	{
		
		animator.SetFloat("Speed", Mathf.Abs(horizontalMove));
		

		horizontalMove = Input.GetAxisRaw("Horizontal2") * runSpeed;

		if (Input.GetButtonDown("Jump2"))
		{
			jump = true;
			animator.SetBool("jump", true);
		}

		if (Input.GetButtonDown("Resize2"))
		{
			if (i>=1 && i<3)
				{
					if (m_Rigidbody2D.transform.localScale.x>0)
					{
						scaleChange = new Vector3(0.2f, 0.2f, 0.0f);
					}
					else
					{
						scaleChange = new Vector3(-0.2f, 0.2f, 0.0f);
					}
					m_Rigidbody2D.transform.position += positionChange;
					m_Rigidbody2D.transform.localScale += scaleChange;
					i++;
				}
		}
		if (Input.GetButtonDown("Resize"))
		{
			if (i>1 && i<=3)
            {
                if (m_Rigidbody2D.transform.localScale.x>0)
                {
                    scaleChange = new Vector3(-0.2f, -0.2f, 0.0f);
                }
                else
                {
                    scaleChange = new Vector3(0.2f, -0.2f, 0.0f);
                }
				m_Rigidbody2D.transform.position -= positionChange;
                m_Rigidbody2D.transform.localScale += scaleChange;
                i--;
            }
		}

	}

	public void OnLanding ()
	{
		animator.SetBool("jump", false);
	}


	void FixedUpdate ()
	{
		// Move our character
		controller.Move(horizontalMove * Time.fixedDeltaTime, jump);
		jump = false;
	}
}
