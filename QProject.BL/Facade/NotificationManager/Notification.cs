using Shared.Helpers;

namespace QProject.BL
{
    /// <summary>
    /// Basuc notification
    /// </summary>
    public abstract class Notification
    {
        /// <summary>
        /// Gets or sets the data source.
        /// </summary>
        /// <value>
        /// The data source.
        /// </value>
        public object? DataSource { get; set; }

        /// <summary>
        /// Gets or sets the subject.
        /// </summary>
        /// <value>
        /// The subject.
        /// </value>
        public abstract string Subject { get; set; }

        /// <summary>
        /// Gets or sets the text.
        /// </summary>
        /// <value>
        /// The text.
        /// </value>
        public abstract string TemplateText { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="Notification"/> class.
        /// </summary>
        public Notification() { }

        /// <summary>
        /// Initializes a new instance of the <see cref="Notification"/> class.
        /// </summary>
        /// <param name="dataSource">The data source.</param>
        /// <param name="templateText">The template text.</param>
        public Notification(object? dataSource, string templateText)
        {
            DataSource = dataSource;
            TemplateText = templateText;
        }

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return StringHelpers.ReplaceVariablesWithValuesFromDataSource(DataSource, TemplateText);
        }
    }

    /// <summary>
    /// Notification with item collection
    /// </summary>
    /// <typeparam name="TItem">The type of the item.</typeparam>
    public abstract class Notification<TItem> : Notification
    {
        /// <summary>
        /// Gets or sets the items.
        /// </summary>
        /// <value>
        /// The items.
        /// </value>
        public List<TItem> Items { get; set; } = new List<TItem>();

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return TemplateText.Replace("%items%", string.Join(Environment.NewLine, Items.Select(i => i?.ToString())));
        }
    }
}
