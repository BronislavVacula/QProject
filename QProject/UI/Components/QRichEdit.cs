using DevExpress.XtraEditors;

namespace QProject.UI.Components
{
    public partial class QRichEdit : XtraUserControl
    {
        #region Properties and fields        
        /// <summary>
        /// Gets or sets a value indicating whether [read only].
        /// </summary>
        public bool ReadOnly
        {
            get => richEditControl1.ReadOnly;
            set => richEditControl1.ReadOnly = value;
        }

        /// <summary>
        /// Gets or sets the text associated with this control.
        /// </summary>
        public override string Text 
        { 
            get => richEditControl1.Text; 
            set => richEditControl1.Text = value; 
        }
        #endregion

        #region Constructor and initialization
        /// <summary>
        /// Initializes a new instance of the <see cref="QRichEdit"/> class.
        /// </summary>
        public QRichEdit()
        {
            InitializeComponent();
            Init();
        }

        /// <summary>
        /// Initializes this instance.
        /// </summary>
        private void Init()
        {
            InitComboBoxes();
        }

        /// <summary>
        /// Initializes the combo boxes.
        /// </summary>
        private void InitComboBoxes()
        {
            
        }
        #endregion
    }
}
