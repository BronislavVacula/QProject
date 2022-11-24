namespace QProject.Classes.DocumentManager
{
    /// <summary>
    /// Opens related form control
    /// </summary>
    /// <typeparam name="TForm">The type of the form.</typeparam>
    /// <seealso cref="QProject.Classes.DocumentManager.MenuItem" />
    internal class MenuItemForm<TForm> : MenuItem
        where TForm: Form
    {
        #region Properties and fields
        /// <summary>
        /// Gets a value indicating whether [open as dialog].
        /// </summary>
        /// <value>
        ///   <c>true</c> if [open as dialog]; otherwise, <c>false</c>.
        /// </value>
        internal bool OpenAsDialog { get; private set; } = false;
        #endregion

        #region Methods        
        /// <summary>
        /// Initializes a new instance of the <see cref="MenuItemUC" /> class.
        /// </summary>
        /// <param name="openAsDialog">if set to <c>true</c> [open as dialog].</param>
        /// <param name="parameters">The parameters.</param>
        internal MenuItemForm(bool openAsDialog = false,  params object[] parameters) : base(typeof(TForm), parameters)
        {
            OpenAsDialog = openAsDialog;
        }

        /// <summary>
        /// Opens related instance.
        /// </summary>
        internal override void Open()
        {
            if (ControlType != null)
            {
                object? createdForm = Activator.CreateInstance(typeof(TForm), ConstructorParameters);

                if(createdForm is TForm form)
                {
                    if(OpenAsDialog)
                    {
                        form.ShowDialog();
                    }
                   else
                    {
                        form.Show();
                    }
                }
            }
        }
        #endregion
    }
}
