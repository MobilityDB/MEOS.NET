namespace MEOS.NET.Types.General
{
	public abstract class MEOSObject
	{
		protected IntPtr _ptr;

		internal MEOSObject(IntPtr ptr)
			=> this._ptr = ptr;
	}
}

