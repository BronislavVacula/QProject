namespace QProject.Classes.DocumentManager
{
    /// <summary>
    /// Menu item will open related user control
    /// </summary>
    /// <typeparam name="TControl">The type of the control.</typeparam>
    /// <seealso cref="QProject.Classes.DocumentManager.MenuItem" />
    internal class MenuItemUC<TControl> : MenuItem 
        where TControl: UserControl
    {
        #region Constructor and initialization
        /// <summary>
        /// Initializes a new instance of the <see cref="MenuItemUC"/> class.
        /// </summary>
        /// <param name="parameters"></param>
        internal MenuItemUC(params object[] parameters) : base(typeof(TControl), parameters)
        {

        }
        #endregion

        #region Methods
        /// <summary>
        /// Opens related instance.
        /// </summary>
        internal override void Open()
        {
            if (ControlType != null)
            {
                DocumentManagerEx.Instance.OpenDocument(ControlType, ConstructorParameters);
            }
        }
        #endregion
    }
}
