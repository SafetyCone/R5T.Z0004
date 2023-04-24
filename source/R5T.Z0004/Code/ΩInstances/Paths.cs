using System;


namespace R5T.Z0004
{
	public class Paths : IPaths
	{
		#region Infrastructure

	    public static Paths Instance { get; } = new();

	    private Paths()
	    {
        }

	    #endregion
	}
}