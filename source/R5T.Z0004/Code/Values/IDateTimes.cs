using System;

using R5T.T0131;


namespace R5T.Z0004
{
    /// <summary>
    /// OBSOLETE - See R5T.Z0066.
    /// </summary>
    [ValuesMarker]
    public partial interface IDateTimes : IValuesMarker
    {
        /// <summary>
        /// 2023-03-31 15:18:17.
        /// </summary>
        public DateTime Example => new(2023, 03, 31, 15, 18, 17);
    }
}
