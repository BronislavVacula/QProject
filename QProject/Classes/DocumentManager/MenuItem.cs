namespace QProject.Classes.DocumentManager
{
    internal abstract class MenuItem
    {
        #region Properties and fields
        /// <summary>
        /// Gets or sets the type of the control.
        /// </summary>
        /// <value>
        /// The type of the control.
        /// </value>
        internal Type? ControlType { get; private set; }

        /// <summary>
        /// Gets the constructor parameters.
        /// </summary>
        /// <value>
        /// The constructor parameters.
        /// </value>
        internal object[]? ConstructorParameters { get; private set; }
        #endregion

        #region Constructor and initialization
        /// <summary>
        /// Initializes a new instance of the <see cref="MenuItem" /> class.
        /// </summary>
        /// <param name="controlType">Type of the control.</param>
        /// <param name="action">The action.</param>
        /// <param name="constructorParameters">The constructor parameters.</param>
        internal MenuItem(Type? controlType, params object[] constructorParameters)
        {
            ControlType = controlType;
            ConstructorParameters = constructorParameters;
        }
        #endregion

        #region Methods        
        /// <summary>
        /// Opens related instance.
        /// </summary>
        internal abstract void Open();
        #endregion
    }
}
