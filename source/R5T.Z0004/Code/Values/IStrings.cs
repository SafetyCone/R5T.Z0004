using System;

using R5T.T0131;


namespace R5T.Z0004
{
	/// <summary>
	/// Example strings.
	/// </summary>
	[ValuesMarker]
	public partial interface IStrings : IValuesMarker
	{
		public string String01 => "String01";
		public string String02 => "String02";
		public string String03 => "String03";
		public string String04 => "String04";
		public string String05 => "String05";

		public string StringA => "StringA";
		public string StringB => "StringB";
		public string StringC => "StringC";
		public string StringD => "StringD";
		public string StringE => "StringE";
	}
}