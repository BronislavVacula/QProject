using QProject.Base;

namespace QProject.Templates.Interfaces
{
    internal interface ITemplate : IReloadable
    {
        void Init();
        void InitComboBoxes();
        void InitBinding();

        void UpdateState();
        void UpdateUIAccess();

        bool CanFinish();

        void LoadContent();
        void SaveContent();

        /// <summary>
        /// Gets the related entity.
        /// </summary>
        /// <value>
        /// The related entity.
        /// </value>
        Entity? RelatedEntity { get; }
    }
}
