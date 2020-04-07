# Unity Sign in with Apple

This feature is Sign in with Apple for unity.

## 1. 

We need to import Sign in with Apple from Asset store.

## 2.

Import UnityEngine.SignInWithApple and add component with SignInWithApple

```
using UnityEngine.SignInWithApple;

	private void Start()
	{
		gameObject.AddComponent<SignInWithApple>();
	}
```

## 3.

Use SignInWithApple to sign in.

And Get user info with callback methods.

```
	private void BtnLoginEvent()
	{
		SignInWithApple signIn = GetComponent<SignInWithApple>();
		signIn.Login(Callback);
	}

	private void Callback(SignInWithApple.CallbackArgs args)
	{
		Debug.Log("This is your id:" + args.userInfo.userId);
	}
```