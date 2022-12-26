using QProject.Base.Enums;

namespace QProject.Interfaces
{
    internal interface INotificable
    {
        #region Methods
        /// <summary>
        /// Called when [received notification].
        /// </summary>
        /// <param name="action">The action.</param>
        /// <param name="entity">The entity.</param>
        void OnReceivedNotification(EntityAction action, object? entity);
        #endregion
    }
}
