namespace ProSoft.Result;

/// <summary>
/// Enum ResultStatus
/// </summary>
public enum ResultStatus
{
	/// <summary>
	/// Successfully completed with messages only of type info or hint
	/// </summary>
	Success = 1,

	/// <summary>
	/// Successfully completed but with messages higher than info
	/// </summary>
	SuccessWithMessages = 2,

	/// <summary>
	/// The partial success
	/// </summary>
	PartialSuccess = 3,

	/// <summary>
	/// The failure
	/// </summary>
	Failure = 4
}
