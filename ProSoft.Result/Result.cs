namespace ProSoft.Result;

/// <summary>
/// Class Result. This class cannot be inherited.
/// </summary>
/// <typeparam name="TData">The type of the t data.</typeparam>
public sealed class Result<TData> where TData : class
{
	/// <summary>
	/// Gets or sets the data.
	/// </summary>
	/// <value>The data.</value>
	public TData? Data { get; set; }

	/// <summary>
	/// Gets or sets the status.
	/// </summary>
	/// <value>The status.</value>
	public ResultStatus Status { get; set; }

	/// <summary>
	/// Gets a value indicating whether this instance has messages.
	/// </summary>
	/// <value><c>true</c> if this instance has messages; otherwise, <c>false</c>.</value>
	public bool HasMessages => Messages.Count > 0;

	/// <summary>
	/// Gets a value indicating whether this instance has infos.
	/// </summary>
	/// <value><c>true</c> if this instance has infos; otherwise, <c>false</c>.</value>
	public bool HasInfos => Messages.Any(x => x.Type == MessageType.Info);

	/// <summary>
	/// Gets a value indicating whether this instance has hints.
	/// </summary>
	/// <value><c>true</c> if this instance has hints; otherwise, <c>false</c>.</value>
	public bool HasHints => Messages.Any(x => x.Type == MessageType.Hint);

	/// <summary>
	/// Gets a value indicating whether this instance has warnings.
	/// </summary>
	/// <value><c>true</c> if this instance has warnings; otherwise, <c>false</c>.</value>
	public bool HasWarnings => Messages.Any(x => x.Type == MessageType.Warning);

	/// <summary>
	/// Gets a value indicating whether this instance has errors.
	/// </summary>
	/// <value><c>true</c> if this instance has errors; otherwise, <c>false</c>.</value>
	public bool HasErrors => Messages.Any(x => x.Type == MessageType.Error);

	/// <summary>
	/// Gets or sets the messages.
	/// </summary>
	/// <value>The messages.</value>
	public List<Message> Messages { get; set; } = [];

	/// <summary>
	/// Initializes a new instance of the <see cref="Result{TData}"/> class.
	/// </summary>
	public Result() { }

	/// <summary>
	/// Initializes a new instance of the <see cref="Result{TData}"/> class.
	/// </summary>
	/// <param name="data">The data.</param>
	public Result(TData? data)
	{
		Data = data;
		Status = ResultStatus.Success;
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="Result{TData}"/> class.
	/// </summary>
	/// <param name="data">The data.</param>
	/// <param name="status">The status.</param>
	public Result(TData? data, ResultStatus status)
	{
		Data = data;
		Status = status;
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="Result{TData}"/> class.
	/// </summary>
	/// <param name="data">The data.</param>
	/// <param name="status">The status.</param>
	/// <param name="messages">The messages.</param>
	public Result(TData? data, ResultStatus status, List<Message> messages)
	{
		Data = data;
		Status = status;
		Messages = messages;
	}
}
