namespace ProSoft.Result;

/// <summary>
/// Class Message. This class cannot be inherited.
/// </summary>
public sealed class Message
{
	/// <summary>
	/// Gets or sets the category of the message.
	/// </summary>
	/// <value>The category.</value>
	public MessageCategory Category { get; set; }

	/// <summary>
	/// Gets or sets the type of the message.
	/// </summary>
	/// <value>The type.</value>
	public MessageType Type { get; set; }

	/// <summary>
	/// Gets or sets the text of the message.
	/// </summary>
	/// <value>The text.</value>
	public string Text { get; set; }

	/// <summary>
	/// Gets or sets the reference identifier associated with the message.
	/// </summary>
	/// <value>The reference identifier.</value>
	public string ReferenceId { get; set; } = string.Empty;

	/// <summary>
	/// Gets or sets the name of the reference property associated with the message.
	/// </summary>
	/// <value>The name of the reference property.</value>
	public string ReferencePropertyName { get; set; } = string.Empty;

	/// <summary>
	/// Initializes a new instance of the <see cref="Message" /> class.
	/// </summary>
	/// <param name="category">The category.</param>
	/// <param name="type">The type.</param>
	/// <param name="text">The text.</param>
	public Message(MessageCategory category, MessageType type, string text)
	{
		Category = category;
		Type = type;
		Text = text;
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="Message" /> class.
	/// </summary>
	/// <param name="category">The category.</param>
	/// <param name="type">The type.</param>
	/// <param name="text">The text.</param>
	/// <param name="referenceId">The reference identifier.</param>
	public Message(MessageCategory category, MessageType type, string text, string referenceId)
	{
		Category = category;
		Type = type;
		Text = text;
		ReferenceId = referenceId;
	}

	/// <summary>
	/// Initializes a new instance of the <see cref="Message" /> class.
	/// </summary>
	/// <param name="category">The category.</param>
	/// <param name="type">The type.</param>
	/// <param name="text">The text.</param>
	/// <param name="referenceId">The reference identifier.</param>
	/// <param name="referencePropertyName">Name of the reference property.</param>
	public Message(MessageCategory category, MessageType type, string text, string referenceId, string referencePropertyName)
	{
		Category = category;
		Type = type;
		Text = text;
		ReferenceId = referenceId;
		ReferencePropertyName = referencePropertyName;
	}
}
