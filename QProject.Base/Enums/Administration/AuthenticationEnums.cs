using System.ComponentModel;

namespace QProject.Base.Enums.Administration
{
    /// <summary>
    /// Result of the authentication
    /// </summary>
    public enum AuthenticationResult
    {
        [Description("Přihlášení proběhlo úspěšně")]
        Success = 0,
        [Description("Uživatelský účet nebyl nalezen")]
        AccountNotFound = 1,
        [Description("Špatné uživatelské jméno, nebo heslo")]
        BadPassword = 2,
        [Description("Uživatelský účet není aktivován")]
        AccountNotActivated = 3,
        [Description("Nastala neočekávaná chyba")]
        UnSuccess = 4,
    }
}
