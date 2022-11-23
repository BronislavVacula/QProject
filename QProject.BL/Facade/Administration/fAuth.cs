using QProject.Base;
using QProject.Base.DatabaseConnection;
using QProject.Base.Enums.Administration;
using QProject.BL.Entities.Administration;

namespace QProject.BL.Facade.Administration
{
    public class fAuth
    {
        #region Singleton        
        /// <summary>
        /// The instance
        /// </summary>
        private static fAuth? instance;

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <value>
        /// The instance.
        /// </value>
        public static fAuth Instance => instance ??= new fAuth();

        /// <summary>
        /// Prevents a default instance of the <see cref="fAuth"/> class from being created.
        /// </summary>
        private fAuth() { }
        #endregion

        #region Properties and fields        
        /// <summary>
        /// Gets the logged user.
        /// </summary>
        /// <value>
        /// The logged user.
        /// </value>
        public User? LoggedUser { get; private set; }
        #endregion

        #region Methods                
        /// <summary>
        /// Authenticates the user.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        public AuthenticationResult AuthenticateUser(string username, string password)
        {
            User? foundUser = DBConn.Instance.FirstOrDefault<User>(nameof(User.Username), username);

            if (foundUser != null)
            {
                if (!foundUser.Activated)
                    return AuthenticationResult.AccountNotActivated;

                if (!BCrypt.Net.BCrypt.Verify(password, foundUser.Password))
                    return AuthenticationResult.BadPassword;

                return (LoggedUser = foundUser) != null ? AuthenticationResult.Success : AuthenticationResult.UnSuccess;
            }

            return AuthenticationResult.AccountNotFound;
        }

        /// <summary>
        /// Activates the account.
        /// </summary>
        /// <param name="username">The username.</param>
        public void ActivateAccount(string username)
        {
            User? foundUser = DBConn.Instance.FirstOrDefault<User>(nameof(User.Username), username);

            if (foundUser != null)
            {
                foundUser.Activated = true;
                foundUser.Save();
            }
        }

        /// <summary>
        /// Logouts currently login user.
        /// </summary>
        public void Logout()
        {
            LoggedUser = null;
        }
        #endregion
    }
}
