namespace QProject.BL.Facade.Administration
{
    public class fRoles
    {
        #region Singleton        
        /// <summary>
        /// The instance
        /// </summary>
        private static fRoles? instance;

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <value>
        /// The instance.
        /// </value>
        public static fRoles Instance => instance ??= new fRoles();

        /// <summary>
        /// Prevents a default instance of the <see cref="fRoles"/> class from being created.
        /// </summary>
        private fRoles() { }
        #endregion

        #region Methods        
        /// <summary>
        /// Gets the role members ids.
        /// </summary>
        /// <param name="roleId">The role identifier.</param>
        /// <returns></returns>
        public IEnumerable<int> GetRoleMembersIds(int? roleId)
        {
            return new List<int>();
        }
        #endregion
    }
}
