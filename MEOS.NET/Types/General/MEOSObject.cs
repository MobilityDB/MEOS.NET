namespace MEOS.NET.Types.General
{
	public abstract class MEOSObject
	{
		internal IntPtr _ptr { get; private set; }

		internal MEOSObject(IntPtr ptr)
			=> this._ptr = ptr;
	}
}

