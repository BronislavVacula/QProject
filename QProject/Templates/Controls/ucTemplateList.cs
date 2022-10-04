using DevExpress.XtraEditors;
using QProject.Templates.Interfaces;

namespace QProject.Templates.Controls
{
    public partial class ucTemplateList : XtraUserControl, IReloadable
    {
        #region Constructor and initialization
        /// <summary>
        /// Initializes a new instance of the <see cref="ucTemplateList"/> class.
        /// </summary>
        public ucTemplateList()
        {
            InitializeComponent();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Reloads this instance.
        /// </summary>
        public virtual void Reload()
        {

        }
        #endregion
    }
}
