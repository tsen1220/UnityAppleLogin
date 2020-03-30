using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SignInWithApple;
using UnityEngine.UI;

public class AppleLogin : MonoBehaviour
{
	public Button btnAppleLogin;

	private void Start()
	{
		btnAppleLogin.onClick.AddListener(BtnLoginEvent);
		gameObject.AddComponent<SignInWithApple>();
	}

	private void BtnLoginEvent()
	{
		SignInWithApple signIn = GetComponent<SignInWithApple>();
		signIn.Login(Callback);
	}

	private void Callback(SignInWithApple.CallbackArgs args)
	{
		Debug.Log("This is your id:" + args.userInfo.userId);
	}
}
