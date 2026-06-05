namespace ProSoft.Result;

/// <summary>
/// Class PagedResult. This class cannot be inherited.
/// </summary>
/// <typeparam name="TData">The type of the t data.</typeparam>
public sealed class PagedResult<TData> where TData : class
{
	/// <summary>
	/// Gets or sets the list items.
	/// </summary>
	/// <value>The list items.</value>
	public List<TData> ListItems { get; set; }

	/// <summary>
	/// Gets or sets the status.
	/// </summary>
	/// <value>The status.</value>
	public ResultStatus Status { get; set; }

	/// <summary>
	/// Gets or sets the total count.
	/// </summary>
	/// <value>The total count.</value>
	public long TotalCount { get; set; }

	/// <summary>
	/// Gets or sets the size of the page.
	/// </summary>
	/// <value>The size of the page.</value>
	public int PageSize { get; set; }

	/// <summary>
	/// Gets or sets the current page.
	/// </summary>
	/// <value>The current page.</value>
	public int CurrentPage { get; set; }

	/// <summary>
	/// Gets or sets the total pages.
	/// </summary>
	/// <value>The total pages.</value>
	public long TotalPages { get; set; }

	/// <summary>
	/// Initializes a new instance of the <see cref="PagedResult{TData}"/> class.
	/// </summary>
	public PagedResult()
	{
		CurrentPage = 1;
		ListItems = [];
		PageSize = 10;
		TotalCount = 0;
		TotalPages = 1;
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="PagedResult{TData}"/> class.
	/// </summary>
	/// <param name="status">The status.</param>
	public PagedResult(ResultStatus status) : this()
	{
		Status = status;
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="PagedResult{TData}"/> class.
	/// </summary>
	/// <param name="listItems">The list items.</param>
	/// <param name="totalCount">The total count.</param>
	/// <param name="pageSize">Size of the page.</param>
	/// <param name="currentPage">The current page.</param>
	/// <param name="status">The status.</param>
	public PagedResult(IEnumerable<TData> listItems, long totalCount, int pageSize, int currentPage, ResultStatus status) : this(status)
	{
		ListItems = listItems.ToList();
		TotalCount = totalCount;
		PageSize = pageSize;
		CurrentPage = currentPage;
		TotalPages = (long)Math.Ceiling((double)totalCount / pageSize);
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="PagedResult{TData}"/> class.
	/// </summary>
	/// <param name="query">The query.</param>
	/// <param name="pageSize">Size of the page.</param>
	/// <param name="currentPage">The current page.</param>
	/// <param name="status">The status.</param>
	public PagedResult(IQueryable<TData> query, int pageSize, int currentPage, ResultStatus status) : this(status)
	{
		var totalCount = query.LongCount();
		var skip = (currentPage - 1) * pageSize;

		ListItems = query.Skip(skip).Take(pageSize).ToList();
		TotalCount = totalCount;
		PageSize = pageSize;
		CurrentPage = currentPage;
		TotalPages = (long)Math.Ceiling((double)totalCount / pageSize);
	}
}
