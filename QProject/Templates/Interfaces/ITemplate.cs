using QProject.Base;

namespace QProject.Templates.Interfaces
{
    internal interface ITemplate : IReloadable
    {
        #region Properties and fields
        Entity? RelatedEntity { get; }
        #endregion

        #region Methods
        void Init();
        void InitComboBoxes();
        void InitBinding();

        void UpdateState();
        void UpdateUIAccess();

        bool CanFinish();

        void LoadContent();
        void SaveContent();
        #endregion
    }
}
