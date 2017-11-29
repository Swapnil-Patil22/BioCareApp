package md5fc32d4cce8d83c48345f691449ce5905;


public class SfDigitalGauge
	extends android.widget.FrameLayout
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"";
		mono.android.Runtime.register ("Com.Syncfusion.Gauges.SfDigitalGauge.SfDigitalGauge, Syncfusion.SfGauge.Android, Version=15.3451.0.29, Culture=neutral, PublicKeyToken=null", SfDigitalGauge.class, __md_methods);
	}


	public SfDigitalGauge (android.content.Context p0, android.util.AttributeSet p1)
	{
		super (p0, p1);
		if (getClass () == SfDigitalGauge.class)
			mono.android.TypeManager.Activate ("Com.Syncfusion.Gauges.SfDigitalGauge.SfDigitalGauge, Syncfusion.SfGauge.Android, Version=15.3451.0.29, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065", this, new java.lang.Object[] { p0, p1 });
	}


	public SfDigitalGauge (android.content.Context p0, android.util.AttributeSet p1, int p2)
	{
		super (p0, p1, p2);
		if (getClass () == SfDigitalGauge.class)
			mono.android.TypeManager.Activate ("Com.Syncfusion.Gauges.SfDigitalGauge.SfDigitalGauge, Syncfusion.SfGauge.Android, Version=15.3451.0.29, Culture=neutral, PublicKeyToken=null", "Android.Content.Context, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:Android.Util.IAttributeSet, Mono.Android, Version=0.0.0.0, Culture=neutral, PublicKeyToken=84e04ff9cfb79065:System.Int32, mscorlib, Version=2.0.5.0, Culture=neutral, PublicKeyToken=7cec85d7bea7798e", this, new java.lang.Object[] { p0, p1, p2 });
	}

	private java.util.ArrayList refList;
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
