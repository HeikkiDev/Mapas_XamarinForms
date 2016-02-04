package md526b7ac14cffc1a788e82c7b73f3add08;


public class ResultCallback_1
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.google.android.gms.common.api.ResultCallback
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onResult:(Lcom/google/android/gms/common/api/Result;)V:GetOnResult_Lcom_google_android_gms_common_api_Result_Handler:Android.Gms.Common.Apis.IResultCallbackInvoker, Xamarin.GooglePlayServices.Base\n" +
			"";
		mono.android.Runtime.register ("Android.Gms.Common.Apis.ResultCallback`1, Xamarin.GooglePlayServices.Base, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ResultCallback_1.class, __md_methods);
	}


	public ResultCallback_1 () throws java.lang.Throwable
	{
		super ();
		if (getClass () == ResultCallback_1.class)
			mono.android.TypeManager.Activate ("Android.Gms.Common.Apis.ResultCallback`1, Xamarin.GooglePlayServices.Base, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onResult (com.google.android.gms.common.api.Result p0)
	{
		n_onResult (p0);
	}

	private native void n_onResult (com.google.android.gms.common.api.Result p0);

	java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
