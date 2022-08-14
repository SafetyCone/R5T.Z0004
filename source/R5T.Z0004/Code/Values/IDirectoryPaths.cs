using System;

using R5T.T0131;


namespace R5T.Z0004
{
	[ValuesMarker]
	public partial interface IDirectoryPaths : IValuesMarker
	{
		private static IPaths Paths { get; } = Z0004.Paths.Instance;


		/// <inheritdoc cref="IPaths.N002"/>
		public string N001 => Paths.N002;
	}
}