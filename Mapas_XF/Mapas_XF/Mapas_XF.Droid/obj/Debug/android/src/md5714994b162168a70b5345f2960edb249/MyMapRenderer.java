package md5714994b162168a70b5345f2960edb249;


public class MyMapRenderer
	extends md5d956392b2b421ac2c9ccfc063253dcd9.MapRenderer
	implements
		mono.android.IGCUserPeer,
		com.google.android.gms.maps.OnMapReadyCallback
{
	static final String __md_methods;
	static {
		__md_methods = 
			"n_onMapReady:(Lcom/google/android/gms/maps/GoogleMap;)V:GetOnMapReady_Lcom_google_android_gms_maps_GoogleMap_Handler:Android.Gms.Maps.IOnMapReadyCallbackInvoker, Xamarin.GooglePlayServices.Maps\n" +
			"";
		mono.android.Runtime.register ("Mapas_XF.Android.CustomRenderers.MyMapRenderer, Mapas_XF.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", MyMapRenderer.class, __md_methods);
	}


	public MyMapRenderer (android.content.Context p0) throws java.lang.Throwable
	{
		super (p0);
		if (getClass () == MyMapRenderer.class)
			mono.android.TypeManager.Activate ("Mapas_XF.Android.CustomRenderers.MyMapRenderer, Mapas_XF.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0 });
	}


	public MyMapRenderer (android.content.Context p0, android.util.AttributeSet p1) throws java.lang.Throwable
	{
		super (p0, p1);
		if (getClass () == MyMapRenderer.class)
			mono.android.TypeManager.Activate ("Mapas_XF.Android.CustomRenderers.MyMapRenderer, Mapas_XF.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0, p1 });
	}


	public MyMapRenderer (android.content.Context p0, android.util.AttributeSet p1, int p2) throws java.lang.Throwable
	{
		super (p0, p1, p2);
		if (getClass () == MyMapRenderer.class)
			mono.android.TypeManager.Activate ("Mapas_XF.Android.CustomRenderers.MyMapRenderer, Mapas_XF.Droid, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:System.Int32, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0, p1, p2 });
	}


	public void onMapReady (com.google.android.gms.maps.GoogleMap p0)
	{
		n_onMapReady (p0);
	}

	private native void n_onMapReady (com.google.android.gms.maps.GoogleMap p0);

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
